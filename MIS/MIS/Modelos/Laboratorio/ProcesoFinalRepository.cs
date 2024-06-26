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
    public class ProcesoFinalRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public ProcesoFinalRepository()
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
                   coalesce(pd.lavado, '') as lavado, coalesce(pd.componentes, '') as componenetes, coalesce(pd.desarme, '') as desarme, coalesce(pd.ensamblaje, '') as ensamblaje,
                   'MIS-'|| m.abreviatura || '-' || trim(to_char(now(), 'YYYY')) || '-' as nomenclatura, coalesce(pd.certificado::text, '') as certificado, 
                    coalesce(pd.fecha_certificado, '') as fecha_certificado,  coalesce(pd.idacreditado, 1) as tipo, coalesce(pd.observacion, '') as observacion
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
                    inner join ordentrabajo_detalle od on od.idingreso = rd.id
                    left join procesofinal_detalle pd on pd.idingreso = od.idingreso
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

        public async Task<DataTable> Buscar(int idrecepcion, int ordentrabajo, int procesofinal)
        {
            try
            {
                string where = "where ";
                if (ordentrabajo > 0)
                {
                    where += $"o.orden = {ordentrabajo}";
                }
                else if (idrecepcion > 0)
                {
                    where += $"r.id = {idrecepcion}";
                }
                 else if (procesofinal > 0)
                {
                    where += $"pf.procesofinal = {procesofinal}";
                }
                else
                {
                    FG.ShowAlert("No se proporciono la informacion", "Alerta");
                    return null;
                }
                string query = $@"select r.id, r.idcliente, c.nombrecompleto as cliente, coalesce(pf.estado, '') as estado, coalesce(pf.procesofinal, 0) as  procesofinal,
                            o.orden as ordentrabajo, o.idusuorden as idmetrologo, o.fecha as fecha_orden, coalesce(pf.fecha) as fecha
                        from recepciones r 
                    inner join clientes c on c.id = r.idcliente
                    inner join recepcion_detalle rd on rd.idrecepcion = r.id 
                    inner join ordentrabajo_detalle od on od.idingreso = rd.id
                    inner join ordentrabajo o on o.id = od.idorden 
                    left join procesofinal_detalle pd on pd.idingreso = od.idingreso
                    left join procesosfinales pf on pf.id = pd.idprocesofinal
                        {where} and o.idusuorden = {FG.UserId}
                    group by r.id, r.idcliente, c.nombrecompleto, o.orden, o.fecha, o.idusuorden, pf.estado, pf.procesofinal, pf.fecha;";
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
    }
}
