namespace MIS.Vistas.Modales
{
    partial class Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camara));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.flpFotos = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnCaptura = new System.Windows.Forms.Button();
            this.cbDispositivos = new System.Windows.Forms.ComboBox();
            this.btnActivar = new System.Windows.Forms.Button();
            this.picCaptura = new System.Windows.Forms.PictureBox();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.btnSubir);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.flpFotos);
            this.panel1.Controls.Add(this.labelPrincipal);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.BtnCaptura);
            this.panel1.Controls.Add(this.cbDispositivos);
            this.panel1.Controls.Add(this.btnActivar);
            this.panel1.Controls.Add(this.picCaptura);
            this.panel1.Controls.Add(this.picPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 598);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // btnSubir
            // 
            this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubir.FlatAppearance.BorderSize = 0;
            this.btnSubir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubir.Image = global::MIS.Properties.Resources.subirfoto64;
            this.btnSubir.Location = new System.Drawing.Point(862, 518);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(71, 70);
            this.btnSubir.TabIndex = 10;
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::MIS.Properties.Resources.papelera64;
            this.btnEliminar.Location = new System.Drawing.Point(939, 518);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 70);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // flpFotos
            // 
            this.flpFotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpFotos.AutoScroll = true;
            this.flpFotos.Location = new System.Drawing.Point(28, 519);
            this.flpFotos.Name = "flpFotos";
            this.flpFotos.Size = new System.Drawing.Size(828, 70);
            this.flpFotos.TabIndex = 8;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.labelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPrincipal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.labelPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelPrincipal.Size = new System.Drawing.Size(1103, 28);
            this.labelPrincipal.TabIndex = 7;
            this.labelPrincipal.Text = "Ingreso Nro: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::MIS.Properties.Resources.agregar64;
            this.btnAgregar.Location = new System.Drawing.Point(1015, 518);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 70);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // BtnCaptura
            // 
            this.BtnCaptura.FlatAppearance.BorderSize = 0;
            this.BtnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCaptura.Image = global::MIS.Properties.Resources.captura64;
            this.BtnCaptura.Location = new System.Drawing.Point(600, 76);
            this.BtnCaptura.Name = "BtnCaptura";
            this.BtnCaptura.Size = new System.Drawing.Size(83, 70);
            this.BtnCaptura.TabIndex = 5;
            this.BtnCaptura.UseVisualStyleBackColor = true;
            this.BtnCaptura.Click += new System.EventHandler(this.BtnCaptura_Click);
            // 
            // cbDispositivos
            // 
            this.cbDispositivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDispositivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbDispositivos.FormattingEnabled = true;
            this.cbDispositivos.Location = new System.Drawing.Point(28, 31);
            this.cbDispositivos.Name = "cbDispositivos";
            this.cbDispositivos.Size = new System.Drawing.Size(455, 21);
            this.cbDispositivos.TabIndex = 4;
            this.cbDispositivos.SelectedIndexChanged += new System.EventHandler(this.cbDispositivos_SelectedIndexChanged);
            // 
            // btnActivar
            // 
            this.btnActivar.FlatAppearance.BorderSize = 0;
            this.btnActivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivar.Image = global::MIS.Properties.Resources.grabar64;
            this.btnActivar.Location = new System.Drawing.Point(28, 76);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(83, 70);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // picCaptura
            // 
            this.picCaptura.Location = new System.Drawing.Point(598, 152);
            this.picCaptura.Name = "picCaptura";
            this.picCaptura.Size = new System.Drawing.Size(452, 361);
            this.picCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptura.TabIndex = 1;
            this.picCaptura.TabStop = false;
            this.picCaptura.Tag = "0";
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(26, 152);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(455, 361);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 598);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Camara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Camara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Camara_FormClosed);
            this.Load += new System.EventHandler(this.Camara_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Camara_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.PictureBox picCaptura;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.ComboBox cbDispositivos;
        private System.Windows.Forms.Button BtnCaptura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flpFotos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSubir;
    }
}