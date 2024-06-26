using System.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MIS.Helpers;
using MIS.Modelos.Registros;
using MIS.Modelos.Registros.Modales;
using MIS.Vistas.Modales;
using bpac;
using System.IO;
using MIS.Modelos;

namespace MIS.Vistas.Recepcion
{
    public partial class FormRecepcion : Form
    {
        public FormRecepcion()
        {
            InitializeComponent();
            txtEstado.Enabled = false;
            txtCliente.ReadOnly = true;
            txtEstado.ReadOnly = true;
            btnAgregarIngreso.Enabled = false;
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            btnCamara.Visible = false;
            btnLimpiar.Visible = false;
            btnBorrar.Visible = false;
            btnDuplicar.Visible = false;
            btnEtiqueta.Visible = false;
            btnRechazar.Visible = false;

            cmsTabla.Visible = false;
            txtAnio.Text = DateTime.Now.Year.ToString();
            txtEstado.Text = "Temporal";
            tablaIngresos.CellMouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        tablaIngresos.ClearSelection();
                        tablaIngresos.Rows[e.RowIndex].Selected = true;
                        Point localMousePosition = tablaIngresos.PointToClient(Cursor.Position);
                        cmsTabla.Show(tablaIngresos, localMousePosition);
                    }
                }
            };
            tablaRecepciones.CellMouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        tablaRecepciones.ClearSelection();
                        tablaRecepciones.Rows[e.RowIndex].Selected = true;
                        Point localMousePosition = tablaRecepciones.PointToClient(Cursor.Position);
                        cmsTablaConsultar.Show(tablaRecepciones, localMousePosition);
                    }
                }
            };
            DatosConsulta();
        }
        #region Crear Recepcion
        private int nro_recepcion = 0;
        private int idcliente { get; set; }
        private int idrecepcion { get; set; }
        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Verificar si el texto es un número válido
                int recepcion;
                if (int.TryParse(txtNro.Text, out recepcion))
                {
                    BuscarRecepcion(recepcion);
                }
                else
                {
                    txtNro.Text = "";
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                MessageBox.Show("Debe seleccionar el cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                int idmagnitudprincipal = 0;
                if (tablaIngresos.Rows.Count > 0)
                {
                    DataGridViewRow firstRow = tablaIngresos.Rows[0];
                    idmagnitudprincipal = Convert.ToInt32(firstRow.Cells["idmagnitud"].Value);
                }

                using (FormAgregarIngresos form = new FormAgregarIngresos(idcliente, idrecepcion, 0, idmagnitudprincipal))
                {
                    form.IngresoAgregado += (eventSender, args) => BuscarIngresos(idcliente, nro_recepcion);
                    DialogResult result = form.ShowDialog();
                    BuscarIngresos(idcliente, nro_recepcion);
                }
            }
        }
        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarCliente form = new FormBuscarCliente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    idcliente = form.idcliente;

                    BuscarCliente(idcliente, "", 0, 0);
                    limpiar();
                }
            }

        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            int idsede = 0;
            int idcontacto = 0;
            int forma_llegada = 0;
            DateTime fecha = dtFechaRecepcion.Value.Date;
            string fechaguardar = fecha.ToString("yyyy-MM-dd HH:mm:ss");
            if (cbFormasLlegada.DataSource != null && (int)cbFormasLlegada.SelectedValue > 0)
            {
                forma_llegada = (int)cbFormasLlegada.SelectedValue;
            }
            else
            {
                MessageBox.Show("Debe seleccionar la forma de llegada");
                cbFormasLlegada.Focus();

                return;
            }
            if (cbSedes.SelectedValue != null)
            {
                idsede = (int)cbSedes.SelectedValue;
            } else
            {
                MessageBox.Show("Debe agregar una sede al cliente");
            }
            if (cbContactos.SelectedValue != null)
            {
                idcontacto = (int)cbContactos.SelectedValue;
            } else
            {
                MessageBox.Show("Debe agregar un contacto al cliente");
            }
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in tablaIngresos.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                ids.Add(id);
            }
            RecepcionRepository guardar = new RecepcionRepository();
            int recepcion = await guardar.GuardarRecepcion(ids, idcliente, idsede, idcontacto, nro_recepcion, txtObservacion.Text, forma_llegada, fechaguardar);
            if (recepcion > 0)
            {
                nro_recepcion = recepcion;
                txtNro.Text = recepcion.ToString();
                txtEstado.Text = "Ingresado";
                BuscarIngresos(idcliente, recepcion);
                MessageBox.Show("Guardado con exito", "exito");
                ImprimirRecepcion();
            }
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab) && txtDocumento.Text.Length > 0)
            {
                BuscarCliente(0, txtDocumento.Text, 0, 0);
            }
        }
        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            if (txtDocumento.Text.Trim().Length == 0)
                limpiar();

        }
        private void tablaIngresos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                btnBorrar_Click(sender, e);
            }
        }
        private void tablaIngresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaIngresos.CurrentRow != null)
            {
                DataGridViewRow selectedRow = tablaIngresos.CurrentRow;
                int idingreso = Convert.ToInt32(selectedRow.Cells["id"].Value);
                DataGridViewRow firstRow = tablaIngresos.Rows[0];
                int idmagnitudprincipal = Convert.ToInt32(firstRow.Cells["idmagnitud"].Value);
                using (FormAgregarIngresos form = new FormAgregarIngresos(idcliente, idrecepcion, idingreso, idmagnitudprincipal))
                {
                    form.IngresoAgregado += (eventSender, args) => BuscarIngresos(idcliente, nro_recepcion);
                    DialogResult result = form.ShowDialog();
                    BuscarIngresos(idcliente, nro_recepcion);
                }

            }
        }
        private async void BorrarIngreso()
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                if (txtEstado.Text == "Temporal" || txtEstado.Text == "Ingresado" || FG.UserId == 1)
                {
                    List<int> ids = new List<int>();
                    List<string> ingresos = new List<string>();
                    foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                    {
                        if (row.Cells["estado"].ToString() != "Anulado")
                        {
                            string ingreso = row.Cells["ingreso"].Value.ToString();
                            ingresos.Add(ingreso);
                            int id = Convert.ToInt32(row.Cells["id"].Value);
                            ids.Add(id);
                        } else
                        {
                            MessageBox.Show("Ingresos anulados no se pueden eliminar");
                        }

                    }
                    string ingresosText = string.Join(", ", ingresos);
                    DialogResult result = MessageBox.Show($"¿Desea borrar los ingresos: {ingresosText}?", "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RecepcionRepository borrar = new RecepcionRepository();
                        bool resultado = await borrar.BorrarIngreso(ids);
                        if (resultado)
                        {
                            BuscarIngresos(idcliente, nro_recepcion);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pueden borrar ingresos de una recepción en estado: " + txtEstado.Text, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BorrarIngreso();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirRecepcion();
        }
        private void ImprimirRecepcion()
        {
            int numeroRecepcion = nro_recepcion;
            string tipo = "Recepcion";
            if (numeroRecepcion > 0)
            {
                FormReportes reportes = new FormReportes(nro_recepcion, tipo);
                reportes.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha cargado el número de documento");
            }
        }
        private void limpiar()
        {
            btnAgregarIngreso.Enabled = false;
            txtAnio.Text = DateTime.Now.Year.ToString();
            txtEstado.Text = "Temporal";
            txtDocumento.Text = string.Empty;
            txtCliente.Text = string.Empty;
            cbSedes.DataSource = null;
            cbSedes.Items.Clear();
            cbContactos.DataSource = null;
            cbContactos.Items.Clear();
            cbFormasLlegada.DataSource = null;
            cbFormasLlegada.Items.Clear();
            txtObservacion.Text = string.Empty;
            tablaIngresos.DataSource = null;
            tablaIngresos.Rows.Clear();
            tablaIngresos.Columns.Clear();
            txtNro.Text = string.Empty;
            dtFechaRecepcion.Value = DateTime.Now;
            idrecepcion = 0;
            nro_recepcion = 0;
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            btnEtiqueta.Visible = false;
            btnBorrar.Visible = false;
            btnDuplicar.Visible = false;
            btnCamara.Visible = false;
            btnLimpiar.Visible = false;
            btnRechazar.Visible = false;
        }
        private async void BuscarIngresos(int idcliente, int nro)
        {
            tablaIngresos.DataSource = null;
            tablaIngresos.Rows.Clear();
            tablaIngresos.Columns.Clear();
            RecepcionRepository ingresos = new RecepcionRepository();
            DataTable tabla = await ingresos.TablaIngresosAsync(idcliente, nro, txtAnio.Text);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                tablaIngresos.DataSource = tabla;
                btnGuardar.Visible = true;
                btnImprimir.Visible = true;
                btnEtiqueta.Visible = true;
                btnBorrar.Visible = true;
                btnDuplicar.Visible = true;
                btnCamara.Visible = true;
                btnLimpiar.Visible = true;
                btnRechazar.Visible = true;
                tablaIngresos.CurrentCell = null;
                tablaIngresos.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                tablaIngresos.Columns["id"].Visible = false;
                tablaIngresos.Columns["con_serie"].Visible = false;
                tablaIngresos.Columns["idmagnitud"].Visible = false;
                tablaIngresos.Columns["codigo"].Visible = false;
                tablaIngresos.Columns["etiqueta"].Visible = false;
                tablaIngresos.Columns["renglon"].HeaderText = "Renglon";
                tablaIngresos.Columns["ingreso"].HeaderText = "Ingreso Unico";
                tablaIngresos.Columns["descripcion"].HeaderText = "Descripcion";
                tablaIngresos.Columns["magnitud"].HeaderText = "Magnitud";
                tablaIngresos.Columns["serie"].HeaderText = "Serie / Codigo";
                tablaIngresos.Columns["marca"].HeaderText = "Marca";
                tablaIngresos.Columns["modelo"].HeaderText = "Modelo";
                tablaIngresos.Columns["estado"].HeaderText = "Estado";
                tablaIngresos.Columns["fechaingreso"].HeaderText = "Fecha de Ingreso";
                tablaIngresos.Columns["observacion"].HeaderText = "Observacion / Accesorios";
                tablaIngresos.Columns["observacion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.AllowUserToOrderColumns = false;
            }
        }
        private async void BuscarCliente(int id, string documento, int idsede, int idcontacto)
        {
            RecepcionRepository cliente = new RecepcionRepository();
            DataTable tabla = await cliente.BuscarCliente(id, documento);
            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    txtDocumento.Text = tabla.Rows[0]["documento"].ToString();
                    txtCliente.Text = tabla.Rows[0]["nombrecompleto"].ToString();
                    idcliente = (int)tabla.Rows[0]["id"];
                    btnAgregarIngreso.Enabled = true;
                    BuscarIngresos(idcliente, nro_recepcion);
                    await FG.CargarCombos(cbSedes, "sedes", $"{idcliente}", idsede);
                    await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", idcontacto);
                    if (cbFormasLlegada.DataSource == null)
                    {
                        await FG.CargarCombos(cbFormasLlegada, "formas_llegada", "", 0);
                    }

                }
            }
        }
        private async void BuscarRecepcion(int recepcion)
        {
            RecepcionRepository buscar = new RecepcionRepository();
            DataTable dataTable = await buscar.BuscarRecepcion(recepcion, txtAnio.Text);
            nro_recepcion = Convert.ToInt32(txtNro.Text);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                int cliente = (int)dataTable.Rows[0]["idcliente"];
                int idSede = (int)dataTable.Rows[0]["idsede"];
                idrecepcion = (int)dataTable.Rows[0]["id"];
                int idContacto = (int)dataTable.Rows[0]["idcontacto"];
                txtObservacion.Text = dataTable.Rows[0]["observacion"].ToString();
                await FG.CargarCombos(cbFormasLlegada, "formas_llegada", "", (int)dataTable.Rows[0]["idforma_llegada"]);
                string fechaRecepcionString = dataTable.Rows[0]["fecha"].ToString();
                DateTimeOffset fechaRecepcionOffset = DateTimeOffset.Parse(fechaRecepcionString);
                DateTime fechaRecepcionLocal = fechaRecepcionOffset.ToLocalTime().DateTime;
                dtFechaRecepcion.Value = fechaRecepcionLocal;


                dtFechaRecepcion.Value = fechaRecepcionLocal;
                txtEstado.Text = dataTable.Rows[0]["estado"].ToString();
                BuscarCliente(cliente, "", idSede, idContacto);
            }
            else
            {
                MessageBox.Show($"Recepción Nro NR-{txtAnio.Text}-{txtNro.Text} no esta registrada");
                txtNro.Text = "";
            }

        }
        private async void labelFormasLlegada_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string texto = form.TextoIngresado;
                    CombosRepository agregar = new CombosRepository();
                    if (await agregar.GuardarNuevoValor("formas_llegada", texto, ""))
                    {
                        await FG.CargarCombos(cbFormasLlegada, "formas_llegada", "", 0);
                    }

                }
            }
        }
        private void DuplicarIngreso()
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(tablaIngresos.SelectedRows[0].Cells["id"].Value);
                using (FormDuplicar form = new FormDuplicar("INGRESOS", id))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        BuscarIngresos(idcliente, nro_recepcion);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso");
            }
        }
        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            DuplicarIngreso();
        }
        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaIngresos.SelectedRows.Count > 0)
                {
                    string path = @"\\Server\metrogestion\008 SOFTWARE\ETIQUETAS\INGRESOS.lbx";
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var doc = new bpac.Document();
                    if (doc.Open(path) != false)
                    {
                        bool success = false;
                        success = doc.SetPrinter(@"\\RECEPCION\Brother QL-800", true);

                        foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                        {
                            doc.GetObject("NUMERO").Text = row.Cells["etiqueta"].Value.ToString();
                            if (!success)
                            {
                                MessageBox.Show("No se pudo establecer la impresora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                doc.Close();
                                return;
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                doc.StartPrint("", PrintOptionConstants.bpoHighResolution);
                                doc.PrintOut(1, PrintOptionConstants.bpoHighResolution);
                                doc.EndPrint();
                            }

                        }
                        doc.Close();
                        MessageBox.Show("Etiqueta(s) impresa(s)");
                    }
                    else
                    {
                        MessageBox.Show("Error al abrir el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar uno o más ingresos");
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void codigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaIngresos.SelectedRows.Count > 0)
                {
                    string path = @"\\Server\metrogestion\008 SOFTWARE\ETIQUETAS\SERIE.lbx";
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var doc = new bpac.Document();
                    if (doc.Open(path) != false)
                    {
                        bool success = false;
                        success = doc.SetPrinter(@"\\RECEPCION\Brother QL-800", true);

                        foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                        {
                            doc.GetObject("SERIE").Text = row.Cells["codigo"].Value.ToString();
                            if (!success)
                            {
                                MessageBox.Show("No se pudo establecer la impresora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                doc.Close();
                                return;
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                doc.StartPrint("", PrintOptionConstants.bpoHighResolution);
                                doc.PrintOut(1, PrintOptionConstants.bpoHighResolution);
                                doc.EndPrint();
                            }

                        }
                        doc.Close();
                        MessageBox.Show("Etiqueta(s) impresa(s)");
                    }
                    else
                    {
                        MessageBox.Show("Error al abrir el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar uno o más ingresos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void serieClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaIngresos.SelectedRows.Count > 0)
                {
                    string path = @"\\Server\metrogestion\008 SOFTWARE\ETIQUETAS\SERIE.lbx";
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var doc = new bpac.Document();
                    if (doc.Open(path) != false)
                    {
                        bool success = false;
                        success = doc.SetPrinter(@"\\RECEPCION\Brother QL-800", true);

                        foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                        {
                            doc.GetObject("SERIE").Text = row.Cells["serie"].Value.ToString();
                            if (!success)
                            {
                                MessageBox.Show("No se pudo establecer la impresora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                doc.Close();
                                return;
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                doc.StartPrint("", PrintOptionConstants.bpoHighResolution);
                                doc.PrintOut(1, PrintOptionConstants.bpoHighResolution);
                                doc.EndPrint();
                            }

                        }
                        doc.Close();
                        MessageBox.Show("Etiqueta(s) impresa(s)");
                    }
                    else
                    {
                        MessageBox.Show("Error al abrir el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar uno o más ingresos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtNro_TextChanged(object sender, EventArgs e)
        {
            if (txtNro.Text.Trim().Length == 0)
                limpiar();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void ModalCamara()
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                int id = (int)tablaIngresos.SelectedRows[0].Cells["id"].Value;
                string ingreso = tablaIngresos.SelectedRows[0].Cells["ingreso"].Value.ToString();
                using (Camara form = new Camara(id, ingreso, "INGRESO"))
                {
                    DialogResult result = form.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso");
            }
        }
        private void btnCamara_Click(object sender, EventArgs e)
        {
            ModalCamara();
        }
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
            } else if (cbSedes.DataSource == null || (int)cbSedes.SelectedValue == 0)
            {
                MessageBox.Show("Debe de seleccionar la sede del cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                using (FormContactos form = new FormContactos(idcliente, (int)cbSedes.SelectedValue, txtCliente.Text))
                {
                    form.ContactoGuardado += async (eventSender, args) => await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", 0);
                    DialogResult result = form.ShowDialog();
                }
            }

        }
        private void duplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuplicarIngreso();
        }
        private void fotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModalCamara();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorrarIngreso();
        }
        private void agregarIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAgregar_Click(sender, e);
        }
        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEtiqueta_Click(sender, e);
        }
        private async void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablaIngresos.SelectedRows.Count > 0)
                {
                    string path = @"\\Server\metrogestion\008 SOFTWARE\ETIQUETAS\SERIE.lbx";
                    if (!File.Exists(path))
                    {
                        MessageBox.Show("El archivo no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    PrintDialog printDialog = new PrintDialog();
                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        var doc = new Document();
                        if (doc.Open(path) != false)
                        {
                            bool success = false;
                            success = doc.SetPrinter(printDialog.PrinterSettings.PrinterName, true);
                            List<int> ids = new List<int>();
                            foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                            {
                                string serie = "SERIE " + row.Cells["etiqueta"].Value.ToString().Replace(" ", "");
                                ids.Add((int)row.Cells["id"].Value);
                                doc.GetObject("SERIE").Text = serie;
                                if (!success)
                                {
                                    MessageBox.Show("No se pudo establecer la impresora.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    doc.Close();
                                    return;
                                }
                                doc.StartPrint("", PrintOptionConstants.bpoHighResolution);
                                doc.PrintOut(printDialog.PrinterSettings.Copies, PrintOptionConstants.bpoHighResolution);
                                doc.EndPrint();
                            }
                            doc.Close();

                            RecepcionRepository etiqueta = new RecepcionRepository();
                            bool impresas = await etiqueta.SerieImpresa(ids);
                            if (impresas)
                            {
                                BuscarIngresos(idcliente, nro_recepcion);
                                MessageBox.Show("Etiqueta(s) impresa(s)");
                            }
                            else
                                return;
                        }
                        else
                        {
                            MessageBox.Show("Error al abrir el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar uno o más ingresos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tablaIngresos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            bool valor = (bool)tablaIngresos.Rows[e.RowIndex].Cells["con_serie"].Value;
            
            if (!valor && (tablaIngresos.Rows[e.RowIndex].Cells["codigo"].ToString() == ""))
            {
                tablaIngresos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 63, 63);
            }
        }
        #endregion

        #region Consultar Recepcion
        private async void DatosConsulta()
        {
            txtCNro.Text = string.Empty;
            dtpCDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpCHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            await FG.CargarCombos(cbCCliente, "clientes", "", 0);
        }

        

        private void txtCNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Consultar();
            }
        }

        private async void Consultar()
        {
            tablaRecepciones.DataSource = null;
            RecepcionRepository recepciones = new RecepcionRepository();
            int idcliente = (int)cbCCliente.SelectedValue > 0 ? (int)cbCCliente.SelectedValue : 0;
            DataTable tabla = await recepciones.Consultar(txtCNro.Text, idcliente, dtpCDesde.Value.ToString("dd-MM-yyyy"), dtpCHasta.Value.ToString("dd-MM-yyyy"));

            if (tabla != null)
            {
                tablaRecepciones.DataSource = tabla;
                tablaRecepciones.Visible = false;
                if (tablaRecepciones.Rows.Count > 0)
                {
                    tablaRecepciones.Visible = true;
                    tablaRecepciones.CurrentCell = null;
                    tablaRecepciones.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                    tablaRecepciones.Font = new Font("Calibri", 12F, FontStyle.Bold);
                    tablaRecepciones.Columns["id"].Visible = false;
                    tablaRecepciones.Columns["nro_recepcion"].Visible = false;
                    tablaRecepciones.Columns["fila"].HeaderText = "#";
                    tablaRecepciones.Columns["anio"].HeaderText = "Año";
                    tablaRecepciones.Columns["recepcion"].HeaderText = "Recepción";                    
                    tablaRecepciones.Columns["cliente"].HeaderText = "Cliente";
                    tablaRecepciones.Columns["magnitud"].HeaderText = "Magnitudes";
                    tablaRecepciones.Columns["cantidad"].HeaderText = "Cantidad de Ingresos";
                    tablaRecepciones.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaRecepciones.Columns["cantidad"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepciones.Columns["fecha"].HeaderText = "Fecha";
                    tablaRecepciones.Columns["registrado_por"].HeaderText = "Registrado por";
                    tablaRecepciones.Columns["registrado_por"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepciones.Columns["observacion"].HeaderText = "Observación";
                    tablaRecepciones.Columns["observacion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepciones.AllowUserToOrderColumns = false;
                }
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (tablaRecepciones.DataSource != null)
            {
                (tablaRecepciones.DataSource as DataTable).DefaultView.RowFilter = string.Format("recepcion like '%{0}%' or anio like '%{0}%' or cliente like '%{0}%' or magnitud like '%{0}%'", txtFiltro.Text);
            }

        }

        private void tablaRecepciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = tablaRecepciones.CurrentRow;
            int recepcion = Convert.ToInt32(selectedRow.Cells["nro_recepcion"].Value);
            txtNro.Text = recepcion.ToString();
            BuscarRecepcion(recepcion);
            tcGeneral.SelectedTab = tpRegistro;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablaRecepciones_CellDoubleClick(null, null);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaRecepciones.CurrentRow != null)
            {
                DataGridViewRow selectedRow = tablaRecepciones.CurrentRow;
                nro_recepcion = Convert.ToInt32(selectedRow.Cells["nro_recepcion"].Value);
                ImprimirRecepcion();
            }
        }



        #endregion

        private async void btnRechazar_Click(object sender, EventArgs e)
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                RecepcionRepository anular = new RecepcionRepository();
                List<int> ingresos = new List<int>();
                foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                {
                    ingresos.Add((int)row.Cells["id"].Value);
                }
                bool anulado = await anular.Anular(ingresos, 1);
                if (anulado)
                {
                    BuscarRecepcion(nro_recepcion);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar mínimo un ingreso");
            }
            
        }

        private async void btnAdjuntar_Click(object sender, EventArgs e)
        {
            
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    string texto = form.TextoIngresado;
                    if (texto != "")
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
                                RecepcionRepository adjuntar = new RecepcionRepository();
                                bool adjuntado = await adjuntar.AdjuntarArchivo(nro_recepcion, txtAnio.Text, base64String, texto);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                    }

                }
            }
        }

        private async void anularIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                RecepcionRepository anular = new RecepcionRepository();
                List<int> ingresos = new List<int>();
                foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                {
                    ingresos.Add((int)row.Cells["id"].Value);
                }
                bool anulado = await anular.Anular(ingresos, 1);
                if (anulado)
                {
                    BuscarRecepcion(nro_recepcion);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar mínimo un ingreso");
            }
        }

        private async void eliminarAnulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaIngresos.SelectedRows.Count > 0)
            {
                RecepcionRepository anular = new RecepcionRepository();
                List<int> ingresos = new List<int>();
                foreach (DataGridViewRow row in tablaIngresos.SelectedRows)
                {
                    ingresos.Add((int)row.Cells["id"].Value);
                }
                bool anulado = await anular.Anular(ingresos, 2);
                if (anulado)
                {
                    BuscarRecepcion(nro_recepcion);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar mínimo un ingreso");
            }
        }
    }
}
