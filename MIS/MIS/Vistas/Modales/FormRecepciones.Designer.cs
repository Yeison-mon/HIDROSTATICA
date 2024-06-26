namespace MIS.Vistas.Modales
{
    partial class FormRecepciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecepciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaRecepcion = new System.Windows.Forms.DataGridView();
            this.cmsTabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.labelRecepcion = new System.Windows.Forms.Label();
            this.txtRecepcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecepcion)).BeginInit();
            this.cmsTabla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.tablaRecepcion);
            this.panel1.Controls.Add(this.cbEstados);
            this.panel1.Controls.Add(this.labelRecepcion);
            this.panel1.Controls.Add(this.txtRecepcion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(993, 585);
            this.panel1.TabIndex = 1;
            // 
            // tablaRecepcion
            // 
            this.tablaRecepcion.AllowUserToAddRows = false;
            this.tablaRecepcion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaRecepcion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRecepcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaRecepcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaRecepcion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaRecepcion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecepcion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaRecepcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRecepcion.ContextMenuStrip = this.cmsTabla;
            this.tablaRecepcion.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaRecepcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaRecepcion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaRecepcion.EnableHeadersVisualStyles = false;
            this.tablaRecepcion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(239)))));
            this.tablaRecepcion.Location = new System.Drawing.Point(10, 146);
            this.tablaRecepcion.Name = "tablaRecepcion";
            this.tablaRecepcion.ReadOnly = true;
            this.tablaRecepcion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaRecepcion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaRecepcion.RowHeadersVisible = false;
            this.tablaRecepcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRecepcion.Size = new System.Drawing.Size(970, 427);
            this.tablaRecepcion.TabIndex = 13;
            this.tablaRecepcion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRecepcion_CellDoubleClick);
            // 
            // cmsTabla
            // 
            this.cmsTabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.verItemsToolStripMenuItem});
            this.cmsTabla.Name = "cmsTabla";
            this.cmsTabla.Size = new System.Drawing.Size(131, 48);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepcionToolStripMenuItem,
            this.inspecciónToolStripMenuItem});
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // recepcionToolStripMenuItem
            // 
            this.recepcionToolStripMenuItem.Name = "recepcionToolStripMenuItem";
            this.recepcionToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.recepcionToolStripMenuItem.Text = "Recepción";
            this.recepcionToolStripMenuItem.Click += new System.EventHandler(this.recepcionToolStripMenuItem_Click);
            // 
            // inspecciónToolStripMenuItem
            // 
            this.inspecciónToolStripMenuItem.Name = "inspecciónToolStripMenuItem";
            this.inspecciónToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inspecciónToolStripMenuItem.Text = "Inspección";
            this.inspecciónToolStripMenuItem.Click += new System.EventHandler(this.inspecciónToolStripMenuItem_Click);
            // 
            // verItemsToolStripMenuItem
            // 
            this.verItemsToolStripMenuItem.Name = "verItemsToolStripMenuItem";
            this.verItemsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.verItemsToolStripMenuItem.Text = "Ver Item(s)";
            this.verItemsToolStripMenuItem.Click += new System.EventHandler(this.verItemsToolStripMenuItem_Click);
            // 
            // cbEstados
            // 
            this.cbEstados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEstados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEstados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Location = new System.Drawing.Point(237, 74);
            this.cbEstados.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(191, 27);
            this.cbEstados.TabIndex = 12;
            this.cbEstados.SelectedIndexChanged += new System.EventHandler(this.cbEstados_SelectedIndexChanged);
            // 
            // labelRecepcion
            // 
            this.labelRecepcion.AutoSize = true;
            this.labelRecepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRecepcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecepcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelRecepcion.Location = new System.Drawing.Point(34, 42);
            this.labelRecepcion.Name = "labelRecepcion";
            this.labelRecepcion.Size = new System.Drawing.Size(109, 19);
            this.labelRecepcion.TabIndex = 2;
            this.labelRecepcion.Text = "Nro Recepción";
            // 
            // txtRecepcion
            // 
            this.txtRecepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtRecepcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecepcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtRecepcion.Location = new System.Drawing.Point(38, 74);
            this.txtRecepcion.Name = "txtRecepcion";
            this.txtRecepcion.Size = new System.Drawing.Size(165, 27);
            this.txtRecepcion.TabIndex = 1;
            this.txtRecepcion.TextChanged += new System.EventHandler(this.txtRecepcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(233, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // FormRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 585);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecepciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recepciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRecepcion)).EndInit();
            this.cmsTabla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRecepcion;
        private System.Windows.Forms.TextBox txtRecepcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.DataGridView tablaRecepcion;
        private System.Windows.Forms.ContextMenuStrip cmsTabla;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspecciónToolStripMenuItem;
    }
}