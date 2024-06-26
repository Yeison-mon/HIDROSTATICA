using MIS.Modelos.Registros;
using System;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormDuplicar : Form
    {
        private string tipo;
        private int id;
        public FormDuplicar(string tipo, int id)
        {
            InitializeComponent();
            cbConSerie.SelectedIndex = 0;
            this.tipo = tipo;
            this.id = id;
            txtCantidad.Enabled = false;
            txtCantidad.Text = "1";
        }
        private async void Duplicar()
        {
            int guardadoTotal = 0;
            RecepcionRepository duplicar = new RecepcionRepository();
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            for (int i = 0; i < cantidad; i++)
            {
                int guardado = await duplicar.Duplicar(id, txtSerie.Text);
                guardadoTotal += guardado;
                if (guardado == 0)
                {
                    return;
                }
            }

            if (guardadoTotal == cantidad)
            {
                MessageBox.Show("Duplicado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudieron duplicar todas las entradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbConSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbConSerie.SelectedIndex == 0)
            {
                txtCantidad.Text = "1";
                txtCantidad.Enabled = false;
                txtSerie.Enabled = true;
            }
            else
            {
                txtCantidad.Enabled = true;
                txtSerie.Text = "";
                txtSerie.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Duplicar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
