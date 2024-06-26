using MIS.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Configuracion
{
    public class ClientesRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public ClientesRepository() 
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }

        public async Task<DataTable> BuscarClientesModal(string documento, string nombre)
        {
            try
            {
                string query = $@"select ROW_NUMBER() OVER () AS nro, c.id, c.documento as documento, c.nombrecompleto as nombrecompleto, c.direccion
                                    from clientes c 
                                where c.id > 0 ";
                DataTable dataTable = await dbHelper.ExecuteQueryAsync(query);
                if (dataTable.Rows.Count > 0)
                {
                    return dataTable;
                }
                else
                {
                    return null;
                }
                
            } catch (Exception ex)
            {
                MessageBox.Show("Error BuscarClientesModal(): " + ex.Message);
                return null;
            }
        }

        public async Task<bool> GuardarSedeModal(int idcliente, string nombre, string direccion, int ciudad, string contacto, string correo, string telefono, string copia)
        {
            try
            {
                string busqueda = $"select count(*) from sedes_cliente where idcliente = {idcliente} and (direccion = '{direccion}' or nombre = '{nombre}')";
                object encontrado = await dbHelper.ExecuteScalarAsync(busqueda);
                if (Convert.ToInt32(encontrado) > 0)
                {
                    MessageBox.Show("Ya existe una sede con la misma dirección o nombre de sede a este cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                string query = $@"insert into sedes_cliente
                            (idcliente, nombre, direccion, idciudad, contacto_factura, correo_factura, telefono_factura, copia_correo_factura)
                    values({idcliente}, '{nombre}', '{direccion}',{ciudad}, '{contacto}', '{correo}', '{telefono}', '{copia}')";
                if (dbHelper.ExecuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                } else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la sede: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<bool> GuardarContactosModal(int idcliente, int idsede, string nombre, string telefono, string correo, string cargo)
        {
            try
            {
                string busqueda = $"select count(*) from contactos_cliente where idcliente = {idcliente} and idsede = {idsede} and nombre = '{nombre}'";
                object encontrado = await dbHelper.ExecuteScalarAsync(busqueda);
                if (Convert.ToInt32(encontrado) > 0)
                {
                    MessageBox.Show("Ya existe este nombre de contacto a esta sede", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                string query = $@"insert into contactos_cliente
                            (idcliente, idsede, nombre, telefonos, correo, cargo)
                    values({idcliente}, {idsede}, '{nombre}', '{telefono}', '{correo}', '{cargo}')";
                if (dbHelper.ExecuteNonQuery(query) > 0)
                {
                    MessageBox.Show("Guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la sede: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
