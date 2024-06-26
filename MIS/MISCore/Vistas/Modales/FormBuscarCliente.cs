using MIS.Modelos.Configuracion;
using System;
using System.Data;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormBuscarCliente : Form
    {
        public int idcliente { get; private set; }
        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            ClientesRepository clientes = new ClientesRepository();
            DataTable data = await clientes.BuscarClientesModal("", "");
            if(data != null)
            {
                tablaClientes.DataSource = data;
                tablaClientes.Columns["nro"].HeaderText = "#";
                tablaClientes.Columns["id"].Visible = false;
                tablaClientes.Columns["nombrecompleto"].HeaderText = "Empresa";
                tablaClientes.Columns["documento"].HeaderText = "Documento";
                tablaClientes.Columns["direccion"].HeaderText = "Dirección";
                tablaClientes.Columns["nombrecompleto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tablaClientes.Columns["nro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                tablaClientes.Columns["direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("No hay clientes cargados");
                this.Close();
            }
        }

        private void tablaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaSeleccionada = e.RowIndex;
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow fila = tablaClientes.Rows[filaSeleccionada];
                idcliente = Convert.ToInt32(fila.Cells["id"].Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && txtNombre.Text.Length > 0)
            {
                

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            (tablaClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("nombrecompleto LIKE '%{0}%'", txtNombre.Text);
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            (tablaClientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("documento LIKE '%{0}%'", txtDocumento.Text);
        }
    }
}
