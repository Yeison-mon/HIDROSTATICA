namespace MIS.Vistas.Laboratorio
{
    partial class FormOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenTrabajo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.tpRegistro = new System.Windows.Forms.TabPage();
            this.panelCotizacion = new System.Windows.Forms.Panel();
            this.tablaDetalle = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelContainer2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtODT = new System.Windows.Forms.TextBox();
            this.txtInspeccion = new System.Windows.Forms.TextBox();
            this.cbMetrologo = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelContenedorPrincipar = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAgregarItems = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tpConsultar = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaRecepciones = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpCHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpCDesde = new System.Windows.Forms.DateTimePicker();
            this.cbCCliente = new System.Windows.Forms.ComboBox();
            this.txtCNro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tcGeneral.SuspendLayout();
            this.tpRegistro.SuspendLayout();
            this.panelCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).BeginInit();
            this.tableLayoutPanelContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpConsultar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecepciones)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.labelDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDescripcion.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Black;
            this.labelDescripcion.Location = new System.Drawing.Point(0, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(1375, 64);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "ÓRDEN DE TRABAJO";
            this.labelDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcGeneral
            // 
            this.tcGeneral.Controls.Add(this.tpRegistro);
            this.tcGeneral.Controls.Add(this.tpConsultar);
            this.tcGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGeneral.Font = new System.Drawing.Font("Calibri", 12F);
            this.tcGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tcGeneral.Location = new System.Drawing.Point(0, 64);
            this.tcGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.Padding = new System.Drawing.Point(5, 3);
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(1375, 719);
            this.tcGeneral.TabIndex = 4;
            this.tcGeneral.TabStop = false;
            // 
            // tpRegistro
            // 
            this.tpRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tpRegistro.Controls.Add(this.panelCotizacion);
            this.tpRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tpRegistro.ForeColor = System.Drawing.Color.White;
            this.tpRegistro.Location = new System.Drawing.Point(4, 28);
            this.tpRegistro.Margin = new System.Windows.Forms.Padding(0);
            this.tpRegistro.Name = "tpRegistro";
            this.tpRegistro.Size = new System.Drawing.Size(1367, 687);
            this.tpRegistro.TabIndex = 0;
            this.tpRegistro.Text = "Registro";
            // 
            // panelCotizacion
            // 
            this.panelCotizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelCotizacion.Controls.Add(this.tablaDetalle);
            this.panelCotizacion.Controls.Add(this.tableLayoutPanelContainer2);
            this.panelCotizacion.Controls.Add(this.tableLayoutPanelContenedorPrincipar);
            this.panelCotizacion.Controls.Add(this.panel2);
            this.panelCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCotizacion.Location = new System.Drawing.Point(0, 0);
            this.panelCotizacion.Margin = new System.Windows.Forms.Padding(0);
            this.panelCotizacion.Name = "panelCotizacion";
            this.panelCotizacion.Padding = new System.Windows.Forms.Padding(10);
            this.panelCotizacion.Size = new System.Drawing.Size(1367, 687);
            this.panelCotizacion.TabIndex = 2;
            // 
            // tablaDetalle
            // 
            this.tablaDetalle.AllowUserToAddRows = false;
            this.tablaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaDetalle.EnableHeadersVisualStyles = false;
            this.tablaDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaDetalle.Location = new System.Drawing.Point(10, 121);
            this.tablaDetalle.Margin = new System.Windows.Forms.Padding(0);
            this.tablaDetalle.MultiSelect = false;
            this.tablaDetalle.Name = "tablaDetalle";
            this.tablaDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaDetalle.RowHeadersVisible = false;
            this.tablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaDetalle.Size = new System.Drawing.Size(1347, 481);
            this.tablaDetalle.TabIndex = 19;
            // 
            // tableLayoutPanelContainer2
            // 
            this.tableLayoutPanelContainer2.AutoSize = true;
            this.tableLayoutPanelContainer2.ColumnCount = 6;
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 754F));
            this.tableLayoutPanelContainer2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelContainer2.Controls.Add(this.labelCliente, 0, 0);
            this.tableLayoutPanelContainer2.Controls.Add(this.txtCliente, 1, 0);
            this.tableLayoutPanelContainer2.Controls.Add(this.labelEstado, 4, 0);
            this.tableLayoutPanelContainer2.Controls.Add(this.txtEstado, 5, 0);
            this.tableLayoutPanelContainer2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelContainer2.Controls.Add(this.label9, 2, 1);
            this.tableLayoutPanelContainer2.Controls.Add(this.txtODT, 3, 1);
            this.tableLayoutPanelContainer2.Controls.Add(this.txtInspeccion, 1, 1);
            this.tableLayoutPanelContainer2.Controls.Add(this.cbMetrologo, 1, 2);
            this.tableLayoutPanelContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelContainer2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelContainer2.Name = "tableLayoutPanelContainer2";
            this.tableLayoutPanelContainer2.RowCount = 3;
            this.tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContainer2.Size = new System.Drawing.Size(1347, 111);
            this.tableLayoutPanelContainer2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Metrólogo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCliente.BackColor = System.Drawing.Color.Transparent;
            this.labelCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelCliente.Location = new System.Drawing.Point(0, 0);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(97, 24);
            this.labelCliente.TabIndex = 14;
            this.labelCliente.Text = "Cliente";
            this.labelCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tableLayoutPanelContainer2.SetColumnSpan(this.txtCliente, 3);
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCliente.Location = new System.Drawing.Point(107, 0);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(382, 27);
            this.txtCliente.TabIndex = 5;
            // 
            // labelEstado
            // 
            this.labelEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEstado.BackColor = System.Drawing.Color.Transparent;
            this.labelEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelEstado.Location = new System.Drawing.Point(499, 0);
            this.labelEstado.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(84, 24);
            this.labelEstado.TabIndex = 11;
            this.labelEstado.Text = "Estado";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtEstado.Location = new System.Drawing.Point(593, 0);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(95, 27);
            this.txtEstado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "IR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label9.Location = new System.Drawing.Point(225, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "ODT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtODT
            // 
            this.txtODT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtODT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtODT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtODT.Location = new System.Drawing.Point(330, 37);
            this.txtODT.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtODT.Name = "txtODT";
            this.txtODT.Size = new System.Drawing.Size(94, 27);
            this.txtODT.TabIndex = 18;
            this.txtODT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtODT.TextChanged += new System.EventHandler(this.txtODT_TextChanged);
            this.txtODT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtODT_KeyPress);
            // 
            // txtInspeccion
            // 
            this.txtInspeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtInspeccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInspeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtInspeccion.Location = new System.Drawing.Point(107, 37);
            this.txtInspeccion.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtInspeccion.Name = "txtInspeccion";
            this.txtInspeccion.Size = new System.Drawing.Size(94, 27);
            this.txtInspeccion.TabIndex = 22;
            this.txtInspeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInspeccion.TextChanged += new System.EventHandler(this.txtInspeccion_TextChanged);
            this.txtInspeccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInspeccion_KeyPress);
            // 
            // cbMetrologo
            // 
            this.cbMetrologo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMetrologo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMetrologo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMetrologo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tableLayoutPanelContainer2.SetColumnSpan(this.cbMetrologo, 3);
            this.cbMetrologo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMetrologo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbMetrologo.FormattingEnabled = true;
            this.cbMetrologo.Location = new System.Drawing.Point(107, 74);
            this.cbMetrologo.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbMetrologo.Name = "cbMetrologo";
            this.cbMetrologo.Size = new System.Drawing.Size(382, 27);
            this.cbMetrologo.TabIndex = 24;
            // 
            // tableLayoutPanelContenedorPrincipar
            // 
            this.tableLayoutPanelContenedorPrincipar.AutoSize = true;
            this.tableLayoutPanelContenedorPrincipar.ColumnCount = 2;
            this.tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedorPrincipar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContenedorPrincipar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelContenedorPrincipar.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelContenedorPrincipar.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelContenedorPrincipar.Name = "tableLayoutPanelContenedorPrincipar";
            this.tableLayoutPanelContenedorPrincipar.RowCount = 1;
            this.tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorPrincipar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanelContenedorPrincipar.Size = new System.Drawing.Size(1347, 0);
            this.tableLayoutPanelContenedorPrincipar.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.btnAprobar);
            this.panel2.Controls.Add(this.btnImportar);
            this.panel2.Controls.Add(this.btnAgregarItems);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 602);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1347, 75);
            this.panel2.TabIndex = 11;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAprobar.FlatAppearance.BorderSize = 0;
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobar.Image = global::MIS.Properties.Resources.aprobado_rechazar64;
            this.btnAprobar.Location = new System.Drawing.Point(374, 3);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(68, 68);
            this.btnAprobar.TabIndex = 20;
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Visible = false;
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImportar.FlatAppearance.BorderSize = 0;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Image = global::MIS.Properties.Resources.importar64;
            this.btnImportar.Location = new System.Drawing.Point(78, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(68, 68);
            this.btnImportar.TabIndex = 18;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Visible = false;
            // 
            // btnAgregarItems
            // 
            this.btnAgregarItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarItems.FlatAppearance.BorderSize = 0;
            this.btnAgregarItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarItems.Image = global::MIS.Properties.Resources.agregar64;
            this.btnAgregarItems.Location = new System.Drawing.Point(1269, 4);
            this.btnAgregarItems.Name = "btnAgregarItems";
            this.btnAgregarItems.Size = new System.Drawing.Size(68, 68);
            this.btnAgregarItems.TabIndex = 17;
            this.btnAgregarItems.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::MIS.Properties.Resources.limpiar64;
            this.btnLimpiar.Location = new System.Drawing.Point(300, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 68);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(152, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(68, 68);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(226, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(68, 68);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 68);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tpConsultar
            // 
            this.tpConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tpConsultar.Controls.Add(this.panel1);
            this.tpConsultar.ForeColor = System.Drawing.Color.White;
            this.tpConsultar.Location = new System.Drawing.Point(4, 28);
            this.tpConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.tpConsultar.Name = "tpConsultar";
            this.tpConsultar.Size = new System.Drawing.Size(1367, 687);
            this.tpConsultar.TabIndex = 1;
            this.tpConsultar.Text = "Consultar";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.tablaRecepciones);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1367, 687);
            this.panel1.TabIndex = 3;
            // 
            // tablaRecepciones
            // 
            this.tablaRecepciones.AllowUserToAddRows = false;
            this.tablaRecepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaRecepciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRecepciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaRecepciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRecepciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaRecepciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecepciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRecepciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.tablaRecepciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaRecepciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaRecepciones.EnableHeadersVisualStyles = false;
            this.tablaRecepciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaRecepciones.Location = new System.Drawing.Point(10, 136);
            this.tablaRecepciones.MultiSelect = false;
            this.tablaRecepciones.Name = "tablaRecepciones";
            this.tablaRecepciones.ReadOnly = true;
            this.tablaRecepciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecepciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaRecepciones.RowHeadersVisible = false;
            this.tablaRecepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRecepciones.Size = new System.Drawing.Size(1347, 466);
            this.tablaRecepciones.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0415F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06224F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.93347F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.17048F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtFiltro, 3, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 73);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1347, 63);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(673, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Filtro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtFiltro.Location = new System.Drawing.Point(967, 31);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(223, 27);
            this.txtFiltro.TabIndex = 9;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 73);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1347, 0);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0415F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06224F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.74636F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35759F));
            this.tableLayoutPanel8.Controls.Add(this.dtpCHasta, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.dtpCDesde, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.cbCCliente, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.txtCNro, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1347, 63);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // dtpCHasta
            // 
            this.dtpCHasta.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCHasta.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dtpCHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dtpCHasta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCHasta.Location = new System.Drawing.Point(830, 31);
            this.dtpCHasta.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.dtpCHasta.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpCHasta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCHasta.Name = "dtpCHasta";
            this.dtpCHasta.Size = new System.Drawing.Size(100, 24);
            this.dtpCHasta.TabIndex = 12;
            // 
            // dtpCDesde
            // 
            this.dtpCDesde.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCDesde.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dtpCDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dtpCDesde.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCDesde.Location = new System.Drawing.Point(673, 31);
            this.dtpCDesde.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.dtpCDesde.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtpCDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpCDesde.Name = "dtpCDesde";
            this.dtpCDesde.Size = new System.Drawing.Size(86, 24);
            this.dtpCDesde.TabIndex = 11;
            // 
            // cbCCliente
            // 
            this.cbCCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cbCCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbCCliente.FormattingEnabled = true;
            this.cbCCliente.Location = new System.Drawing.Point(202, 31);
            this.cbCCliente.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbCCliente.Name = "cbCCliente";
            this.cbCCliente.Size = new System.Drawing.Size(461, 27);
            this.cbCCliente.TabIndex = 10;
            // 
            // txtCNro
            // 
            this.txtCNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCNro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCNro.Location = new System.Drawing.Point(0, 31);
            this.txtCNro.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtCNro.Name = "txtCNro";
            this.txtCNro.Size = new System.Drawing.Size(114, 27);
            this.txtCNro.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label7.Location = new System.Drawing.Point(830, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hasta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(673, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Desde";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(202, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(461, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recepcion";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 602);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1347, 75);
            this.panel3.TabIndex = 11;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(68, 68);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FormOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1375, 783);
            this.Controls.Add(this.tcGeneral);
            this.Controls.Add(this.labelDescripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrdenTrabajo";
            this.Text = "FormOrdenTrabajo";
            this.tcGeneral.ResumeLayout(false);
            this.tpRegistro.ResumeLayout(false);
            this.panelCotizacion.ResumeLayout(false);
            this.panelCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDetalle)).EndInit();
            this.tableLayoutPanelContainer2.ResumeLayout(false);
            this.tableLayoutPanelContainer2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tpConsultar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecepciones)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TabControl tcGeneral;
        private System.Windows.Forms.TabPage tpRegistro;
        private System.Windows.Forms.Panel panelCotizacion;
        private System.Windows.Forms.DataGridView tablaDetalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer2;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtODT;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorPrincipar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAgregarItems;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaRecepciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.DateTimePicker dtpCHasta;
        private System.Windows.Forms.DateTimePicker dtpCDesde;
        private System.Windows.Forms.ComboBox cbCCliente;
        private System.Windows.Forms.TextBox txtCNro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInspeccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMetrologo;
    }
}