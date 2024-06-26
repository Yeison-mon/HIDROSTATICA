namespace MIS.Vistas.Laboratorio
{
    partial class FormProcesoFinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcesoFinal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            labelDescripcion = new System.Windows.Forms.Label();
            tcGeneral = new System.Windows.Forms.TabControl();
            tpRegistro = new System.Windows.Forms.TabPage();
            panelRecepcion = new System.Windows.Forms.Panel();
            tablaDetalle = new System.Windows.Forms.DataGridView();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            txtObservacion = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanelContainer2 = new System.Windows.Forms.TableLayoutPanel();
            dtFechaIPF = new System.Windows.Forms.DateTimePicker();
            labelCliente = new System.Windows.Forms.Label();
            txtCliente = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtNroIPF = new System.Windows.Forms.TextBox();
            labelNumero = new System.Windows.Forms.Label();
            txtNroODT = new System.Windows.Forms.TextBox();
            txtEstado = new System.Windows.Forms.TextBox();
            labelEstado = new System.Windows.Forms.Label();
            labelFecha = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            dtFechaODT = new System.Windows.Forms.DateTimePicker();
            tableLayoutPanelContenedorPrincipar = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            btnLimpiar = new System.Windows.Forms.Button();
            btnImprimir = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            tpConsultar = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            tablaConsulta = new System.Windows.Forms.DataGridView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            txtFiltro = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            cbCCliente = new System.Windows.Forms.ComboBox();
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
            tcGeneral.SuspendLayout();
            tpRegistro.SuspendLayout();
            panelRecepcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
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
            labelDescripcion.Size = new System.Drawing.Size(1541, 74);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "INSPECCIÓN EN PROCESO Y FINAL";
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
            tcGeneral.Size = new System.Drawing.Size(1541, 733);
            tcGeneral.TabIndex = 3;
            tcGeneral.TabStop = false;
            // 
            // tpRegistro
            // 
            tpRegistro.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tpRegistro.Controls.Add(panelRecepcion);
            tpRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            tpRegistro.ForeColor = System.Drawing.Color.White;
            tpRegistro.Location = new System.Drawing.Point(4, 28);
            tpRegistro.Margin = new System.Windows.Forms.Padding(0);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Size = new System.Drawing.Size(1533, 701);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            // 
            // panelRecepcion
            // 
            panelRecepcion.AutoScroll = true;
            panelRecepcion.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panelRecepcion.Controls.Add(tablaDetalle);
            panelRecepcion.Controls.Add(tableLayoutPanel3);
            panelRecepcion.Controls.Add(tableLayoutPanelContainer2);
            panelRecepcion.Controls.Add(tableLayoutPanelContenedorPrincipar);
            panelRecepcion.Controls.Add(panel2);
            panelRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRecepcion.Location = new System.Drawing.Point(0, 0);
            panelRecepcion.Margin = new System.Windows.Forms.Padding(0);
            panelRecepcion.Name = "panelRecepcion";
            panelRecepcion.Padding = new System.Windows.Forms.Padding(12);
            panelRecepcion.Size = new System.Drawing.Size(1533, 701);
            panelRecepcion.TabIndex = 2;
            // 
            // tablaDetalle
            // 
            tablaDetalle.AllowUserToAddRows = false;
            tablaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            tablaDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            tablaDetalle.BackgroundColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tablaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(60, 120, 216);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            tablaDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            tablaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            tablaDetalle.EnableHeadersVisualStyles = false;
            tablaDetalle.GridColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaDetalle.Location = new System.Drawing.Point(12, 132);
            tablaDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablaDetalle.MultiSelect = false;
            tablaDetalle.Name = "tablaDetalle";
            tablaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tablaDetalle.RowHeadersVisible = false;
            tablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            tablaDetalle.Size = new System.Drawing.Size(1509, 333);
            tablaDetalle.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(txtObservacion, 0, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel3.Location = new System.Drawing.Point(12, 465);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.05042F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.94958F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1509, 137);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // txtObservacion
            // 
            txtObservacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtObservacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtObservacion.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtObservacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtObservacion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtObservacion.Location = new System.Drawing.Point(0, 35);
            txtObservacion.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtObservacion.Multiline = true;
            txtObservacion.Name = "txtObservacion";
            txtObservacion.Size = new System.Drawing.Size(959, 89);
            txtObservacion.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1497, 23);
            label1.TabIndex = 14;
            label1.Text = "Observación";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelContainer2
            // 
            tableLayoutPanelContainer2.AutoSize = true;
            tableLayoutPanelContainer2.ColumnCount = 6;
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 845F));
            tableLayoutPanelContainer2.Controls.Add(dtFechaIPF, 3, 2);
            tableLayoutPanelContainer2.Controls.Add(labelCliente, 0, 0);
            tableLayoutPanelContainer2.Controls.Add(txtCliente, 1, 0);
            tableLayoutPanelContainer2.Controls.Add(label2, 2, 2);
            tableLayoutPanelContainer2.Controls.Add(txtNroIPF, 3, 1);
            tableLayoutPanelContainer2.Controls.Add(labelNumero, 0, 1);
            tableLayoutPanelContainer2.Controls.Add(txtNroODT, 1, 1);
            tableLayoutPanelContainer2.Controls.Add(txtEstado, 5, 0);
            tableLayoutPanelContainer2.Controls.Add(labelEstado, 4, 0);
            tableLayoutPanelContainer2.Controls.Add(labelFecha, 0, 2);
            tableLayoutPanelContainer2.Controls.Add(label8, 2, 1);
            tableLayoutPanelContainer2.Controls.Add(dtFechaODT, 1, 2);
            tableLayoutPanelContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContainer2.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanelContainer2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContainer2.Name = "tableLayoutPanelContainer2";
            tableLayoutPanelContainer2.RowCount = 3;
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelContainer2.Size = new System.Drawing.Size(1509, 120);
            tableLayoutPanelContainer2.TabIndex = 7;
            // 
            // dtFechaIPF
            // 
            dtFechaIPF.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFechaIPF.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFechaIPF.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFechaIPF.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFechaIPF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtFechaIPF.Location = new System.Drawing.Point(390, 80);
            dtFechaIPF.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtFechaIPF.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtFechaIPF.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtFechaIPF.Name = "dtFechaIPF";
            dtFechaIPF.Size = new System.Drawing.Size(110, 24);
            dtFechaIPF.TabIndex = 16;
            // 
            // labelCliente
            // 
            labelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelCliente.BackColor = System.Drawing.Color.Transparent;
            labelCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            labelCliente.Location = new System.Drawing.Point(0, 0);
            labelCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new System.Drawing.Size(113, 28);
            labelCliente.TabIndex = 14;
            labelCliente.Text = "Cliente";
            labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            txtCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtCliente.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtCliente, 3);
            txtCliente.Enabled = false;
            txtCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCliente.Location = new System.Drawing.Point(125, 0);
            txtCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(445, 27);
            txtCliente.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label2.Location = new System.Drawing.Point(263, 80);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(115, 28);
            label2.TabIndex = 15;
            label2.Text = "Fecha (IPF)";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNroIPF
            // 
            txtNroIPF.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtNroIPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNroIPF.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtNroIPF.Location = new System.Drawing.Point(390, 40);
            txtNroIPF.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtNroIPF.Name = "txtNroIPF";
            txtNroIPF.Size = new System.Drawing.Size(109, 27);
            txtNroIPF.TabIndex = 18;
            txtNroIPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelNumero
            // 
            labelNumero.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelNumero.BackColor = System.Drawing.Color.Transparent;
            labelNumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelNumero.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            labelNumero.Location = new System.Drawing.Point(0, 40);
            labelNumero.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new System.Drawing.Size(113, 28);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "ODT";
            labelNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNroODT
            // 
            txtNroODT.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtNroODT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNroODT.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtNroODT.Location = new System.Drawing.Point(125, 40);
            txtNroODT.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtNroODT.Name = "txtNroODT";
            txtNroODT.Size = new System.Drawing.Size(109, 27);
            txtNroODT.TabIndex = 3;
            txtNroODT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEstado
            // 
            txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtEstado.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEstado.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtEstado.Location = new System.Drawing.Point(660, 0);
            txtEstado.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new System.Drawing.Size(110, 27);
            txtEstado.TabIndex = 5;
            // 
            // labelEstado
            // 
            labelEstado.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelEstado.BackColor = System.Drawing.Color.Transparent;
            labelEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelEstado.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            labelEstado.Location = new System.Drawing.Point(582, 0);
            labelEstado.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new System.Drawing.Size(66, 28);
            labelEstado.TabIndex = 11;
            labelEstado.Text = "Estado";
            labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFecha
            // 
            labelFecha.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelFecha.BackColor = System.Drawing.Color.Transparent;
            labelFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelFecha.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            labelFecha.Location = new System.Drawing.Point(0, 80);
            labelFecha.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new System.Drawing.Size(113, 28);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Fecha (ODT)";
            labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label8.Location = new System.Drawing.Point(263, 40);
            label8.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(115, 28);
            label8.TabIndex = 17;
            label8.Text = "Inspección (IPF)";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtFechaODT
            // 
            dtFechaODT.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFechaODT.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFechaODT.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtFechaODT.Enabled = false;
            dtFechaODT.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtFechaODT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtFechaODT.Location = new System.Drawing.Point(125, 80);
            dtFechaODT.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtFechaODT.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtFechaODT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtFechaODT.Name = "dtFechaODT";
            dtFechaODT.Size = new System.Drawing.Size(109, 24);
            dtFechaODT.TabIndex = 7;
            // 
            // tableLayoutPanelContenedorPrincipar
            // 
            tableLayoutPanelContenedorPrincipar.AutoSize = true;
            tableLayoutPanelContenedorPrincipar.ColumnCount = 2;
            tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedorPrincipar.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContenedorPrincipar.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanelContenedorPrincipar.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContenedorPrincipar.Name = "tableLayoutPanelContenedorPrincipar";
            tableLayoutPanelContenedorPrincipar.RowCount = 1;
            tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            tableLayoutPanelContenedorPrincipar.Size = new System.Drawing.Size(1509, 0);
            tableLayoutPanelContenedorPrincipar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(12, 602);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1509, 87);
            panel2.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.limpiar64;
            btnLimpiar.Location = new System.Drawing.Point(264, 4);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(79, 78);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimir.Image = (System.Drawing.Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new System.Drawing.Point(177, 4);
            btnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(79, 78);
            btnImprimir.TabIndex = 13;
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(91, 4);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(79, 78);
            btnGuardar.TabIndex = 11;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new System.Drawing.Point(5, 4);
            btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(79, 78);
            btnBuscar.TabIndex = 10;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            tpConsultar.Size = new System.Drawing.Size(1242, 701);
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
            panel1.Size = new System.Drawing.Size(1234, 695);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tablaConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(60, 120, 216);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            tablaConsulta.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tablaConsulta.RowHeadersVisible = false;
            tablaConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            tablaConsulta.Size = new System.Drawing.Size(1210, 438);
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
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(cbCCliente, 0, 1);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel4.Location = new System.Drawing.Point(12, 85);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1210, 73);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label3.Location = new System.Drawing.Point(602, 35);
            label3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(253, 24);
            label3.TabIndex = 7;
            label3.Text = "Filtro";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtFiltro.Location = new System.Drawing.Point(867, 35);
            txtFiltro.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new System.Drawing.Size(259, 27);
            txtFiltro.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label5.Location = new System.Drawing.Point(0, 0);
            label5.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(362, 23);
            label5.TabIndex = 5;
            label5.Text = "Cliente";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCCliente
            // 
            cbCCliente.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbCCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbCCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbCCliente.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            cbCCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbCCliente.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbCCliente.FormattingEnabled = true;
            cbCCliente.Location = new System.Drawing.Point(0, 35);
            cbCCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbCCliente.Name = "cbCCliente";
            cbCCliente.Size = new System.Drawing.Size(362, 27);
            cbCCliente.TabIndex = 10;
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
            tableLayoutPanel5.Size = new System.Drawing.Size(1210, 0);
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
            tableLayoutPanel8.Size = new System.Drawing.Size(1210, 73);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // txtCInspeccion
            // 
            txtCInspeccion.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtCInspeccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCInspeccion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCInspeccion.Location = new System.Drawing.Point(158, 35);
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
            dtpCHasta.Location = new System.Drawing.Point(483, 35);
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
            dtpCDesde.Location = new System.Drawing.Point(338, 35);
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
            txtCNro.Size = new System.Drawing.Size(132, 27);
            txtCNro.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label7.Location = new System.Drawing.Point(483, 0);
            label7.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(715, 23);
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
            label6.Location = new System.Drawing.Point(338, 0);
            label6.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(133, 23);
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
            label4.Size = new System.Drawing.Size(146, 23);
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
            label9.Location = new System.Drawing.Point(158, 0);
            label9.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(168, 23);
            label9.TabIndex = 13;
            label9.Text = "Inspeccion";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel3.Controls.Add(btnConsultar);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(12, 596);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1210, 87);
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
            // FormProcesoFinal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1541, 807);
            Controls.Add(tcGeneral);
            Controls.Add(labelDescripcion);
            Name = "FormProcesoFinal";
            Text = "FormProcesoFinal";
            tcGeneral.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            panelRecepcion.ResumeLayout(false);
            panelRecepcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
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
        private System.Windows.Forms.DataGridView tablaDetalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer2;
        private System.Windows.Forms.DateTimePicker dtFechaIPF;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroIPF;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox txtNroODT;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtFechaODT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorPrincipar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCCliente;
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
    }
}