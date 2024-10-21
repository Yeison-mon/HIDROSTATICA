using MIS.Modelos;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using MsBox.Avalonia.Dto;
using MsBox.Avalonia.Enums;
using MsBox.Avalonia;

namespace MIS.Helpers
{
    public static class FG
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static string Cargo { get; set; }
        public static string Ip { get; set; }
        public static string Mac { get; set; }
        public static string Url { get; set; }

        public static async Task CargarCombos(ComboBox comboBox, string tipo, string condicion, int seleccionado)
        {
            CombosRepository combos = new CombosRepository();
            DataTable data = await combos.CargarCombos(tipo, condicion);
            if (data != null)
            {

                DataRow newRow = data.NewRow();
                newRow["id"] = 0;
                newRow["descripcion"] = "--SELECCIONE--";
                data.Rows.InsertAt(newRow, 0);
                comboBox.DisplayMember = "descripcion";
                comboBox.ValueMember = "id";
                comboBox.DataSource = data;
                if (seleccionado > 0)
                {
                    comboBox.SelectedValue = seleccionado;
                }
            }
        }

        public static string ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                if (image != null)
                {
                    image.Save(ms, format);
                    byte[] imageBytes = ms.ToArray();
                    return Convert.ToBase64String(imageBytes);
                }else
                {
                    return string.Empty;
                }
                
            }
        }

        public static string FileToBase64(string filePath)
        {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            return Convert.ToBase64String(fileBytes);
        }

        public static void ShowMsg(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowAlert(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
