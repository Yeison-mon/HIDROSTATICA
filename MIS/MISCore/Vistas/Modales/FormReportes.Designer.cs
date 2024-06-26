namespace MIS.Vistas.Modales
{
    partial class FormReportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportes));
            this.recepcionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsRecepcion = new MIS.Reportes.Recepcion.dsRecepcion();
            this.recepciondetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsInspeccion = new MIS.Reportes.Recepcion.dsInspeccion();
            this.inspecciondetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
            this.rvRecepcion = new Microsoft.Reporting.WinForms.ReportViewer();
            // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
            this.rvInspeccion = new Microsoft.Reporting.WinForms.ReportViewer();
            // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
            this.rvOrdenTrabajo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsOrdenTrabajo = new MIS.Reportes.Laboratorio.dsOrdenTrabajo();
            this.ordentrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordentrabajodetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.recepcionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepciondetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInspeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecciondetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenTrabajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajodetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // recepcionesBindingSource
            // 
            this.recepcionesBindingSource.DataMember = "recepciones";
            this.recepcionesBindingSource.DataSource = this.dsRecepcion;
            // 
            // dsRecepcion
            // 
            this.dsRecepcion.DataSetName = "dsRecepcion";
            this.dsRecepcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recepciondetalleBindingSource
            // 
            this.recepciondetalleBindingSource.DataMember = "recepcion_detalle";
            this.recepciondetalleBindingSource.DataSource = this.dsRecepcion;
            // 
            // inspeccionesBindingSource
            // 
            this.inspeccionesBindingSource.DataMember = "inspecciones";
            this.inspeccionesBindingSource.DataSource = this.dsInspeccion;
            // 
            // dsInspeccion
            // 
            this.dsInspeccion.DataSetName = "dsInspeccion";
            this.dsInspeccion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspecciondetalleBindingSource
            // 
            this.inspecciondetalleBindingSource.DataMember = "inspeccion_detalle";
            this.inspecciondetalleBindingSource.DataSource = this.dsInspeccion;
            // 
            // rvRecepcion
            // 
            this.rvRecepcion.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "recepciones";
            reportDataSource1.Value = this.recepcionesBindingSource;
            reportDataSource2.Name = "recepcion_detalle";
            reportDataSource2.Value = this.recepciondetalleBindingSource;
            this.rvRecepcion.LocalReport.DataSources.Add(reportDataSource1);
            this.rvRecepcion.LocalReport.DataSources.Add(reportDataSource2);
            this.rvRecepcion.LocalReport.ReportEmbeddedResource = "MIS.Reportes.Recepcion.rpRecepcion.rdlc";
            this.rvRecepcion.Location = new System.Drawing.Point(0, 0);
            this.rvRecepcion.Name = "rvRecepcion";
            this.rvRecepcion.ServerReport.BearerToken = null;
            this.rvRecepcion.Size = new System.Drawing.Size(730, 745);
            this.rvRecepcion.TabIndex = 0;
            // 
            // rvInspeccion
            // 
            this.rvInspeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "inspecciones";
            reportDataSource3.Value = this.inspeccionesBindingSource;
            reportDataSource4.Name = "inspeccion_detalle";
            reportDataSource4.Value = this.inspecciondetalleBindingSource;
            this.rvInspeccion.LocalReport.DataSources.Add(reportDataSource3);
            this.rvInspeccion.LocalReport.DataSources.Add(reportDataSource4);
            this.rvInspeccion.LocalReport.ReportEmbeddedResource = "MIS.Reportes.Recepcion.rpInspeccion.rdlc";
            this.rvInspeccion.Location = new System.Drawing.Point(0, 0);
            this.rvInspeccion.Name = "rvInspeccion";
            this.rvInspeccion.ServerReport.BearerToken = null;
            this.rvInspeccion.Size = new System.Drawing.Size(730, 745);
            this.rvInspeccion.TabIndex = 1;
            // 
            // rvOrdenTrabajo
            // 
            this.rvOrdenTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource5.Name = "ordentrabajo";
            reportDataSource5.Value = this.ordentrabajoBindingSource;
            reportDataSource6.Name = "ordentrabajo_detalle";
            reportDataSource6.Value = this.ordentrabajodetalleBindingSource;
            this.rvOrdenTrabajo.LocalReport.DataSources.Add(reportDataSource5);
            this.rvOrdenTrabajo.LocalReport.DataSources.Add(reportDataSource6);
            this.rvOrdenTrabajo.LocalReport.ReportEmbeddedResource = "MIS.Reportes.Laboratorio.rpOrdenTrabajo.rdlc";
            this.rvOrdenTrabajo.Location = new System.Drawing.Point(0, 0);
            this.rvOrdenTrabajo.Name = "rvOrdenTrabajo";
            this.rvOrdenTrabajo.ServerReport.BearerToken = null;
            this.rvOrdenTrabajo.Size = new System.Drawing.Size(730, 745);
            this.rvOrdenTrabajo.TabIndex = 2;
            // 
            // dsOrdenTrabajo
            // 
            this.dsOrdenTrabajo.DataSetName = "dsOrdenTrabajo";
            this.dsOrdenTrabajo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordentrabajoBindingSource
            // 
            this.ordentrabajoBindingSource.DataMember = "ordentrabajo";
            this.ordentrabajoBindingSource.DataSource = this.dsOrdenTrabajo;
            // 
            // ordentrabajodetalleBindingSource
            // 
            this.ordentrabajodetalleBindingSource.DataMember = "ordentrabajo_detalle";
            this.ordentrabajodetalleBindingSource.DataSource = this.dsOrdenTrabajo;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 745);
            this.Controls.Add(this.rvOrdenTrabajo);
            this.Controls.Add(this.rvInspeccion);
            this.Controls.Add(this.rvRecepcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recepcionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRecepcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recepciondetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspeccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsInspeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspecciondetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOrdenTrabajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordentrabajodetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
                private Microsoft.Reporting.WinForms.ReportViewer rvRecepcion;
        private Reportes.Recepcion.dsRecepcion dsRecepcion;
        // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
        private Microsoft.Reporting.WinForms.ReportViewer rvInspeccion;
        private Reportes.Recepcion.dsInspeccion dsInspeccion;
        private System.Windows.Forms.BindingSource recepcionesBindingSource;
        private System.Windows.Forms.BindingSource recepciondetalleBindingSource;
        private System.Windows.Forms.BindingSource inspeccionesBindingSource;
        private System.Windows.Forms.BindingSource inspecciondetalleBindingSource;
        // TODO Microsoft.Reporting.WinForms.ReportViewer no longer supported.
        private Microsoft.Reporting.WinForms.ReportViewer rvOrdenTrabajo;
        private System.Windows.Forms.BindingSource ordentrabajoBindingSource;
        private Reportes.Laboratorio.dsOrdenTrabajo dsOrdenTrabajo;
        private System.Windows.Forms.BindingSource ordentrabajodetalleBindingSource;
    }
}