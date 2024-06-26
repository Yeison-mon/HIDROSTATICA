using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using MIS.Helpers;
using System.Diagnostics;
using MIS.Vistas.Modales;
using MIS.Modelos.Registros;
using OxyPlot.WindowsForms;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using MIS.Modelos.Laboratorio;
using MIS.Modelos;
using Microsoft.Reporting.WinForms;
using OfficeOpenXml;


namespace MIS.Vistas.Laboratorio
{
    public partial class FormSensor : Form
    {
        private SerialPort _serialPort;
        private DataTable _dataTable;
        private System.Windows.Forms.Timer _timer;
        private int _intervalo;
        private PlotModel _plotModel;
        private LineSeries _lineaTemperatura;
        private LineSeries _lineaVariable;
        private double temperatura;
        private double variable;
        private float minPSI, maxPSI;
        private int idcliente = 0;
        private bool simularDatos = false;
        private int hidrostatica = 0;
        public FormSensor()
        {
            CultureInfo culture = new CultureInfo("en-US");
            culture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            InitializeComponent();
            FillComboBoxWithCOMPorts();
            InicializarGrafica();

            _dataTable = new DataTable();
            _dataTable.Columns.Add("Variable", typeof(float));
            _dataTable.Columns.Add("Temperatura", typeof(float));
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += Timer_Tick;
            _timer.Tick += Datos;
            _intervalo = int.TryParse(txtTiempo.Text, out int result) ? result : 1000;
            _timer.Interval = _intervalo;
            this.FormClosing += FormSensor_FormClosing;
            limpiar();
        }

