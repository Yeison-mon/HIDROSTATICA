using MIS.Modelos.Configuracion;
using System;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{
    public partial class FormContactos : Form
    {
        private int idcliente;
        private int idsede;
        public FormContactos(int _idcliente, int _idsede, string cliente)
        {
            InitializeComponent();
            idcliente = _idcliente;
            idsede = _idsede;
            labelCliente.Text = cliente;
        }
        public event EventHandler ContactoGuardado;

        private void OnContactoGuardada()
        {
            ContactoGuardado?.Invoke(this, EventArgs.Empty);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string correo = txtCorreo.Text;
            string cargo = txtCargo.Text;
            if (nombre == "")
            {
                MessageBox.Show("Debe agregar el nombre del contacto");
                txtNombre.Focus();
                return;
            } else if (telefono == "")
            {
                MessageBox.Show("Debe agregar el telefono/celular del contacto");
                txtTelefono.Focus();
                return;
            } else if(correo == "")
            {
                MessageBox.Show("Debe agregar el correo del contacto");
                txtCorreo.Focus();
                return;
            }
            ClientesRepository guardar = new ClientesRepository();
            bool guardado = await guardar.GuardarContactosModal(idcliente, idsede, nombre, telefono, correo, cargo);
            if (guardado)
            {
                OnContactoGuardada();
                this.Close();
            }
        }
    }
}
