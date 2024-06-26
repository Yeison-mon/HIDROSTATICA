using MIS.Modelos.Seguridad;
using MIS.Vistas.Comercial;
using MIS.Vistas.Configuracion;
using MIS.Vistas.Laboratorio;
using MIS.Vistas.Recepcion;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MIS.Vistas
{
    public partial class Inicio : Form
    {

        private bool menuAbierto = false;
        private bool mouseDown;
        private Point lastLocation;
        
        public Inicio()
        {
            InitializeComponent();
            customizaDesing();
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.DoubleBuffered = true;
            AbrirFormulario<FormDashboard>();
            btnDashboard.BackColor = Color.FromArgb(50, 50, 50);
            panelMenu.Width = 100; // Establece el ancho del panel a cero para ocultarlo
            btnMenu.Image = Properties.Resources.LogoCircular;
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.Size = new Size(100, 100);
            btnMenu.Location = new Point(0, 5);
            btnDashboard.Text = "";
            btnMRecepcion.Text = "";
            btnMComercial.Text = "";
            btnMConfiguracion.Text = "";
            btnLaboratorio.Text = "";
            btnSalir.Text = "";
        }
        #region Funcionalidades formulario
        private void Tittle_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Tittle_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            InicioSesion cerrar = new InicioSesion();
            if (cerrar.CerrarSesion())
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        
        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*
        
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        */
        /*
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(64,64,64));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        */
        int lx, ly;
        int sw, sh;
        private void maximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            maximizar.Visible = false;
            contraer.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        
        private void contraer_Click(object sender, EventArgs e)
        {
            maximizar.Visible = true;
            contraer.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }
        

        private void btnMenu_Click(object sender, EventArgs e)
        {
            InteraccionMenu();
            hideSubmenu();
        }


        private void InteraccionMenu()
        {
            if (menuAbierto)
            {

                // Si el menú está abierto, cierra el menú
                panelMenu.Width = 100; // Establece el ancho del panel a cero para ocultarlo
                btnMenu.Image = Properties.Resources.LogoCircular;
                btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
                btnMenu.Size = new Size(100, 100);
                btnMenu.Location = new Point(0, 5);
                menuAbierto = false; // Actualiza el estado del menú
                btnDashboard.Text = "";
                btnMRecepcion.Text = "";
                btnMComercial.Text = "";
                btnMConfiguracion.Text = "";
                btnLaboratorio.Text = "";
                btnSalir.Text = "";
                hideSubmenu();

            }
            else
            {
                // Si el menú está cerrado, ábrelo
                panelMenu.Width = 250; // Establece el ancho del panel según tu preferencia
                btnMenu.Image = Properties.Resources.LogoRectangular;
                btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
                btnMenu.Size = new Size(250, 57);
                btnMenu.Location = new Point(0, 15);
                menuAbierto = true; // Actualiza el estado del menú
                btnDashboard.Text = "INICIO";
                btnMRecepcion.Text = "RECEPCIÓN";
                btnMComercial.Text = "COMERCIAL";
                btnMConfiguracion.Text = "CONFIGURACIÓN";
                btnLaboratorio.Text = "";
                btnSalir.Text = "SALIR";
            }
        }
        #endregion


        // Abrir Formulario dentro del panel
        private Form formularioActual;
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            // Cerrar el formulario actual si existe
            if (formularioActual != null && !formularioActual.IsDisposed)
            {
                formularioActual.Close();
            }

            Form formulario;
            formulario = panelContenedorForms.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formularioActual = formulario; // Actualiza la referencia al formulario actual
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenedorForms.Controls.Add(formulario);
                panelContenedorForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }



        #region Botones Menu
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormDashboard>();
            btnDashboard.BackColor = Color.FromArgb(50, 50, 50);
        }
        

        private void btnSubRecep_RegistroEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormRecepcion>();
            btnMRecepcion.BackColor = Color.FromArgb(50, 50, 50);
            hideSubmenu();
        }

        private void ValidarMenu()
        {
            if (!menuAbierto)
            {   // Si el menú está cerrado, ábrelo
                panelMenu.Width = 250; // Establece el ancho del panel según tu preferencia
                btnMenu.Image = Properties.Resources.LogoRectangular;
                btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
                btnMenu.Size = new Size(250, 57);
                btnMenu.Location = new Point(0, 15);
                menuAbierto = true; // Actualiza el estado del menú
                btnDashboard.Text = "INICIO";
                btnMRecepcion.Text = "RECEPCIÓN";
                btnMComercial.Text = "COMERCIAL";
                btnMConfiguracion.Text = "CONFIGURACIÓN";
                btnLaboratorio.Text = "LABORATORIO";
                btnSalir.Text = "SALIR";
            }
        }
        private void btnMRecepcion_Click(object sender, EventArgs e)
        {
            ValidarMenu();
            showSubmenu(panelSubrecepcion);
        }

        private void btnMComercial_Click(object sender, EventArgs e)
        {
            ValidarMenu();
            showSubmenu(panelSubComercial);
        }

        private void btnMConfiguracion_Click(object sender, EventArgs e)
        {
            ValidarMenu();
            showSubmenu(panelSubConfiguracion);
        }
        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            ValidarMenu();
            showSubmenu(panelSubLaboratorio);
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["FormDashboard"] == null)
                btnDashboard.BackColor = Color.FromArgb(15, 15, 15);
            if (Application.OpenForms["FormRecepcion"] == null || Application.OpenForms["FormInspeccion"] == null || Application.OpenForms["FormDevolucion"] == null)
                btnMRecepcion.BackColor = Color.FromArgb(15, 15, 15);
            if (Application.OpenForms["FormClientes"] == null)
                btnMConfiguracion.BackColor = Color.FromArgb(15, 15, 15);
            if (Application.OpenForms["FormCotizacion"] == null)
                btnMComercial.BackColor = Color.FromArgb(15, 15, 15);
            if (Application.OpenForms["FormOrdenTrabajo"] == null)
                btnLaboratorio.BackColor = Color.FromArgb(15, 15, 15);
            formularioActual = null;
        }

        private void customizaDesing()
        {
            panelSubrecepcion.Visible = false;
            panelSubConfiguracion.Visible = false;
            panelSubComercial.Visible = false;
            panelSubLaboratorio.Visible = false;
        }

        private void btnSubRecep_RecibirEquipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormInspeccion>();
            btnMRecepcion.BackColor = Color.FromArgb(50, 50, 50);
            hideSubmenu();
        }

        private void btnSubRecep_Devolucion_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void btnSubConf_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormClientes>();
            btnMConfiguracion.BackColor = Color.FromArgb(50, 50, 50);
            hideSubmenu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            InicioSesion cerrar = new InicioSesion();
            if (cerrar.CerrarSesion())
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            InicioSesion cerrar = new InicioSesion();
            if (cerrar.CerrarSesion())
            {
                Login login = new Login();
                login.Show();
            }
        }

        private void btnSubCom_Cotizaciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormCotizacion>();
            btnMComercial.BackColor = Color.FromArgb(50, 50, 50);
            hideSubmenu();
        }

        private void btnSubLab_OrdenTrabajo_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormOrdenTrabajo>();
            btnLaboratorio.BackColor = Color.FromArgb(50, 50, 50);
            hideSubmenu();
        }

        private void btnSubLab_Inspeccion_Click(object sender, EventArgs e)
        {

        }

        private void hideSubmenu()
        {
            if (panelSubrecepcion.Visible == true)
                panelSubrecepcion.Visible = false;
            if (panelSubConfiguracion.Visible == true)
                panelSubConfiguracion.Visible = false;
            if (panelSubComercial.Visible == true)
                panelSubComercial.Visible = false;
            if (panelSubLaboratorio.Visible == true)
                panelSubLaboratorio.Visible = false;
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

    }
}
