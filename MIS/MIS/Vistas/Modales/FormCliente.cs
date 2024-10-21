using MIS.Helpers;
using MIS.Modelos;
using MIS.Modelos.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormCliente : Form
    {
        public int idcliente { get; private set; }
        public FormCliente(int _idcliente)
        {
            idcliente = _idcliente;
            InitializeComponent();
            cbDepartamento.Enabled = false;
            cbCiudad.Enabled = false;
            Combos();
        }

        private async void Combos()
        {
            await FG.CargarCombos(cbPais, "pais", "", 0);
        }

        private async void labelPais_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("pais", texto, "");
                    if (guardadoExitoso)
                    {
                        await FG.CargarCombos(cbPais, "pais", "", 0);
                        cbPais.SelectedItem = texto;
                    }
                }
            }
        }

        private async void labelDepartamento_Click(object sender, EventArgs e)
        {
            if ((int)cbPais.SelectedValue > 0)
            {
                using (FormAgregarDescripciones form = new FormAgregarDescripciones())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        string texto = form.TextoIngresado;
                        bool guardadoExitoso = await combosRepository.GuardarNuevoValor("departamento", texto, cbPais.SelectedValue.ToString());
                        if (guardadoExitoso)
                        {
                            await FG.CargarCombos(cbDepartamento, "departamento", cbPais.SelectedValue.ToString(), 0);
                            cbPais.SelectedItem = texto;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Debes seleccionar el pais"); cbPais.Focus();
        }

        private async void labelCiudad_Click(object sender, EventArgs e)
        {
            if (cbDepartamento.DataSource != null && (int)cbDepartamento.SelectedValue > 0)
            {
                using (FormAgregarDescripciones form = new FormAgregarDescripciones())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        string texto = form.TextoIngresado;
                        bool guardadoExitoso = await combosRepository.GuardarNuevoValor("ciudad", texto, cbDepartamento.SelectedValue.ToString());
                        if (guardadoExitoso)
                        {
                            await FG.CargarCombos(cbCiudad, "ciudad", cbDepartamento.SelectedValue.ToString(), 0);
                            cbPais.SelectedItem = texto;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Debes seleccionar el departamento"); cbDepartamento.Focus();
        }

        private async void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.DataSource != null)
            {
                if ((int)cbPais.SelectedValue > 0)
                {
                    string id = cbPais.SelectedValue.ToString();
                    await FG.CargarCombos(cbDepartamento, "departamento", id, 0);
                    cbDepartamento.Enabled = true;
                }
            }
        }

        private async void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartamento.DataSource != null)
            {
                if ((int)cbDepartamento.SelectedValue > 0)
                {
                    string id = cbDepartamento.SelectedValue.ToString();
                    await FG.CargarCombos(cbCiudad, "ciudad", id, 0);
                    cbCiudad.Enabled = true;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            int idciudad = 0;
            if ((int)cbCiudad.SelectedValue > 0)
            {
                idciudad = (int)cbCiudad.SelectedValue;
            }else
            {
                FG.ShowAlert("Agregue la ciudad", "Alerta");
                return;
            }
            if (txtDocumento.Text == "" || txtNombre.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtCorreo.Text == "" || idciudad == 0)
            {
                FG.ShowAlert("Agregue toda la informacion", "Alerta");
                return;
            }
            ClientesRepository guardar = new ClientesRepository();
            idcliente = await guardar.GuardarCliente(idcliente, txtDocumento.Text, txtNombre.Text, txtTelefono.Text, txtCelular.Text, txtDireccion.Text, txtCorreo.Text, idciudad);
            if (idcliente > 0)
                this.Close();
        }
    }
}
