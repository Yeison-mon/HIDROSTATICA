namespace MIS.Vistas.Laboratorio
{
    partial class FormSensor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSensor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            labelDescripcion = new System.Windows.Forms.Label();
            tcGeneral = new System.Windows.Forms.TabControl();
            tpRegistro = new System.Windows.Forms.TabPage();
            panelRecepcion = new System.Windows.Forms.Panel();
            Grafica = new OxyPlot.WindowsForms.PlotView();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            cbModelos = new System.Windows.Forms.ComboBox();
            lbModelos = new System.Windows.Forms.Label();
            txtDimensiones = new System.Windows.Forms.TextBox();
            txtSerie = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lbEquipo = new System.Windows.Forms.Label();
            cbHerraminetas = new System.Windows.Forms.ComboBox();
            cbMarcas = new System.Windows.Forms.ComboBox();
            lbMarca = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            txtObservacion = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            tableLayoutPanelContainer2 = new System.Windows.Forms.TableLayoutPanel();
            label14 = new System.Windows.Forms.Label();
            lbCliente = new System.Windows.Forms.Label();
            txtCliente = new System.Windows.Forms.TextBox();
            lbSede = new System.Windows.Forms.Label();
            cbSedes = new System.Windows.Forms.ComboBox();
            lbContacto = new System.Windows.Forms.Label();
            cbContactos = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelCliente = new System.Windows.Forms.Label();
            btnComenzar = new System.Windows.Forms.Button();
            btnDetener = new System.Windows.Forms.Button();
            txtMin = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtMax = new System.Windows.Forms.TextBox();
            txtTiempo = new System.Windows.Forms.TextBox();
            cbSensores = new System.Windows.Forms.ComboBox();
            label13 = new System.Windows.Forms.Label();
            dtFecha = new System.Windows.Forms.DateTimePicker();
            txtNro = new System.Windows.Forms.TextBox();
            checkTemperatura = new System.Windows.Forms.CheckBox();
            checkPSI = new System.Windows.Forms.CheckBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            tableLayoutPanelContenedorPrincipar = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            btnExportar = new System.Windows.Forms.Button();
            btnImagen = new System.Windows.Forms.Button();
            btnCliente = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnImprimir = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            tpConsultar = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            tablaConsulta = new System.Windows.Forms.DataGridView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            txtFiltro = new System.Windows.Forms.TextBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            txtCInspeccion = new System.Windows.Forms.TextBox();
            dtpCHasta = new System.Windows.Forms.DateTimePicker();
            dtpCDesde = new System.Windows.Forms.DateTimePicker();
            txtCNro = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnConsultar = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tcGeneral.SuspendLayout();
            tpRegistro.SuspendLayout();
            panelRecepcion.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanelContainer2.SuspendLayout();
            panel2.SuspendLayout();
            tpConsultar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaConsulta).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // labelDescripcion
            // 
            labelDescripcion.BackColor = System.Drawing.Color.FromArgb(78, 233, 15);
            labelDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            labelDescripcion.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelDescripcion.ForeColor = System.Drawing.Color.Black;
            labelDescripcion.Location = new System.Drawing.Point(0, 0);
            labelDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new System.Drawing.Size(1370, 74);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "PRUEBA HIDROSTATICA";
            labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcGeneral
            // 
            tcGeneral.Controls.Add(tpRegistro);
            tcGeneral.Controls.Add(tpConsultar);
            tcGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            tcGeneral.Font = new System.Drawing.Font("Calibri", 12F);
            tcGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            tcGeneral.Location = new System.Drawing.Point(0, 74);
            tcGeneral.Margin = new System.Windows.Forms.Padding(0);
            tcGeneral.Name = "tcGeneral";
            tcGeneral.Padding = new System.Drawing.Point(5, 3);
            tcGeneral.SelectedIndex = 0;
            tcGeneral.Size = new System.Drawing.Size(1370, 894);
            tcGeneral.TabIndex = 3;
            tcGeneral.TabStop = false;
            // 
            // tpRegistro
            // 
            tpRegistro.AutoScroll = true;
            tpRegistro.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tpRegistro.Controls.Add(panelRecepcion);
            tpRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            tpRegistro.ForeColor = System.Drawing.Color.White;
            tpRegistro.Location = new System.Drawing.Point(4, 28);
            tpRegistro.Margin = new System.Windows.Forms.Padding(0);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Size = new System.Drawing.Size(1362, 862);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            // 
            // panelRecepcion
            // 
            panelRecepcion.AutoScroll = true;
            panelRecepcion.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panelRecepcion.Controls.Add(Grafica);
            panelRecepcion.Controls.Add(tableLayoutPanel3);
            panelRecepcion.Controls.Add(tableLayoutPanelContainer2);
            panelRecepcion.Controls.Add(tableLayoutPanelContenedorPrincipar);
            panelRecepcion.Controls.Add(panel2);
            panelRecepcion.Dock = System.Windows.Forms.DockStyle.Top;
            panelRecepcion.Location = new System.Drawing.Point(0, 0);
            panelRecepcion.Margin = new System.Windows.Forms.Padding(0);
            panelRecepcion.Name = "panelRecepcion";
            panelRecepcion.Padding = new System.Windows.Forms.Padding(12, 30, 12, 12);
            panelRecepcion.Size = new System.Drawing.Size(1345, 924);
            panelRecepcion.TabIndex = 2;
            // 
            // Grafica
            // 
            Grafica.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Grafica.Location = new System.Drawing.Point(12, 193);
            Grafica.Name = "Grafica";
            Grafica.PanCursor = System.Windows.Forms.Cursors.Hand;
            Grafica.Size = new System.Drawing.Size(1321, 400);
            Grafica.TabIndex = 15;
            Grafica.Text = "plotView1";
            Grafica.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            Grafica.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            Grafica.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.64151F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.5849037F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.538229F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.016655F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.932627F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5669956F));
            tableLayoutPanel3.Controls.Add(cbModelos, 5, 0);
            tableLayoutPanel3.Controls.Add(lbModelos, 4, 0);
            tableLayoutPanel3.Controls.Add(txtDimensiones, 3, 1);
            tableLayoutPanel3.Controls.Add(txtSerie, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 2);
            tableLayoutPanel3.Controls.Add(lbEquipo, 0, 0);
            tableLayoutPanel3.Controls.Add(cbHerraminetas, 1, 0);
            tableLayoutPanel3.Controls.Add(cbMarcas, 3, 0);
            tableLayoutPanel3.Controls.Add(lbMarca, 2, 0);
            tableLayoutPanel3.Controls.Add(label15, 0, 1);
            tableLayoutPanel3.Controls.Add(txtObservacion, 0, 3);
            tableLayoutPanel3.Controls.Add(label12, 2, 1);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel3.Location = new System.Drawing.Point(12, 599);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.3716812F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.4867258F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.2389374F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.9026566F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1321, 226);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // cbModelos
            // 
            cbModelos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbModelos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbModelos.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            cbModelos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbModelos.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbModelos.FormattingEnabled = true;
            cbModelos.Location = new System.Drawing.Point(910, 0);
            cbModelos.Margin = new System.Windows.Forms.Padding(7, 0, 12, 0);
            cbModelos.Name = "cbModelos";
            cbModelos.Size = new System.Drawing.Size(244, 27);
            cbModelos.TabIndex = 20;
            // 
            // lbModelos
            // 
            lbModelos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbModelos.BackColor = System.Drawing.Color.Transparent;
            lbModelos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbModelos.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbModelos.Location = new System.Drawing.Point(786, 0);
            lbModelos.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbModelos.Name = "lbModelos";
            lbModelos.Size = new System.Drawing.Size(105, 22);
            lbModelos.TabIndex = 19;
            lbModelos.Text = "Modelos (+)";
            lbModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbModelos.Click += lbModelos_Click;
            // 
            // txtDimensiones
            // 
            txtDimensiones.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtDimensiones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtDimensiones.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtDimensiones.Location = new System.Drawing.Point(549, 37);
            txtDimensiones.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtDimensiones.Name = "txtDimensiones";
            txtDimensiones.Size = new System.Drawing.Size(185, 27);
            txtDimensiones.TabIndex = 60;
            txtDimensiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSerie
            // 
            txtSerie.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtSerie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSerie.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtSerie.Location = new System.Drawing.Point(140, 37);
            txtSerie.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new System.Drawing.Size(149, 27);
            txtSerie.TabIndex = 59;
            txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel3.SetColumnSpan(label1, 5);
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label1.Location = new System.Drawing.Point(0, 72);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(891, 30);
            label1.TabIndex = 22;
            label1.Text = "Observación";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEquipo
            // 
            lbEquipo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbEquipo.BackColor = System.Drawing.Color.Transparent;
            lbEquipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbEquipo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbEquipo.Location = new System.Drawing.Point(0, 0);
            lbEquipo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbEquipo.Name = "lbEquipo";
            lbEquipo.Size = new System.Drawing.Size(128, 22);
            lbEquipo.TabIndex = 16;
            lbEquipo.Text = "Herramienta (+)";
            lbEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbEquipo.Click += lbEquipo_Click;
            // 
            // cbHerraminetas
            // 
            cbHerraminetas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbHerraminetas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbHerraminetas.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            cbHerraminetas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbHerraminetas.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbHerraminetas.FormattingEnabled = true;
            cbHerraminetas.Location = new System.Drawing.Point(147, 0);
            cbHerraminetas.Margin = new System.Windows.Forms.Padding(7, 0, 12, 0);
            cbHerraminetas.Name = "cbHerraminetas";
            cbHerraminetas.Size = new System.Drawing.Size(265, 27);
            cbHerraminetas.TabIndex = 17;
            // 
            // cbMarcas
            // 
            cbMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbMarcas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbMarcas.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            cbMarcas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbMarcas.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbMarcas.FormattingEnabled = true;
            cbMarcas.Location = new System.Drawing.Point(556, 0);
            cbMarcas.Margin = new System.Windows.Forms.Padding(7, 0, 12, 0);
            cbMarcas.Name = "cbMarcas";
            cbMarcas.Size = new System.Drawing.Size(218, 27);
            cbMarcas.TabIndex = 19;
            // 
            // lbMarca
            // 
            lbMarca.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbMarca.BackColor = System.Drawing.Color.Transparent;
            lbMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbMarca.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbMarca.Location = new System.Drawing.Point(424, 0);
            lbMarca.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new System.Drawing.Size(113, 22);
            lbMarca.TabIndex = 18;
            lbMarca.Text = "Marcas (+)";
            lbMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbMarca.Click += lbMarca_Click;
            // 
            // label15
            // 
            label15.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label15.BackColor = System.Drawing.Color.Transparent;
            label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label15.Location = new System.Drawing.Point(0, 37);
            label15.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(128, 22);
            label15.TabIndex = 21;
            label15.Text = "Serial";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtObservacion
            // 
            txtObservacion.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtObservacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtObservacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtObservacion.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanel3.SetColumnSpan(txtObservacion, 6);
            txtObservacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtObservacion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtObservacion.Location = new System.Drawing.Point(0, 120);
            txtObservacion.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.ReadOnly = true;
            txtObservacion.Size = new System.Drawing.Size(1309, 94);
            txtObservacion.TabIndex = 15;
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label12.BackColor = System.Drawing.Color.Transparent;
            label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label12.Location = new System.Drawing.Point(424, 37);
            label12.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(113, 22);
            label12.TabIndex = 20;
            label12.Text = "Dimensiones";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelContainer2
            // 
            tableLayoutPanelContainer2.AutoSize = true;
            tableLayoutPanelContainer2.ColumnCount = 10;
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanelContainer2.Controls.Add(label14, 0, 3);
            tableLayoutPanelContainer2.Controls.Add(lbCliente, 0, 0);
            tableLayoutPanelContainer2.Controls.Add(txtCliente, 1, 0);
            tableLayoutPanelContainer2.Controls.Add(lbSede, 0, 1);
            tableLayoutPanelContainer2.Controls.Add(cbSedes, 1, 1);
            tableLayoutPanelContainer2.Controls.Add(lbContacto, 0, 2);
            tableLayoutPanelContainer2.Controls.Add(cbContactos, 1, 2);
            tableLayoutPanelContainer2.Controls.Add(label8, 4, 0);
            tableLayoutPanelContainer2.Controls.Add(label5, 4, 1);
            tableLayoutPanelContainer2.Controls.Add(labelCliente, 4, 2);
            tableLayoutPanelContainer2.Controls.Add(btnComenzar, 4, 3);
            tableLayoutPanelContainer2.Controls.Add(btnDetener, 5, 3);
            tableLayoutPanelContainer2.Controls.Add(txtMin, 5, 2);
            tableLayoutPanelContainer2.Controls.Add(label2, 6, 2);
            tableLayoutPanelContainer2.Controls.Add(txtMax, 7, 2);
            tableLayoutPanelContainer2.Controls.Add(txtTiempo, 5, 1);
            tableLayoutPanelContainer2.Controls.Add(cbSensores, 5, 0);
            tableLayoutPanelContainer2.Controls.Add(label13, 2, 3);
            tableLayoutPanelContainer2.Controls.Add(dtFecha, 3, 3);
            tableLayoutPanelContainer2.Controls.Add(txtNro, 1, 3);
            tableLayoutPanelContainer2.Controls.Add(checkTemperatura, 8, 3);
            tableLayoutPanelContainer2.Controls.Add(checkPSI, 8, 2);
            tableLayoutPanelContainer2.Controls.Add(label10, 9, 2);
            tableLayoutPanelContainer2.Controls.Add(label11, 9, 3);
            tableLayoutPanelContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContainer2.Location = new System.Drawing.Point(12, 30);
            tableLayoutPanelContainer2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContainer2.Name = "tableLayoutPanelContainer2";
            tableLayoutPanelContainer2.RowCount = 4;
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelContainer2.Size = new System.Drawing.Size(1321, 160);
            tableLayoutPanelContainer2.TabIndex = 7;
            // 
            // label14
            // 
            label14.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label14.BackColor = System.Drawing.Color.Transparent;
            label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label14.Location = new System.Drawing.Point(0, 120);
            label14.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(99, 28);
            label14.TabIndex = 58;
            label14.Text = "Nro";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCliente
            // 
            lbCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbCliente.BackColor = System.Drawing.Color.Transparent;
            lbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbCliente.Location = new System.Drawing.Point(0, 0);
            lbCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbCliente.Name = "lbCliente";
            lbCliente.Size = new System.Drawing.Size(99, 28);
            lbCliente.TabIndex = 29;
            lbCliente.Text = "Cliente";
            lbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtCliente.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtCliente, 3);
            txtCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCliente.Location = new System.Drawing.Point(111, 0);
            txtCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(356, 27);
            txtCliente.TabIndex = 30;
            // 
            // lbSede
            // 
            lbSede.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbSede.BackColor = System.Drawing.Color.Transparent;
            lbSede.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbSede.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbSede.Location = new System.Drawing.Point(0, 40);
            lbSede.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbSede.Name = "lbSede";
            lbSede.Size = new System.Drawing.Size(99, 28);
            lbSede.TabIndex = 50;
            lbSede.Text = "Sede (+)";
            lbSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbSede.Click += lbSede_Click;
            // 
            // cbSedes
            // 
            cbSedes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbSedes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbSedes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbSedes.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(cbSedes, 3);
            cbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbSedes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbSedes.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbSedes.FormattingEnabled = true;
            cbSedes.Location = new System.Drawing.Point(111, 40);
            cbSedes.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbSedes.Name = "cbSedes";
            cbSedes.Size = new System.Drawing.Size(356, 27);
            cbSedes.TabIndex = 51;
            // 
            // lbContacto
            // 
            lbContacto.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbContacto.BackColor = System.Drawing.Color.Transparent;
            lbContacto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbContacto.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbContacto.Location = new System.Drawing.Point(0, 80);
            lbContacto.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            lbContacto.Name = "lbContacto";
            lbContacto.Size = new System.Drawing.Size(99, 28);
            lbContacto.TabIndex = 52;
            lbContacto.Text = "Contacto (+)";
            lbContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbContacto.Click += lbContacto_Click;
            // 
            // cbContactos
            // 
            cbContactos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbContactos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbContactos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbContactos.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(cbContactos, 3);
            cbContactos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbContactos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbContactos.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbContactos.FormattingEnabled = true;
            cbContactos.Location = new System.Drawing.Point(111, 80);
            cbContactos.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbContactos.Name = "cbContactos";
            cbContactos.Size = new System.Drawing.Size(356, 27);
            cbContactos.TabIndex = 53;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label8.Location = new System.Drawing.Point(479, 0);
            label8.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(188, 28);
            label8.TabIndex = 21;
            label8.Text = "Sensor";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label5.Location = new System.Drawing.Point(479, 40);
            label5.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(188, 28);
            label5.TabIndex = 27;
            label5.Text = "Tiempo de lectura (ms)";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCliente
            // 
            labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelCliente.BackColor = System.Drawing.Color.Transparent;
            labelCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            labelCliente.Location = new System.Drawing.Point(479, 80);
            labelCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new System.Drawing.Size(188, 28);
            labelCliente.TabIndex = 14;
            labelCliente.Text = "Min";
            labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnComenzar
            // 
            btnComenzar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnComenzar.BackColor = System.Drawing.Color.FromArgb(128, 255, 128);
            btnComenzar.FlatAppearance.BorderSize = 0;
            btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnComenzar.ForeColor = System.Drawing.Color.Black;
            btnComenzar.Location = new System.Drawing.Point(580, 120);
            btnComenzar.Margin = new System.Windows.Forms.Padding(0);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnComenzar.Size = new System.Drawing.Size(99, 40);
            btnComenzar.TabIndex = 24;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = false;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnDetener.BackColor = System.Drawing.Color.Salmon;
            btnDetener.FlatAppearance.BorderSize = 0;
            btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDetener.ForeColor = System.Drawing.Color.Black;
            btnDetener.Location = new System.Drawing.Point(679, 120);
            btnDetener.Margin = new System.Windows.Forms.Padding(0);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new System.Drawing.Size(93, 40);
            btnDetener.TabIndex = 25;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // txtMin
            // 
            txtMin.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtMin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMin.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtMin.Location = new System.Drawing.Point(679, 80);
            txtMin.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtMin.Name = "txtMin";
            txtMin.Size = new System.Drawing.Size(85, 27);
            txtMin.TabIndex = 19;
            txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label2.Location = new System.Drawing.Point(816, 80);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 28);
            label2.TabIndex = 20;
            label2.Text = "Max";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMax
            // 
            txtMax.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtMax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtMax.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtMax.Location = new System.Drawing.Point(930, 80);
            txtMax.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtMax.Name = "txtMax";
            txtMax.Size = new System.Drawing.Size(97, 27);
            txtMax.TabIndex = 3;
            txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTiempo
            // 
            txtTiempo.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtTiempo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTiempo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtTiempo.Location = new System.Drawing.Point(679, 40);
            txtTiempo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new System.Drawing.Size(57, 27);
            txtTiempo.TabIndex = 28;
            txtTiempo.Text = "1000";
            txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            txtTiempo.TextChanged += txtTiempo_TextChanged;
            // 
            // cbSensores
            // 
            cbSensores.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbSensores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbSensores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbSensores.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(cbSensores, 3);
            cbSensores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSensores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cbSensores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbSensores.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbSensores.FormattingEnabled = true;
            cbSensores.Location = new System.Drawing.Point(679, 0);
            cbSensores.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbSensores.Name = "cbSensores";
            cbSensores.Size = new System.Drawing.Size(356, 27);
            cbSensores.TabIndex = 1;
            // 
            // label13
            // 
            label13.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label13.BackColor = System.Drawing.Color.Transparent;
            label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label13.Location = new System.Drawing.Point(208, 120);
            label13.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(72, 28);
            label13.TabIndex = 54;
            label13.Text = "Fecha";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFecha
            // 
            dtFecha.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFecha.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFecha.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtFecha.Location = new System.Drawing.Point(292, 120);
            dtFecha.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtFecha.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtFecha.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new System.Drawing.Size(116, 24);
            dtFecha.TabIndex = 55;
            // 
            // txtNro
            // 
            txtNro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtNro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtNro.Location = new System.Drawing.Point(111, 120);
            txtNro.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtNro.Name = "txtNro";
            txtNro.Size = new System.Drawing.Size(85, 27);
            txtNro.TabIndex = 57;
            txtNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtNro.TextChanged += txtNro_TextChanged;
            txtNro.KeyPress += txtNro_KeyPress;
            // 
            // checkTemperatura
            // 
            checkTemperatura.AutoSize = true;
            checkTemperatura.Checked = true;
            checkTemperatura.CheckState = System.Windows.Forms.CheckState.Checked;
            checkTemperatura.Location = new System.Drawing.Point(1050, 123);
            checkTemperatura.Name = "checkTemperatura";
            checkTemperatura.Size = new System.Drawing.Size(25, 23);
            checkTemperatura.TabIndex = 59;
            checkTemperatura.Text = "checkBox1";
            checkTemperatura.UseVisualStyleBackColor = true;
            checkTemperatura.CheckedChanged += checkTemperatura_CheckedChanged;
            // 
            // checkPSI
            // 
            checkPSI.AutoSize = true;
            checkPSI.Checked = true;
            checkPSI.CheckState = System.Windows.Forms.CheckState.Checked;
            checkPSI.Location = new System.Drawing.Point(1050, 83);
            checkPSI.Name = "checkPSI";
            checkPSI.Size = new System.Drawing.Size(25, 23);
            checkPSI.TabIndex = 60;
            checkPSI.Text = "checkBox2";
            checkPSI.UseVisualStyleBackColor = true;
            checkPSI.CheckedChanged += checkPSI_CheckedChanged;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label10.Location = new System.Drawing.Point(1078, 80);
            label10.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(231, 28);
            label10.TabIndex = 61;
            label10.Text = "PSI";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label11.BackColor = System.Drawing.Color.Transparent;
            label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label11.Location = new System.Drawing.Point(1078, 120);
            label11.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(231, 28);
            label11.TabIndex = 62;
            label11.Text = "Temperatura";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelContenedorPrincipar
            // 
            tableLayoutPanelContenedorPrincipar.AutoSize = true;
            tableLayoutPanelContenedorPrincipar.ColumnCount = 2;
            tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedorPrincipar.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContenedorPrincipar.Location = new System.Drawing.Point(12, 30);
            tableLayoutPanelContenedorPrincipar.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContenedorPrincipar.Name = "tableLayoutPanelContenedorPrincipar";
            tableLayoutPanelContenedorPrincipar.RowCount = 1;
            tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            tableLayoutPanelContenedorPrincipar.Size = new System.Drawing.Size(1321, 0);
            tableLayoutPanelContenedorPrincipar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel2.Controls.Add(btnExportar);
            panel2.Controls.Add(btnImagen);
            panel2.Controls.Add(btnCliente);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(btnGuardar);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(12, 825);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1321, 87);
            panel2.TabIndex = 11;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportar.Image = Properties.Resources.importar64;
            btnExportar.Location = new System.Drawing.Point(890, 6);
            btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new System.Drawing.Size(79, 78);
            btnExportar.TabIndex = 21;
            toolTip1.SetToolTip(btnExportar, "Exportar a excel");
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnImagen
            // 
            btnImagen.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnImagen.FlatAppearance.BorderSize = 0;
            btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImagen.Image = Properties.Resources.subirfoto64;
            btnImagen.Location = new System.Drawing.Point(977, 5);
            btnImagen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImagen.Name = "btnImagen";
            btnImagen.Size = new System.Drawing.Size(79, 78);
            btnImagen.TabIndex = 20;
            toolTip1.SetToolTip(btnImagen, "Descargar imagen");
            btnImagen.UseVisualStyleBackColor = true;
            btnImagen.Click += btnImagen_Click;
            // 
            // btnCliente
            // 
            btnCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCliente.Image = Properties.Resources.agregar64;
            btnCliente.Location = new System.Drawing.Point(91, 5);
            btnCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new System.Drawing.Size(79, 78);
            btnCliente.TabIndex = 19;
            toolTip1.SetToolTip(btnCliente, "Nuevo Cliente");
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new System.Drawing.Point(4, 5);
            btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(79, 78);
            btnBuscar.TabIndex = 17;
            toolTip1.SetToolTip(btnBuscar, "Buscar Cliente");
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.limpiar64;
            btnLimpiar.Location = new System.Drawing.Point(1238, 4);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(79, 78);
            btnLimpiar.TabIndex = 16;
            toolTip1.SetToolTip(btnLimpiar, "Limpiar Todo");
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimir.Image = (System.Drawing.Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new System.Drawing.Point(1151, 3);
            btnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(79, 78);
            btnImprimir.TabIndex = 13;
            toolTip1.SetToolTip(btnImprimir, "Imprimirr Informe");
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(1064, 4);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(79, 78);
            btnGuardar.TabIndex = 11;
            toolTip1.SetToolTip(btnGuardar, "Guardar Informe");
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // tpConsultar
            // 
            tpConsultar.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tpConsultar.Controls.Add(panel1);
            tpConsultar.ForeColor = System.Drawing.Color.White;
            tpConsultar.Location = new System.Drawing.Point(4, 28);
            tpConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpConsultar.Name = "tpConsultar";
            tpConsultar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tpConsultar.Size = new System.Drawing.Size(1362, 862);
            tpConsultar.TabIndex = 1;
            tpConsultar.Text = "Consultar";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel1.Controls.Add(tablaConsulta);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(tableLayoutPanel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 3);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12);
            panel1.Size = new System.Drawing.Size(1354, 856);
            panel1.TabIndex = 3;
            // 
            // tablaConsulta
            // 
            tablaConsulta.AllowUserToAddRows = false;
            tablaConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            tablaConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            tablaConsulta.BackgroundColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tablaConsulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            tablaConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tablaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(60, 120, 216);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            tablaConsulta.DefaultCellStyle = dataGridViewCellStyle2;
            tablaConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            tablaConsulta.EnableHeadersVisualStyles = false;
            tablaConsulta.GridColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaConsulta.Location = new System.Drawing.Point(12, 158);
            tablaConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablaConsulta.MultiSelect = false;
            tablaConsulta.Name = "tablaConsulta";
            tablaConsulta.ReadOnly = true;
            tablaConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tablaConsulta.RowHeadersVisible = false;
            tablaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            tablaConsulta.Size = new System.Drawing.Size(1330, 599);
            tablaConsulta.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.919F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84735F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.93347F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.17048F));
            tableLayoutPanel4.Controls.Add(label3, 2, 1);
            tableLayoutPanel4.Controls.Add(txtFiltro, 3, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel4.Location = new System.Drawing.Point(12, 85);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1330, 73);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label3.Location = new System.Drawing.Point(661, 35);
            label3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(280, 24);
            label3.TabIndex = 7;
            label3.Text = "Filtro";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtFiltro.Location = new System.Drawing.Point(953, 35);
            txtFiltro.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new System.Drawing.Size(259, 27);
            txtFiltro.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel5.Location = new System.Drawing.Point(12, 85);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new System.Drawing.Size(1330, 0);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.08411F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.87539F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.99377F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.89096F));
            tableLayoutPanel8.Controls.Add(txtCInspeccion, 1, 1);
            tableLayoutPanel8.Controls.Add(dtpCHasta, 3, 1);
            tableLayoutPanel8.Controls.Add(dtpCDesde, 2, 1);
            tableLayoutPanel8.Controls.Add(txtCNro, 0, 1);
            tableLayoutPanel8.Controls.Add(label7, 3, 0);
            tableLayoutPanel8.Controls.Add(label6, 2, 0);
            tableLayoutPanel8.Controls.Add(label4, 0, 0);
            tableLayoutPanel8.Controls.Add(label9, 1, 0);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel8.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel8.Size = new System.Drawing.Size(1330, 73);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // txtCInspeccion
            // 
            txtCInspeccion.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtCInspeccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCInspeccion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCInspeccion.Location = new System.Drawing.Point(174, 35);
            txtCInspeccion.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCInspeccion.Name = "txtCInspeccion";
            txtCInspeccion.Size = new System.Drawing.Size(132, 27);
            txtCInspeccion.TabIndex = 11;
            // 
            // dtpCHasta
            // 
            dtpCHasta.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCHasta.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCHasta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpCHasta.Location = new System.Drawing.Point(531, 35);
            dtpCHasta.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtpCHasta.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpCHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCHasta.Name = "dtpCHasta";
            dtpCHasta.Size = new System.Drawing.Size(116, 24);
            dtpCHasta.TabIndex = 12;
            // 
            // dtpCDesde
            // 
            dtpCDesde.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCDesde.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCDesde.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpCDesde.Location = new System.Drawing.Point(372, 35);
            dtpCDesde.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtpCDesde.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpCDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCDesde.Name = "dtpCDesde";
            dtpCDesde.Size = new System.Drawing.Size(100, 24);
            dtpCDesde.TabIndex = 11;
            // 
            // txtCNro
            // 
            txtCNro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtCNro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCNro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCNro.Location = new System.Drawing.Point(0, 35);
            txtCNro.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCNro.Name = "txtCNro";
            txtCNro.Size = new System.Drawing.Size(125, 27);
            txtCNro.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label7.Location = new System.Drawing.Point(531, 0);
            label7.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(787, 23);
            label7.TabIndex = 7;
            label7.Text = "Hasta";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label6.Location = new System.Drawing.Point(372, 0);
            label6.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(147, 23);
            label6.TabIndex = 6;
            label6.Text = "Desde";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label4.Location = new System.Drawing.Point(0, 0);
            label4.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 23);
            label4.TabIndex = 4;
            label4.Text = "Recepcion";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label9.Location = new System.Drawing.Point(174, 0);
            label9.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(186, 23);
            label9.TabIndex = 13;
            label9.Text = "Inspeccion";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel3.Controls.Add(btnConsultar);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(12, 757);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1330, 87);
            panel3.TabIndex = 11;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.Image = (System.Drawing.Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new System.Drawing.Point(5, -8);
            btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(79, 78);
            btnConsultar.TabIndex = 10;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FormSensor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1370, 968);
            Controls.Add(tcGeneral);
            Controls.Add(labelDescripcion);
            Name = "FormSensor";
            Text = "FormSensor";
            tcGeneral.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            panelRecepcion.ResumeLayout(false);
            panelRecepcion.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanelContainer2.ResumeLayout(false);
            tableLayoutPanelContainer2.PerformLayout();
            panel2.ResumeLayout(false);
            tpConsultar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaConsulta).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TabControl tcGeneral;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.Panel panelRecepcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer2;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorPrincipar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox txtCInspeccion;
        private System.Windows.Forms.DateTimePicker dtpCHasta;
        private System.Windows.Forms.DateTimePicker dtpCDesde;
        private System.Windows.Forms.TextBox txtCNro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.ComboBox cbSensores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempo;
        private OxyPlot.WindowsForms.PlotView Grafica;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lbSede;
        private System.Windows.Forms.ComboBox cbSedes;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.ComboBox cbContactos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkPSI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkTemperatura;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.ComboBox cbHerraminetas;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.ComboBox cbMarcas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtDimensiones;
        private System.Windows.Forms.ComboBox cbModelos;
        private System.Windows.Forms.Label lbModelos;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnExportar;
    }
}