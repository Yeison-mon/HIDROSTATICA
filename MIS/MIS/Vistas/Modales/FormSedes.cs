using MIS.Helpers;
using MIS.Modelos;
using MIS.Modelos.Configuracion;
using System;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormSedes : Form
    {
        private int idcliente = 0;
        public FormSedes(int _idcliente, string _nombrecompleto)
        {
            InitializeComponent();
            idcliente = _idcliente;
            labelCliente.Text = _nombrecompleto;
            cbDepartamento.Enabled = false;
            cbCiudad.Enabled = false;
            Combos();
        }

        private async void Combos()
        {
            await FG.CargarCombos(cbPais, "pais", "", 0);
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        public event EventHandler SedeGuardada;

        private void OnSedeGuardada()
        {
            SedeGuardada?.Invoke(this, EventArgs.Empty);
        }

        private async void btnAgregar_Click(object sender, System.EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int ciudad = 0;
            if (cbCiudad.DataSource != null)
            {
                ciudad = (int)cbCiudad.SelectedValue;
            } else
            {
                MessageBox.Show("Debe cargar la departamento/ciudad y seleccionar la ciudad!");
            }
            string contacto = txtContacto.Text;
            string correo = txtCorreoFac.Text;
            string telefono = txtTelefono.Text;
            string copia = txtCopiaCorreo.Text;
            if(nombre == "")
            {
                MessageBox.Show("Debe agregar el nombre de la sede", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            } else if (direccion == "")
            {
                MessageBox.Show("Debe agregar la dirección de la sede", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDireccion.Focus();
            } else
            {
                ClientesRepository guardar = new ClientesRepository();
                bool guardado = await guardar.GuardarSedeModal(idcliente, nombre, direccion, ciudad, contacto, correo, telefono, copia);
                if (guardado)
                {
                    OnSedeGuardada();
                    this.Close();
                }
            }
        }

        private async void cbPais_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbPais.DataSource != null)
            {
                if((int)cbPais.SelectedValue > 0)
                {
                    string id = cbPais.SelectedValue.ToString();
                    await FG.CargarCombos(cbDepartamento, "departamento", id, 0);
                    cbDepartamento.Enabled = true;
                }
            }
        }

        private async void cbDepartamento_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(cbDepartamento.DataSource != null)
            {
                if ((int)cbDepartamento.SelectedValue > 0)
                {
                    string id = cbDepartamento.SelectedValue.ToString();
                    await FG.CargarCombos(cbCiudad, "ciudad", id, 0);
                    cbCiudad.Enabled = true;
                }
            }
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
    }
}
