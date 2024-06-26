using MIS.Helpers;
using MIS.Modelos.Comercial;
using MIS.Vistas.Modales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Comercial
{
    public partial class FormCotizacion : Form
    {
        public FormCotizacion()
        {
            InitializeComponent();
            limpiar();
            cmsAdjuntos.Visible = false;
            btnAdjuntar.Click += (sender, e) =>
            {
                MouseEventArgs me = e as MouseEventArgs;
                Point localMousePosition = btnAdjuntar.PointToClient(Cursor.Position);
                cmsAdjuntos.Show(btnAdjuntar, localMousePosition);
                
            };
            tablaDetalle.CellMouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        tablaDetalle.ClearSelection();
                        tablaDetalle.Rows[e.RowIndex].Selected = true;
                        Point localMousePosition = tablaDetalle.PointToClient(Cursor.Position);
                        cmsDetalle.Show(tablaDetalle, localMousePosition);
                    }
                }
            };

        }
        private int idcliente = 0;
        private int cotizacion = 0;
        private int idcotizacion = 0;
        private int recepcion = 0;

        private void labelSede_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                MessageBox.Show("Debe de seleccionar el cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                using (FormSedes form = new FormSedes(idcliente, txtCliente.Text))
                {
                    form.SedeGuardada += async (eventSender, args) => await FG.CargarCombos(cbSedes, "sedes", $"{idcliente}", 0);
                    DialogResult result = form.ShowDialog();
                }
            }
        }

        private void labelContacto_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                MessageBox.Show("Debe de seleccionar el cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (cbContactos.DataSource == null || (int)cbContactos.SelectedValue == 0)
            {
                MessageBox.Show("Debe de seleccionar la sede del cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                using (FormContactos form = new FormContactos(idcliente, (int)cbContactos.SelectedValue, txtCliente.Text))
                {
                    form.ContactoGuardado += async (eventSender, args) => await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", 0);
                    DialogResult result = form.ShowDialog();
                }
            }
        }

        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void limpiar()
        {
            btnGuardar.Visible = false;
            btnAgregarItems.Visible = false;
            btnLimpiar.Visible = false;
            btnImprimir.Visible = false;
            btnAdjuntar.Visible = false;
            btnAprobar.Visible = false;
            idcliente = 0;
            cotizacion = 0;
            idcotizacion = 0;
            recepcion = 0;
            txtDocumento.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtAnio.Text = DateTime.Now.Year.ToString();
            txtEstado.Text = "Temporal";
            tablaDetalle.DataSource = null;
            tablaDetalle.Rows.Clear();
            cbContactos.DataSource = null;
            cbContactos.Items.Clear();
            cbSedes.DataSource = null;
            cbSedes.Items.Clear();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente form = new FormBuscarCliente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    limpiar();
                    idcliente = form.idcliente;
                    BuscarCliente(idcliente, "", 0, 0);
                }
            }
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            using (FormRecepciones form = new FormRecepciones(idcliente, "Cotizacion"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    recepcion = form.recepcion;
                    int id = form.idrecepcion;
                    if (idcliente == 0)
                    {
                        BuscarCliente(form.idcliente, "", 0, 0);
                    }
                    ImportarRecepcion(id);
                }
            }
        }
        private async void BuscarCliente(int id, string documento, int idsede, int idcontacto)
        {
            CotizacionRepository cliente = new CotizacionRepository();
            DataTable tabla = await cliente.BuscarCliente(id, documento);
            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    txtDocumento.Text = tabla.Rows[0]["documento"].ToString();
                    txtCliente.Text = tabla.Rows[0]["nombrecompleto"].ToString();
                    idcliente = (int)tabla.Rows[0]["id"];
                    btnAgregarItems.Enabled = true;
                    await FG.CargarCombos(cbSedes, "sedes", $"{idcliente}", idsede);
                    await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", idcontacto);
                    btnLimpiar.Visible = true;
                    await TablaDetalle();
                }
            }
        }
        private async void ImportarRecepcion(int id) 
        {
            CotizacionRepository importar = new CotizacionRepository();
            bool importado = await importar.ImportarRecepcion(id, idcotizacion);
            if (importado)
            {
                MessageBox.Show("Importado con éxito");
                await TablaDetalle();
            }
        }

        private async Task TablaDetalle()
        {
            CotizacionRepository detalle = new CotizacionRepository();
            DataTable tabla = await detalle.Detalle(idcliente, cotizacion);
            if (tabla != null && tabla.Rows.Count > 0)
            {
                tablaDetalle.Rows.Clear();
                tablaDetalle.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                tablaDetalle.Columns["ColumnDescripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns["ColumnInspeccion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns["ColumnCantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tablaDetalle.Columns["ColumnPrecio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tablaDetalle.Columns["ColumnDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tablaDetalle.Columns["ColumnIva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tablaDetalle.Columns["ColumnPrecio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                int numeroFila = 1;
                foreach (DataRow row in tabla.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string ingreso = row["ingreso"].ToString();
                    string descripcion = row["descripcion"].ToString();
                    string inspeccion = row["inspeccion"].ToString();
                    string moneda = row["moneda"].ToString();
                    int cantidad = Convert.ToInt32(row["cantidad"]);
                    decimal precio = Convert.ToDecimal(row["precio"]);
                    int descuento = Convert.ToInt32(row["descuento"]);
                    int iva = Convert.ToInt32(row["iva"]);
                    decimal subtotal = (precio * cantidad) - (precio * cantidad * descuento / 100);

                    tablaDetalle.Rows.Add(id, numeroFila, ingreso, descripcion, inspeccion, "", moneda, cantidad, precio, descuento, iva, subtotal);
                    numeroFila++;
                }
                btnGuardar.Visible = true;
            }
        }


        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Trim().Length == 0)
            {
                idcliente = 0;
                cotizacion = 0;
                idcotizacion = 0;
                limpiar();
            }

                
        }

        private void txtCotizacion_TextChanged(object sender, EventArgs e)
        {
            if (txtCotizacion.Text.Trim().Length == 0)
            {
                idcliente = 0;
                cotizacion = 0;
                idcotizacion = 0;
                limpiar();
            }
        }

       
        private async void Buscar(int cotizacion, string anio)
        {
            CotizacionRepository buscar = new CotizacionRepository();
            DataTable tabla = await buscar.Buscar(cotizacion, anio);
            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    this.cotizacion = Convert.ToInt32(tabla.Rows[0]["cotizacion"]);
                    idcotizacion = Convert.ToInt32(tabla.Rows[0]["id"]);
                    idcliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                    txtAnio.Text = tabla.Rows[0]["anio"].ToString();
                    txtEstado.Text = tabla.Rows[0]["estado"].ToString();
                    int idsede = Convert.ToInt32(tabla.Rows[0]["idsede"]);
                    int idcontacto= Convert.ToInt32(tabla.Rows[0]["idcontacto"]);
                    BuscarCliente(idcliente, "", idsede, idcontacto);
                    btnImprimir.Visible = true;
                    btnAdjuntar.Visible = true;
                    btnAprobar.Visible = true;
                }
            }
        }

        private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && txtDocumento.Text.Length > 0)
            {
                BuscarCliente(0, txtDocumento.Text, 0, 0);
                e.SuppressKeyPress = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            List<int> ids = new List<int>();
            int idsede = 0;
            int idcontacto = 0;
            if (cbSedes.SelectedValue != null)
                idsede = (int)cbSedes.SelectedValue;
            else
                MessageBox.Show("Debe agregar una sede al cliente");
            if (cbContactos.SelectedValue != null)
                idcontacto = (int)cbContactos.SelectedValue;
            else
                MessageBox.Show("Debe agregar un contacto al cliente");
            foreach (DataGridViewRow row in tablaDetalle.Rows)
            {
                int id = Convert.ToInt32(row.Cells["ColumnId"].Value);
                ids.Add(id);
            }
            CotizacionRepository guardar = new CotizacionRepository();
            int cotizacion = await guardar.Guardar(ids, idcliente, idsede, idcontacto, this.cotizacion, "");
            if (cotizacion > 0)
            {
                Buscar(cotizacion, txtAnio.Text);
                txtCotizacion.Text = cotizacion.ToString();
                btnAdjuntar.Visible = true;
                btnAprobar.Visible = true;
                btnImprimir.Visible = true;
            }
            
        }

        private void txtCotizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab) && txtCotizacion.Text.Length > 0)
            {
                Buscar(int.Parse(txtCotizacion.Text), txtAnio.Text);
                e.SuppressKeyPress = true;
            }
            
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            using (FormAprobarCotizacion form = new FormAprobarCotizacion(idcotizacion))
            {
                DialogResult result = form.ShowDialog();
                Buscar(cotizacion, txtAnio.Text);
            }
        }

        private async void AdjuntarCotizacion_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF|*.pdf";
            openFileDialog.Title = "Seleccionar archivo PDF";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string base64String = FG.FileToBase64(filePath);
                    CotizacionRepository adjuntar = new CotizacionRepository();
                    await adjuntar.AdjuntarArchivo(idcotizacion, base64String, "COTIZACION ADJUNTO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void AdjuntarAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos PDF|*.pdf";
            openFileDialog.Title = "Seleccionar archivo PDF";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    string base64String = FG.FileToBase64(filePath);
                    CotizacionRepository adjuntar = new CotizacionRepository();
                    await adjuntar.AdjuntarArchivo(idcotizacion, base64String, "COTIZACION ANEXO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void VerCotizacionAdj_Click(object sender, EventArgs e)
        {
            
            string tipo = "COTIZACION ADJUNTO";

            CotizacionRepository adjunto = new CotizacionRepository();
            var (tipoArchivo, base64) = await adjunto.VerAdjunto(idcotizacion, tipo);

            if (!string.IsNullOrEmpty(base64))
            {
                byte[] fileBytes = Convert.FromBase64String(base64);

                // Guardar el archivo temporalmente
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.pdf");
                File.WriteAllBytes(tempFilePath, fileBytes);

                // Abrir el archivo con el visor de PDF predeterminado del sistema
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = tempFilePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se encontró el adjunto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void VerAnexoAdj_Click(object sender, EventArgs e)
        {
            string tipo = "COTIZACION ANEXO";

            CotizacionRepository adjunto = new CotizacionRepository();
            var (tipoArchivo, base64) = await adjunto.VerAdjunto(idcotizacion, tipo);

            if (!string.IsNullOrEmpty(base64))
            {
                byte[] fileBytes = Convert.FromBase64String(base64);
                string tempFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.pdf");
                File.WriteAllBytes(tempFilePath, fileBytes);
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = tempFilePath,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se encontró el adjunto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void asignarAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar archivo anexo";
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                MessageBox.Show("Archivo seleccionado: " + rutaArchivo);
            }
        }
    }
}
