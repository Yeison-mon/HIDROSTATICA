namespace MIS.Vistas.Configuracion
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            labelDescripcion = new System.Windows.Forms.Label();
            tcGeneral = new System.Windows.Forms.TabControl();
            tpRegistro = new System.Windows.Forms.TabPage();
            panelRecepcion = new System.Windows.Forms.Panel();
            tableLayoutPanelContainer2 = new System.Windows.Forms.TableLayoutPanel();
            lbCliente = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtUsu = new System.Windows.Forms.TextBox();
            txtCargo = new System.Windows.Forms.TextBox();
            txtClave = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            txtConfirmar = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            cbEstado = new System.Windows.Forms.ComboBox();
            tableLayoutPanelContenedorPrincipar = new System.Windows.Forms.TableLayoutPanel();
            panel2 = new System.Windows.Forms.Panel();
            btnAgregar = new System.Windows.Forms.Button();
            tpConsultar = new System.Windows.Forms.TabPage();
            panel1 = new System.Windows.Forms.Panel();
            tablaConsulta = new System.Windows.Forms.DataGridView();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            txtFiltro = new System.Windows.Forms.TextBox();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            txtCUsuario = new System.Windows.Forms.TextBox();
            txtCNombre = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            btnConsultar = new System.Windows.Forms.Button();
            tcGeneral.SuspendLayout();
            tpRegistro.SuspendLayout();
            panelRecepcion.SuspendLayout();
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
            labelDescripcion.Size = new System.Drawing.Size(1066, 74);
            labelDescripcion.TabIndex = 2;
            labelDescripcion.Text = "REGISTRO DE USUARIOS";
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
            tcGeneral.Size = new System.Drawing.Size(1066, 608);
            tcGeneral.TabIndex = 4;
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
            tpRegistro.Size = new System.Drawing.Size(1058, 576);
            tpRegistro.TabIndex = 0;
            tpRegistro.Text = "Registro";
            // 
            // panelRecepcion
            // 
            panelRecepcion.AutoScroll = true;
            panelRecepcion.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panelRecepcion.Controls.Add(tableLayoutPanelContainer2);
            panelRecepcion.Controls.Add(tableLayoutPanelContenedorPrincipar);
            panelRecepcion.Controls.Add(panel2);
            panelRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            panelRecepcion.Location = new System.Drawing.Point(0, 0);
            panelRecepcion.Margin = new System.Windows.Forms.Padding(0);
            panelRecepcion.Name = "panelRecepcion";
            panelRecepcion.Padding = new System.Windows.Forms.Padding(12, 30, 12, 12);
            panelRecepcion.Size = new System.Drawing.Size(1058, 576);
            panelRecepcion.TabIndex = 2;
            // 
            // tableLayoutPanelContainer2
            // 
            tableLayoutPanelContainer2.AutoSize = true;
            tableLayoutPanelContainer2.ColumnCount = 10;
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            tableLayoutPanelContainer2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanelContainer2.Controls.Add(lbCliente, 0, 0);
            tableLayoutPanelContainer2.Controls.Add(txtNombre, 1, 0);
            tableLayoutPanelContainer2.Controls.Add(label2, 0, 1);
            tableLayoutPanelContainer2.Controls.Add(label5, 0, 2);
            tableLayoutPanelContainer2.Controls.Add(label8, 0, 3);
            tableLayoutPanelContainer2.Controls.Add(txtUsu, 1, 1);
            tableLayoutPanelContainer2.Controls.Add(txtCargo, 1, 2);
            tableLayoutPanelContainer2.Controls.Add(txtClave, 1, 3);
            tableLayoutPanelContainer2.Controls.Add(label1, 0, 4);
            tableLayoutPanelContainer2.Controls.Add(txtConfirmar, 1, 4);
            tableLayoutPanelContainer2.Controls.Add(label10, 0, 5);
            tableLayoutPanelContainer2.Controls.Add(cbEstado, 1, 5);
            tableLayoutPanelContainer2.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanelContainer2.Location = new System.Drawing.Point(12, 30);
            tableLayoutPanelContainer2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanelContainer2.Name = "tableLayoutPanelContainer2";
            tableLayoutPanelContainer2.RowCount = 6;
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0192862F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0192833F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0192833F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.84573F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0547943F));
            tableLayoutPanelContainer2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.38356F));
            tableLayoutPanelContainer2.Size = new System.Drawing.Size(1034, 368);
            tableLayoutPanelContainer2.TabIndex = 7;
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
            lbCliente.Size = new System.Drawing.Size(171, 28);
            lbCliente.TabIndex = 29;
            lbCliente.Text = "Nombre Completo";
            lbCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtNombre.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtNombre, 3);
            txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNombre.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtNombre.Location = new System.Drawing.Point(183, 0);
            txtNombre.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(355, 27);
            txtNombre.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label2.Location = new System.Drawing.Point(0, 40);
            label2.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(171, 28);
            label2.TabIndex = 68;
            label2.Text = "Nombre de Usuario";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label5.Location = new System.Drawing.Point(0, 80);
            label5.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(171, 28);
            label5.TabIndex = 69;
            label5.Text = "Cargo";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label8.Location = new System.Drawing.Point(0, 120);
            label8.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(171, 28);
            label8.TabIndex = 70;
            label8.Text = "Clave";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsu
            // 
            txtUsu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtUsu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtUsu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtUsu.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtUsu, 3);
            txtUsu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsu.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtUsu.Location = new System.Drawing.Point(183, 40);
            txtUsu.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtUsu.Name = "txtUsu";
            txtUsu.Size = new System.Drawing.Size(355, 27);
            txtUsu.TabIndex = 71;
            // 
            // txtCargo
            // 
            txtCargo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtCargo.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtCargo, 3);
            txtCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCargo.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCargo.Location = new System.Drawing.Point(183, 80);
            txtCargo.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new System.Drawing.Size(355, 27);
            txtCargo.TabIndex = 72;
            // 
            // txtClave
            // 
            txtClave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtClave.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtClave, 3);
            txtClave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtClave.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtClave.Location = new System.Drawing.Point(183, 120);
            txtClave.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new System.Drawing.Size(355, 27);
            txtClave.TabIndex = 73;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label1.Location = new System.Drawing.Point(0, 163);
            label1.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(171, 28);
            label1.TabIndex = 74;
            label1.Text = "Confirmar Clave";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtConfirmar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtConfirmar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtConfirmar.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            tableLayoutPanelContainer2.SetColumnSpan(txtConfirmar, 3);
            txtConfirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtConfirmar.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtConfirmar.Location = new System.Drawing.Point(183, 163);
            txtConfirmar.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new System.Drawing.Size(355, 27);
            txtConfirmar.TabIndex = 75;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label10.BackColor = System.Drawing.Color.Transparent;
            label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label10.Location = new System.Drawing.Point(0, 206);
            label10.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(171, 28);
            label10.TabIndex = 76;
            label10.Text = "Estado";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEstado
            // 
            cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            cbEstado.Location = new System.Drawing.Point(186, 209);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new System.Drawing.Size(95, 27);
            cbEstado.TabIndex = 77;
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
            tableLayoutPanelContenedorPrincipar.Size = new System.Drawing.Size(1034, 0);
            tableLayoutPanelContenedorPrincipar.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel2.Controls.Add(btnAgregar);
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(12, 477);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1034, 87);
            panel2.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Image = Properties.Resources.agregar64;
            btnAgregar.Location = new System.Drawing.Point(4, 6);
            btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(79, 78);
            btnAgregar.TabIndex = 19;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
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
            tpConsultar.Size = new System.Drawing.Size(1058, 576);
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
            panel1.Size = new System.Drawing.Size(1050, 570);
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
            tablaConsulta.Location = new System.Drawing.Point(12, 121);
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
            tablaConsulta.Size = new System.Drawing.Size(1026, 350);
            tablaConsulta.TabIndex = 12;
            tablaConsulta.CellDoubleClick += tablaConsulta_CellDoubleClick;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.919F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84735F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3411217F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.009346F));
            tableLayoutPanel4.Controls.Add(label3, 2, 0);
            tableLayoutPanel4.Controls.Add(txtFiltro, 3, 0);
            tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            tableLayoutPanel4.Location = new System.Drawing.Point(12, 85);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.20635F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1026, 36);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label3.Location = new System.Drawing.Point(509, 0);
            label3.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(175, 24);
            label3.TabIndex = 7;
            label3.Text = "Filtro";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtFiltro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtFiltro.Location = new System.Drawing.Point(696, 0);
            txtFiltro.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new System.Drawing.Size(263, 27);
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
            tableLayoutPanel5.Size = new System.Drawing.Size(1026, 0);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.8177567F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.2476635F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.6588783F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.1588783F));
            tableLayoutPanel8.Controls.Add(txtCUsuario, 1, 1);
            tableLayoutPanel8.Controls.Add(txtCNombre, 0, 1);
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
            tableLayoutPanel8.Size = new System.Drawing.Size(1026, 73);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // txtCUsuario
            // 
            txtCUsuario.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtCUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCUsuario.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCUsuario.Location = new System.Drawing.Point(265, 35);
            txtCUsuario.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCUsuario.Name = "txtCUsuario";
            txtCUsuario.Size = new System.Drawing.Size(187, 27);
            txtCUsuario.TabIndex = 11;
            // 
            // txtCNombre
            // 
            txtCNombre.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            txtCNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtCNombre.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            txtCNombre.Location = new System.Drawing.Point(0, 35);
            txtCNombre.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            txtCNombre.Name = "txtCNombre";
            txtCNombre.Size = new System.Drawing.Size(209, 27);
            txtCNombre.TabIndex = 8;
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
            label4.Size = new System.Drawing.Size(253, 23);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            label9.Location = new System.Drawing.Point(265, 0);
            label9.Margin = new System.Windows.Forms.Padding(0, 0, 12, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(226, 23);
            label9.TabIndex = 13;
            label9.Text = "Usuario";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(230, 233, 239);
            panel3.Controls.Add(btnConsultar);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(12, 471);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1026, 87);
            panel3.TabIndex = 11;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.Image = (System.Drawing.Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new System.Drawing.Point(5, 4);
            btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(79, 78);
            btnConsultar.TabIndex = 10;
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1066, 682);
            Controls.Add(tcGeneral);
            Controls.Add(labelDescripcion);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuarios";
            Text = "Usuarios";
            tcGeneral.ResumeLayout(false);
            tpRegistro.ResumeLayout(false);
            panelRecepcion.ResumeLayout(false);
            panelRecepcion.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer2;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorPrincipar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tpConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaConsulta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox txtCNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtCUsuario;
        private System.Windows.Forms.Label label9;
    }
}