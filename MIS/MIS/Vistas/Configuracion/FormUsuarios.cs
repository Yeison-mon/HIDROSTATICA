using MIS.Helpers;
using MIS.Modelos.Registros;
using MIS.Modelos.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Configuracion
{
    public partial class FormUsuarios : Form
    {
        private int idusuario = 0;
        SeguridadRepository seguridad = new SeguridadRepository();
        public FormUsuarios()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            txtNombre.Text = string.Empty;
            txtUsu.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmar.Text = string.Empty;
            cbEstado.SelectedIndex = 0;
            idusuario = 0;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty || txtUsu.Text == string.Empty || txtCargo.Text == string.Empty)
            {
                MessageBox.Show("Agregue toda la información");
                return;
            }
            if (txtClave.Text != txtConfirmar.Text)
            {
                MessageBox.Show("No concide la confirmación de la clave");
                return;
            }
            string nombre = txtNombre.Text;
            string usuario = txtUsu.Text;
            string cargo = txtCargo.Text;
            string clave = txtClave.Text;
            string estado = cbEstado.SelectedItem.ToString();
            if (FG.Cargo == "ADMINISTRADOR" || FG.Cargo == "ADMIN")
            {
                idusuario = await seguridad.Guardar(idusuario, nombre, usuario, cargo, clave, estado);
            }
            else
            {
                MessageBox.Show("No posee permisos para esta acción");
                return;
            }
            if (idusuario > 0)
            {
                MessageBox.Show("Usuario guardado con exito");
                Usuario(idusuario);
            }
            else
            {
                MessageBox.Show("Comuniquese con el Administrador (3025974171)");
            }
        }
        private async void Usuario(int id)
        {
            idusuario = id;
            DataRow data = await seguridad.Buscar(id);
            if (data == null)
            {
                MessageBox.Show("Usuario no encontrado (3025974171) ");
            }
            else
            {
                txtNombre.Text = data["nombrecompleto"].ToString();
                txtUsu.Text = data["nomusu"].ToString();
                txtCargo.Text = data["cargo"].ToString();
                txtClave.Text = string.Empty;
                txtConfirmar.Text = string.Empty;
            }
        }

        private async void Buscar()
        {
            tablaConsulta.DataSource = null;
            tablaConsulta.Rows.Clear();
            tablaConsulta.Columns.Clear();
            DataTable tabla = await seguridad.Usuarios(txtCNombre.Text, txtCUsuario.Text);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                tablaConsulta.DataSource = tabla;
                tablaConsulta.CurrentCell = null;
                tablaConsulta.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                tablaConsulta.Columns["id"].Visible = false;
                tablaConsulta.Columns["nomusu"].HeaderText = "USUARIO";
                tablaConsulta.Columns["nombrecompleto"].HeaderText = "NOMBRE COMPLETO";
                tablaConsulta.Columns["cargo"].HeaderText = "CARGO";
                tablaConsulta.Columns["estado"].HeaderText = "ESTADO";
                tablaConsulta.Columns["nombrecompleto"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaConsulta.AllowUserToOrderColumns = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void tablaConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = tablaConsulta.CurrentRow;
            Usuario(Convert.ToInt32(selectedRow.Cells["id"].Value));
            tcGeneral.SelectedTab = tpRegistro;
        }
    }
}
