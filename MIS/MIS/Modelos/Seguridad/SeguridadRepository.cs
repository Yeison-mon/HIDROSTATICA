using MIS.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Seguridad
{
    public class SeguridadRepository
    {
        private readonly PostgreSQLHelper dbHelper;
        public SeguridadRepository()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }
        public async Task<int> Guardar(int idusu, string nombre, string usuario, string cargo, string clave, string estado)
        {
            try
            {
                string consulta = $"SELECT id FROM seguridad.rbac_usuarios WHERE nomusu = '{usuario}'";
                object encontrado = await dbHelper.ExecuteScalarAsync(consulta);
                int id = encontrado != null ? Convert.ToInt32(encontrado) : 0;

                string insert = "";
                if (id > 0 && idusu == 0)
                {
                    MessageBox.Show("Realice la busqueda mediante consultar para mas seguridad");
                    return 0;
                }
                if (idusu == 0 && id == 0)
                {
                    insert= $@"INSERT INTO seguridad.rbac_usuarios(nomusu, clave, cargo, estado, nombrecompleto) 
                    VALUES ('{usuario}', '{EncryptPassword(clave)}', '{cargo}', '{estado}', '{nombre}') RETURNING id";
                }
                
                if (idusu > 0)
                {
                    insert = $@"UPDATE seguridad.rbac_usuarios SET nombrecompleto = '{nombre}', nomusu = '{usuario}', estado = '{estado}', cargo = '{cargo}',
                        clave = '{EncryptPassword(clave)}'
                        WHERE id = {idusu} RETURNING id";
                }

                object idUsu = await dbHelper.ExecuteScalarAsync(insert);
                int idUsuario = idUsu != null ? Convert.ToInt32(idUsu) : 0;

                if (idUsuario <= 0)
                {
                    MessageBox.Show("No se guardó el usuario (3025974171)", "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
                return idUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se realizo el guardado: " + ex.Message, "Guardar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public async Task<DataRow> Buscar(int id)
        {
            string query = $@"select nombrecompleto, nomusu, cargo, estado from seguridad.rbac_usuarios where id = {id}";
            DataTable dt = await dbHelper.ExecuteQueryAsync(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            return null;
        }
        public async Task<DataTable> Usuarios(string nombre, string usuario)
        {
            try
            {
                string where = "";
                if (nombre != "") { where = $"where nombrecompleto ilike '%{nombre}%'"; }
                if (usuario != "") { where = $"where nomusu ilike '%{usuario}%'"; }
                string query = $@"select id, nomusu, nombrecompleto, cargo, estado from seguridad.rbac_usuarios {where}";
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
        private string EncryptPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
