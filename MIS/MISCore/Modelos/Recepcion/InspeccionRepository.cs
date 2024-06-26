using MIS.Helpers;
using MIS.Reportes.Recepcion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Recepcion
{
    public class InspeccionRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public InspeccionRepository() 
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }

        public async Task<DataTable> Buscar(int recepcion, int inspeccion)
        {
            try
            {
                string where = "where ";
                if(recepcion > 0)
                {
                    where += $"r.recepcion = {recepcion}";
                } else if (inspeccion > 0)
                {
                    where += $"i.inspeccion= {inspeccion}";
                } else
                {
                    MessageBox.Show("No se proporciono la informacion");
                    return null;
                }
                string query = $@"select r.id, r.idcliente, r.idsede, r.idcontacto, r.estado, r.recepcion, r.fecha as fecha_recepcion, c.nombrecompleto as cliente, coalesce(i.estado, '') as estado_inspeccion,
                    i.fecha as fecha_inspeccion, coalesce(i.inspeccion, 0) as inspeccion
                        from recepciones r 
                    inner join clientes c on c.id = r.idcliente
                    inner join recepcion_detalle rd on rd.idrecepcion = r.id 
                    left join inspeccion_detalle id on rd.id  = id.idingreso
                    left join inspecciones i on i.id = id.idinspeccion
                        {where}
                    group by r.id, r.idcliente, r.idsede, r.idcontacto, r.estado, r.recepcion, r.fecha, c.nombrecompleto, i.estado, i.fecha, i.inspeccion";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable == null)
                    return null;
                else
                    return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        public async Task<DataTable> TablaIngresos(int id)
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
                   coalesce(id.piezas, '') as piezas, coalesce(id.funcionalidades, '') as funcionalidades, coalesce(id.acabado, '') as acabados, coalesce(id.observacion, '') as observaciones, coalesce(id.estado, true) as estados
                FROM recepcion_detalle rd  
                INNER JOIN equipos e ON rd.idequipo = e.id  
                INNER JOIN magnitudes m ON rd.idmagnitud = m.id  
                INNER JOIN magnitud_intervalos mi1 ON rd.idintervalo1 = mi1.id  
                INNER JOIN marcas ma ON rd.idmarca = ma.id  
                INNER JOIN modelos mo ON rd.idmodelo = mo.id  
                INNER JOIN recepciones r ON rd.idrecepcion = r.id
                inner join magnitud_intervalos mi2 ON rd.idintervalo2 = mi2.id
                left join inspeccion_detalle id on id.idingreso = rd.id
                WHERE r.id = {id} and rd.inactivo = 0 order by ingreso";
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

        public async Task<int> GuardarInspeccion(List<int> ids, List<string> piezas, List<string> funcionalidades, List<string> acabados, List<string> observaciones, List<string> estados, int nro_recepcion, int nro_inspeccion, string observacion)
        {
            try
            {
                string insert = "";
                string update = "";
                string busContador = "select inspeccion from contador where id = 1";
                object contador = await dbHelper.ExecuteScalarAsync(busContador);
                if (contador != null)
                {
                    int inspeccion = Convert.ToInt32(contador) + 1;
                    if (nro_inspeccion == 0)
                    {
                        insert = $"INSERT INTO inspecciones(inspeccion, idusuario, estado, observacion) " +
                                         $"VALUES({inspeccion}, {FG.UserId}, 'Inspeccionado', '{observacion}') RETURNING id";
                        
                    }
                    else
                    {
                        insert = $"update inspecciones set observacion='{observacion}' where inspeccion = {nro_inspeccion} returning id";
                    }

                    object idGenerado = dbHelper.ExecuteScalar(insert);

                    if (idGenerado != null && idGenerado != DBNull.Value && Convert.ToInt32(idGenerado) != 0)
                    {
                        for (int i = 0; i < ids.Count; i++)
                        {
                            
                            int id = ids[i];
                            string pieza = piezas[i];
                            string funcionalidad = funcionalidades[i];
                            string acabado = acabados[i];
                            string observacion_ingreso = observaciones[i];
                            string estado = estados[i];
                            int idingreso = Convert.ToInt32(dbHelper.ExecuteScalar($"select coalesce(idingreso, 0) from inspeccion_detalle where idingreso = {id}"));
                            if (idingreso > 0)
                            {
                                // Actualiza la inspección existente
                                update = $@"UPDATE inspeccion_detalle 
                                        SET piezas='{pieza}', funcionalidades='{funcionalidad}', acabado='{acabado}', observacion= '{observacion_ingreso}', estado={(estado == "Aprobado")}
                                        WHERE idingreso = {id}";
                                dbHelper.ExecuteNonQuery(update);
                                update = $"update recepcion_detalle set estado = 'Inspeccionado' where id = {id}";
                                dbHelper.ExecuteNonQuery(update);
                            }
                            else
                            {
                                // Inserta una nueva inspección
                                insert = $@"INSERT INTO inspeccion_detalle (idingreso, idinspeccion, piezas, funcionalidades, acabado, observacion, estado) 
                                    VALUES ({id}, {Convert.ToInt32(idGenerado)}, '{pieza}', '{funcionalidad}', '{acabado}', '{observacion_ingreso}', {(estado == "Aprobado")})";
                                dbHelper.ExecuteNonQuery(insert);
                            }

                        }
                        if (nro_inspeccion <= 0)
                        {
                            update = $"UPDATE contador SET inspeccion = {inspeccion} WHERE id = 1";
                            dbHelper.ExecuteNonQuery(update);
                        }

                        if (nro_inspeccion > 0)
                        {
                            MessageBox.Show("Actualizado con éxito");
                            return nro_inspeccion;
                        }
                        else
                        {
                            MessageBox.Show("Guardado con éxito");
                            return inspeccion;
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se guardo la recepción", "GuardarRecepcion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return 0;
                    }

                }
                else
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

        public async Task<DataTable> GetEncabezadoInspeccion(int inspeccion)
        {
            string query = $@"
                select c.nombrecompleto as cliente, c.documento,'NR-' || to_char(r.fecha, 'YY-') || trim(to_char(r.recepcion, '0000')) as recepcion, 
	                'IR-' || to_char(i.fecha, 'YY-') || trim(to_char(i.inspeccion, '0000')) as inspeccion,
	                to_char(r.fecha, 'DD-MM-YYYY') as fecha_recepcion, to_char(i.fecha, 'DD-MM-YYYY') as fecha_inspeccion,
	                (select count(*) from recepcion_detalle rd2 where rd2.idrecepcion = r.id) as ingresos,
	                (select count(*) from material_detalle md where md.idrecepcion = r.id) as materiales,
	                (select count(*) from recepcion_detalle rd3 where rd3.idrecepcion = r.id) + (select count(*) from material_detalle md2 where md2.idrecepcion = r.id) as recibidos,
	                sum(case when id.idingreso > 0 then 1 else 0 end + case when id.idmaterial > 0 then 1 else 0 end) as inspeccionados,
	                sum(case when id.estado = true then 1 else 0 end) as aprobados,
	                sum(case when id.estado = false then 1 else 0 end) as rechazados,
	                i.observacion, ru.nombrecompleto as usuario
	                from inspecciones i
	                inner join inspeccion_detalle id on id.idinspeccion = i.id 
                inner join recepcion_detalle rd on rd.id = id.idingreso 
                inner join recepciones r on r.id = rd.idrecepcion
                inner join clientes c on c.id = r.idcliente
                inner join seguridad.rbac_usuarios ru on ru.id = i.idusuario
                WHERE i.inspeccion = {inspeccion}
                group by c.nombrecompleto, c.documento, r.fecha, r.recepcion, i.fecha, i.inspeccion, r.id, id.idmaterial, i.observacion, ru.nombrecompleto";
            return await dbHelper.ExecuteQueryAsync(query);
        }
        public async Task<DataTable> GetDetalleInspecccion(int inspeccion)
        {
            string query = $@"
                SELECT rd.id, renglon,
                   'NR-' || to_char(rd.fechaing, 'YY-') || to_char(r.recepcion, '0000') || '-' || rd.renglon AS ingreso,
                   '<b>EQUIPO:</b> ' || e.descripcion || '; <b>MAGNITUD:</b> ' || m.descripcion ||
                   '; <b>MARCA:</b> ' || ma.descripcion || '; <b>MODELO:</b> ' || mo.descripcion || CASE WHEN rd.codigo not in ('', 'Sin Información') THEN ' <b>SERIE:</b> ' || rd.serie || ' <b>CÓDIGO:</b> ' || rd.codigo ELSE ' <b>SERIE:</b> ' || rd.serie end ||
                   CASE WHEN rd.idintervalo1 > 0 then '; <b>RANGO:</b> (' || mi1.desde || ' a ' || mi1.hasta || ') ' || mi1.medida else '; <b>RANGO:</b> VER ESPECIFICACIONES' end ||
                   CASE WHEN rd.idintervalo2 > 0 then '; <b>RANGO 2:</b> (' || mi2.desde || ' a ' || mi2.hasta || ') ' || mi2.medida else '' end ||
                   CASE WHEN rd.accesorios != '' THEN '; <b>OBSERVACIÓN:</b> ' || rd.observacion || '; <b>ACCESORIOS:</b> ' || rd.accesorios ELSE '; <b>OBSERVACIÓN:</b> ' || rd.observacion end || '; <b>SERVICIO:</b> ' || rd.tipo_servicio  as descripcion,
                   id.piezas, id.funcionalidades, id.acabado
                FROM recepcion_detalle rd  
                INNER JOIN equipos e ON rd.idequipo = e.id  
                INNER JOIN magnitudes m ON rd.idmagnitud = m.id  
                INNER JOIN magnitud_intervalos mi1 ON rd.idintervalo1 = mi1.id  
                INNER JOIN marcas ma ON rd.idmarca = ma.id  
                INNER JOIN modelos mo ON rd.idmodelo = mo.id  
                INNER JOIN recepciones r ON rd.idrecepcion = r.id
                inner join magnitud_intervalos mi2 ON rd.idintervalo2 = mi2.id
                inner join inspeccion_detalle id on id.idingreso = rd.id
                inner join inspecciones i on i.id = id.idinspeccion 
                WHERE i.inspeccion = {inspeccion} order by rd.renglon";
            return await dbHelper.ExecuteQueryAsync(query);
        }

        public async Task<DataTable> Consulta(int inspeccion, int recepcion, int idcliente, string desde, string hasta)
        {
            string where = $"where to_char(i.fecha, 'DD-MM-YYYY') >= '{desde}' and to_char(i.fecha, 'DD-MM-YYYY') <= '{hasta}'";
            if (inspeccion > 0)
            {
                where += $" i.inspeccion = {inspeccion}";
            } else if (recepcion > 0)
            {
                where += $" r.recepcion = {recepcion}";
            }
            else if (idcliente > 0)
            {
                where += $" and r.idcliente = {idcliente}";
            }
            string query = $@"
                select r.recepcion as nro_recepcion, i.inspeccion as nro_inspeccion, c.nombrecompleto as cliente, c.documento,'NR-' || to_char(r.fecha, 'YY-') || trim(to_char(r.recepcion, '0000')) as recepcion, 
	                'IR-' || to_char(i.fecha, 'YY-') || trim(to_char(i.inspeccion, '0000')) as inspeccion,
	                to_char(r.fecha, 'DD-MM-YYYY') as fecha_recepcion, to_char(i.fecha, 'DD-MM-YYYY') as fecha_inspeccion,
	                (select count(*) from recepcion_detalle rd2 where rd2.idrecepcion = r.id) as ingresos,
	                (select count(*) from material_detalle md where md.idrecepcion = r.id) as materiales,
	                (select count(*) from recepcion_detalle rd3 where rd3.idrecepcion = r.id) + (select count(*) from material_detalle md2 where md2.idrecepcion = r.id) as recibidos,
	                sum(case when id.idingreso > 0 then 1 else 0 end + case when id.idmaterial > 0 then 1 else 0 end) as inspeccionados,
	                sum(case when id.estado = true then 1 else 0 end) as aprobados,
	                sum(case when id.estado = false then 1 else 0 end) as rechazados,
	                i.observacion, ru.nombrecompleto as usuario
	                from inspecciones i
	                inner join inspeccion_detalle id on id.idinspeccion = i.id 
                inner join recepcion_detalle rd on rd.id = id.idingreso 
                inner join recepciones r on r.id = rd.idrecepcion
                inner join clientes c on c.id = r.idcliente
                inner join seguridad.rbac_usuarios ru on ru.id = i.idusuario
                {where}
                group by c.nombrecompleto, c.documento, r.fecha, r.recepcion, i.fecha, i.inspeccion, r.id, id.idmaterial, i.observacion, ru.nombrecompleto";
            return await dbHelper.ExecuteQueryAsync(query);
        }
    }
}
