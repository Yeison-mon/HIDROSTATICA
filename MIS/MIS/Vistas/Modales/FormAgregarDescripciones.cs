using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormAgregarDescripciones : Form
    {
        public string TextoIngresado { get; private set; }
        //private string tipo = "";
        public FormAgregarDescripciones()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            TextoIngresado = txtEntrada.Text;
            if (TextoIngresado != "")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe de ingresar la información requerida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
