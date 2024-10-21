using MIS.Helpers;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos
{
    public class CombosRepository
    {
        private readonly PostgreSQLHelper dbHelper;

        public CombosRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }
        public async Task<DataTable> CargarCombos(string tipo, string condicion)
        { 
            
            try
            {
                string query = "";
                
                switch (tipo)
                {
                    case "magnitudes":
                        if(condicion == "" || condicion == "0")
                            query = "select id, descripcion from magnitudes where id > 0 and estado = 1 order by descripcion;";
                        else
                            query = $@"select m.id, m.descripcion from magnitudes m inner join equipos e on e.idmagnitud = m.id
                                    where m.id > 0 and m.estado = 1 and e.id = {condicion} order by m.descripcion;";
                        break;
                    case "equipos":
                        if (condicion == "" || condicion == "0")
                            query = "select id, descripcion from equipos where id > 0 and estado = 1 order by descripcion";
                        else
                            query = $"select id, descripcion from equipos where id > 0 and estado = 1 and idmagnitud = {condicion} order by descripcion";
                        break;
                    case "ubicaciones":
                        query = "select id, descripcion from ubicaciones where id > 0 order by descripcion";
                        break;
                    case "marcas":
                        if (condicion == "" || condicion == "0")
                            query = "select id, descripcion from marcas where id > 0 and estado > 0 order by descripcion;";
                        else
                            query = $"select ma.id, ma.descripcion from marcas ma inner join modelos mo on mo.idmarca = ma.id where mo.id = {condicion} order by ma.descripcion;";
                        
                        break;
                    case "modelos":
                        if (condicion == "" || condicion == "0")
                            query = "select id, descripcion from modelos where id > 0 and estado > 0 order by descripcion;";
                        else
                            query = $"select id, mo.descripcion from modelos mo where mo.idmarca = {condicion} order by mo.descripcion;";
                        break;
                    case "accesorios":
                        query = "select id, descripcion from accesorios where id > 0 order by descripcion";
                        break;
                    case "observaciones":
                        query = "select id, descripcion from observaciones where id > 0 order by descripcion";
                        break;
                    case "intervalos":
                        if (condicion != "" && condicion != "0")
                            query = $@"select id, '(' || desde || ' a ' || hasta || ') ' || medida as descripcion from magnitud_intervalos 
                                        where estado = 1 and id > 0 and idmagnitud = {condicion} order by id";
                        else
                            query = "select id, desde || ' a ' || hasta || ' ' || medida as descripcion from magnitud_intervalos where estado = 1 and id > 0 order by id";
                        break;
                    case "medidas":
                        if (condicion != "")
                            query = $"select id, descripcion from medidas where id > 0 and estado = 1 and idmagnitud={condicion} order by descripcion";
                        else
                            query = "select id, descripcion from medidas where id > 0 and estado = 1 order by descripcion";
                        break;
                    case "contactos":
                        query = $"select id, nombre as descripcion from contactos_cliente where idcliente = {condicion} order by nombre";
                        break;
                    case "sedes":
                        if (condicion != "")
                            query = $"select id, nombre || ' ' || direccion as descripcion from sedes_cliente where idcliente = {condicion} order by nombre";
                        else
                            query = "select id, nombre || ' ' || direccion as descripcion from sedes_cliente order by nombre";
                        break;
                    case "tipo_indicacion":
                        query = $"select id, descripcion from tipo_indicacion where estado = 1 order by descripcion";
                        break;
                    case "tipo_servicio":
                        query = $"select id, descripcion from tipo_servicio where estado = 1 order by descripcion";
                        break;
                    case "pais":
                        query = "select id, descripcion from pais where id > 0 order by descripcion";
                        break;
                    case "departamento":
                        if (condicion != "")
                            query = $@"select id, descripcion from departamento where idpais = {condicion} and id > 0 order by descripcion";
                        else
                            query = "select id, descripcion from departamento where id > 0 order by descripcion";
                        break;
                    case "ciudad":
                        if (condicion != "")
                            query = $@"select id, descripcion from ciudad where iddepartamento = {condicion} and id > 0 order by descripcion";
                        else
                            query = "select id, descripcion from departamento where id > 0 order by descripcion";
                        break;
                    case "clientes":
                        query = "select id, nombrecompleto || ' (' || documento || ')' as descripcion from clientes where id > 0";
                        break;
                    case "formas_llegada":
                        query = "select id, descripcion from formas_llegada where id > 0 order by descripcion";
                            break;
                    case "metrologo":
                        query = "select id, nombrecompleto as descripcion from seguridad.rbac_usuarios where id > 0 and estado != 'INACTIVO'";
                        break;
                    case "tipo_acreditacion":
                        query = "select id, descripcion from tipo_acreditacion where id > 0";
                        break;
                    case "herramientas":
                        query = "select id, descripcion from herramientas where id > 0";
                        break;
                    default:
                        return null;
                }
                if (query != "")
                {
                    DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                    if (dataTable != null && dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show($"El combo para {tipo} no posee información en la base de datos");
                        return null;
                    }
                    else
                    {
                        return dataTable;
                    }
                } else
                {
                    MessageBox.Show($"No existe el tipo {tipo}");
                    return null;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los combos: {ex.Message}", "warning");
                return null;
            }
            
        }

        public async Task<bool> GuardarNuevoValor(string tabla, string texto, string id)
        {
            try
            {
                
                string busqueda = "";
                string insercion = "";

                // Determinar la tabla y el campo correspondiente según el tipo de combo
                switch (tabla)
                {
                    case "magnitudes":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "equipos":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion, idmagnitud) values('{texto}', 0)";
                        break;
                    case "ubicaciones":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "marcas":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "modelos":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}' and idmarca = {id}";
                        insercion = $"insert into {tabla} (descripcion, idmarca) values('{texto}', {id})";
                        break;
                    case "observaciones":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "accesorios":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "medidas":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}' and idmagnitud = {id}";
                        insercion = $"insert into {tabla} (descripcion, idmagnitud) values('{texto}', {id})";
                        break;
                    case "tipo_servicio":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "pais":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "departamento":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}' and idpais = {id} ";
                        insercion = $"insert into {tabla} (descripcion, idpais) values('{texto}', {id})";
                        break;
                    case "ciudad":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}' and iddepartamento = {id}";
                        insercion = $"insert into {tabla} (descripcion, iddepartamento) values('{texto}', {id})";
                        break;
                    case "formas_llegada":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    case "herramientas":
                        busqueda = $"select count(*) from {tabla} where descripcion = '{texto}'";
                        insercion = $"insert into {tabla} (descripcion) values('{texto}')";
                        break;
                    default:
                        MessageBox.Show($"El tipo de combo '{tabla}' no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                }
                object resultado = await dbHelper.ExecuteScalarAsync(busqueda);
                if (resultado != null && Convert.ToInt32(resultado) > 0)
                {
                    MessageBox.Show($"El valor '{texto}' ya existe en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                int filasAfectadas = dbHelper.ExecuteNonQuery(insercion);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Nuevo valor '{texto}' insertado en la tabla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"No se pudo insertar el valor '{texto}' en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el nuevo valor en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> GuardarIntervalos(string desde, string hasta, string medida, int idmagnitud)
        {
            try
            {

                string busqueda = "";
                string insercion = "";
                busqueda = $"select count(*) from magnitud_intervalos mi where idmagnitud = {idmagnitud} and desde = '{desde}' and hasta = '{hasta}' and medida = '{medida}' and estado = 1";
                insercion = $"insert into magnitud_intervalos(idmagnitud, desde, hasta, medida) values({idmagnitud}, '{desde}', '{hasta}', '{medida}')";

                // Determinar la tabla y el campo correspondiente según el tipo de combo
                object resultado = await dbHelper.ExecuteScalarAsync(busqueda);
                if (resultado != null && Convert.ToInt32(resultado) > 0)
                {
                    MessageBox.Show($"El valor '{desde}' a '{hasta}' {medida} ya existe en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                int filasAfectadas = dbHelper.ExecuteNonQuery(insercion);
                if (filasAfectadas > 0)
                {
                    MessageBox.Show($"Nuevo valor '{desde}' insertado en la tabla.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"No se pudo insertar el valor '{desde}' en la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el nuevo valor en la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
