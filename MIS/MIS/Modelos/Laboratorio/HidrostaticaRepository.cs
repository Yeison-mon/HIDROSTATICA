using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIS.Helpers;


namespace MIS.Modelos.Laboratorio
{
    public class HidrostaticaRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public HidrostaticaRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }

        public async Task<int> GuardarPrueba(int hidrostatica, string imagen, int idcliente, int idcontacto, string observacion, List<double> psis, List<double> temperaturas, List<DateTime> tiempos, string serie, string dimensiones, int herramienta, int idequipo, int marca, int modelo, int psimin, int psimax)
        {
            try
            {
                string queryContador = $"SELECT max(numero) as numero FROM prueba_hidrostatica WHERE to_char(fecha, 'YYYY') = '{DateTime.Now.Year.ToString()}'";
                object contadorObj = await dbHelper.ExecuteScalarAsync(queryContador);
                int numeroPrueba = contadorObj != null ? Convert.ToInt32(contadorObj) + 1 : 1;

                string insertPruebaQuery;
                if (hidrostatica == 0)
                {
                    insertPruebaQuery = $@"INSERT INTO prueba_hidrostatica(idusuario, numero, idcliente, idcontacto, grafica, estado, observacion, idherramienta, idequipo, idmarca, idmodelo, serie, dimensiones, psi_min, psi_max) 
                    VALUES ({FG.UserId}, {numeroPrueba}, {idcliente}, {idcontacto}, '{imagen}', 'Registrado', '{observacion}', {herramienta}, {idequipo}, {marca}, {modelo}, '{serie}', '{dimensiones}', {psimin}, {psimax}) RETURNING id";
                }
                else
                {
                    insertPruebaQuery = $@"UPDATE prueba_hidrostatica SET idcontacto = {idcontacto}, grafica = '{imagen}', observacion = '{observacion}', idherramienta = {herramienta}, idequipo={idequipo},
                        idmarca = {marca}, idmodelo = {modelo}, serie = '{serie}', dimensiones = '{dimensiones}', psi_min = {psimin}, psi_max = {psimax}
                        WHERE numero = {hidrostatica} RETURNING id";
                }

                object idPruebaObj = await dbHelper.ExecuteScalarAsync(insertPruebaQuery);
                int idPrueba = idPruebaObj != null ? Convert.ToInt32(idPruebaObj) : 0;

                if (idPrueba > 0)
                {
                    // Preparar los arrays para insertar los detalles
                    string psiArray = "{" + string.Join(",", psis.Select(p => p.ToString(CultureInfo.InvariantCulture))) + "}";
                    string temperaturaArray = "{" + string.Join(",", temperaturas.Select(t => t.ToString(CultureInfo.InvariantCulture))) + "}";
                    string tiempoArray = "{" + string.Join(",", tiempos.Select(t => $"\"{t.ToString("yyyy-MM-dd HH:mm:ss")}\"")) + "}";

                    // Verificar si los detalles ya existen para la prueba y actualizar o insertar en consecuencia
                    string checkDetalleQuery = $"SELECT COUNT(*) FROM prueba_hidrostatica_detalle WHERE idprueba = {idPrueba}";
                    int detalleCount = Convert.ToInt32(await dbHelper.ExecuteScalarAsync(checkDetalleQuery));

                    string insertOrUpdateDetalleQuery;
                    if (detalleCount > 0)
                    {
                        insertOrUpdateDetalleQuery = $@"UPDATE prueba_hidrostatica_detalle 
                                                SET psi = '{psiArray}', temperatura = '{temperaturaArray}', tiempo = '{tiempoArray}'
                                                WHERE idprueba = {idPrueba}";
                    }
                    else
                    {
                        insertOrUpdateDetalleQuery = $@"INSERT INTO prueba_hidrostatica_detalle (idprueba, psi, temperatura, tiempo) 
                                                VALUES ({idPrueba}, '{psiArray}', '{temperaturaArray}', '{tiempoArray}')";
                    }

                    int rowsAffected = dbHelper.ExecuteNonQuery(insertOrUpdateDetalleQuery);

                    if (rowsAffected > 0)
                    {
                        // Solo actualizar el contador si es una nueva prueba
                        if (hidrostatica == 0)
                        {
                            int updateContador = dbHelper.ExecuteNonQuery($"UPDATE contador SET hidrostatica = {numeroPrueba} WHERE id = 1");
                            if (updateContador > 0)
                                return numeroPrueba;
                            else
                                MessageBox.Show("No se actualizó el contador", "GuardarPrueba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            return hidrostatica;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se guardaron los detalles de la prueba", "GuardarPrueba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se guardó la prueba", "GuardarPrueba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la prueba: " + ex.Message, "GuardarPrueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public async Task<DataTable> EncabezadoHidrostatica(int numero, string anio)
        {
            string query = $@"
                    WITH prueba AS (
                        SELECT *
                        FROM prueba_hidrostatica ph
                        WHERE ph.numero = {numero} and to_char(ph.fecha, 'YYYY') = '{anio}'
                    ),
                    valores_validos AS (
                        SELECT unnest(phd.psi) AS valor, generate_series(1, array_length(phd.psi, 1)) AS pos,
                               unnest(phd.temperatura) AS temperatura  -- Asumiendo que tienes un campo ""temperaturas""
                        FROM prueba_hidrostatica_detalle phd
                        JOIN prueba p ON p.id = phd.idprueba
                    ),
                    primer_valor AS (
                        SELECT MIN(pos) AS primer_pos
                        FROM valores_validos
                        WHERE valor > (SELECT psi_max FROM prueba)
                    ),
                    ultimo_valor AS (
                        SELECT MAX(pos) AS ultimo_pos
                        FROM valores_validos
                        WHERE valor > (SELECT psi_max FROM prueba)
                    ),
                    valores_en_rango AS (
                        SELECT v.valor, v.temperatura
                        FROM valores_validos v
                        WHERE v.pos >= (SELECT primer_pos FROM primer_valor)
                          AND v.pos <= (SELECT ultimo_pos FROM ultimo_valor)
                    ),
                    presion_final AS (
                        SELECT valor AS final_presion
                        FROM valores_validos
                        WHERE pos = (SELECT ultimo_pos FROM ultimo_valor)
                    ),
                    promedio_psi AS (
                        SELECT COALESCE(ROUND(AVG(valor)), 0)::int AS avg_psi
                        FROM valores_en_rango
                    ),
                    promedio_temperatura AS (
                        SELECT COALESCE(ROUND(AVG(temperatura)), 0)::int AS avg_temp
                        FROM valores_en_rango
                    ),
                    psi_valores AS (
                        SELECT 
                            (SELECT valor FROM valores_validos WHERE pos = (SELECT ultimo_pos FROM ultimo_valor)) AS psi_ultimo_pos,
                            (SELECT valor FROM valores_validos WHERE pos = (SELECT primer_pos FROM primer_valor)) AS psi_primer_pos,
                            (SELECT ultimo_pos FROM ultimo_valor) + 1 AS pos_ultima_plus_1
                    ),
                    temperaturas_extremas AS (
                        SELECT 
                            MIN(temperatura) AS tem_min, 
                            MAX(temperatura) AS tem_max
                        FROM valores_validos
                        WHERE pos = (SELECT primer_pos FROM primer_valor)
                           OR pos = (SELECT ultimo_pos FROM ultimo_valor)
                    )
                    SELECT
                        c.nombrecompleto AS cliente,
                        '{DateTime.Now.Year}-' || TRIM(TO_CHAR(ph.numero, '0000')) AS numero,
                        ci.descripcion AS lugar,
                        TO_CHAR(ph.fecha, 'YYYY-MM-DD') AS fecha,
                        (SELECT MAX(valor) FROM valores_validos) AS inicial,
                        (SELECT valor FROM valores_validos WHERE pos = (SELECT ultimo_pos FROM ultimo_valor)) AS final,
                        ROUND(EXTRACT(EPOCH FROM (phd.tiempo[ARRAY_LENGTH(phd.tiempo, 1)] - phd.tiempo[1])) / 60.0, 2)::TEXT || ' min' AS tiempo,
                        ru.nombrecompleto AS usuario,
                        ph.observacion,
                        ph.grafica,
                        '' AS tipo_servicio,
                        '' AS variables,
                        h.descripcion AS herramienta,
                        (SELECT tem_min FROM temperaturas_extremas) AS tem_min,  -- Cambiando por el valor mínimo de temperatura
                        (SELECT tem_max FROM temperaturas_extremas) AS tem_max,  -- Cambiando por el valor máximo de temperatura
                        m.descripcion AS marca,
                        e.descripcion AS equipo,
                        ph.serie,
                        ph.dimensiones,
                        (SELECT avg_psi FROM promedio_psi) AS promedio_psi,
                        (SELECT avg_temp FROM promedio_temperatura) AS promedio_tem,  -- Incluyendo el promedio de temperatura
                        (SELECT primer_pos FROM primer_valor) AS primera_posicion,
                        (SELECT ultimo_pos FROM ultimo_valor) AS ultima_posicion,
                        (SELECT psi_ultimo_pos FROM psi_valores) AS psi_ultimo_pos,
                        (SELECT psi_primer_pos FROM psi_valores) AS psi_primer_pos,
                        (SELECT pos_ultima_plus_1 FROM psi_valores) AS pos_ultima_plus_1,
                        ROUND(ABS((SELECT avg_psi FROM promedio_psi) - (SELECT final_presion FROM presion_final))) AS delta,
                        CASE 
                            WHEN (SELECT avg_psi FROM promedio_psi) > 0 THEN
                                ROUND(CAST((ABS((SELECT avg_psi FROM promedio_psi) - (SELECT final_presion FROM presion_final)) * 100.0) / (SELECT avg_psi FROM promedio_psi) AS numeric), 2)
                            ELSE 0
                        END AS error_psi
                    FROM prueba_hidrostatica ph
                    INNER JOIN clientes c ON c.id = ph.idcliente
                    INNER JOIN ciudad ci ON ci.id = c.idciudad 
                    INNER JOIN prueba_hidrostatica_detalle phd ON phd.idprueba = ph.id
                    INNER JOIN seguridad.rbac_usuarios ru ON ru.id = ph.idusuario
                    INNER JOIN herramientas h ON h.id = ph.idherramienta
                    INNER JOIN marcas m ON m.id = ph.idmarca
                    INNER JOIN equipos e ON e.id = ph.idequipo
                WHERE ph.numero = {numero} and to_char(ph.fecha, 'YYYY') = '{anio}';";
            return await dbHelper.ExecuteQueryAsync(query);
        }

        public async Task<DataRow> Buscar(int numero, string anio)
        {
            string query = $@"
                select ph.idcliente, ph.idcontacto, ph.numero, ph.fecha, ph.psi_min, ph.psi_max, cc.idsede,
                    phd.psi as psiarray, phd.tiempo as tiempoarray, phd.temperatura as temarray, ph.idequipo,
                    ph.observacion, ph.idherramienta, ph.idmarca, ph.idmodelo, ph.serie, ph.dimensiones
                    from prueba_hidrostatica ph
                        inner join clientes c on c.id = ph.idcliente
                        inner join contactos_cliente cc on cc.id = ph.idcontacto
                        inner join prueba_hidrostatica_detalle phd on phd.idprueba = ph.id
                    where ph.numero = {numero} and to_char(ph.fecha, 'YYYY') = '{anio}'";
            DataTable dt = await dbHelper.ExecuteQueryAsync(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
        public async Task<DataTable> Consultar(string numero, int idcliente, string desde, string hasta, string serie)
        {
            string where = $"where DATE_TRUNC('day', ph.fecha) >= '{desde}' and DATE_TRUNC('day', ph.fecha) <= '{hasta}'";
            if (numero != "")
            {
                where += $" and ph.numero = {numero}";
            }
            else if (idcliente > 0)
            {
                where += $" and ph.idcliente = {idcliente}";
            }
            if (serie != "")
            {
                where += $" and ph.serie ilike '%{serie}%'";
            }
            string query = $@"
                    select ph.id, ROW_NUMBER() OVER(order by ph.id desc) as fila, ph.numero,'VCO-'|| trim(to_char(ph.fecha, 'YYYY-')) || trim(to_char(ph.numero, '0000')) as prueba, c.nombrecompleto || '(' || c.documento  || ')' as cliente, 
                    to_char(ph.fecha, 'DD-MM-YYYY') as fecha, to_char(ph.fecha, 'YYYY') as anio, e.descripcion as equipo, h.descripcion as herramienta, ph.serie, ph.dimensiones as parte, ru.nombrecompleto as registrado_por, ph.observacion
                            from prueba_hidrostatica ph
                        inner join clientes c on c.id = ph.idcliente 
                        inner join seguridad.rbac_usuarios ru on ru.id = ph.idusuario
                        inner join equipos e on e.id = ph.idequipo
                        inner join herramientas h on h.id = ph.idherramienta
                    {where}
                    order by ph.numero desc";
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
        public async Task<int> CambioCliente(int idcliente, int numero, string anio)
        {
            try
            {

                string update = $"update prueba_hidrostatica set idcontacto = 0, idcliente = {idcliente} where numero = {numero} and to_char(fecha, 'YYYY') = '{anio}' returning id";
                
                object idPruebaObj = await dbHelper.ExecuteScalarAsync(update);
                int idPrueba = idPruebaObj != null ? Convert.ToInt32(idPruebaObj) : 0;

                if (idPrueba > 0)
                {
                    MessageBox.Show("Cambio de cliente realizado con exito");
                    return idPrueba;
                }
                else
                {
                    MessageBox.Show("No se cambio el cliente", "CambioCliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Cambio Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
