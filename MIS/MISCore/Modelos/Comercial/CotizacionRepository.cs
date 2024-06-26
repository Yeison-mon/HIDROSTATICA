using MIS.Helpers;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
namespace MIS.Modelos.Comercial
{
    public class CotizacionRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public CotizacionRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }
        #region Registro

        public async Task<DataTable> Buscar(int cotizacion, string anio)
        {
            try
            {
                string query = $@"select id, idcliente, cotizacion, idsede, idcontacto,anio, estado from cotizaciones where cotizacion = {cotizacion} and anio = '{anio}'";
                
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
                MessageBox.Show("Error Buscar(): " + ex.Message);
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

        public async Task<DataTable> Detalle(int idcliente, int cotizacion)
        {
            try
            {

                string where = $" where cd.idcliente = {idcliente} and coalesce(c.cotizacion, 0) = {cotizacion}";
                string query = $@"SELECT cd.id, renglon, cd.idcliente,
                           'NR-' || to_char(rd.fechaing, 'YY-') || to_char(r.recepcion, '0000') || '-' || rd.renglon AS ingreso,
                           'EQUIPO: ' || e.descripcion || '; MAGNITUD: ' || m.descripcion ||
                           '; MARCA: ' || ma.descripcion || '; MODELO: ' || mo.descripcion || CASE WHEN cd.codigo not in ('', 'Sin Información') THEN ' SERIE: ' || cd.serie || ' CÓDIGO: ' || cd.codigo ELSE ' SERIE: ' || cd.serie end ||
                           CASE WHEN cd.idintervalo1 > 0 then '; RANGO: (' || mi1.desde || ' a ' || mi1.hasta || ') ' || mi1.medida else '; RANGO: VER ESPECIFICACIONES' end ||
                           CASE WHEN cd.idintervalo2 > 0 then '; RANGO 2: (' || mi2.desde || ' a ' || mi2.hasta || ') ' || mi2.medida else '' end as descripcion,
                            CASE WHEN id.estado = true THEN 
                                'Estado: Aprobado' || chr(10) || 
                                'Piezas: ' || id.piezas || chr(10) || 
                                'Funcionalidad: ' || id.funcionalidades || chr(10) || 
                                'Acabado: ' || id.acabado || chr(10) || 
                                'Observacion: ' || id.observacion 
                                ELSE 
                                'Estado: Rechazado' || chr(10) || 
                                'Piezas: ' || id.piezas || chr(10) || 
                                'Funcionalidad: ' || id.funcionalidades || chr(10) || 
                                'Acabado: ' || id.acabado || chr(10) || 
                                'Observacion: ' || id.observacion 
                           END AS inspeccion,
                           cd.precio, cd.iva, cd.descuento, case when cd.cantidad = 0 then 1 else cd.cantidad end as cantidad, tm.descripcion as moneda
                           from cotizacion_detalle cd 
                        INNER JOIN equipos e ON cd.idequipo = e.id  
                        INNER JOIN magnitudes m ON e.idmagnitud = m.id  
                        INNER JOIN magnitud_intervalos mi1 ON cd.idintervalo1 = mi1.id  
                        inner JOIN modelos mo ON cd.idmodelo = mo.id  
                        inner JOIN marcas ma ON mo.idmarca = ma.id
                        inner join magnitud_intervalos mi2 ON cd.idintervalo2 = mi2.id
                        inner join tipo_moneda tm on tm.id = cd.idmoneda
                        left join recepcion_detalle rd on rd.id = cd.idingreso 
                        left JOIN recepciones r ON rd.idrecepcion = r.id
                        left join inspeccion_detalle id on id.idingreso = rd.id
                        left join cotizaciones c on c.id = cd.idcotizacion 
                        {where} order by rd.ingreso, cd.id desc";
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

        public async Task<bool> ImportarRecepcion(int idrecepcion, int idcotizacion)
        {
            try
            {
                string sql = $@"SELECT 
                            string_agg(id::text, ',') AS ids, 
                            string_agg(idequipo::text, ',') AS idsequipo, 
                            string_agg(serie, ',') AS series, 
                            string_agg(codigo, ',') AS codigos, 
                            string_agg(idmodelo::text, ',') AS idsmodelo, 
                            string_agg(idintervalo1::text, ',') AS idsintervalo1, 
                            string_agg(idintervalo2::text, ',') AS idsintervalo2, 
                            idcliente
                        FROM (
                            SELECT 
                                id,
                                idequipo,
                                serie,
                                codigo,
                                idmodelo,
                                idintervalo1,
                                idintervalo2,
                                idcliente
                            FROM recepcion_detalle
                            WHERE idrecepcion = {idrecepcion} AND cotizado = 0
                            ORDER BY id
                        ) AS ordered_rd
                        GROUP BY idcliente;";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(sql);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string idsStr = row["ids"].ToString();
                    string idsEquipoStr = row["idsequipo"].ToString();
                    string idsModeloStr = row["idsmodelo"].ToString();
                    string idsIntercalo1Str = row["idsintervalo1"].ToString();
                    string idsIntercalo2Str = row["idsintervalo2"].ToString();
                    string seriesStr = row["series"].ToString();
                    string codigosStr = row["codigos"].ToString();
                    int idcliente = (int)row["idcliente"];
                    string[] idsArray = idsStr.Split(',');
                    string[] idsEquipoArray = idsEquipoStr.Split(',');
                    string[] idsModeloArray = idsModeloStr.Split(',');
                    string[] idsIntervalo1Array = idsIntercalo1Str.Split(',');
                    string[] idsIntervalo2Array = idsIntercalo2Str.Split(',');
                    string[] seriesArray = seriesStr.Split(',');
                    string[] codigosArray = codigosStr.Split(',');
                    string update = "";
                    for (int i = 0; i < idsArray.Length; i++)
                    {
                        string insert = $@"INSERT INTO public.cotizacion_detalle
                        (idcliente, idcotizacion, idingreso, idequipo, idmodelo, idintervalo1, idintervalo2, serie, codigo, iva)
                        VALUES({idcliente}, {idcotizacion}, {int.Parse(idsArray[i])}, {int.Parse(idsEquipoArray[i])}, {int.Parse(idsModeloArray[i])}, {int.Parse(idsIntervalo1Array[i])}, {int.Parse(idsIntervalo2Array[i])}, '{seriesArray[i]}', '{codigosArray[i]}', 19);";
                        if (dbHelper.ExecuteNonQuery(insert) <= 0)
                        {
                            MessageBox.Show($"Alerta: No todos los items fueron añadidos -> Cantidad añadida: {i}"); 
                            return false;
                        } else
                        {
                            update = $@"update recepcion_detalle set cotizado = 1 where id = {idsArray[i]}";
                            dbHelper.ExecuteNonQuery(update);
                        }
                        update = $"UPDATE recepciones SET estado = 'Cotizado' WHERE id = {idrecepcion}";
                        dbHelper.ExecuteNonQuery(update);   
                    }
                    return true;
                }
                return true;
            } catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Acción cancelada");
                return false;
            }
        }

        public async Task<int> Guardar(List<int> ids, int idcliente, int idsede, int idcontacto, int nro_cotizacion, string observacion)
        {
            try
            {
                string query = "";
                string busContador = "select cotizacion from contador where id = 1";
                object contador = await dbHelper.ExecuteScalarAsync(busContador);
                if (contador != null)
                {
                    int cotizacion = Convert.ToInt32(contador) + 1;
                    if (nro_cotizacion == 0)
                    {
                        query = $@"INSERT INTO public.cotizaciones
                                        (cotizacion, anio, idcliente, idsede, idcontacto, idusuario, estado, observacion)
                                        VALUES({cotizacion}, '{DateTime.Now.ToString("yyyy")}', {idcliente}, {idsede}, {idcontacto}, {FG.UserId}, 'Registrado', '{observacion}') returning id;";
                    }
                    else
                    {
                        query = $"update cotizaciones set idsede = {idsede}, idcontacto = {idcontacto}, observacion='{observacion}' where cotizacion = {nro_cotizacion} returning id";
                    }

                    object idGenerado = dbHelper.ExecuteScalar(query);

                    if (idGenerado != null && idGenerado != DBNull.Value && Convert.ToInt32(idGenerado) != 0)
                    {
                        string idsConcatenados = string.Join(",", ids);
                        string updateQuery = $"UPDATE cotizacion_detalle SET idcotizacion = {idGenerado}, estado = 'Cotizado' WHERE id IN ({idsConcatenados})";
                        int filasActualizadas = dbHelper.ExecuteNonQuery(updateQuery);
                        if (filasActualizadas > 0)
                        {
                            if (nro_cotizacion == 0)
                            {
                                int actcontador = dbHelper.ExecuteNonQuery($"update contador set cotizacion = {cotizacion} where id = 1");
                            }
                            if (nro_cotizacion == 0){
                                MessageBox.Show("Guardado con éxito");
                                return cotizacion;
                            }
                            else{
                                MessageBox.Show("Actualizado con éxito");
                                return nro_cotizacion;
                            }
                        }
                        
                        else
                        {
                            MessageBox.Show("No se actualizaron los ingresos", "GuardarCotizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se guardo la Cotizacion", "GuardarCotizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }

                }
                else
                {
                    MessageBox.Show("No se encontro el numero de recepcion en el contador.", "GuardarCotizacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar ingreso(s): " + ex.Message, "GuardarCotizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public async Task<bool> AdjuntarArchivo(int idcotizacion, string base64, string tipo)
        {
            try
            {
                string query = "";
                object id = await dbHelper.ExecuteScalarAsync($@"select coalesce(id, 0) as id from archivos.archivos_laboratorio where nrocontrol = {idcotizacion} and base64 = '{base64}' and tipo = 'COTIZACION ADJUNTO'");
                if (Convert.ToInt32(id) == 0)
                {
                    query = $@"insert into archivos.archivos_laboratorio
                                    (tipo, nrocontrol, base64, nroarchivo)
                                values('{tipo}', {idcotizacion}, '{base64}', 1)";
                    
                } else
                {
                    query = $@"update archivos.archivos_laboratorio set base64 = '{base64}' where id = {id}";
                }
                int guardado = dbHelper.ExecuteNonQuery(query);
                if (guardado > 0)
                {
                    MessageBox.Show("Guardado o Actualizado con éxito");
                    return true;
                } else
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

        public async Task<(string tipo, string base64)> VerAdjunto(int idcotizacion, string tipo)
        {
            try
            {
                string sql = $@"select tipo, base64 from archivos.archivos_laboratorio where nrocontrol = {idcotizacion} and tipo = '{tipo}'";
                DataTable data = await dbHelper.ExecuteQueryAsync(sql);
                if (data != null && data.Rows.Count > 0)
                {
                    var row = data.Rows[0];
                    return (row["tipo"].ToString(), row["base64"].ToString());
                }

                return (null, null);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return (null, null);
            }
        }


        #endregion
        #region Modal Aprobar

        public async Task<bool> Aprobar(int idcotizacion, int opcion, int estado, string base64, string tiempo, string contacto, string documento, string cargo, string telefono, string mensaje)
        {
            try
            {
                string query = $@"select estado from cotizaciones where id = {idcotizacion}";
                object estadocoti = await dbHelper.ExecuteScalarAsync(query);
                if (estadocoti != null && estadocoti != DBNull.Value)
                {
                    string estadocotizacion = Convert.ToString(estadocoti);
                    if (estadocotizacion == "Aprobado" && estado == 1)
                    {
                        MessageBox.Show($"No se puede Aprobar una cotización en estado: {estadocotizacion}");
                        return false;
                    }
                    if (estadocotizacion == "Registrado" && estado == 2)
                    {
                        MessageBox.Show($"No se puede Revisar una cotización en estado: {estadocotizacion}");
                        return false;
                    }
                    if (new [] {"Anulado", "Vencido", "Rechazado"}.Contains(estadocotizacion))
                    {
                        MessageBox.Show($"No se puede {(estado == 1 ? "Aprobar" : "Revisar")} una cotización en estado: {estadocotizacion}");
                        return false;
                    }
                    if(estado == 1)
                    {
                        string sql_aprobacion = $@"INSERT INTO public.cotizacion_aprobacion
                        (idcotizacion, contacto, cedula, cargo, telefono, estado, tiempo, idusuario, conversacion, tipo)
                        VALUES({idcotizacion}, '{contacto}', '{documento}', '{cargo}', '{telefono}', {estado}, '{tiempo}', {FG.UserId}, '{mensaje}', {opcion}) returning id; ";
                        object idObj = dbHelper.ExecuteScalar(sql_aprobacion);
                        if (idObj != null)
                        {
                            int id = Convert.ToInt32(idObj);
                            string sql_base64 = "";
                            switch (opcion)
                            {
                                case 1:
                                    sql_base64 = $@"insert into archivos.archivos_laboratorio
                                    (tipo, nrocontrol, base64, nroarchivo)
                                values('APROBACION COTIZACION', {id}, '{base64}', 1)";
                                    break;
                                case 2:
                                    sql_base64 = $@"insert into archivos.fotos_laboratorio
                                    (tipo, nrocontrol, base64, nrofoto, comprimido)
                                values('APROBACION COTIZACION', {id}, '{base64}', 1, '')";
                                    break;
                                default:
                                    break;
                            }
                            if(sql_base64 != "" || opcion == 3)
                            {
                                dbHelper.ExecuteNonQuery(sql_base64);
                            }
                            else
                            {
                                MessageBox.Show("No se encontro documento/imagen para guardar");
                                return false;
                            }
                            string update = $"update cotizaciones set estado = 'Aprobado', aprobada = 1, fechaaprobacion = now() where id = {idcotizacion}";
                            dbHelper.ExecuteNonQuery(update);
                            return true;
                        } 
                        else
                        {
                            MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    } else
                    {

                        string sql = $"select id from cotizacion_aprobacion where idcotizacion = {idcotizacion}";
                        object idObj = dbHelper.ExecuteScalar(sql);
                        if (idObj != null)
                        {
                            int id = Convert.ToInt32(idObj);
                            string delete = $"delete from cotizacion_aprobacion where id = {id}";
                            dbHelper.ExecuteNonQuery(delete);
                            delete = "";
                            if (opcion == 1)
                            {
                                delete = $"delete from archivos.archivos_laboratorio where tipo = 'APROBACION COTIZACION' and nrocontrol = {id}";
                            } else if (opcion == 2)
                            {
                                delete = $"delete from archivos.fotos_laboratorio where tipo = 'APROBACION COTIZACION' and nrocontrol = {id}";
                            }
                            if (delete != "")
                            {
                                dbHelper.ExecuteNonQuery(delete);
                            }
                            string update = $"update cotizaciones set estado = 'Registrado', aprobada = 0, fechaaprobacion = null where id = {idcotizacion}";
                            dbHelper.ExecuteNonQuery(update);
                            return true;
                        } else
                        {
                            MessageBox.Show("Numero de aprobación no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    
                } else
                {
                    MessageBox.Show("Estado no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Acción cancelada");
                return false;
            }
        }


        public async Task<DataTable> BuscarAprobacion(int idcotizacion)
        {
            try
            {
                string query = $@"select ca.id, ca.idcotizacion, ca.contacto, ca.cargo, ca.cedula, ca.telefono, ca.conversacion, ca.tiempo, ca.tipo, ca.estado,
                                case when ca.tipo in (1,2) then case when al.base64 != '' then al.base64 else fl.base64 end else '' end as base64
	                                from cotizacion_aprobacion ca
	                                left join archivos.archivos_laboratorio al on al.nrocontrol = ca.id
	                                left join archivos.fotos_laboratorio fl on fl.nrocontrol = ca.id
                                where idcotizacion = {idcotizacion}";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable.Rows.Count > 0)
                    return dataTable;
                else
                    return null;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Buscar(): " + ex.Message);
                return null;
            }
        }

        #endregion
    }
}