        private void InicializarGrafica()
        {
            _plotModel = new PlotModel { Title = "Datos" };
            _plotModel.Axes.Add(new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "HH:mm:ss",
                Title = "Tiempo",
                IntervalType = DateTimeIntervalType.Seconds,
                MinorIntervalType = DateTimeIntervalType.Seconds,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });
            _plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Temperatura (°C)",
                Minimum = 0,
                Maximum = 100,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot
            });
            _plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Right,
                Title = "Presión (PSI)",
                Minimum = 0,
                Maximum = 10000,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Key = "PressureAxis" // Añade una clave para este eje
            });
            _lineaTemperatura = new LineSeries
            {
                Title = "Temperatura",
                StrokeThickness = 2,
                MarkerType = MarkerType.None,
                MarkerSize = 3,
                Color = OxyColors.BlueViolet
            };
            _lineaVariable = new LineSeries
            {
                Title = "PSI",
                StrokeThickness = 2,
                MarkerType = MarkerType.None,
                MarkerSize = 3,
                Color = OxyColors.Blue,
                YAxisKey = "PressureAxis"
            };
            _plotModel.Series.Add(_lineaTemperatura);
            _plotModel.Series.Add(_lineaVariable);
            Grafica.Model = _plotModel;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                try
                {
                    string data = _serialPort.ReadLine();
                    string[] values = data.Split(',');

                    if (values.Length == 2 &&
                        double.TryParse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double variable) &&
                        (double.TryParse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double temperatura)))
                    {
                        DataRow newRow = _dataTable.NewRow();
                        newRow["Variable"] = variable;
                        newRow["Temperatura"] = temperatura == double.NaN ? 0.0 : temperatura;
                        this.variable = variable;
                        this.temperatura = temperatura == double.NaN ? 0.00 : temperatura;
                        _dataTable.Rows.InsertAt(newRow, 0);
                        btnLimpiar.Visible = true;
                    }
                    else
                    {
                        Debug.WriteLine("Invalid data format or conversion failed.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error reading data: " + ex.Message);
                }
            }
            else if (simularDatos)
            {
                this.variable = 256;
                this.temperatura = 22.50;

                DataRow newRow = _dataTable.NewRow();
                newRow["Variable"] = this.variable;
                newRow["Temperatura"] = this.temperatura;
                _dataTable.Rows.InsertAt(newRow, 0);
                btnLimpiar.Visible = true;
                btnImprimir.Visible = true;
                btnImagen.Visible = true;
                btnExportar.Visible = true;
            }
        }
        private void Datos(object sender, EventArgs e)
        {
            if (_lineaTemperatura != null && _lineaVariable != null)
            {
                _lineaTemperatura.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), 22.01));
                _lineaVariable.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now), this.variable));
                (_plotModel.Axes[0] as DateTimeAxis).Maximum = DateTimeAxis.ToDouble(DateTime.Now);
                if (_lineaTemperatura.Points.Count == 1)
                {
                    (_plotModel.Axes[0] as DateTimeAxis).Minimum = DateTimeAxis.ToDouble(DateTime.Now);
                }
                Grafica.InvalidatePlot(true);
            }
            else
            {
                MessageBox.Show("La serie de temperatura no está inicializada correctamente.");
            }
        }
        private void FormSensor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
                _serialPort.Dispose();
                _serialPort = null;
            }
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
            }
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                FG.ShowAlert("Debe seleccionar un cliente", "Alerta");
                btnBuscar_Click(null, null);
                return;
            }
            else if (cbHerraminetas.DataSource == null || (int)cbHerraminetas.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione la herramienta", "Alerta");
                return;
            }
            else if (cbMarcas.DataSource == null || (int)cbMarcas.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione la Marca", "Alerta");
                return;
            }
            else if (cbModelos.DataSource == null || (int)cbModelos.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione el Modelo", "Alerta");
                return;
            }
            else if (txtSerie.Text == "")
            {
                FG.ShowAlert("Debe agregar la Serie", "Alerta");
                txtSerie.Focus();
                return;
            }
            else if (txtDimensiones.Text == "")
            {
                FG.ShowAlert("Debe agregar las Dimensiones", "Alerta");
                txtSerie.Focus();
                return;
            }

            if (cbSensores.SelectedItem != null)
            {
                string selectedPort = cbSensores.SelectedItem.ToString();

                if (!SerialPort.GetPortNames().Contains(selectedPort))
                {
                    MessageBox.Show($"El puerto {selectedPort} no está disponible o no está conectado.");
                    return;
                }
                try
                {
                    if (!float.TryParse(txtMin.Text, out minPSI))
                    {
                        FG.ShowAlert("Ingrese un valor valido (Valor Mínimo)", "Advertencia");
                        return;
                    }
                    if (!float.TryParse(txtMax.Text, out maxPSI))
                    {
                        FG.ShowAlert("Ingrese un valor valido (Valor Máximo)", "Advertencia");
                        return;
                    }
                    txtMin.Enabled = false;
                    txtMax.Enabled = false;
                    var pressureAxis = _plotModel.Axes.FirstOrDefault(a => a.Key == "PressureAxis") as LinearAxis;
                    if (pressureAxis != null)
                    {
                        double range = maxPSI - minPSI;
                        double increment = range * 0.1;

                        pressureAxis.Minimum = minPSI - increment;
                        pressureAxis.Maximum = maxPSI + increment;
                    }
                    _serialPort = new SerialPort(selectedPort, 9600);
                    _serialPort.Open();
                    int tiempo = int.TryParse(txtTiempo.Text, out int result) ? result : 1;
                    string configuration = $"{tiempo},{minPSI},{maxPSI}";
                    _serialPort.WriteLine(configuration);
                    _timer.Start();
                    btnComenzar.Enabled = false;
                    txtSerie.Enabled = false;
                    txtDimensiones.Enabled = false;
                    cbHerraminetas.Enabled = false;
                    cbMarcas.Enabled = false;
                    cbModelos.Enabled = false;
                    btnDetener.Enabled = true;
                    txtNro.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al abrir el puerto {selectedPort}: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un puerto COM primero.");
            }
        }
        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                txtMin.Enabled = true;
                txtMax.Enabled = true;

                _serialPort.Close();
                _serialPort.Dispose();
                _serialPort = null;
            }
            if (simularDatos)
            {
                simularDatos = false;
            }
            _timer.Stop();
            btnGuardar.Visible = true;
            btnComenzar.Enabled = true;
            btnDetener.Enabled = false;
            txtObservacion.Enabled = true;
            txtObservacion.ReadOnly = false;
            txtNro.Enabled = true;
        }
        private async void limpiar()
        {
            btnDetener_Click(null, null);
            btnLimpiar.Visible = false;
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            btnImagen.Visible = false;
            btnExportar.Visible = false;
            cbSedes.DataSource = null;
            cbContactos.DataSource = null;
            cbHerraminetas.DataSource = null;
            cbHerraminetas.Items.Clear();
            cbMarcas.DataSource = null;
            cbMarcas.Items.Clear();
            cbModelos.DataSource = null;
            cbModelos.Items.Clear();
            txtSerie.Text = "";
            txtDimensiones.Text = "";
            cbSedes.Items.Clear();
            cbContactos.Items.Clear();
            txtCliente.Text = "";
            txtObservacion.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
            checkPSI.Checked = true;
            checkTemperatura.Checked = true;
            idcliente = 0;
            if (_lineaTemperatura != null)
            {
                _lineaTemperatura.Points.Clear();
            }
            if (_lineaVariable != null)
            {
                _lineaVariable.Points.Clear();
            }
            txtObservacion.Enabled = false;
            txtObservacion.ReadOnly = true;
            txtCliente.Enabled = false;
            Grafica.InvalidatePlot(true);
            txtSerie.Enabled = false;
            txtDimensiones.Enabled = false;
            cbHerraminetas.Enabled = false;
            cbMarcas.Enabled = false;
            cbModelos.Enabled = false;
            txtNro.Text = "";
            this.hidrostatica = 0;
            Combos();
        }
        private async void Combos()
        {
            await FG.CargarCombos(cbHerraminetas, "herramientas", "", 0);
            await FG.CargarCombos(cbMarcas, "marcas", "", 0);
            await FG.CargarCombos(cbModelos, "modelos", "", 0);
        }
        private void FillComboBoxWithCOMPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cbSensores.Items.Clear();
            cbSensores.Items.AddRange(ports);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _dataTable.Clear();
            limpiar();
        }
        private void txtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTiempo.Text, out int tiempo) && tiempo >= 200)
            {
                _intervalo = tiempo;
                _timer.Interval = _intervalo;
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    _serialPort.WriteLine(tiempo.ToString());
                }
            }
        }
        private void lbSede_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                MessageBox.Show("Debe de seleccionar el cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                using (FormSedes form = new FormSedes(idcliente, txtCliente.Text))
                {
                    form.SedeGuardada += async (eventSender, args) => await FG.CargarCombos(cbSedes, "sedes", $"{idcliente}", 0);
                    DialogResult result = form.ShowDialog();
                }
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente form = new FormBuscarCliente())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    idcliente = form.idcliente;
                    BuscarCliente(idcliente, "", 0, 0);
                    limpiar();
                }
            }
        }
        private async void BuscarCliente(int id, string documento, int idsede, int idcontacto)
        {
            RecepcionRepository cliente = new RecepcionRepository();
            DataTable tabla = await cliente.BuscarCliente(id, documento);
            if (tabla != null)
            {
                if (tabla.Rows.Count > 0)
                {
                    txtCliente.Text = tabla.Rows[0]["nombrecompleto"].ToString();
                    idcliente = (int)tabla.Rows[0]["id"];
                    await FG.CargarCombos(cbSedes, "sedes", $"{idcliente}", idsede);
                    await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", idcontacto);
                    txtSerie.Enabled = true;
                    txtDimensiones.Enabled = true;
                    cbHerraminetas.Enabled = true;
                    cbMarcas.Enabled = true;
                    cbModelos.Enabled = true;
                    btnLimpiar.Visible = true;
                }
            }
        }
        private void lbContacto_Click(object sender, EventArgs e)
        {
            if (idcliente == 0)
            {
                MessageBox.Show("Debe de seleccionar el cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (cbSedes.DataSource == null || (int)cbSedes.SelectedValue == 0)
            {
                MessageBox.Show("Debe de seleccionar la sede del cliente", "Sugerencias", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                using (FormContactos form = new FormContactos(idcliente, (int)cbSedes.SelectedValue, txtCliente.Text))
                {
                    form.ContactoGuardado += async (eventSender, args) => await FG.CargarCombos(cbContactos, "contactos", $"{idcliente}", 0);
                    DialogResult result = form.ShowDialog();
                }
            }
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            using (FormCliente form = new FormCliente(idcliente))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    idcliente = form.idcliente;
                    BuscarCliente(idcliente, "", 0, 0);
                }
            }
        }
        private void checkPSI_CheckedChanged(object sender, EventArgs e)
        {
            if (_lineaVariable != null)
            {
                _lineaVariable.IsVisible = checkPSI.Checked;
                Grafica.InvalidatePlot(true); // Actualiza la gráfica
            }
            else
            {
                MessageBox.Show("La serie de variable no está inicializada correctamente.");
            }
        }
        private void checkTemperatura_CheckedChanged(object sender, EventArgs e)
        {
            if (_lineaTemperatura != null)
            {
                _lineaTemperatura.IsVisible = checkTemperatura.Checked;
                Grafica.InvalidatePlot(true);
            }
            else
            {
                MessageBox.Show("La serie de temperatura no está inicializada correctamente.");
            }
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string base64imagen = "";

            if (idcliente == 0)
            {
                FG.ShowAlert("No se puede guardar la prueba sin el cliente", "Alerta");
                return;
            }
            else if (cbSedes.DataSource == null || (int)cbSedes.SelectedValue == 0)
            {
                FG.ShowAlert("No se puede guardar la prueba sin la sede del cliente", "Alerta");
                return;
            }
            else if (cbContactos.DataSource == null || (int)cbContactos.SelectedValue == 0)
            {
                FG.ShowAlert("No se puede guardar la prueba sin el contacto del cliente", "Alerta");
                return;
            }
            else if (cbHerraminetas.DataSource == null || (int)cbHerraminetas.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione la herramienta", "Alerta");
                return;
            }
            else if (cbMarcas.DataSource == null || (int)cbMarcas.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione la Marca", "Alerta");
                return;
            }
            else if (cbModelos.DataSource == null || (int)cbModelos.SelectedValue == 0)
            {
                FG.ShowAlert("Seleccione la Marca", "Alerta");
                return;
            }
            else if (txtSerie.Text == "")
            {
                FG.ShowAlert("Debe agregar la Serie", "Alerta");
                txtSerie.Focus();
                return;
            }
            else if (txtDimensiones.Text == "")
            {
                FG.ShowAlert("Debe agregar las Dimensiones", "Alerta");
                txtSerie.Focus();
                return;
            }
            else if (txtMin.Text == "" || txtMax.Text == "")
            {
                FG.ShowAlert("Valores Min y Max PSI faltantes", "Alerta");
                return;
            }
            int idcontacto = (int)cbContactos.SelectedValue;
            int idherramienta = (int)cbHerraminetas.SelectedValue;
            int idmarca = (int)cbMarcas.SelectedValue;
            int idmodelo = (int)cbModelos.SelectedValue;
            string observacion = txtObservacion.Text;
            string serie = txtSerie.Text;
            string dimensiones = txtDimensiones.Text;
            List<double> temperaturas = new List<double>();
            List<double> psis = new List<double>();
            List<DateTime> tiempos = new List<DateTime>();
            int psi_min = Convert.ToInt32(txtMin.Text);
            int psi_max = Convert.ToInt32(txtMax.Text);
            foreach (var point in _lineaTemperatura.Points)
            {
                temperaturas.Add(point.Y);

            }

            foreach (var point in _lineaVariable.Points)
            {
                psis.Add(point.Y);
                tiempos.Add(DateTimeAxis.ToDateTime(point.X));
            }
            if (_plotModel != null)
            {
                int width = 700;
                int height = 500;
                var pngExporter = new PngExporter { Width = width, Height = height, Resolution = 500 };
                using (var stream = new MemoryStream())
                {
                    pngExporter.Export(_plotModel, stream);
                    using (var bitmap = new Bitmap(stream))
                    {
                        base64imagen = FG.ImageToBase64(bitmap, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }
            else
            {
                FG.ShowError("El modelo de la gráfica no está inicializado correctamente.", "Error");
                return;
            }
            HidrostaticaRepository guardar = new HidrostaticaRepository();
            this.hidrostatica = await guardar.GuardarPrueba(this.hidrostatica, base64imagen, idcliente, idcontacto, observacion, psis, temperaturas, tiempos, serie, dimensiones, idherramienta, idmarca, idmodelo, psi_min, psi_max);
            if (this.hidrostatica > 0)
            {
                txtNro.Text = this.hidrostatica.ToString();
                btnImprimir.Visible = true;
                btnImagen.Visible = true;
                btnExportar.Visible = true;
                FG.ShowMsg("PRUEBA GUARDADA CON ÉXITO", "");
            }
            else
            {
                FG.ShowAlert("No se registro la prueba comuniquese con el administrador del sistema", "Alerta");
            }

        }
        private async void btnImprimir_Click(object sender, EventArgs e)
        {

            if (hidrostatica > 0)
            {
                // Obtener el encabezado de la hidrostatica
                HidrostaticaRepository tabla = new HidrostaticaRepository();
                DataTable dt = await tabla.EncabezadoHidrostatica(hidrostatica);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Crear un nuevo control ReportViewer
                    ReportViewer reportViewer1 = new ReportViewer();
                    reportViewer1.ProcessingMode = ProcessingMode.Local;

                    // Usar una ruta relativa para el archivo RDLC
                    string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes", "rpHidrostatica.rdlc");
                    reportViewer1.LocalReport.ReportPath = reportPath; // Ruta al archivo .rdlc
                    reportViewer1.LocalReport.DataSources.Clear();

                    // Agregar el DataTable como fuente de datos del reporte
                    ReportDataSource rds = new ReportDataSource("prueba_hidrostatica", dt);
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // Configurar el tamaño y ubicación del ReportViewer
                    reportViewer1.Dock = DockStyle.Fill;

                    // Agregar el ReportViewer al formulario (si aún no está agregado)
                    if (!this.Controls.Contains(reportViewer1))
                    {
                        this.Controls.Add(reportViewer1);
                    }

                    // Refrescar el reporte
                    reportViewer1.RefreshReport();

                    // Renderizar el reporte a PDF
                    byte[] pdfBytes = reportViewer1.LocalReport.Render(format: "PDF");

                    // Mostrar el diálogo SaveFileDialog para guardar el archivo PDF
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Archivo PDF (*.pdf)|*.pdf";
                    saveFileDialog1.Title = "Guardar Reporte PDF";
                    saveFileDialog1.FileName = $"Reporte_Hidrostatica_{hidrostatica}.pdf"; // Nombre sugerido para el archivo

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF en la ubicación seleccionada
                        string filePath = saveFileDialog1.FileName;
                        File.WriteAllBytes(filePath, pdfBytes);

                        // Mostrar mensaje de éxito
                        MessageBox.Show($"Archivo PDF guardado correctamente en: {filePath}");
                    }
                    else
                    {
                        MessageBox.Show("Se canceló la operación de guardado.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el número de documento proporcionado.");
                }
            }
            else
            {
                MessageBox.Show("No se ha cargado el número de documento");
            }
        }

        private void txtNro_TextChanged(object sender, EventArgs e)
        {
            if (txtNro.Text.Trim().Length == 0)
                limpiar();
        }
        private async void lbEquipo_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("herramientas", texto, "");
                    if (guardadoExitoso)
                    {
                        await FG.CargarCombos(cbHerraminetas, "herramientas", "", 0);
                        cbHerraminetas.SelectedItem = texto;
                    }
                }
            }
        }
        private async void lbMarca_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("marcas", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbMarcas, "marcas", "", 0);
                        cbMarcas.SelectedItem = texto;
                    }
                }
            }
        }
        private async void lbModelos_Click(object sender, EventArgs e)
        {
            if ((int)cbMarcas.SelectedValue > 0)
            {
                string id = cbMarcas.SelectedValue.ToString();
                using (FormAgregarDescripciones form = new FormAgregarDescripciones())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        string texto = form.TextoIngresado;
                        bool guardadoExitoso = await combosRepository.GuardarNuevoValor("modelos", texto, id);
                        if (guardadoExitoso)
                        {

                            await FG.CargarCombos(cbModelos, "modelos", id, 0);
                            cbModelos.SelectedItem = texto;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar la magnitud", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMarcas.Focus();
            }
        }

        private void txtNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Verificar si el texto es un número válido
                int hidrostatica;
                if (int.TryParse(txtNro.Text, out hidrostatica))
                {
                    Buscar(hidrostatica);
                }
                else
                {
                    txtNro.Text = "";
                }
            }
        }

        private async void Buscar(int numero)
        {
            HidrostaticaRepository buscar = new HidrostaticaRepository();
            DataRow data = await buscar.Buscar(numero);
            if (data == null)
            {
                limpiar();
                return;
            }
            BuscarCliente((int)data["idcliente"], "", (int)data["idsede"], (int)data["idcontacto"]);
            cbHerraminetas.DataSource = null;
            cbHerraminetas.Items.Clear();
            await FG.CargarCombos(cbHerraminetas, "herramientas", "", (int)data["idherramienta"]);
            cbMarcas.DataSource = null;
            cbMarcas.Items.Clear();
            await FG.CargarCombos(cbMarcas, "marcas", "", (int)data["idmarca"]);
            cbModelos.DataSource = null;
            cbModelos.Items.Clear();
            await FG.CargarCombos(cbModelos, "modelos", "", (int)data["idmodelo"]);
            txtSerie.Text = data["serie"].ToString();
            txtDimensiones.Text = data["dimensiones"].ToString();
            txtObservacion.Text = data["observacion"].ToString();
            string fechaString = data["fecha"].ToString();
            DateTimeOffset fechaOffset = DateTimeOffset.Parse(fechaString);
            DateTime fechaLocal = fechaOffset.ToLocalTime().DateTime;
            dtFecha.Value = fechaLocal;
            txtNro.Text = data["numero"].ToString();
            this.hidrostatica = (int)data["numero"];
            txtMin.Text = data["psi_min"].ToString();
            txtMax.Text = data["psi_max"].ToString();
            if (!float.TryParse(txtMin.Text, out minPSI))
            {
                FG.ShowAlert("Ingrese un valor valido (Valor Mínimo)", "Advertencia");
                limpiar();
                return;
            }
            if (!float.TryParse(txtMax.Text, out maxPSI))
            {
                FG.ShowAlert("Ingrese un valor valido (Valor Máximo)", "Advertencia");
                limpiar();
                return;
            }
            var pressureAxis = _plotModel.Axes.FirstOrDefault(a => a.Key == "PressureAxis") as LinearAxis;
            if (pressureAxis != null)
            {
                double range = maxPSI - minPSI;
                double increment = range * 0.1;

                pressureAxis.Minimum = minPSI - increment;
                pressureAxis.Maximum = maxPSI + increment;

            }
            double[] psiArray = (double[])data["psiarray"];
            DateTime[] tiempoArray = (DateTime[])data["tiempoarray"];
            double[] temperaturaArray = (double[])data["temarray"];

            // Convertir los DateTime a TimeSpan (segundos desde el inicio)
            TimeSpan[] tiempoInSeconds = tiempoArray.Select(t => t - tiempoArray[0]).ToArray();

            // Llenar el gráfico
            LlenarGrafico(tiempoInSeconds, psiArray, temperaturaArray);
            btnImprimir.Visible = true;
            btnImagen.Visible = true;
            btnExportar.Visible = true;
            btnLimpiar.Visible = true;
            btnGuardar.Visible = true;

        }
        private void LlenarGrafico(TimeSpan[] tiempoInSeconds, double[] psiArray, double[] temperaturaArray)
        {
            _lineaTemperatura.Points.Clear();
            _lineaVariable.Points.Clear();

            for (int i = 0; i < tiempoInSeconds.Length; i++)
            {
                _lineaTemperatura.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now.Date.Add(tiempoInSeconds[i])), temperaturaArray[i]));
                _lineaVariable.Points.Add(new DataPoint(DateTimeAxis.ToDouble(DateTime.Now.Date.Add(tiempoInSeconds[i])), psiArray[i]));
            }

            Grafica.Model.InvalidatePlot(true);
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            if (_plotModel != null)
            {
                int width = 1200;
                int height = 800;
                var pngExporter = new PngExporter { Width = width, Height = height };

                // Crear un Bitmap con fondo blanco
                using (var bitmap = new Bitmap(width, height))
                {
                    using (var graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.Clear(Color.White); // Establecer el fondo blanco
                        using (var stream = new MemoryStream())
                        {
                            pngExporter.Export(_plotModel, stream);
                            stream.Seek(0, SeekOrigin.Begin); // Asegúrate de que la posición del stream esté al inicio
                            using (var image = Image.FromStream(stream))
                            {
                                graphics.DrawImage(image, 0, 0, width, height); // Dibujar la imagen en el Bitmap con fondo blanco
                            }
                        }
                    }

                    // Guardar la imagen en un archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "PNG Image|*.png";
                    saveFileDialog.Title = "Guardar imagen como";
                    saveFileDialog.FileName = "grafico.png";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            MessageBox.Show("Imagen guardada correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                FG.ShowError("El modelo de la gráfica no está inicializado correctamente.", "Error");
                return;
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (_plotModel != null)
            {
                // Crear un SaveFileDialog para elegir la ubicación y el nombre del archivo Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar como archivo Excel";
                saveFileDialog.FileName = "GraficoDatos.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog.FileName != "")
                    {
                        // Obtener los datos de la gráfica
                        var psiSeries = _plotModel.Series.OfType<LineSeries>().FirstOrDefault(s => s.Title == "PSI");
                        var tempSeries = _plotModel.Series.OfType<LineSeries>().FirstOrDefault(s => s.Title == "Temperatura");

                        if (psiSeries == null || tempSeries == null)
                        {
                            MessageBox.Show("Las series de datos no están disponibles en el modelo de gráfico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Obtener los arrays de datos
                        var tiempoArray = psiSeries.Points.Select(p => DateTimeAxis.ToDateTime(p.X)).ToArray();
                        var psiArray = psiSeries.Points.Select(p => p.Y).ToArray();
                        var temperaturaArray = tempSeries.Points.Select(p => p.Y).ToArray();

                        // Convertir el tiempoArray de segundos a formato de fecha y hora
                        DateTime fechaBase = DateTime.MinValue; // Puedes ajustar esto según la fecha base adecuada
                        for (int i = 0; i < tiempoArray.Length; i++)
                        {
                            tiempoArray[i] = fechaBase.AddSeconds(tiempoArray[i].TimeOfDay.TotalSeconds);
                        }

                        // Crear el archivo Excel
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Datos");
                            worksheet.Cells[1, 1].Value = "Tiempo";
                            worksheet.Cells[1, 2].Value = "PSI";
                            worksheet.Cells[1, 3].Value = "Temperatura";
                            for (int i = 0; i < psiArray.Length; i++)
                            {
                                worksheet.Cells[i + 2, 1].Value = tiempoArray[i].ToString("guardarHH:mm:ss");
                                worksheet.Cells[i + 2, 2].Value = psiArray[i];
                                worksheet.Cells[i + 2, 3].Value = temperaturaArray[i];
                            }
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            package.SaveAs(fileInfo);

                            MessageBox.Show("Datos exportados correctamente a Excel.", "Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El modelo de la gráfica no está inicializado correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
