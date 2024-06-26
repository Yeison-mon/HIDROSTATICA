using AForge.Video;
using AForge.Video.DirectShow;
using MIS.Helpers;
using MIS.Modelos.Registros;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MIS.Vistas.Modales
{

    public partial class Camara : Form
    {
 
        private bool HayDispositivos = false;
        private FilterInfoCollection DispositivosDisponibles;
        private VideoCaptureDevice DispositivoActivo;
        private int id = 0;
        private string tipo = "";
        public Camara(int nrocontrol, string informacion, string _tipo)
        {
            InitializeComponent();
            labelPrincipal.Text = "Ingreso nro: " + informacion;
            id = nrocontrol;
            tipo = _tipo;
            BtnCaptura.Focus();
            KeyPress += Camara_KeyPress;
        }
        private void CargarDispositivos()
        {
            DispositivosDisponibles = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDisponibles.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < DispositivosDisponibles.Count; i++)
                    cbDispositivos.Items.Add(DispositivosDisponibles[i].Name.ToString());
                cbDispositivos.Text = DispositivosDisponibles[0].Name.ToString();
            }
            else
                HayDispositivos = false;
        }
        private void Camara_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
            BuscarImagenes();
            if (HayDispositivos)
            {
                ActivarCamara();
            }
        }
        private void CerrarCamara() 
        {
            if(DispositivoActivo != null && DispositivoActivo.IsRunning)
            {
                DispositivoActivo.SignalToStop();
                DispositivoActivo = null;
            }
        }
        private void btnActivar_Click(object sender, EventArgs e)
        {
            ActivarCamara();
        }
        private void ActivarCamara()
        {
            CerrarCamara();
            int i = cbDispositivos.SelectedIndex;
            string nombrecamara = DispositivosDisponibles[i].MonikerString;
            DispositivoActivo = new VideoCaptureDevice(nombrecamara);
            DispositivoActivo.NewFrame += new NewFrameEventHandler(Capturando);
            DispositivoActivo.Start();
        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap) eventArgs.Frame.Clone();
            picPreview.Image = Imagen;
        }
        private void Camara_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarCamara();
            
        }

        private void BtnCaptura_Click(object sender, EventArgs e)
        {
            Capturar();
        }

        private void Capturar()
        {
            if (DispositivoActivo != null && DispositivoActivo.IsRunning)
            {
                picCaptura.Image = picPreview.Image;
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (picCaptura.Image != null)
            {
                string base64 = FG.ImageToBase64(picCaptura.Image, ImageFormat.Jpeg);
                if (base64 != "")
                {
                    switch (tipo)
                    {
                        case "INGRESO":
                            RecepcionRepository guardar = new RecepcionRepository();
                            await guardar.GuardarFotoIngreso(id, base64);
                            break;
                        default: break;
                    }
                    base64 = "";
                    picCaptura.Image = null;
                    BuscarImagenes();
                }
            }
        }

        private async void BuscarImagenes()
        {
            try
            {
                if (id > 0)
                {
                    RecepcionRepository buscar = new RecepcionRepository();
                    var imagenes = await buscar.FotosIngreso(id, tipo);
                    if (imagenes != null && imagenes.Count > 0)
                    {
                        flpFotos.Controls.Clear();
                        int ancho = 60;
                        int alto = 50;
                        foreach (var imagen in imagenes)
                        {
                            string base64 = imagen.Base64.Replace("data:image/jpeg;base64,", "");
                            byte[] imagenBytes = Convert.FromBase64String(base64);
                            Image img = Image.FromStream(new MemoryStream(imagenBytes));
                            PictureBox pictureBox = new PictureBox();
                            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox.Image = img;
                            pictureBox.Width = ancho;
                            pictureBox.Height = alto;
                            pictureBox.Tag = imagen.NroFoto;
                            pictureBox.Click += PictureBox_Click;
                            flpFotos.Controls.Add(pictureBox);
                        }
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar las imagenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            picCaptura.Image = clickedPictureBox.Image;
            picCaptura.Tag = clickedPictureBox.Tag;
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    using (var stream = File.OpenRead(filePath))
                    {
                        // Crear una copia de la imagen antes de asignarla a picCaptura
                        using (Image img = Image.FromStream(stream))
                        {
                            picCaptura.Image = new Bitmap(img);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BuscarImagenes();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((int)picCaptura.Tag > 0)
            {
                RecepcionRepository borrar = new RecepcionRepository();
                await borrar.BorrarFotoIngreso(id, (int)picCaptura.Tag);
                BuscarImagenes();
                picCaptura.Image = null;
            }
        }

        private void Camara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                Capturar();
                e.Handled = true;
            }
        }

        private void cbDispositivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarCamara();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            BtnCaptura.Focus();
        }
    }
}