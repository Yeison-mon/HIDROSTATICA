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

        public async Task<int> GuardarPrueba(int hidrostatica, string imagen, int idcliente, int idcontacto, string observacion, List<double> psis, List<double> temperaturas, List<DateTime> tiempos, string serie, string dimensiones, int herramienta, int marca, int modelo, int psimin, int psimax)
        {
            try
            {
                string queryContador = "SELECT hidrostatica FROM contador WHERE id = 1";
                object contadorObj = await dbHelper.ExecuteScalarAsync(queryContador);
                int numeroPrueba = contadorObj != null ? Convert.ToInt32(contadorObj) + 1 : 1;

                string insertPruebaQuery;
                if (hidrostatica == 0)
                {
                    insertPruebaQuery = $@"INSERT INTO prueba_hidrostatica(idusuario, numero, idcliente, idcontacto, grafica, estado, observacion, idherramienta, idmarca, idmodelo, serie, dimensiones, psi_min, psi_max) 
                    VALUES ({FG.UserId}, {numeroPrueba}, {idcliente}, {idcontacto}, '{imagen}', 'Registrado', '{observacion}', {herramienta}, {marca}, {modelo}, '{serie}', '{dimensiones}', {psimin}, {psimax}) RETURNING id";
                }
                else
                {
                    insertPruebaQuery = $@"UPDATE prueba_hidrostatica SET idcontacto = {idcontacto}, grafica = '{imagen}', observacion = '{observacion}', idherramienta = {herramienta},
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
        public async Task<DataTable> EncabezadoHidrostatica(int numero)
        {
            string query = $@"
                select c.nombrecompleto as cliente, 'MIS-2024-' || trim(to_char(ph.numero, '000')) as numero, ci.descripcion as lugar, to_char(ph.fecha, 'YYYY-MM-DD') as fecha,
                    phd.psi[1] as inicial, phd.psi[array_length(phd.psi, 1)] as final,
                    round(extract(epoch from (phd.tiempo[array_length(phd.tiempo, 1)] - phd.tiempo[1])) / 60.0, 2)::text || ' min' as tiempo,
                    ru.nombrecompleto as usuario, ph.observacion, ph.grafica, '' as tipo_servicio, '' as variables, h.descripcion as herramienta,
                    ph.psi_min, ph.psi_max, ph.tem_min, ph.tem_max, m.descripcion as marca, mo.descripcion as modelo,
                    ph.serie, ph.dimensiones,
                    phd.temperatura[1] as temini, phd.temperatura[array_length(phd.temperatura, 1)] as temfinal
                    from prueba_hidrostatica ph
                    inner join clientes c on c.id = ph.idcliente
                    inner join ciudad ci on ci.id = c.idciudad 
                    inner join prueba_hidrostatica_detalle phd on phd.idprueba = ph.id
                    inner join seguridad.rbac_usuarios ru on ru.id = ph.idusuario
                    inner join herramientas h on h.id = ph.idherramienta
                    inner join marcas m on m.id = ph.idmarca
                    inner join modelos mo on mo.id = ph.idmodelo
                    where ph.numero = {numero}";
            return await dbHelper.ExecuteQueryAsync(query);
        }

        public async Task<DataRow> Buscar(int numero)
        {
            string query = $@"
                select ph.idcliente, ph.idcontacto, ph.numero, ph.fecha, ph.psi_min, ph.psi_max, cc.idsede,
                    phd.psi as psiarray, phd.tiempo as tiempoarray, phd.temperatura as temarray,
                    ph.observacion, ph.idherramienta, ph.idmarca, ph.idmodelo, ph.serie, ph.dimensiones
                    from prueba_hidrostatica ph
                        inner join clientes c on c.id = ph.idcliente
                        inner join contactos_cliente cc on cc.id = ph.idcontacto
                        inner join prueba_hidrostatica_detalle phd on phd.idprueba = ph.id
                    where ph.numero = {numero}";
            DataTable dt = await dbHelper.ExecuteQueryAsync(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }

    }
}
