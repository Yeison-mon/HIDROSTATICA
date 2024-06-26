namespace MIS.Vistas.Modales
{
    partial class FormAprobarCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAprobarCotizacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.tcGeneral = new System.Windows.Forms.TabControl();
            this.tpDocumento = new System.Windows.Forms.TabPage();
            this.panelRecepcion = new System.Windows.Forms.Panel();
            this.pdfvDocumento = new PdfiumViewer.PdfViewer();
            this.tpCorreo = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pbCapturaCorreo = new System.Windows.Forms.PictureBox();
            this.tpOtros = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConversacion = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.labelCargo = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.labelContacto = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.labelDocumento = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tcGeneral.SuspendLayout();
            this.tpDocumento.SuspendLayout();
            this.panelRecepcion.SuspendLayout();
            this.tpCorreo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaCorreo)).BeginInit();
            this.tpOtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpHora);
            this.panel1.Controls.Add(this.cbOpciones);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAdjuntar);
            this.panel1.Controls.Add(this.tcGeneral);
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Controls.Add(this.labelCargo);
            this.panel1.Controls.Add(this.btnAccion);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.labelContacto);
            this.panel1.Controls.Add(this.txtContacto);
            this.panel1.Controls.Add(this.labelDocumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(1033, 526);
            this.panel1.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(771, 75);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(96, 20);
            this.dtpFecha.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Location = new System.Drawing.Point(774, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha y Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(873, 75);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(96, 20);
            this.dtpHora.TabIndex = 25;
            // 
            // cbOpciones
            // 
            this.cbOpciones.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOpciones.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpciones.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Items.AddRange(new object[] {
            "-- SELECCIONE --",
            "Aprobar",
            "Revisar"});
            this.cbOpciones.Location = new System.Drawing.Point(524, 74);
            this.cbOpciones.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(241, 27);
            this.cbOpciones.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Location = new System.Drawing.Point(520, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Opción";
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdjuntar.FlatAppearance.BorderSize = 0;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Image = global::MIS.Properties.Resources.Adjuntar64;
            this.btnAdjuntar.Location = new System.Drawing.Point(18, 446);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(68, 68);
            this.btnAdjuntar.TabIndex = 22;
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // tcGeneral
            // 
            this.tcGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGeneral.Controls.Add(this.tpDocumento);
            this.tcGeneral.Controls.Add(this.tpCorreo);
            this.tcGeneral.Controls.Add(this.tpOtros);
            this.tcGeneral.Font = new System.Drawing.Font("Calibri", 12F);
            this.tcGeneral.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tcGeneral.Location = new System.Drawing.Point(14, 114);
            this.tcGeneral.Margin = new System.Windows.Forms.Padding(0);
            this.tcGeneral.Name = "tcGeneral";
            this.tcGeneral.Padding = new System.Drawing.Point(5, 3);
            this.tcGeneral.SelectedIndex = 0;
            this.tcGeneral.Size = new System.Drawing.Size(1006, 329);
            this.tcGeneral.TabIndex = 21;
            this.tcGeneral.TabStop = false;
            this.tcGeneral.Tag = "";
            this.tcGeneral.SelectedIndexChanged += new System.EventHandler(this.tcGeneral_SelectedIndexChanged);
            // 
            // tpDocumento
            // 
            this.tpDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tpDocumento.Controls.Add(this.panelRecepcion);
            this.tpDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.tpDocumento.ForeColor = System.Drawing.Color.White;
            this.tpDocumento.Location = new System.Drawing.Point(4, 28);
            this.tpDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.tpDocumento.Name = "tpDocumento";
            this.tpDocumento.Size = new System.Drawing.Size(998, 297);
            this.tpDocumento.TabIndex = 0;
            this.tpDocumento.Tag = "1";
            this.tpDocumento.Text = "Orden de Compra";
            // 
            // panelRecepcion
            // 
            this.panelRecepcion.AutoScroll = true;
            this.panelRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panelRecepcion.Controls.Add(this.pdfvDocumento);
            this.panelRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRecepcion.Location = new System.Drawing.Point(0, 0);
            this.panelRecepcion.Margin = new System.Windows.Forms.Padding(0);
            this.panelRecepcion.Name = "panelRecepcion";
            this.panelRecepcion.Size = new System.Drawing.Size(998, 297);
            this.panelRecepcion.TabIndex = 2;
            // 
            // pdfvDocumento
            // 
            this.pdfvDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfvDocumento.Location = new System.Drawing.Point(0, 0);
            this.pdfvDocumento.Margin = new System.Windows.Forms.Padding(0);
            this.pdfvDocumento.Name = "pdfvDocumento";
            this.pdfvDocumento.ShowToolbar = false;
            this.pdfvDocumento.Size = new System.Drawing.Size(998, 297);
            this.pdfvDocumento.TabIndex = 3;
            this.pdfvDocumento.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitWidth;
            // 
            // tpCorreo
            // 
            this.tpCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tpCorreo.Controls.Add(this.label3);
            this.tpCorreo.Controls.Add(this.pbCapturaCorreo);
            this.tpCorreo.ForeColor = System.Drawing.Color.White;
            this.tpCorreo.Location = new System.Drawing.Point(4, 28);
            this.tpCorreo.Name = "tpCorreo";
            this.tpCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tpCorreo.Size = new System.Drawing.Size(998, 297);
            this.tpCorreo.TabIndex = 1;
            this.tpCorreo.Tag = "2";
            this.tpCorreo.Text = "Correo Autorizado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(600, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Si posee una imagen en portapapeles use CRTL+V; Doble click en la imagen para des" +
    "cargar";
            // 
            // pbCapturaCorreo
            // 
            this.pbCapturaCorreo.Location = new System.Drawing.Point(3, 25);
            this.pbCapturaCorreo.Name = "pbCapturaCorreo";
            this.pbCapturaCorreo.Size = new System.Drawing.Size(989, 324);
            this.pbCapturaCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCapturaCorreo.TabIndex = 1;
            this.pbCapturaCorreo.TabStop = false;
            // 
            // tpOtros
            // 
            this.tpOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tpOtros.Controls.Add(this.label2);
            this.tpOtros.Controls.Add(this.txtTelefono);
            this.tpOtros.Controls.Add(this.label1);
            this.tpOtros.Controls.Add(this.txtConversacion);
            this.tpOtros.Location = new System.Drawing.Point(4, 28);
            this.tpOtros.Name = "tpOtros";
            this.tpOtros.Size = new System.Drawing.Size(998, 297);
            this.tpOtros.TabIndex = 2;
            this.tpOtros.Tag = "3";
            this.tpOtros.Text = "Otros medios";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(651, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Numero de Teléfono ->";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtTelefono.Location = new System.Drawing.Point(823, 7);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(165, 27);
            this.txtTelefono.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción del mensaje";
            // 
            // txtConversacion
            // 
            this.txtConversacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConversacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtConversacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtConversacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtConversacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtConversacion.Location = new System.Drawing.Point(24, 42);
            this.txtConversacion.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.txtConversacion.Multiline = true;
            this.txtConversacion.Name = "txtConversacion";
            this.txtConversacion.Size = new System.Drawing.Size(964, 245);
            this.txtConversacion.TabIndex = 18;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtCargo.Location = new System.Drawing.Point(356, 74);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(165, 27);
            this.txtCargo.TabIndex = 20;
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelCargo.Location = new System.Drawing.Point(352, 42);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(48, 19);
            this.labelCargo.TabIndex = 19;
            this.labelCargo.Text = "Cargo";
            // 
            // btnAccion
            // 
            this.btnAccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccion.FlatAppearance.BorderSize = 0;
            this.btnAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccion.Image = global::MIS.Properties.Resources.agregar64;
            this.btnAccion.Location = new System.Drawing.Point(952, 446);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(68, 68);
            this.btnAccion.TabIndex = 18;
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtDocumento.Location = new System.Drawing.Point(185, 74);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(165, 27);
            this.txtDocumento.TabIndex = 3;
            // 
            // labelContacto
            // 
            this.labelContacto.AutoSize = true;
            this.labelContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelContacto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelContacto.Location = new System.Drawing.Point(13, 42);
            this.labelContacto.Name = "labelContacto";
            this.labelContacto.Size = new System.Drawing.Size(71, 19);
            this.labelContacto.TabIndex = 2;
            this.labelContacto.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtContacto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtContacto.Location = new System.Drawing.Point(14, 74);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(165, 27);
            this.txtContacto.TabIndex = 1;
            // 
            // labelDocumento
            // 
            this.labelDocumento.AutoSize = true;
            this.labelDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelDocumento.Location = new System.Drawing.Point(181, 42);
            this.labelDocumento.Name = "labelDocumento";
            this.labelDocumento.Size = new System.Drawing.Size(89, 19);
            this.labelDocumento.TabIndex = 0;
            this.labelDocumento.Text = "Documento";
            // 
            // FormAprobarCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 526);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormAprobarCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aprobar o rechazar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAprobarCotizacion_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAprobarCotizacion_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcGeneral.ResumeLayout(false);
            this.tpDocumento.ResumeLayout(false);
            this.panelRecepcion.ResumeLayout(false);
            this.tpCorreo.ResumeLayout(false);
            this.tpCorreo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaCorreo)).EndInit();
            this.tpOtros.ResumeLayout(false);
            this.tpOtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label labelContacto;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label labelDocumento;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.TabControl tcGeneral;
        private System.Windows.Forms.TabPage tpDocumento;
        private System.Windows.Forms.Panel panelRecepcion;
        private System.Windows.Forms.TabPage tpCorreo;
        private System.Windows.Forms.TabPage tpOtros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConversacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.PictureBox pbCapturaCorreo;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOpciones;
        private PdfiumViewer.PdfViewer pdfvDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}