using MIS.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Registros
{
    public class RecepcionRepository
    {
        private readonly PostgreSQLHelper dbHelper;

        public RecepcionRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }
        #region Modulo Recepcion
        public async Task<DataTable> TablaIngresosAsync(int idcliente, int recepcion, string anio)
        {
            try
            {
                string where = "";
                if (recepcion > 0)
                {
                    where += $" where r.recepcion = {recepcion} and r.anio = '{anio}' and rd.idcliente = {idcliente}";
                } else
                {
                    where += $" where rd.idrecepcion = 0 and rd.idcliente = {idcliente}";
                }
                string query = $@"SELECT renglon, rd.id,
                                    'NR-' || to_char(rd.fechaing, 'YY-') || coalesce(r.recepcion, 0) || '-' || renglon || '-' || m.abreviatura AS ingreso,  
                                    'NR-' || to_char(rd.fechaing, 'YY-') || to_char(coalesce(r.recepcion, 0), '0000') || '-' || renglon AS etiqueta,
                                    'Equipo: ' || e.descripcion || ' (' || t.descripcion || ')' as descripcion, 
                                    'Magnitud: ' || m.descripcion as magnitud, rd.con_serie,
                                    CASE WHEN rd.codigo != '' THEN 'SERIE: ' || rd.serie || ' CODIGO: ' || rd.codigo ELSE 'SERIE: ' || rd.serie END as serie, 
                                    ma.descripcion as marca, mo.descripcion as modelo, to_char(rd.fechaing, 'DD-MM-YY') as fechaingreso, rd.idmagnitud as idmagnitud,
                                    CASE WHEN rd.accesorios != '' THEN 'Observacion: ' || rd.observacion || ' Accesorios: ' || rd.accesorios ELSE rd.observacion END as observacion,
                                    rd.codigo, rd.estado
                                FROM recepcion_detalle rd 
                                INNER JOIN equipos e ON rd.idequipo = e.id 
                                INNER JOIN magnitudes m ON rd.idmagnitud = m.id 
                                INNER JOIN magnitud_intervalos mi1 ON rd.idintervalo1 = mi1.id 
                                INNER JOIN marcas ma ON rd.idmarca = ma.id 
                                INNER JOIN modelos mo ON rd.idmodelo = mo.id 
                                INNER JOIN magnitud_intervalos mi2 ON rd.idintervalo2 = mi2.id
                                INNER JOIN tipo_indicacion t ON t.id = rd.idtipoindicacion 
                                LEFT JOIN recepciones r ON rd.idrecepcion = r.id
                                {where} ORDER BY renglon;";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable != null)
                {
                    return dataTable;
                } else
                {
                    return null;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de la base de datos: {ex.Message}", "warning");
                return null;
            }
        }
        public async Task<DataTable> BuscarCliente(int idcliente, string documento)
        {
            try
            {
                string query = "";
                if (idcliente == 0 && documento != "")
                {
                    query = $@"select c.id, c.documento as documento, c.nombrecompleto as nombrecompleto from clientes c 
                        where c.id > 0 and documento = '{documento}' order by c.nombrecompleto";
                }
                if (idcliente > 0 && documento == "")
                {
                    query = $"select c.id, c.documento as documento, c.nombrecompleto as nombrecompleto from clientes c " +
                    $" where c.id = {idcliente} order by c.nombrecompleto";
                }
                if (query != "")
                {
                    DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                    if (dataTable.Rows.Count > 0)
                        return dataTable;
                    else 
                        return null;
                }
                else 
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error BuscarClientesModal(): " + ex.Message);
                return null;
            }
        }
        public async Task<bool> BorrarIngreso(List<int> ids)
        {
            try
            {
                // Obtener la recepción del primer ingreso de la lista
                int firstId = ids.First();
                string getReceptionQuery = $"SELECT idrecepcion FROM recepcion_detalle WHERE id = {firstId}";
                object receptionResult = await dbHelper.ExecuteScalarAsync(getReceptionQuery);

                if (receptionResult == null)
                {
                    MessageBox.Show($"No se pudo obtener la recepción del ingreso con ID: {firstId}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                int receptionId = Convert.ToInt32(receptionResult);

                foreach (int id in ids)
                {
                    // Eliminar el ingreso solo si pertenece a la misma recepción
                    string deleteQuery = $"DELETE FROM recepcion_detalle WHERE id = {id} AND idrecepcion = {receptionId}";
                    int result = await Task.Run(() => dbHelper.ExecuteNonQuery(deleteQuery));

                    if (result <= 0)
                    {
                        MessageBox.Show($"Error al intentar eliminar el ingreso con ID: {id}!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    await BorrarFotoIngreso(id, -1);
                }
                

                // Reasignar los valores de la columna 'renglon' solo para los ingresos de la misma recepción
                string updateQuery = $@"
                        UPDATE recepcion_detalle 
                        SET renglon = new_renglon 
                        FROM (
                            SELECT id, ROW_NUMBER() OVER(ORDER BY id) AS new_renglon
                            FROM recepcion_detalle
                            WHERE idrecepcion = {receptionId}
                        ) AS sub
                        WHERE recepcion_detalle.id = sub.id;";
                await Task.Run(() => dbHelper.ExecuteNonQuery(updateQuery));

                // Si todas las eliminaciones y la reasignación fueron exitosas, mostrar un mensaje de éxito y devolver true
                MessageBox.Show("Ingreso(s) eliminado(s) exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show($"Error al intentar eliminar ingreso(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<bool> SerieImpresa(List<int> ids)
        {
            try
            {
                string idsingresos = string.Join(",", ids);    
                string update = $"update recepcion_detalle set con_serie=true where id in ({idsingresos})";
                int result = await Task.Run(() => dbHelper.ExecuteNonQuery(update));
                if(result <= 0)
                {
                    return false;
                } else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre alguna excepción
                MessageBox.Show($"Error al intentar eliminar ingreso(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<int> GuardarRecepcion(List<int> ids, int idcliente, int idsede, int idcontacto, int nro_recepcion, string observacion, int idforma_llegada, string fecha)
        {
            try
            {
                string query = "";
                string busContador = "select recepcion from contador where id = 1";
                object contador = await dbHelper.ExecuteScalarAsync(busContador);
                if (contador != null)
                {
                    int recepcion = Convert.ToInt32(contador) + 1;
                    if (nro_recepcion == 0)
                    {
                        query = $"INSERT INTO recepciones(recepcion, idcliente, idsede, idcontacto, fecha, idusuario, anio, estado, observacion, idforma_llegada) " +
                                         $"VALUES({recepcion}, {idcliente}, {idsede}, {idcontacto}, '{fecha}', {FG.UserId}, to_char(current_timestamp, 'YYYY'), 'Ingresado', '{observacion}', {idforma_llegada}) RETURNING id";
                    } else
                    {
                        query = $"update recepciones set fecha='{fecha}', idsede = {idsede}, idcontacto = {idcontacto}, observacion='{observacion}', idforma_llegada = {idforma_llegada} where recepcion = {nro_recepcion} returning id" ;
                    }
                    
                    object idGenerado = dbHelper.ExecuteScalar(query);

                    if (idGenerado != null && idGenerado != DBNull.Value && Convert.ToInt32(idGenerado) != 0)
                    {
                        string idsConcatenados = string.Join(",", ids);
                        string updateQuery = $"UPDATE recepcion_detalle SET idrecepcion = {idGenerado}, estado = 'Ingresado' WHERE id IN ({idsConcatenados}) and inactivo = 0";
                        foreach(int id in ids)
                        {
                            string update = $"update recepcion_detalle set serie='NR' || (select to_char(fecha, 'YY') || trim(to_char(recepcion, '0000')) from recepciones where id = {idGenerado}) || '-'|| (select renglon from recepcion_detalle where id = {id}) where id = {id} and con_serie = false";
                            dbHelper.ExecuteNonQuery(update);
                            update = $"update recepcion_detalle set fechaing='{fecha}'";
                            dbHelper.ExecuteNonQuery(update);
                        }
                        int filasActualizadas = dbHelper.ExecuteNonQuery(updateQuery);
                        if(nro_recepcion == 0)
                        {
                            int actcontador = dbHelper.ExecuteNonQuery($"update contador set recepcion = {recepcion} where id = 1");
                        }
                        if (filasActualizadas > 0)
                        {
                            if (nro_recepcion == 0)
                                return recepcion;
                            else
                                return nro_recepcion;
                        }
                        else
                        {
                            MessageBox.Show("No se actualizaron los ingresos", "GuardarRecepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    } else
                    {
                        MessageBox.Show("No se guardo la recepción", "GuardarRecepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }
                    
                } else
                {
                    MessageBox.Show("No se encontro el numero de recepcion en el contador.", "GuardarRecepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ingreso(s): " + ex.Message, "GuardarRecepcion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public async Task<DataTable> BuscarRecepcion(int recepcion, string anio)
        {
            try
            {
                string query = $"select id, idcliente, idsede, idcontacto, estado, fecha, observacion, idforma_llegada from recepciones r where recepcion = {recepcion} and anio = '{anio}'";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if(dataTable == null)
                {
                    MessageBox.Show($"No existe la recepción nro: NR-{anio.Substring(2)}-{recepcion}", "BuscarRecepcion");
                    return null;
                } else
                {
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error BuscarRecepcion(): " + ex.Message);
                return null;
            }
        }
        public async Task<DataTable> Consultar(string recepcion, int idcliente, string desde, string hasta)
        {
            string where = $"where DATE_TRUNC('day', r.fecha) >= '{desde}' and DATE_TRUNC('day', r.fecha) <= '{hasta}'";
            if(recepcion != "")
            {
                where += $" and r.recepcion = {recepcion}";
            } else if(idcliente > 0)
            {
                where += $" and r.idcliente = {idcliente}";
            }
            string query = $@"
                    select r.id, ROW_NUMBER() OVER(order by r.id desc) as fila, r.recepcion as nro_recepcion, r.anio,'NR-'|| to_char(r.fecha, 'YY-') || trim(to_char(r.recepcion, '0000')) as recepcion, c.nombrecompleto || '(' || c.documento  || ')' as cliente, 
                    to_char(r.fecha, 'DD-MM-YYYY') as fecha, count(rd.renglon) as cantidad, string_agg(distinct m.descripcion, ', ') as magnitud, ru.nombrecompleto as registrado_por, r.observacion
                            from recepciones r
                        inner join clientes c on c.id = r.idcliente 
                        inner join seguridad.rbac_usuarios ru on ru.id = r.idusuario
                        inner join recepcion_detalle rd on r.id= rd.idrecepcion
                        inner join magnitudes m on m.id = rd.idmagnitud 
                    {where}
                    group by r.id, r.recepcion, c.nombrecompleto, c.documento, r.fecha, ru.nombrecompleto, r.observacion 
                    order by r.recepcion desc";
            DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                return dataTable;
            }
        }
        public async Task<bool> Anular(List<int> ingresos, int tipo)
        {
            try
            {
                string ingresosList = string.Join(", ", ingresos);
                if (tipo == 1)
                {
                    
                    string inspeccionados = $"select count(*) from inspeccion_detalle where idingreso in ({ingresosList})";
                    object cantinsp = await dbHelper.ExecuteScalarAsync(inspeccionados);
                    if (Convert.ToInt32(cantinsp) > 0)
                    {
                        MessageBox.Show("No se puede anular un ingreso(s) inspeccionado(s)");
                        return false;
                    }
                    string anulados = $"select count(*) from recepcion_detalle where id in ({ingresosList}) and inactivo = 1";
                    object cantianulado = await dbHelper.ExecuteScalarAsync(anulados);
                    if (Convert.ToInt32(cantianulado) > 0)
                    {
                        MessageBox.Show("No se puede anular un ingreso(s) anulado(s)");
                        return false;
                    }
                    string sql = $"UPDATE recepcion_detalle SET estado = 'Anulado', inactivo = 1 WHERE id IN ({ingresosList})";
                    int guardado = dbHelper.ExecuteNonQuery(sql);
                    if (guardado > 0)
                    {
                        MessageBox.Show("Ingreso(s) anulado(s) con éxito");
                        return true;
                    }
                } else
                {
                    string anulados = $"select count(*) from recepcion_detalle where id in ({ingresosList}) and inactivo = 0";
                    object cantianulado = await dbHelper.ExecuteScalarAsync(anulados);
                    if (Convert.ToInt32(cantianulado) > 0)
                    {
                        MessageBox.Show("No se puede elimanr la anulación sino esta anulado");
                        return false;
                    }
                    string sql = $"UPDATE recepcion_detalle SET estado = 'Temporal', inactivo = 0 WHERE id IN ({ingresosList})";
                    int guardado = dbHelper.ExecuteNonQuery(sql);
                    if (guardado > 0)
                    {
                        MessageBox.Show("Anulación eliminada");
                        return true;
                    }
                }
                return false;
            } catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
                return false;
            }
            
        }
        public async Task<bool> AdjuntarArchivo(int recepcion, string anio, string base64, string talonario)
        {
            try
            {
                string query = "";
                object idrecepcion = await dbHelper.ExecuteScalarAsync($@"select id from recepciones where recepcion = {recepcion} and anio = '{anio}'");
                object id = await dbHelper.ExecuteScalarAsync($@"select coalesce(id, 0) as id from archivos.archivos_laboratorio where nrocontrol = {Convert.ToInt32(idrecepcion)} and base64 = '{base64}' and tipo = 'TALONARIO RECEPCION'");
                if (Convert.ToInt32(id) == 0)
                {
                    query = $@"insert into archivos.archivos_laboratorio
                                    (tipo, nrocontrol, base64, nroarchivo)
                                values('TALONARIO RECEPCION', {Convert.ToInt32(idrecepcion)}, '{base64}', 1)";
                    string update = $"update recepciones set talonario = '{talonario}'";
                    int actualizado = dbHelper.ExecuteNonQuery(update);
                    if (actualizado > 0)
                    {
                        MessageBox.Show("Ingreso(s) anulado(s) con éxito");
                        return true;
                    }
                }
                else
                {
                    query = $@"update archivos.archivos_laboratorio set base64 = '{base64}' where id = {id}";
                }
                int guardado = dbHelper.ExecuteNonQuery(query);
                if (guardado > 0)
                {
                    MessageBox.Show("Guardado o Actualizado con éxito");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al Guardadar o Actualizadar");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Acción cancelada");
                return false;
            }
        }
        #endregion
        #region Reporte Recepción
        public async Task<DataTable> GetEncabezadoRecepcion(int numeroRecepcion)
        {
            string query = $@"
                SELECT 
                    r.id, 
                    'NR-' || TO_CHAR(r.fecha, 'YY-') || TO_CHAR(r.recepcion, '0000') AS recepcion, to_char(r.fecha, 'YYYY-MM-DD') as fecha,
                    r.observacion, c.nombrecompleto AS cliente, c.documento as documento, UPPER(ru.nombrecompleto) AS usuario,
                    'Firmado digitalemente por ' || UPPER(ru.nombrecompleto) || ' cn=' || UPPER(ru.nombrecompleto) || ', c=CO,' ||
                    ' o=METROLOGY INTEGRATION SAS, ou=' || ru.cargo || ', email=' || ru.email || '<br>Motivo: Soy el autor de este documento.' as firma,
                    CASE
                        WHEN EXISTS (SELECT 1 FROM recepcion_detalle rd WHERE rd.idrecepcion = r.id AND rd.material = false) THEN 1
                        ELSE 0 
                    END as item,
                    CASE 
                        WHEN EXISTS (SELECT 1 FROM recepcion_detalle rd WHERE rd.idrecepcion = r.id AND rd.material = true) THEN 1
                        ELSE 0 
                    END as material
                FROM recepciones r
                INNER JOIN clientes c ON c.id = r.idcliente
                INNER JOIN seguridad.rbac_usuarios ru ON ru.id = r.idusuario
                WHERE r.recepcion = {numeroRecepcion}
                GROUP BY 
                    r.id, r.fecha, c.nombrecompleto, c.documento, ru.nombrecompleto, ru.cargo, ru.email";
            return await dbHelper.ExecuteQueryAsync(query);
        }
        public async Task<DataTable> GetDetalleRecepcion(int numeroRecepcion)
        {
            string query = $@"
                SELECT rd.id, renglon,
                   'NR-' || to_char(rd.fechaing, 'YY-') || to_char(r.recepcion, '0000') || '-' || rd.renglon AS ingreso,
                   '<b>EQUIPO:</b> ' || e.descripcion || '; <b>MAGNITUD:</b> ' || m.descripcion ||
                   '; <b>MARCA:</b> ' || ma.descripcion || '; <b>MODELO:</b> ' || mo.descripcion || CASE WHEN rd.codigo not in ('', 'Sin Información') THEN ' <b>SERIE:</b> ' || rd.serie || ' <b>CÓDIGO:</b> ' || rd.codigo ELSE ' <b>SERIE:</b> ' || rd.serie end ||
                   CASE WHEN rd.idintervalo1 > 0 then '; <b>RANGO:</b> (' || mi1.desde || ' a ' || mi1.hasta || ') ' || mi1.medida else '; <b>RANGO:</b> VER ESPECIFICACIONES' end ||
                   CASE WHEN rd.idintervalo2 > 0 then '; <b>RANGO 2:</b> (' || mi2.desde || ' a ' || mi2.hasta || ') ' || mi2.medida else '' end ||
                   CASE WHEN rd.accesorios != '' THEN '; <b>OBSERVACIÓN:</b> ' || rd.observacion || '; <b>ACCESORIOS:</b> ' || rd.accesorios ELSE '; <b>OBSERVACIÓN:</b> ' || rd.observacion end || '; <b>SERVICIO:</b> ' || rd.tipo_servicio  as descripcion
                FROM recepcion_detalle rd  
                INNER JOIN equipos e ON rd.idequipo = e.id  
                INNER JOIN magnitudes m ON rd.idmagnitud = m.id  
                INNER JOIN magnitud_intervalos mi1 ON rd.idintervalo1 = mi1.id  
                INNER JOIN marcas ma ON rd.idmarca = ma.id  
                INNER JOIN modelos mo ON rd.idmodelo = mo.id  
                INNER JOIN recepciones r ON rd.idrecepcion = r.id
                inner join magnitud_intervalos mi2 ON rd.idintervalo2 = mi2.id
                WHERE recepcion = {numeroRecepcion} order by ingreso" ;

            return await dbHelper.ExecuteQueryAsync(query);
        }
        #endregion
        #region Modal Agregar Ingreso
        public async Task<bool> GuardarIngreso(int idingreso, int idrecepcion, int idcliente, string serie, string codigo, int idequipo, int idmagnitud, int idintervalo1, int idintervalo2, int idmarca, int idmodelo, string ubicacion, bool material, string accesorios, string observaciones, int idtipoindicacion, string tipo_servicio)
        {
            try
            {
                if (idingreso > 0)
                {
                    string query = $@"update recepcion_detalle set idequipo = {idequipo}, idmagnitud = {idmagnitud}, idintervalo1 = {idintervalo1}, idintervalo2 = {idintervalo2}, 
                                        idmarca = {idmarca},idmodelo = {idmodelo}, serie = '{serie}', con_serie={serie.Length>0}, codigo='{codigo}', ubicacion = '{ubicacion}', material = {material}, accesorios = '{accesorios}', 
                                        observacion = '{observaciones}', idtipoindicacion = '{idtipoindicacion}', tipo_servicio = '{tipo_servicio}' where id = {idingreso}";
                    if (dbHelper.ExecuteNonQuery(query) > 0) 
                    {
                        MessageBox.Show("Actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    } else
                    {
                        MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    
                } else
                {
                    string busqueda = "select ingreso from contador where id = 1";
                    object contador = await dbHelper.ExecuteScalarAsync(busqueda);
                    if (contador != null)
                    {
                        int numeroingreso = Convert.ToInt32(contador) + 1;
                        string busrenglon = $@"select coalesce(max(renglon), 0) from recepcion_detalle where idcliente = {idcliente} and idrecepcion = {idrecepcion}";
                        object renglon = await PostgreSQLHelper.GetInstance().ExecuteScalarAsync(busrenglon);
                        string query = $@"insert into recepcion_detalle
                                        (renglon, idrecepcion, idcliente, ingreso, idequipo, idmagnitud, idintervalo1, idintervalo2, idmarca, idmodelo, serie, con_serie, codigo, 
                                        material, accesorios, observacion, idtipoindicacion, tipo_servicio, idusuario)
                                values({Convert.ToInt32(renglon) + 1}, {idrecepcion}, {idcliente}, {numeroingreso}, {idequipo}, {idmagnitud}, {idintervalo1}, {idintervalo2}, {idmarca}, {idmodelo}, '{serie}', {serie.Length > 0},'{codigo}', 
                                        {material}, '{accesorios}', '{observaciones}', {idtipoindicacion}, '{tipo_servicio}', {FG.UserId})";
                        string updatedontador = $"update contador set ingreso = {numeroingreso} where id = 1;";
                        int guardado = dbHelper.ExecuteNonQuery(query);

                        if (guardado > 0)
                        {
                            int actualizado = dbHelper.ExecuteNonQuery(updatedontador);
                            MessageBox.Show("Guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen el contador ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<bool> BuscarSerie(string serie, int idcliente, int idrecepcion)
        {
            try
            {
                string query = $@"select count(*) from recepcion_detalle where serie='{serie}' and idcliente = {idcliente} and idrecepcion = {idrecepcion}";
                
                object contador = await dbHelper.ExecuteScalarAsync(query);
                if (Convert.ToInt32(contador) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "BuscarSerie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            
        }
        public async Task<DataTable> BuscarIngreso(int id)
        {
            try
            {
                string query = $@"select rd.id, rd.ingreso, rd.serie, rd.codigo, case when rd.con_serie = true then 'SI' else 'NO' end as con_serie,case when rd.material = false then 'NO' else 'SI' end as material, rd.tipo_servicio,
                                    rd.ubicacion, rd.idmagnitud, rd.idequipo, rd.idtipoindicacion, rd.idintervalo1, rd.idintervalo2, rd.idmarca, rd.idmodelo,
                                    rd.accesorios, rd.observacion
                                    from recepcion_detalle rd where id = {id}";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable != null)
                {
                    return dataTable;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener datos de la base de datos: {ex.Message}", "warning");
                return null;
            }
        }
        public async Task<bool> GuardarMaterial(int idingreso, int idrecepcion, int idcliente,  string descripcion, string serie, string codigo)
        {
            try
            {
                if (idingreso > 0)
                {
                    string query = $@"update material_detalle set descripcion = '{descripcion}', serie = '{serie}', codigo = '{codigo}' where id = {idingreso}";
                    if (dbHelper.ExecuteNonQuery(query) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                }
                else
                {
                    string busqueda = "select ingreso from contador where id = 1";
                    object contador = await PostgreSQLHelper.GetInstance().ExecuteScalarAsync(busqueda);
                    if (contador != null)
                    {
                        int numeroingreso = Convert.ToInt32(contador) + 1;

                        string query = $@"insert into material_detalle" +
                            $@"(idrecepcion, idcliente, ingreso, descripcion, serie, codigo)
                            values({idrecepcion}, {idcliente}, {numeroingreso}, '{descripcion}', '{serie}', '{codigo}')";
                        string updatedontador = $"update contador set ingreso = {numeroingreso} where id = 1;";
                        int guardado = dbHelper.ExecuteNonQuery(query);

                        if (guardado > 0)
                        {
                            int actualizado = dbHelper.ExecuteNonQuery(updatedontador);
                            MessageBox.Show("Guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                            MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("No existen el contador ingreso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<int> Duplicar(int id, string serie)
        {
            try
            {
                string busqueda = "select ingreso from contador where id = 1";
                object contador = await PostgreSQLHelper.GetInstance().ExecuteScalarAsync(busqueda);
                if (contador != null)
                {
                    int numeroingreso = Convert.ToInt32(contador) + 1;
                    string query = $@"INSERT INTO recepcion_detalle (renglon, ingreso, idusuario, serie, con_serie, fechaing, idrecepcion, idcliente, idequipo, idmarca, idmodelo, idintervalo1, idintervalo2, idmagnitud, ubicacion, material, accesorios, observacion, idtipoindicacion, tipo_servicio)
                            SELECT
                                COALESCE((SELECT MAX(renglon) FROM recepcion_detalle WHERE idrecepcion = (SELECT idrecepcion FROM recepcion_detalle WHERE id = {id})), 0) + 1 as renglon,
                                {numeroingreso}, {FG.UserId}, '{serie}', {serie.Length>0}, NOW(), idrecepcion, idcliente, idequipo, idmarca, idmodelo, idintervalo1, idintervalo2, idmagnitud, ubicacion, material, accesorios, observacion, idtipoindicacion, tipo_servicio
                            FROM recepcion_detalle
                            WHERE id = {id};";
                    string updatedontador = $"update contador set ingreso = {numeroingreso} where id = 1;";
                    int guardado = dbHelper.ExecuteNonQuery(query);

                    if (guardado > 0)
                    {
                        int actualizado = dbHelper.ExecuteNonQuery(updatedontador);
                        return 1;
                    } else
                    {
                        MessageBox.Show("Error al duplicar");
                        return 0;
                    }
                } else
                {
                    MessageBox.Show("Error en el contador ingreso");
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al duplicar ingreso(s): " + ex.Message, "Duplicar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        #endregion
        #region Camara
        public async Task<bool> GuardarFotoIngreso(int nrocontrol, string base64)
        {
            try
            {
                object cantidad = await dbHelper.ExecuteScalarAsync($@"select coalesce(max(nrofoto), 0) as cantidad from archivos.fotos_laboratorio where nrocontrol = {nrocontrol}");
                string query = $@"insert into archivos.fotos_laboratorio
                                    (tipo, nrocontrol, base64, comprimido, nrofoto)
                                values('INGRESO', {nrocontrol}, 'data:image/jpeg;base64,{base64}', '', {Convert.ToInt32(cantidad) + 1})";
                
                int guardado = dbHelper.ExecuteNonQuery(query);
                if (guardado > 0)
                {
                    string update = $"update recepcion_detalle set fotos = {Convert.ToInt32(cantidad) + 1} where id = {nrocontrol}";
                    if (dbHelper.ExecuteNonQuery(update) > 0)
                    {
                        MessageBox.Show("Foto guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    } else
                    {
                        return false;
                    }
                    
                } else
                {
                    MessageBox.Show("No se logró guardar la imagen: " + query, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la foto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<List<(string Base64, int NroFoto)>> FotosIngreso(int nrocontrol, string tipo)
        {
            try
            {
                string query = $"select id, nrofoto, base64 from archivos.fotos_laboratorio where nrocontrol={nrocontrol} and tipo = '{tipo}'";
                DataTable tabla = await dbHelper.ExecuteQueryAsync(query);
                List<(string Base64, int NroFoto)> imagenes = new List<(string, int)>();
                if (tabla != null && tabla.Rows.Count > 0)
                {
                    foreach (DataRow row in tabla.Rows)
                    {
                        string base64 = row["base64"].ToString();
                        int nrofoto = Convert.ToInt32(row["nrofoto"]);
                        imagenes.Add((base64, nrofoto));
                    }
                }
                return imagenes;
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener imágenes de la base de datos: {ex.Message}", "Advertencia");
                return null;
            }
        }
        public async Task<bool> BorrarFotoIngreso(int id, int nrofoto)
        {
            try
            {
                string delete;
                if (nrofoto < 0)
                {
                    delete = $"delete from archivos.fotos_laboratorio where nrocontrol = {id}";
                } else
                {
                    delete = $"delete from archivos.fotos_laboratorio where nrocontrol = {id} and nrofoto = {nrofoto}";
                }
                
                int result = await Task.Run(() => dbHelper.ExecuteNonQuery(delete));
                if (result > 0)
                {
                    string update = $@"
                        WITH Fotos AS (
                            SELECT id, ROW_NUMBER() OVER (ORDER BY nrofoto) AS new_nrofoto
                            FROM archivos.fotos_laboratorio
                            WHERE nrocontrol = {id}
                        )
                        UPDATE archivos.fotos_laboratorio
                        SET nrofoto = Fotos.new_nrofoto
                        FROM Fotos
                        WHERE archivos.fotos_laboratorio.id = Fotos.id;";
                    await Task.Run(() => dbHelper.ExecuteNonQuery(update));
                    object cantidad = await dbHelper.ExecuteScalarAsync($@"select coalesce(max(nrofoto), 0) as cantidad from archivos.fotos_laboratorio where nrocontrol = {id}");
                    string canfotos = $"update recepcion_detalle set fotos = {Convert.ToInt32(cantidad) + 1} where id = {id}";
                    dbHelper.ExecuteNonQuery(update);
                } else
                {
                    return false;
                }
                MessageBox.Show("Foto eliminida con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar eliminar la foto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #region Modal Recepción
        public async Task<DataTable> ModalRecepciones(string estado, int idcliente, string tipo)
        {
            string where = "";
            
            if (tipo == "IR")
            {
                where += $"where r.estado = '{estado}'";
            }
            if (tipo == "ODT")
            {
                where += $"where r.estado != 'Ingresado' and (r.estado = '{estado}' or c.convenio = 1) and i.inspeccion > 0";
            }
            if (tipo == "Cotizacion")
            {
                where += $"where r.estado = '{estado}'";
            }
            if (idcliente > 0)
            {
                where += $" and r.idcliente = {idcliente}";
            }

            string query = $@"
                    select r.id, r.idcliente, ROW_NUMBER() OVER(order by r.id desc) as fila, r.recepcion as nro_recepcion, coalesce(i.inspeccion, 0) as nro_inspeccion, r.anio,'NR-'|| to_char(r.fecha, 'YY-') || trim(to_char(r.recepcion, '0000')) as recepcion, r.estado, c.nombrecompleto || '(' || c.documento  || ')' as cliente,
                    to_char(r.fecha, 'DD-MM-YYYY') as fecha, count(rd.renglon) as cantidad, string_agg(distinct m.descripcion, ', ') as magnitud, ru.nombrecompleto as registrado_por, r.observacion,
                    count(rd.inactivo) as anulados
                            from recepciones r
                        inner join clientes c on c.id = r.idcliente
                        inner join seguridad.rbac_usuarios ru on ru.id = r.idusuario
                        inner join recepcion_detalle rd on r.id= rd.idrecepcion
                        inner join magnitudes m on m.id = rd.idmagnitud
                        left join inspeccion_detalle id on id.idingreso = rd.id
                        left join inspecciones i on i.id = id.idinspeccion
                        left join cotizacion_detalle cd on cd.idingreso = rd.id
                        left join cotizaciones co on co.id = cd.idcotizacion
                    {where} and rd.inactivo = 0
                    group by r.id, r.recepcion, c.nombrecompleto, c.documento, r.fecha, ru.nombrecompleto, r.observacion, i.inspeccion, r.idcliente
                    order by r.recepcion desc";

            DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                return dataTable;
            }
        }
        #endregion
    }
}