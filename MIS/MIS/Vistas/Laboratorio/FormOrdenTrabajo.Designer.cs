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
            labelDescripcion = new System.Windows.Forms.Label();
            tcGeneral = new System.Windows.Forms.TabControl();
            tpRegistro = new System.Windows.Forms.TabPage();
            panelCotizacion = new System.Windows.Forms.Panel();
            tablaDetalle = new System.Windows.Forms.DataGridView();
            tableLayoutPanelContainer2 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            labelCliente = new System.Windows.Forms.Label();
            txtCliente = new System.Windows.Forms.TextBox();
            labelEstado = new System.Windows.Forms.Label();
            txtEstado = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtODT = new System.Windows.Forms.TextBox();
            txtInspeccion = new System.Windows.Forms.TextBox();
            cbMetrologo = new System.Windows.Forms.ComboBox();
            tableLayoutPanelContenedorPrincipar = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            btnAprobar = new System.Windows.Forms.Button();
            btnImportar = new System.Windows.Forms.Button();
            btnAgregarItems = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnImprimir = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            tpConsultar = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            tablaRecepciones = new System.Windows.Forms.DataGridView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            txtFiltro = new System.Windows.Forms.TextBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            dtpCHasta = new System.Windows.Forms.DateTimePicker();
            dtpCDesde = new System.Windows.Forms.DateTimePicker();
            cbCCliente = new System.Windows.Forms.ComboBox();
            txtCNro = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnConsultar = new System.Windows.Forms.Button();
            tcGeneral.SuspendLayout();
            tpRegistro.SuspendLayout();
            panelCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).BeginInit();
            tableLayoutPanelContainer2.SuspendLayout();
            panel2.SuspendLayout();
            tpConsultar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaRecepciones).BeginInit();
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
            labelDescripcion.Size = new System.Drawing.Size(1604, 74);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "ÓRDEN DE TRABAJO";
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
            tcGeneral.Size = new System.Drawing.Size(1604, 829);
            tcGeneral.TabIndex = 4;
            tcGeneral.TabStop = false;
            // 
            // tpRegistro
            // 
            tpRegistro.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tpRegistro.Controls.Add(panelCotizacion);
            tpRegistro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            tpRegistro.ForeColor = System.Drawing.Color.White;
            tpRegistro.Location = new System.Drawing.Point(4, 28);
            tpRegistro.Margin = new System.Windows.Forms.Padding(0);
            tpRegistro.Name = "tpRegistro";
            tpRegistro.Size = new System.Drawing.Size(1596, 797);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            // 
            // panelCotizacion
            // 
            panelCotizacion.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panelCotizacion.Controls.Add(tablaDetalle);
            panelCotizacion.Controls.Add(tableLayoutPanelContainer2);
            panelCotizacion.Controls.Add(tableLayoutPanelContenedorPrincipar);
            panelCotizacion.Controls.Add(panel2);
            panelCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCotizacion.Location = new System.Drawing.Point(0, 0);
            panelCotizacion.Margin = new System.Windows.Forms.Padding(0);
            panelCotizacion.Name = "panelCotizacion";
            panelCotizacion.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            panelCotizacion.Size = new System.Drawing.Size(1596, 797);
            panelCotizacion.TabIndex = 2;
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
            tablaDetalle.Margin = new System.Windows.Forms.Padding(0);
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
            tablaDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            tablaDetalle.Size = new System.Drawing.Size(1572, 566);
            tablaDetalle.TabIndex = 19;
            // 
            // tableLayoutPanelContainer2
            // 
            tableLayoutPanelContainer2.AutoSize = true;
            tableLayoutPanelContainer2.ColumnCount = 6;
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 880F));
            tableLayoutPanelContainer2.Controls.Add(label2, 0, 2);
            tableLayoutPanelContainer2.Controls.Add(labelCliente, 0, 0);
            tableLayoutPanelContainer2.Controls.Add(txtCliente, 1, 0);
            tableLayoutPanelContainer2.Controls.Add(labelEstado, 4, 0);
            tableLayoutPanelContainer2.Controls.Add(txtEstado, 5, 0);
            tableLayoutPanelContainer2.Controls.Add(label1, 0, 1);
            tableLayoutPanelContainer2.Controls.Add(label9, 2, 1);
            tableLayoutPanelContainer2.Controls.Add(txtODT, 3, 1);
            tableLayoutPanelContainer2.Controls.Add(txtInspeccion, 1, 1);
            tableLayoutPanelContainer2.Controls.Add(cbMetrologo, 1, 2);
            tableLayoutPanelContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContainer2.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanelContainer2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContainer2.Name = "tableLayoutPanelContainer2";
            tableLayoutPanelContainer2.RowCount = 3;
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanelContainer2.Size = new System.Drawing.Size(1572, 120);
            tableLayoutPanelContainer2.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label2.Location = new System.Drawing.Point(0, 80);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 28);
            label2.TabIndex = 23;
            label2.Text = "Metrólogo";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            txtCliente.ReadOnly = true;
            txtCliente.Size = new System.Drawing.Size(445, 27);
            txtCliente.TabIndex = 5;
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
            labelEstado.Size = new System.Drawing.Size(98, 28);
            labelEstado.TabIndex = 11;
            labelEstado.Text = "Estado";
            labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEstado
            // 
            txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtEstado.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtEstado.Enabled = false;
            txtEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEstado.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtEstado.Location = new System.Drawing.Point(692, 0);
            txtEstado.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new System.Drawing.Size(110, 27);
            txtEstado.TabIndex = 5;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label1.Location = new System.Drawing.Point(0, 40);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 28);
            label1.TabIndex = 21;
            label1.Text = "IR";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label9.Location = new System.Drawing.Point(263, 40);
            label9.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(110, 28);
            label9.TabIndex = 20;
            label9.Text = "ODT";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtODT
            // 
            txtODT.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtODT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtODT.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtODT.Location = new System.Drawing.Point(385, 40);
            txtODT.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtODT.Name = "txtODT";
            txtODT.Size = new System.Drawing.Size(109, 27);
            txtODT.TabIndex = 18;
            txtODT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtODT.TextChanged += txtODT_TextChanged;
            txtODT.KeyPress += txtODT_KeyPress;
            // 
            // txtInspeccion
            // 
            txtInspeccion.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtInspeccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtInspeccion.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtInspeccion.Location = new System.Drawing.Point(125, 40);
            txtInspeccion.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtInspeccion.Name = "txtInspeccion";
            txtInspeccion.Size = new System.Drawing.Size(109, 27);
            txtInspeccion.TabIndex = 22;
            txtInspeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtInspeccion.TextChanged += txtInspeccion_TextChanged;
            txtInspeccion.KeyPress += txtInspeccion_KeyPress;
            // 
            // cbMetrologo
            // 
            cbMetrologo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbMetrologo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbMetrologo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbMetrologo.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(cbMetrologo, 3);
            cbMetrologo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbMetrologo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            cbMetrologo.FormattingEnabled = true;
            cbMetrologo.Location = new System.Drawing.Point(125, 80);
            cbMetrologo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbMetrologo.Name = "cbMetrologo";
            cbMetrologo.Size = new System.Drawing.Size(445, 27);
            cbMetrologo.TabIndex = 24;
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
            tableLayoutPanelContenedorPrincipar.Size = new System.Drawing.Size(1572, 0);
            tableLayoutPanelContenedorPrincipar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel2.Controls.Add(btnAprobar);
            panel2.Controls.Add(btnImportar);
            panel2.Controls.Add(btnAgregarItems);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnImprimir);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnBuscar);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(12, 698);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1572, 87);
            panel2.TabIndex = 11;
            // 
            // btnAprobar
            // 
            btnAprobar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAprobar.FlatAppearance.BorderSize = 0;
            btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAprobar.Image = Properties.Resources.aprobado_rechazar64;
            btnAprobar.Location = new System.Drawing.Point(436, 3);
            btnAprobar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAprobar.Name = "btnAprobar";
            btnAprobar.Size = new System.Drawing.Size(79, 78);
            btnAprobar.TabIndex = 20;
            btnAprobar.UseVisualStyleBackColor = true;
            btnAprobar.Visible = false;
            // 
            // btnImportar
            // 
            btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnImportar.FlatAppearance.BorderSize = 0;
            btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImportar.Image = Properties.Resources.importar64;
            btnImportar.Location = new System.Drawing.Point(91, 5);
            btnImportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new System.Drawing.Size(79, 78);
            btnImportar.TabIndex = 18;
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Visible = false;
            // 
            // btnAgregarItems
            // 
            btnAgregarItems.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnAgregarItems.FlatAppearance.BorderSize = 0;
            btnAgregarItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregarItems.Image = Properties.Resources.agregar64;
            btnAgregarItems.Location = new System.Drawing.Point(1480, 5);
            btnAgregarItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAgregarItems.Name = "btnAgregarItems";
            btnAgregarItems.Size = new System.Drawing.Size(79, 78);
            btnAgregarItems.TabIndex = 17;
            btnAgregarItems.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.limpiar64;
            btnLimpiar.Location = new System.Drawing.Point(350, 5);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(79, 78);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnImprimir.FlatAppearance.BorderSize = 0;
            btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnImprimir.Image = (System.Drawing.Image)resources.GetObject("btnImprimir.Image");
            btnImprimir.Location = new System.Drawing.Point(177, 5);
            btnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(79, 78);
            btnImprimir.TabIndex = 13;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGuardar.Image = (System.Drawing.Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.Location = new System.Drawing.Point(264, 3);
            btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(79, 78);
            btnGuardar.TabIndex = 11;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new System.Drawing.Point(5, 5);
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
            tpConsultar.Margin = new System.Windows.Forms.Padding(0);
            tpConsultar.Name = "tpConsultar";
            tpConsultar.Size = new System.Drawing.Size(1596, 798);
            tpConsultar.TabIndex = 1;
            tpConsultar.Text = "Consultar";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel1.Controls.Add(tablaRecepciones);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(tableLayoutPanel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            panel1.Size = new System.Drawing.Size(1596, 798);
            panel1.TabIndex = 3;
            // 
            // tablaRecepciones
            // 
            tablaRecepciones.AllowUserToAddRows = false;
            tablaRecepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            tablaRecepciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            tablaRecepciones.BackgroundColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaRecepciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tablaRecepciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            tablaRecepciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(240, 243, 249);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaRecepciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tablaRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(60, 120, 216);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            tablaRecepciones.DefaultCellStyle = dataGridViewCellStyle5;
            tablaRecepciones.Dock = System.Windows.Forms.DockStyle.Fill;
            tablaRecepciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            tablaRecepciones.EnableHeadersVisualStyles = false;
            tablaRecepciones.GridColor = System.Drawing.Color.FromArgb(230, 233, 239);
            tablaRecepciones.Location = new System.Drawing.Point(12, 158);
            tablaRecepciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tablaRecepciones.MultiSelect = false;
            tablaRecepciones.Name = "tablaRecepciones";
            tablaRecepciones.ReadOnly = true;
            tablaRecepciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            tablaRecepciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            tablaRecepciones.RowHeadersVisible = false;
            tablaRecepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            tablaRecepciones.Size = new System.Drawing.Size(1572, 541);
            tablaRecepciones.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0415F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06224F));
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
            tableLayoutPanel4.Size = new System.Drawing.Size(1572, 73);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label3.Location = new System.Drawing.Point(785, 35);
            label3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(332, 24);
            label3.TabIndex = 7;
            label3.Text = "Filtro";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtFiltro.Location = new System.Drawing.Point(1129, 35);
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
            tableLayoutPanel5.Size = new System.Drawing.Size(1572, 0);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0415F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.06224F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.74636F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35759F));
            tableLayoutPanel8.Controls.Add(dtpCHasta, 3, 1);
            tableLayoutPanel8.Controls.Add(dtpCDesde, 2, 1);
            tableLayoutPanel8.Controls.Add(cbCCliente, 1, 1);
            tableLayoutPanel8.Controls.Add(txtCNro, 0, 1);
            tableLayoutPanel8.Controls.Add(label7, 3, 0);
            tableLayoutPanel8.Controls.Add(label6, 2, 0);
            tableLayoutPanel8.Controls.Add(label5, 1, 0);
            tableLayoutPanel8.Controls.Add(label4, 0, 0);
            tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel8.Location = new System.Drawing.Point(12, 12);
            tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.79365F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel8.Size = new System.Drawing.Size(1572, 73);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // dtpCHasta
            // 
            dtpCHasta.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCHasta.CalendarForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(120, 120, 120);
            dtpCHasta.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpCHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpCHasta.Location = new System.Drawing.Point(969, 35);
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
            dtpCDesde.Location = new System.Drawing.Point(785, 35);
            dtpCDesde.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            dtpCDesde.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            dtpCDesde.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpCDesde.Name = "dtpCDesde";
            dtpCDesde.Size = new System.Drawing.Size(100, 24);
            dtpCDesde.TabIndex = 11;
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
            cbCCliente.Location = new System.Drawing.Point(235, 35);
            cbCCliente.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            cbCCliente.Name = "cbCCliente";
            cbCCliente.Size = new System.Drawing.Size(538, 27);
            cbCCliente.TabIndex = 10;
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
            label7.Location = new System.Drawing.Point(969, 0);
            label7.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(591, 23);
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
            label6.Location = new System.Drawing.Point(785, 0);
            label6.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(172, 23);
            label6.TabIndex = 6;
            label6.Text = "Desde";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label5.Location = new System.Drawing.Point(235, 0);
            label5.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(538, 23);
            label5.TabIndex = 5;
            label5.Text = "Cliente";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            label4.Size = new System.Drawing.Size(223, 23);
            label4.TabIndex = 4;
            label4.Text = "Recepcion";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel3.Controls.Add(btnConsultar);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(12, 699);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1572, 87);
            panel3.TabIndex = 11;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.Image = (System.Drawing.Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new System.Drawing.Point(5, 5);
            btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(79, 78);
            btnConsultar.TabIndex = 10;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // FormOrdenTrabajo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1604, 903);
            Controls.Add(tcGeneral);
            Controls.Add(labelDescripcion);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOrdenTrabajo";
            Text = "FormOrdenTrabajo";
            tcGeneral.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            panelCotizacion.ResumeLayout(false);
            panelCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDetalle).EndInit();
            tableLayoutPanelContainer2.ResumeLayout(false);
            tableLayoutPanelContainer2.PerformLayout();
            panel2.ResumeLayout(false);
            tpConsultar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaRecepciones).EndInit();
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