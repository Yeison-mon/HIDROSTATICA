using MIS.Helpers;
using MIS.Modelos.Registros;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormRecepciones : Form
    {

        public int recepcion { get; private set; }
        public int idrecepcion { get; private set; }
        public int inspeccion { get; private set; }
        public int idcliente { get; private set; }
        private string tipo = "";
        public FormRecepciones(int idcliente, string tipo)
        {
            InitializeComponent();
            this.idcliente = idcliente;
            this.tipo = tipo;
            if (tipo == "IR")
            {
                cbEstados.Items.Add("Ingresado");
                cbEstados.Items.Add("Inspeccionado");
            }
            if (tipo == "Cotizacion")
            {
                cbEstados.Items.Add("Inspeccionado");
            }
            if (tipo == "ODT")
            {
                cbEstados.Items.Add("Cotizado");
                cbEstados.Items.Add("Inspeccionado");
            }
            if (tipo == "IPF") 
            {
                cbEstados.Items.Add("Programado");
            }

            cbEstados.SelectedIndex = 0;
            TablaRecepciones();
            tablaRecepcion.CellMouseDown += (sender, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        tablaRecepcion.ClearSelection();
                        tablaRecepcion.Rows[e.RowIndex].Selected = true;
                        Point localMousePosition = tablaRecepcion.PointToClient(Cursor.Position);
                        cmsTabla.Show(tablaRecepcion, localMousePosition);
                    }
                }
            };
            
        }

        private async void TablaRecepciones()
        {
            tablaRecepcion.DataSource = null;
            tablaRecepcion.Rows.Clear();
            RecepcionRepository recepciones = new RecepcionRepository();
            string estado = cbEstados.SelectedItem.ToString();
            DataTable tabla = await recepciones.ModalRecepciones(estado, idcliente, tipo);

            if (tabla != null)
            {
                tablaRecepcion.DataSource = tabla;
                tablaRecepcion.Visible = false;
                if (tablaRecepcion.Rows.Count > 0)
                {
                    tablaRecepcion.Visible = true;
                    tablaRecepcion.CurrentCell = null;
                    tablaRecepcion.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                    tablaRecepcion.Font = new Font("Calibri", 12F, FontStyle.Bold);
                    tablaRecepcion.Columns["id"].Visible = false;
                    tablaRecepcion.Columns["nro_recepcion"].Visible = false;
                    tablaRecepcion.Columns["nro_inspeccion"].Visible = false;
                    tablaRecepcion.Columns["idcliente"].Visible = false;
                    tablaRecepcion.Columns["fila"].HeaderText = "#";
                    tablaRecepcion.Columns["anio"].HeaderText = "Año";
                    tablaRecepcion.Columns["recepcion"].HeaderText = "Recepción";
                    tablaRecepcion.Columns["estado"].HeaderText = "Estado";
                    tablaRecepcion.Columns["cliente"].HeaderText = "Cliente";
                    tablaRecepcion.Columns["magnitud"].HeaderText = "Magnitudes";
                    tablaRecepcion.Columns["cantidad"].HeaderText = "Cantidad de Ingresos";
                    tablaRecepcion.Columns["cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaRecepcion.Columns["anulados"].HeaderText = "Anulados";
                    tablaRecepcion.Columns["anulados"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    tablaRecepcion.Columns["cantidad"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepcion.Columns["fecha"].HeaderText = "Fecha";
                    tablaRecepcion.Columns["registrado_por"].HeaderText = "Registrado por";
                    tablaRecepcion.Columns["registrado_por"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepcion.Columns["observacion"].HeaderText = "Observación";
                    tablaRecepcion.Columns["observacion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tablaRecepcion.AllowUserToOrderColumns = false;
                }
            }
        }




        private void txtRecepcion_TextChanged(object sender, EventArgs e)
        {
            if (tablaRecepcion.DataSource != null)
            {
                (tablaRecepcion.DataSource as DataTable).DefaultView.RowFilter = string.Format("recepcion like '%{0}%'", txtRecepcion.Text);
            }
        }

        private void cbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            TablaRecepciones();
        }

        private void tablaRecepcion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = tablaRecepcion.Rows[filaSeleccionada];
                recepcion = Convert.ToInt32(fila.Cells["nro_recepcion"].Value);
                inspeccion = Convert.ToInt32(fila.Cells["nro_inspeccion"].Value);
                idrecepcion = Convert.ToInt32(fila.Cells["id"].Value);
                idcliente = Convert.ToInt32(fila.Cells["idcliente"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void verItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaRecepcion.CurrentRow != null)
            {
                DataGridViewRow selectedRow = tablaRecepcion.CurrentRow;
                int recepcion = Convert.ToInt32(selectedRow.Cells["nro_recepcion"].Value);
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private async void Imprimir(int nro, string tipo)
        {
            int numeroRecepcion = nro;
            if (numeroRecepcion > 0)
            {
                ReportService reportService = new ReportService();
                await reportService.OpenReportInBrowserAsync(numeroRecepcion, tipo);
            }
            else
            {
                MessageBox.Show("No se ha cargado el número de documento");
            }
        }

        private void recepcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaRecepcion.CurrentRow != null)
            {
                DataGridViewRow selectedRow = tablaRecepcion.CurrentRow;
                int recepcion = Convert.ToInt32(selectedRow.Cells["nro_recepcion"].Value);
                Imprimir(recepcion, "Recepcion");
            }
        }

        private void inspecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tablaRecepcion.CurrentRow != null)
            {
                DataGridViewRow selectedRow = tablaRecepcion.CurrentRow;
                int numero = Convert.ToInt32(selectedRow.Cells["nro_inspeccion"]?.Value);
                Imprimir(numero, "Inspeccion");
            }
        }
    }
}
