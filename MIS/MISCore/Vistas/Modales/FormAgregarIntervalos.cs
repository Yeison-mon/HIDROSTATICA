using MIS.Helpers;
using MIS.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormAgregarIntervalos : Form
    {
        public string desde { get; private set; }
        public string hasta { get; private set; }
        public string medida { get; private set; }
        private int idmagnitud; 
        public FormAgregarIntervalos(int _idmagnitud)
        {
            InitializeComponent();
            idmagnitud = _idmagnitud;
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
            btnAceptar.Enabled = false;
            Combos();
        }

        private async void Combos()
        {
            await FG.CargarCombos(cbMedidas, "medidas", $"{idmagnitud}", 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((int)cbMedidas.SelectedValue> 0)
            {
                txtDesde.Enabled = true;
                txtHasta.Enabled = true;
                btnAceptar.Enabled = true;
            } else
            {
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
                btnAceptar.Enabled = false;
            }
        }

        private async void labelMedida_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("medidas", texto, $"{idmagnitud}");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbMedidas, "medidas", "", 0);
                        cbMedidas.SelectedItem = texto;
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            desde = txtDesde.Text;
            hasta = txtHasta.Text;
            medida = this.cbMedidas.GetItemText(this.cbMedidas.SelectedItem); ;
            if(!(desde.Equals("") || hasta.Equals("") || medida.Equals("--SELECCIONE--")))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("Debe completar la información", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
                
        }
    }
}
