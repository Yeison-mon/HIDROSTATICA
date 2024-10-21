using System;

namespace MIS
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Tittle_Bar = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            btnMinize = new System.Windows.Forms.PictureBox();
            btnClose = new System.Windows.Forms.PictureBox();
            txtUser = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnEntrar = new System.Windows.Forms.Button();
            btnActiva = new System.Windows.Forms.Button();
            Tittle_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Tittle_Bar
            // 
            Tittle_Bar.BackColor = System.Drawing.Color.FromArgb(60, 60, 59);
            Tittle_Bar.Controls.Add(pictureBox3);
            Tittle_Bar.Controls.Add(btnMinize);
            Tittle_Bar.Controls.Add(btnClose);
            Tittle_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            Tittle_Bar.Location = new System.Drawing.Point(0, 0);
            Tittle_Bar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Tittle_Bar.Name = "Tittle_Bar";
            Tittle_Bar.Size = new System.Drawing.Size(420, 29);
            Tittle_Bar.TabIndex = 1;
            Tittle_Bar.MouseDown += Tittle_Bar_MouseDown;
            Tittle_Bar.MouseMove += Tittle_Bar_MouseMove;
            Tittle_Bar.MouseUp += Tittle_Bar_MouseUp;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LogoCircular;
            pictureBox3.Location = new System.Drawing.Point(4, 3);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(23, 23);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // btnMinize
            // 
            btnMinize.Cursor = System.Windows.Forms.Cursors.Hand;
            btnMinize.Image = Properties.Resources.minimizar_ventana_white;
            btnMinize.Location = new System.Drawing.Point(369, 5);
            btnMinize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMinize.Name = "btnMinize";
            btnMinize.Size = new System.Drawing.Size(18, 17);
            btnMinize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnMinize.TabIndex = 1;
            btnMinize.TabStop = false;
            btnMinize.Click += btnMinize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.Image = Properties.Resources.x_white;
            btnClose.Location = new System.Drawing.Point(394, 5);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(18, 17);
            btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtUser
            // 
            txtUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtUser.BackColor = System.Drawing.Color.FromArgb(60, 60, 59);
            txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtUser.ForeColor = System.Drawing.Color.White;
            txtUser.Location = new System.Drawing.Point(58, 312);
            txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(294, 19);
            txtUser.TabIndex = 2;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(55, 284);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 19);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoCuadrado;
            pictureBox1.Location = new System.Drawing.Point(58, 46);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(294, 178);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(55, 346);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 19);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            txtPassword.BackColor = System.Drawing.Color.FromArgb(60, 60, 59);
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            txtPassword.ForeColor = System.Drawing.Color.White;
            txtPassword.Location = new System.Drawing.Point(58, 376);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(294, 19);
            txtPassword.TabIndex = 5;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = System.Drawing.Color.FromArgb(17, 97, 237);
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEntrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = System.Drawing.Color.White;
            btnEntrar.Location = new System.Drawing.Point(58, 463);
            btnEntrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new System.Drawing.Size(294, 42);
            btnEntrar.TabIndex = 7;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_ClickAsync;
            // 
            // btnActiva
            // 
            btnActiva.BackColor = System.Drawing.Color.FromArgb(17, 97, 237);
            btnActiva.FlatAppearance.BorderSize = 0;
            btnActiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActiva.Font = new System.Drawing.Font("Arial", 12F);
            btnActiva.ForeColor = System.Drawing.Color.White;
            btnActiva.Location = new System.Drawing.Point(58, 524);
            btnActiva.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnActiva.Name = "btnActiva";
            btnActiva.Size = new System.Drawing.Size(294, 42);
            btnActiva.TabIndex = 8;
            btnActiva.Text = "Sesión Activa";
            btnActiva.UseVisualStyleBackColor = false;
            btnActiva.Visible = false;
            btnActiva.Click += btnActiva_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ClientSize = new System.Drawing.Size(420, 668);
            Controls.Add(btnActiva);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(Tittle_Bar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Login";
            Opacity = 0.85D;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Metrology Integration S.A.S.";
            MouseDown += Login_MouseDown;
            MouseMove += Login_MouseMove;
            MouseUp += Login_MouseUp;
            Tittle_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private System.Windows.Forms.Panel Tittle_Bar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMinize;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnActiva;
    }
}

