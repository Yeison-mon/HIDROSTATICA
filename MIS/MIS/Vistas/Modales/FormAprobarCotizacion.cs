using System;
using System.Buffers.Text;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MIS.Helpers;
using MIS.Modelos.Comercial;
using PdfiumViewer;

namespace MIS.Vistas.Modales
{
    public partial class FormAprobarCotizacion : Form
    {

        private int idcotizacion = 0;
        private string pdfBase64;
        private string tempFilePath;
        public FormAprobarCotizacion(int idcotizacion)
        {
            this.idcotizacion = idcotizacion;
            InitializeComponent();
            this.KeyPreview = true;
            cbOpciones.SelectedIndex = 0;
            Buscar();

        }

        private void FormAprobarCotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (tcGeneral.SelectedTab == tpCorreo)
            {
                if (e.Control && e.KeyCode == Keys.V)
                {
                    if (Clipboard.ContainsImage())
                    {
                        Image clipboardImage = Clipboard.GetImage();
                        pbCapturaCorreo.Image = clipboardImage;
                    }
                    e.Handled = true;
                }
            }
        }

        private void tcGeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcGeneral.SelectedTab == tpDocumento || tcGeneral.SelectedTab == tpCorreo)
            {
                if(tcGeneral.SelectedTab == tpDocumento)
                {
                    pbCapturaCorreo.Image = null;
                    txtTelefono.Text = "";
                    txtConversacion.Text = "";
                } else if (tcGeneral.SelectedTab == tpCorreo)
                {
                    txtTelefono.Text = "";
                    txtConversacion.Text = "";
                }
                btnAdjuntar.Visible = true;
            }
            else
            {
                pdfvDocumento.Refresh();
                btnAdjuntar.Visible = false;
                pdfvDocumento.Document = null;
                pbCapturaCorreo.Image = null;
            }
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            if (tcGeneral.SelectedTab == tpDocumento)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Seleccione un documento PDF para cargar"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pdfBase64 = FG.FileToBase64(filePath);
                    LoadPdfInViewer(filePath);
                }
            }
        }

        private void LoadPdfInViewer(string filePath)
        {
            try
            {
                pdfvDocumento.Document?.Dispose(); // Asegúrate de liberar cualquier documento previo
                pdfvDocumento.Document = PdfDocument.Load(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el documento PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReleasePdfDocument()
        {

            if (pdfvDocumento.Document != null)
            {
                pdfvDocumento.Document.Dispose();
                pdfvDocumento.Document = null;
            }

            if (!string.IsNullOrEmpty(tempFilePath) && File.Exists(tempFilePath))
            {
                try
                {
                    File.Delete(tempFilePath);
                    tempFilePath = null;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error al eliminar el archivo temporal: " + ex.Message);
                }
            }
        }

        private async void Buscar()
        {
            CotizacionRepository buscar = new CotizacionRepository();
            DataTable tabla = await buscar.BuscarAprobacion(idcotizacion);
            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    int tipo = (int)tabla.Rows[0]["tipo"];
                    string base64 = tabla.Rows[0]["base64"].ToString();
                    switch (tipo)
                    {
                        case 1:
                            tcGeneral.SelectedTab = tpDocumento;
                            if (base64 != "")
                            {
                                byte[] bytes = Convert.FromBase64String(base64);
                                tempFilePath = Path.GetTempFileName(); // Asigna a la variable de clase
                                File.WriteAllBytes(tempFilePath, bytes);
                                LoadPdfInViewer(tempFilePath);
                            }
                            else
                            {
                                MessageBox.Show("Documento no encontrado");
                            }

                            break;
                        case 2:
                            tcGeneral.SelectedTab = tpCorreo;
                            if (base64 != "")
                            {
                                byte[] imagenBytes = Convert.FromBase64String(base64);
                                pbCapturaCorreo.Image = Image.FromStream(new MemoryStream(imagenBytes));
                            } else
                            {
                                MessageBox.Show("Imagen no encontrada");
                            }
                            break;
                        case 3:
                            tcGeneral.SelectedTab = tpOtros;
                            break;
                    }
                    txtContacto.Text = tabla.Rows[0]["contacto"].ToString();
                    txtDocumento.Text = tabla.Rows[0]["cedula"].ToString();
                    txtCargo.Text = tabla.Rows[0]["cargo"].ToString();
                    cbOpciones.SelectedIndex = (int)tabla.Rows[0]["estado"];
                    string tiempoString = tabla.Rows[0]["tiempo"].ToString();
                    DateTime fechaHora;

                    if (DateTime.TryParseExact(tiempoString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaHora))
                    {
                        dtpFecha.Value = fechaHora.Date;
                        dtpHora.Text = fechaHora.ToShortTimeString();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo convertir la cadena a DateTime");
                    }
                    txtConversacion.Text = tabla.Rows[0]["conversacion"].ToString();
                    txtTelefono.Text = tabla.Rows[0]["telefono"].ToString();

                }
            }
        }

        private async void btnAccion_Click(object sender, EventArgs e)
        {
            
            string contacto = txtContacto.Text;
            string documento = txtDocumento.Text;
            string cargo = txtCargo.Text;
            int estado = cbOpciones.SelectedIndex;
            int opcion = 0;
            if(estado == -1 || estado == 0) 
            {
                MessageBox.Show("Seleccione un una opción");
                cbOpciones.Focus();
                return;
            }
            string conversacion = string.Empty;
            string telefono = string.Empty;
            string base64 = string.Empty;
            string tiempo = string.Empty;
            DateTime fecha = dtpFecha.Value.Date;
            DateTime hora = dtpHora.Value;
            DateTime fechaYHoraSeleccionada = fecha.AddHours(hora.Hour).AddMinutes(hora.Minute);
            DateTime fechaYHoraActual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);
            DateTime fechaYHoraGuardar = fecha.AddHours(hora.Hour).AddMinutes(hora.Minute);
            if (estado == 1)
            {
                if (fechaYHoraSeleccionada < fechaYHoraActual)
                {
                    MessageBox.Show("La fecha y hora seleccionadas no pueden ser menores a la fecha y hora actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tiempo = fechaYHoraGuardar.ToString("yyyy-MM-dd HH:mm:ss");
                if (tcGeneral.SelectedTab == tpDocumento)
                {
                    if (pdfBase64 != "" || pdfBase64 != string.Empty)
                    {
                        opcion = 1;
                        base64 = pdfBase64;
                        conversacion = string.Empty;
                        telefono = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se ha cargado ninguna documento pdf");
                        return;
                    }

                }
                else if (tcGeneral.SelectedTab == tpCorreo)
                {
                    if (pbCapturaCorreo.Image != null)
                    {
                        opcion = 2;
                        base64 = FG.ImageToBase64(pbCapturaCorreo.Image, ImageFormat.Jpeg);
                        conversacion = string.Empty;
                        telefono = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se ha cargado ninguna imagen");
                        return;
                    }

                }
                if (tcGeneral.SelectedTab == tpOtros)
                {
                    opcion = 3;
                    base64 = string.Empty;
                    conversacion = txtConversacion.Text;
                    telefono = txtTelefono.Text;
                }
            }
            
            CotizacionRepository aprobar = new CotizacionRepository();
            bool aprobado = await aprobar.Aprobar(idcotizacion, opcion, estado, base64, tiempo, contacto, documento, cargo, telefono, conversacion);
            if (aprobado)
            {
                MessageBox.Show("Cotización: " + (estado == 1 ? "Aprobada" : "En Revisión"));
                this.Close();
            } else
            {
                this.Close();
            }

            
        }

        private void FormAprobarCotizacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReleasePdfDocument();
        }
    }
}
