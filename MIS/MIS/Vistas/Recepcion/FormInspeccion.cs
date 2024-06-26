using MIS.Helpers;
using MIS.Modelos.Recepcion;
using MIS.Vistas.Modales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MIS.Vistas.Recepcion
{
    public partial class FormInspeccion : Form
    {
        private int recepcion;
        private int inspeccion;
        public FormInspeccion()
        {
            InitializeComponent();
            btnLimpiar_Click(null, null);
            txtEstado.Enabled= false;
            DatosConsulta();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            txtEstado.Text = "Temporal";
            txtObservacion.Text = "";
            dtFechaInspeccion.Value = DateTime.Now;
            dtFechaRecepcion.Value = DateTime.Now;
            txtNroInspeccion.Text = "";
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            btnLimpiar.Visible = false;
            tablaIngresos.DataSource = null;
            tablaIngresos.Rows.Clear();
            tablaIngresos.Columns.Clear();
            txtNroRecepcion.Text = "";
            recepcion = 0;
        }

        private async void ImprimirInspeccion()
        {
            if (inspeccion > 0)
            {
                ReportService reportService = new ReportService();
                await reportService.OpenReportInBrowserAsync(inspeccion, "Inspeccion");
            }
            else
            {
                MessageBox.Show("No se ha cargado el número de documento");
            }
        }
        private void txtNroRecepcion_TextChanged(object sender, EventArgs e)
        {
            if (txtNroRecepcion.Text.Length == 0)
                btnLimpiar_Click(null, null);
        }

        private void txtNroRecepcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                int recepcion;
                if (int.TryParse(txtNroRecepcion.Text, out recepcion))
                {
                    Buscar(recepcion, 0);
                }
                else
                {
                    txtNroRecepcion.Text = "";
                }
            }
        }

        private void txtNroInspeccion_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                int inspeccion;
                if (int.TryParse(txtNroInspeccion.Text, out inspeccion))
                {
                    Buscar(0, inspeccion);
                }
                else
                {
                    txtNroInspeccion.Text = "";
                }
            }
        }

        private void txtNroInspeccion_TextChanged(object sender, EventArgs e)
        {
            if (txtNroInspeccion.Text.Length == 0)
                btnLimpiar_Click(null, null);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FormRecepciones form = new FormRecepciones(0, "IR"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    recepcion = form.recepcion;
                    Buscar(recepcion, 0);
                }
            }
        }

        private async void Buscar(int recepcion, int inspeccion)
        {
            InspeccionRepository buscar = new InspeccionRepository();
            
            DataTable tabla = await buscar.Buscar(recepcion, inspeccion);
            if (tabla != null && tabla.Rows.Count > 0)
            {
                txtCliente.Text = tabla.Rows[0]["cliente"].ToString();
                txtEstado.Text = tabla.Rows[0]["estado_inspeccion"].ToString() != "" ? tabla.Rows[0]["estado_inspeccion"].ToString() : "Temporal";
                txtNroRecepcion.Text = tabla.Rows[0]["recepcion"].ToString();
                this.recepcion = (int)tabla.Rows[0]["recepcion"];
                this.inspeccion = (int)tabla.Rows[0]["inspeccion"];
                txtNroInspeccion.Text = tabla.Rows[0]["inspeccion"].ToString() != "0" ? tabla.Rows[0]["inspeccion"].ToString() : "";
                dtFechaRecepcion.Value = (DateTime)tabla.Rows[0]["fecha_recepcion"];
                dtFechaInspeccion.Value = tabla.Rows[0]["fecha_inspeccion"].ToString() != "" ? (DateTime)tabla.Rows[0]["fecha_inspeccion"] : DateTime.Now;
                int id = (int)tabla.Rows[0]["id"];
                Ingresos(id);
            }
        }

        private async void Ingresos(int id)
        {
            tablaIngresos.DataSource = null;
            tablaIngresos.Rows.Clear();
            tablaIngresos.Columns.Clear();
            InspeccionRepository ingresos = new InspeccionRepository();
            DataTable tabla = await ingresos.TablaIngresos(id);
            
            if (tabla != null && tabla.Rows.Count > 0)
            {
                btnGuardar.Visible = true;
                btnImprimir.Visible = true;
                btnLimpiar.Visible = true;
                tablaIngresos.DataSource = tabla;
                tablaIngresos.CurrentCell = null;
                tablaIngresos.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                tablaIngresos.Columns["id"].Visible = false;
                tablaIngresos.Columns["renglon"].HeaderText = "Renglon";
                tablaIngresos.Columns["renglon"].ReadOnly = true;
                tablaIngresos.Columns["renglon"].DisplayIndex = 0;
                tablaIngresos.Columns["ingreso"].HeaderText = "Ingreso";
                tablaIngresos.Columns["ingreso"].ReadOnly = true;
                tablaIngresos.Columns["ingreso"].DisplayIndex = 1;
                tablaIngresos.Columns["descripcion"].HeaderText = "Descripción";
                tablaIngresos.Columns["descripcion"].ReadOnly = true;
                tablaIngresos.Columns["descripcion"].DisplayIndex = 2;
                tablaIngresos.Columns["descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.Columns["piezas"].Visible = false;
                tablaIngresos.Columns["funcionalidades"].Visible = false;
                tablaIngresos.Columns["acabados"].Visible = false;
                tablaIngresos.Columns["observaciones"].Visible = false;
                tablaIngresos.Columns["estados"].Visible = false;
                tablaIngresos.AllowUserToOrderColumns = false;

                DataGridViewTextBoxColumn columnaPiezas = new DataGridViewTextBoxColumn();
                columnaPiezas.Name = "pieza";
                columnaPiezas.HeaderText = "Piezas";
                columnaPiezas.DisplayIndex = 3;
                columnaPiezas.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaPiezas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.Columns.Add(columnaPiezas);

                DataGridViewTextBoxColumn columnaFuncionalidades = new DataGridViewTextBoxColumn();
                columnaFuncionalidades.Name = "funcionalidad";
                columnaFuncionalidades.HeaderText = "Funcionalidades";
                columnaFuncionalidades.DisplayIndex = 4;
                columnaFuncionalidades.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaFuncionalidades.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.Columns.Add(columnaFuncionalidades);

                DataGridViewTextBoxColumn columnaAcabado = new DataGridViewTextBoxColumn();
                columnaAcabado.Name = "acabado";
                columnaAcabado.HeaderText = "Acabado";
                columnaAcabado.DisplayIndex = 5;
                columnaAcabado.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaAcabado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.Columns.Add(columnaAcabado);

                DataGridViewTextBoxColumn columnaObservacion = new DataGridViewTextBoxColumn();
                columnaObservacion.Name = "observacion";
                columnaObservacion.HeaderText = "Observación";
                columnaObservacion.DisplayIndex = 6;
                columnaObservacion.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaObservacion.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaIngresos.Columns.Add(columnaObservacion);

                // Agregar columna de selección
                DataGridViewComboBoxColumn columnaSeleccion = new DataGridViewComboBoxColumn();
                columnaSeleccion.Name = "estado";
                columnaSeleccion.HeaderText = "Estado";
                columnaSeleccion.Items.AddRange("Aprobado", "Rechazado");
                columnaSeleccion.DisplayIndex = 7;
                columnaSeleccion.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                tablaIngresos.Columns.Add(columnaSeleccion);
                columnaSeleccion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tablaIngresos.CellClick += tablaIngresos_CellClick;
            }
            foreach (DataGridViewRow fila in tablaIngresos.Rows)
            {
                fila.Cells["estado"].Value = "Aprobado";
            }
            foreach (DataRow fila in tabla.Rows)
            {
                // Buscar la fila correspondiente en el DataGridView
                foreach (DataGridViewRow dgvRow in tablaIngresos.Rows)
                {
                    if (dgvRow.Cells["id"].Value != null && dgvRow.Cells["id"].Value.ToString() == fila["id"].ToString())
                    {
                        // Asignar los valores a las celdas de las columnas dinámicas
                        dgvRow.Cells["pieza"].Value = fila["piezas"];
                        dgvRow.Cells["funcionalidad"].Value = fila["funcionalidades"];
                        dgvRow.Cells["acabado"].Value = fila["acabados"];
                        dgvRow.Cells["observacion"].Value = fila["observaciones"];

                        // Para la columna "estado", necesitas asignar el valor a través de la celda DataGridViewComboBoxCell
                        DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dgvRow.Cells["estado"];
                        cell.Value = (bool)fila["estados"] == true ? "Aprobado" : "Rechazado";

                        break;
                    }
                }
            }
        }

        private void tablaIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            //int rowIndex = e.RowIndex;

            // Habilitar la edición solo para las columnas deseadas
            if (columnIndex == tablaIngresos.Columns["pieza"].Index ||
                columnIndex == tablaIngresos.Columns["funcionalidad"].Index ||
                columnIndex == tablaIngresos.Columns["acabado"].Index ||
                columnIndex == tablaIngresos.Columns["estado"].Index)
            {
                tablaIngresos.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            else
            {
                tablaIngresos.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            List<string> piezas = new List<string>();
            List<string> funcionalidades = new List<string>();
            List<string> acabados = new List<string>();
            List<string> observaciones = new List<string>();
            List<string> estados = new List<string>();
            foreach (DataGridViewRow row in tablaIngresos.Rows)
            {
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string pieza = row.Cells["pieza"].Value?.ToString() ?? "";
                string funcionalidad = row.Cells["funcionalidad"].Value?.ToString() ?? "";
                string acabado = row.Cells["acabado"].Value?.ToString() ?? "";
                string observacion = row.Cells["observacion"].Value?.ToString() ?? "";
                string estado = row.Cells["estado"].Value.ToString();
                ids.Add(id);
                piezas.Add(pieza);
                funcionalidades.Add(funcionalidad);
                acabados.Add(acabado);
                observaciones.Add(observacion);
                estados.Add(estado);
            }
            InspeccionRepository guardar = new InspeccionRepository();
            inspeccion = await guardar.GuardarInspeccion(ids, piezas, funcionalidades, acabados, observaciones, estados, recepcion, inspeccion, txtObservacion.Text);
            if (inspeccion > 0)
            {
                txtNroInspeccion.Text = inspeccion.ToString();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirInspeccion();
        }
        #region Consultar
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            int inspeccion = 0;
            int recepcion = 0;
            if (txtCInspeccion.Text != string.Empty)
            {
                inspeccion = Convert.ToInt32(txtCInspeccion.Text);
            }
            if (txtCNro.Text != string.Empty)
            {
                recepcion = Convert.ToInt32(txtCNro.Text);
            }
            tablaConsulta.DataSource = null;
            int idcliente = cbCCliente.SelectedValue != null ? ((int)cbCCliente.SelectedValue > 0 ? (int)cbCCliente.SelectedValue : 0) : 0;
            InspeccionRepository consultar = new InspeccionRepository();
            DataTable table = await consultar.Consulta(inspeccion, recepcion, idcliente, dtpCDesde.Value.ToString("dd-MM-yyyy"), dtpCHasta.Value.ToString("dd-MM-yyyy"));
            if (table != null)
            {
                tablaConsulta.DataSource = table;
                tablaConsulta.Visible = false;
                if(tablaConsulta.Rows.Count > 0)
                {
                    tablaConsulta.Visible = true;
                    tablaConsulta.CurrentCell = null;
                    tablaConsulta.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                    tablaConsulta.Font = new Font("Calibri", 12F, FontStyle.Bold);
                    tablaConsulta.Columns["documento"].Visible = false;
                    tablaConsulta.Columns["nro_inspeccion"].Visible = false;
                    tablaConsulta.Columns["nro_recepcion"].Visible = false;
                    tablaConsulta.Columns["cliente"].HeaderText = "Cliente";
                    tablaConsulta.Columns["cliente"].DisplayIndex = 0;
                    tablaConsulta.Columns["inspeccion"].HeaderText = "IR";
                    tablaConsulta.Columns["inspeccion"].DisplayIndex = 1;
                    tablaConsulta.Columns["recepcion"].HeaderText = "NR";
                    tablaConsulta.Columns["recepcion"].DisplayIndex = 2;
                    tablaConsulta.Columns["fecha_inspeccion"].HeaderText = "Fecha (IR)";
                    tablaConsulta.Columns["fecha_inspeccion"].DisplayIndex = 3;
                    tablaConsulta.Columns["fecha_recepcion"].HeaderText = "Fecha (NR)";
                    tablaConsulta.Columns["fecha_recepcion"].DisplayIndex = 4;
                    tablaConsulta.Columns["ingresos"].HeaderText = "Cant. Ingresos";
                    tablaConsulta.Columns["ingresos"].DisplayIndex = 5;
                    tablaConsulta.Columns["ingresos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["materiales"].HeaderText = "Cant. Materiales";
                    tablaConsulta.Columns["materiales"].DisplayIndex = 6;
                    tablaConsulta.Columns["materiales"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["recibidos"].HeaderText = "Cant. Recibidos";
                    tablaConsulta.Columns["recibidos"].DisplayIndex = 7;
                    tablaConsulta.Columns["recibidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["aprobados"].HeaderText = "Cant. Aprobados";
                    tablaConsulta.Columns["aprobados"].DisplayIndex = 8;
                    tablaConsulta.Columns["aprobados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["inspeccionados"].HeaderText = "Cant. Inspeccionados";
                    tablaConsulta.Columns["inspeccionados"].DisplayIndex = 9;
                    tablaConsulta.Columns["inspeccionados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["rechazados"].HeaderText = "Cant. Rechazados";
                    tablaConsulta.Columns["rechazados"].DisplayIndex = 10;
                    tablaConsulta.Columns["rechazados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaConsulta.Columns["observacion"].HeaderText = "Observación";
                    tablaConsulta.Columns["observacion"].DisplayIndex = 11;
                    tablaConsulta.Columns["usuario"].HeaderText = "Registrado por";
                    tablaConsulta.Columns["usuario"].DisplayIndex = 12;
                }
            }

        }
        private void txtCNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCInspeccion.Text = "";
                btnConsultar_Click(null, null);
            }
        }
        private void txtCInspeccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCNro.Text = "";
                btnConsultar_Click(null, null);
            }
        }

        private async void DatosConsulta()
        {
            txtCNro.Text = string.Empty;
            dtpCDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpCHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            await FG.CargarCombos(cbCCliente, "clientes", "", 0);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (tablaConsulta.DataSource != null)
            {
                (tablaConsulta.DataSource as DataTable).DefaultView.RowFilter = string.Format("cliente like '%{0}%' or inspeccion like '%{0}%' or recepcion like '%{0}%' or fecha_inspeccion like '%{0}%' or fecha_recepcion or observacion like '%{0}%' or usuario like '%{0}%'", txtFiltro.Text);
            }
        }


        #endregion

        private void tablaConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = tablaConsulta.CurrentRow;
            int inspeccion = Convert.ToInt32(selectedRow.Cells["nro_inspeccion"].Value);
            txtNroInspeccion.Text = inspeccion.ToString();
            Buscar(0, inspeccion);
            tcGeneral.SelectedTab = tpRegistro;
        }
    }
}
