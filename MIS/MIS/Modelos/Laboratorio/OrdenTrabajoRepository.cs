using MIS.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Laboratorio
{
    public class OrdenTrabajoRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public OrdenTrabajoRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }
        public async Task<DataTable> Detalle(int id)
        {
            try
            {

                string query = $@"
                SELECT rd.id, renglon,
                       'NR-' || to_char(rd.fechaing, 'YY-') || to_char(r.recepcion, '0000') || '-' || rd.renglon AS ingreso,
                       'EQUIPO: ' || e.descripcion || '; MAGNITUD: ' || m.descripcion ||
                       '; MARCA: ' || ma.descripcion || '; MODELO: ' || mo.descripcion || CASE WHEN rd.codigo not in ('', 'Sin Información') THEN ' SERIE: ' || rd.serie || ' CÓDIGO: ' || rd.codigo ELSE ' SERIE: ' || rd.serie end ||
                       CASE WHEN rd.idintervalo1 > 0 then '; RANGO: (' || mi1.desde || ' a ' || mi1.hasta || ') ' || mi1.medida else '; RANGO: VER ESPECIFICACIONES' end ||
                       CASE WHEN rd.idintervalo2 > 0 then '; RANGO 2: (' || mi2.desde || ' a ' || mi2.hasta || ') ' || mi2.medida else '' end ||
                       CASE WHEN rd.accesorios != '' THEN '; OBSERVACIÓN: ' || rd.observacion || '; ACCESORIOS: ' || rd.accesorios ELSE '; OBSERVACIÓN: ' || rd.observacion end || '; SERVICIO: ' || rd.tipo_servicio  as descripcion,
                       coalesce(od.observacion, '') as  observacion
                    FROM recepcion_detalle rd  
                    INNER JOIN equipos e ON rd.idequipo = e.id  
                    INNER JOIN magnitudes m ON rd.idmagnitud = m.id  
                    INNER JOIN magnitud_intervalos mi1 ON rd.idintervalo1 = mi1.id  
                    INNER JOIN marcas ma ON rd.idmarca = ma.id  
                    INNER JOIN modelos mo ON rd.idmodelo = mo.id  
                    INNER JOIN recepciones r ON rd.idrecepcion = r.id
                    inner join magnitud_intervalos mi2 ON rd.idintervalo2 = mi2.id
                    inner join clientes c on r.idcliente = c.id
                    inner join inspeccion_detalle id on id.idingreso = rd.id
                    left join ordentrabajo_detalle od on od.idingreso = rd.id
                    left join cotizacion_detalle cd on cd.idingreso = rd.id
                WHERE r.id = {id} and rd.inactivo = 0 and (rd.cotizado = 1 or c.convenio = 1) order by id asc";
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
                FG.ShowError($"Error al obtener datos de la base de datos: {ex.Message}", "error");
                return null;
            }
        }

        public async Task<DataTable> Buscar(int inspeccion, int ordentrabajo)
        {
            try
            {
                string where = "where ";
                if (ordentrabajo > 0)
                {
                    where += $"o.orden = {ordentrabajo}";
                }
                else if (inspeccion > 0)
                {
                    where += $"i.inspeccion= {inspeccion}";
                }
                else
                {
                    MessageBox.Show("No se proporciono la informacion");
                    return null;
                }
                string query = $@"select r.id, r.idcliente, c.nombrecompleto as cliente, coalesce(o.estado, '') as estado,
                    i.fecha as fecha_inspeccion, i.inspeccion, coalesce(o.orden) as ordentrabajo, coalesce(o.idusuorden, 0) as idmetrologo
                        from recepciones r 
                    inner join clientes c on c.id = r.idcliente
                    inner join recepcion_detalle rd on rd.idrecepcion = r.id 
                    inner join inspeccion_detalle id on rd.id  = id.idingreso
                    inner join inspecciones i on i.id = id.idinspeccion
                    left join ordentrabajo_detalle od on od.idingreso = rd.id
                    left join ordentrabajo o on o.id = od.idorden 
                        {where}
                    group by r.id, r.idcliente, c.nombrecompleto, i.estado, i.fecha, i.inspeccion, o.orden, o.estado, o.idusuorden;";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable == null)
                    return null;
                else
                    return dataTable;
            }
            catch (Exception ex)
            {
                FG.ShowError("Error: " + ex.Message, "Error");
                return null;
            }
        }

        public async Task<int> Guardar(List<int> ids, List<string> observaciones, int nro_orden, string observacion, int idmetrologo)
        {
            try
            {
                string insert = "";
                string update = "";
                string busContador = "select ordentrabajo from contador where id = 1";
                object contador = await dbHelper.ExecuteScalarAsync(busContador);
                if (contador != null)
                {
                    int orden = Convert.ToInt32(contador) + 1;
                    if (nro_orden == 0)
                    {
                        insert = $"INSERT INTO ordentrabajo(orden, idusuario, idusuorden,estado, observacion) " +
                                         $"VALUES({orden}, {FG.UserId}, {idmetrologo},'Registrado', '{observacion}') RETURNING id";

                    }
                    else
                    {
                        insert = $"update ordentrabajo set observacion='{observacion}', idusuorden={idmetrologo} where orden = {nro_orden} returning id";
                    }

                    object idGenerado = dbHelper.ExecuteScalar(insert);

                    if (idGenerado != null && idGenerado != DBNull.Value && Convert.ToInt32(idGenerado) != 0)
                    {
                        for (int i = 0; i < ids.Count; i++)
                        {

                            int id = ids[i];
                            string observacion_ingreso = observaciones[i];
                            int idingreso = Convert.ToInt32(dbHelper.ExecuteScalar($"select coalesce(idingreso, 0) from ordentrabajo_detalle where idingreso = {id}"));
                            if (idingreso > 0)
                            {
                                // Actualiza la inspección existente
                                update = $@"UPDATE ordentrabajo_detalle 
                                        SET observacion= '{observacion_ingreso}'
                                        WHERE idingreso = {id}";
                                dbHelper.ExecuteNonQuery(update);
                                update = $"update recepcion_detalle set estado = 'Programado' where id = {id}";
                                dbHelper.ExecuteNonQuery(update);
                            }
                            else
                            {
                                // Inserta una nueva inspección
                                insert = $@"INSERT INTO ordentrabajo_detalle(idingreso, idorden, observacion) 
                                    VALUES ({id}, {Convert.ToInt32(idGenerado)}, '{observacion_ingreso}')";
                                dbHelper.ExecuteNonQuery(insert);
                            }

                        }
                        if (nro_orden <= 0)
                        {
                            update = $"UPDATE contador SET ordentrabajo = {orden} WHERE id = 1";
                            dbHelper.ExecuteNonQuery(update);
                        }

                        if (nro_orden > 0)
                        {
                            FG.ShowMsg("Actualizado con éxito", "");
                            return nro_orden;
                        }
                        else
                        {
                            FG.ShowMsg("Guardado con éxito", "");
                            return orden;
                        }

                    }
                    else
                    {
                        FG.ShowAlert("No se guardo la recepción", "GuardarRecepcion");
                        return 0;
                    }

                }
                else
                {
                    FG.ShowAlert("No se encontro el numero de recepcion en el contador.", "GuardarRecepcion");
                    return 0;
                }


            }
            catch (Exception ex)
            {
                FG.ShowError("Error al eliminar ingreso(s): " + ex.Message, "GuardarRecepcion");
                return 0;
            }
        }

        public async Task<DataTable> EncabezadoReporte(int ordentrabajo)
        {
            string query = $@"
                select c.nombrecompleto as cliente, 
                'ODT-'|| trim(to_char(o.fecha, 'YY-')) || trim(to_char(o.orden,'0000')) as orden, to_char(o.fecha, 'DD-MM-YYYY') as fecha,
                'NR-' || trim(to_char(r.fecha, 'YY-')) || trim(to_char(r.recepcion, '0000')) as recepcion,
                'IR-' || trim(to_char(i.fecha, 'YY-')) || trim(to_char(i.inspeccion, '0000')) as inspeccion,
                to_char(r.fecha, 'DD-MM-YYYY') as fecharecepcion,
                to_char(i.fecha, 'DD-MM-YYYY') as fechainspeccion,
                string_agg(distinct m.abreviatura, ', ') as magnitud,
                ru.nombrecompleto as usuario
                from ordentrabajo o 
                inner join ordentrabajo_detalle od on o.id = od.idorden 
                inner join recepcion_detalle rd on rd.id = od.idingreso 
                inner join inspeccion_detalle id on rd.id = id.idingreso 
                inner join inspecciones i on i.id = id.idinspeccion 
                inner join recepciones r on r.id = rd.idrecepcion 
                inner join clientes c on c.id = r.idcliente 
                inner join magnitudes m on m.id = rd.idmagnitud 
                inner join seguridad.rbac_usuarios ru on ru.id = o.idusuario 
                WHERE o.orden = {ordentrabajo}
                group by c.nombrecompleto, o.orden, o.fecha, r.recepcion, r.fecha, i.inspeccion, i.fecha, ru.nombrecompleto ";
            return await dbHelper.ExecuteQueryAsync(query);
        }
        public async Task<DataTable> DetalleReporte(int ordentrabajo)
        {
            string query = $@"
                SELECT rd.id, renglon,
                   'NR-' || to_char(rd.fechaing, 'YY-') || trim(to_char(r.recepcion, '0000')) || '-' || rd.renglon AS ingreso,
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
                inner join ordentrabajo_detalle od on od.idingreso = rd.id
                inner join ordentrabajo o on o.id = od.idorden 
                where o.orden = {ordentrabajo} order by rd.id";
            return await dbHelper.ExecuteQueryAsync(query);
        }
    }
}
