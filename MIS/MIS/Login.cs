using MIS.Vistas;
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Windows.Forms;
using MIS.Modelos.Seguridad;
using System.Data;
using System.Linq;
using MIS.Helpers;

namespace MIS
{
    public partial class Login : Form
    {

        private bool mouseDown;
        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
            

        }
        #region Funcionalidades del Form
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Tittle_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcula la diferencia entre la posición actual del mouse y la última posición registrada
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;

                // Mueve el formulario a la nueva posición
                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void Tittle_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Tittle_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcula la diferencia entre la posición actual del mouse y la última posición registrada
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;

                // Mueve el formulario a la nueva posición
                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown= false;
        }
        #endregion

        private void btnEntrar_ClickAsync(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ejecuta el evento btnEntrar_Click cuando se presiona la tecla "Enter"
                btnEntrar_ClickAsync(sender, e);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enfoca el campo de texto txtPassword cuando se presiona la tecla "Enter"
                txtPassword.Focus();
            }
        }

        private void btnActiva_Click(object sender, EventArgs e)
        {

        }

        private async void IniciarSesion()
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = txtUser.Text;
                string password = txtPassword.Text;
                string ip = string.Empty;
                string mac = string.Empty;

                // Obtener la dirección IP de la computadora local
                IPAddress ipv4Address = Dns.GetHostEntry(Dns.GetHostName())
                                   .AddressList
                                   .FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                if (ipv4Address != null)
                {
                    ip = ipv4Address.ToString();
                }

                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface networkInterface in networkInterfaces)
                {
                    if (networkInterface.OperationalStatus == OperationalStatus.Up && networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        mac = networkInterface.GetPhysicalAddress().ToString();
                        break;
                    }
                }


                InicioSesion userRepository = new InicioSesion();
                DataTable user = await userRepository.ValidateUserAsync(username, password, ip, mac);
                if (user != null && user.Rows.Count > 0)
                {
                    FG.UserId = Convert.ToInt32(user.Rows[0]["id"]);
                    FG.UserName = user.Rows[0]["nombrecompleto"].ToString();
                    FG.Cargo = user.Rows[0]["cargo"].ToString().ToUpper();
                    Inicio inicio = new Inicio();
                    this.Hide();
                    inicio.Show();
                }
            }
        }
    }
}
