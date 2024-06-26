using MIS.Helpers;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Modelos.Seguridad
{
    public class InicioSesion
    {
        private readonly PostgreSQLHelper dbHelper;

        public InicioSesion()
        {
            dbHelper = PostgreSQLHelper.GetInstance();
        }

        public async Task<DataTable> ValidateUserAsync(string username, string password, string ip, string mac)
        {
            string encryptedPassword = EncryptPassword(password);
            string query = $"SELECT id, nombrecompleto, nomusu, clave, ip, mac FROM seguridad.rbac_usuarios WHERE nomusu = '{username}' AND clave = '{encryptedPassword}'";
            DataTable result = await dbHelper.ExecuteQueryAsync(query);
            if (result != null)
            {
                if (result.Rows.Count > 0)
                {
                    // Si se encontró una fila, obtén los valores de nomusu y clave de la primera fila
                    string nomusu = result.Rows[0]["nomusu"].ToString();
                    string clave = result.Rows[0]["clave"].ToString();
                    if (nomusu == username && encryptedPassword == clave)
                    {
                        if (ip != result.Rows[0]["ip"].ToString() && result.Rows[0]["ip"].ToString() != "") 
                        {
                            MessageBox.Show("Ya posee una sesión activa en: " + result.Rows[0]["ip"].ToString());
                            return null;
                        }
                        await dbHelper.ExecuteQueryAsync($"update seguridad.rbac_usuarios set mac='{mac}', ip='{ip}' where id={result.Rows[0]["id"]}");
                        return result;
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y contraseña incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            } else { return null; }
            
        }

        public bool CerrarSesion()
        {
            int cerrar = dbHelper.ExecuteNonQuery($"update seguridad.rbac_usuarios set ip='', mac='' where id = {FG.UserId}");
            if (cerrar > 0)
            {
                FG.Mac = "";
                FG.Ip = "";
                FG.UserId = 0;
                FG.UserName = "";
                return true;
            } else
            {
                return false;
            }
        }

        private string EncryptPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                // Convierte la contraseña en una matriz de bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);

                // Calcula el hash MD5 de la contraseña
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convierte el hash en una cadena hexadecimal
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
