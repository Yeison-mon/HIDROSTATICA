using MIS.Helpers;
using MIS.Modelos.Laboratorio;
using MIS.Vistas.Modales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS.Vistas.Laboratorio
{
    public partial class FormProcesoFinal : Form
    {
        private int odt = 0;
        private int ipf = 0;
        private int idrecepcion = 0;
        public FormProcesoFinal()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            txtCliente.Text = string.Empty;
            txtNroODT.Text = string.Empty;
            txtEstado.Text = "Temporal";
            txtObservacion.Text = string.Empty;
            txtNroIPF.Text = string.Empty;
            dtFechaIPF.Value = DateTime.Now;
            dtFechaODT.Value = DateTime.Now;
            btnGuardar.Visible = false;
            btnImprimir.Visible = false;
            btnLimpiar.Visible = false;
            tablaDetalle.DataSource = null;
            tablaDetalle.Rows.Clear();
            tablaDetalle.Columns.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FormRecepciones form = new FormRecepciones(0, "IPF"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    idrecepcion = form.idrecepcion;
                    Buscar(idrecepcion, 0, 0);
                }
            }
        }

        private async void Buscar(int idrecepcion, int odt, int ipf)
        {
            ProcesoFinalRepository buscar = new ProcesoFinalRepository();
            DataTable tabla = await buscar.Buscar(idrecepcion, odt, ipf);
            if (tabla != null && tabla.Rows.Count > 0)
            {
                txtCliente.Text = tabla.Rows[0]["cliente"].ToString();
                txtEstado.Text = tabla.Rows[0]["estado"].ToString() != "" ? tabla.Rows[0]["estado"].ToString() : "Temporal";
                this.odt = (int)tabla.Rows[0]["ordentrabajo"];
                txtNroODT.Text = tabla.Rows[0]["ordentrabajo"].ToString();
                txtNroIPF.Text = tabla.Rows[0]["procesofinal"].ToString() != "0" ? tabla.Rows[0]["procesofinal"].ToString() : "";
                dtFechaODT.Value = (DateTime)tabla.Rows[0]["fecha_orden"];
                dtFechaIPF.Value = tabla.Rows[0]["fecha"].ToString() != "" ? (DateTime)tabla.Rows[0]["fecha"] : DateTime.Now;
                int id = (int)tabla.Rows[0]["id"];
                Detalle(id);
            }
        }

        private async void Detalle(int id)
        {
            tablaDetalle.DataSource = null;
            tablaDetalle.Rows.Clear();
            tablaDetalle.Columns.Clear();
            ProcesoFinalRepository ingresos = new ProcesoFinalRepository();
            DataTable tabla = await ingresos.Detalle(id);
            if (tabla != null && tabla.Rows.Count > 0)
            {
                btnGuardar.Visible = true;
                btnLimpiar.Visible = true;
                tablaDetalle.DataSource = tabla;
                tablaDetalle.CurrentCell = null;
                tablaDetalle.DefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
                tablaDetalle.Columns["id"].Visible = false;
                tablaDetalle.Columns["id"].DisplayIndex = 0;
                tablaDetalle.Columns["renglon"].HeaderText = "Renglon";
                tablaDetalle.Columns["renglon"].DisplayIndex = 1;
                tablaDetalle.Columns["ingreso"].HeaderText = "Ingreso";
                tablaDetalle.Columns["ingreso"].DisplayIndex = 2;
                tablaDetalle.Columns["descripcion"].HeaderText = "Descripción";
                tablaDetalle.Columns["descripcion"].DisplayIndex = 3;
                tablaDetalle.Columns["descripcion"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns["lavado"].Visible = false;
                tablaDetalle.Columns["componenetes"].Visible = false;
                tablaDetalle.Columns["desarme"].Visible = false;
                tablaDetalle.Columns["ensamblaje"].Visible = false;
                tablaDetalle.Columns["certificado"].Visible = false;
                tablaDetalle.Columns["fecha_certificado"].Visible = false;
                tablaDetalle.Columns["tipo"].Visible = false;
                tablaDetalle.Columns["observacion"].Visible = false;
                
                DataGridViewTextBoxColumn columnaLavado = new DataGridViewTextBoxColumn();
                columnaLavado.Name = "ColumnLavado";
                columnaLavado.HeaderText = "Lavado";
                columnaLavado.DisplayIndex = 4;
                columnaLavado.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaLavado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(columnaLavado);

                DataGridViewTextBoxColumn ColumnnaComponentes = new DataGridViewTextBoxColumn();
                ColumnnaComponentes.Name = "ColumnnaComponentes";
                ColumnnaComponentes.HeaderText = "Componenetes";
                ColumnnaComponentes.DisplayIndex = 5;
                ColumnnaComponentes.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                ColumnnaComponentes.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(ColumnnaComponentes);
                
                DataGridViewTextBoxColumn columnaDesarme = new DataGridViewTextBoxColumn();
                columnaDesarme.Name = "columnaDesarme";
                columnaDesarme.HeaderText = "Desarme";
                columnaDesarme.DisplayIndex = 6;
                columnaDesarme.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaDesarme.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(columnaDesarme);

                DataGridViewTextBoxColumn columnaEnsamblaje = new DataGridViewTextBoxColumn();
                columnaEnsamblaje.Name = "columnaEnsamblaje";
                columnaEnsamblaje.HeaderText = "Ensamblaje";
                columnaEnsamblaje.DisplayIndex = 7;
                columnaEnsamblaje.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaEnsamblaje.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(columnaEnsamblaje);
                
                tablaDetalle.Columns["nomenclatura"].HeaderText = "Nomenclatura";
                tablaDetalle.Columns["nomenclatura"].DisplayIndex = 8;

                DataGridViewTextBoxColumn columnaCertificado = new DataGridViewTextBoxColumn();
                columnaCertificado.Name = "columnaCertificado";
                columnaCertificado.HeaderText = "Certificado";
                columnaCertificado.DisplayIndex = 9;
                columnaCertificado.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaCertificado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(columnaCertificado);

                DataGridViewTextBoxColumn columnaFechaCertificado = new DataGridViewTextBoxColumn();
                columnaFechaCertificado.Name = "columnaFechaCertificado";
                columnaFechaCertificado.HeaderText = "Fecha Certificado";
                columnaFechaCertificado.DisplayIndex = 10;
                columnaFechaCertificado.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaFechaCertificado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tablaDetalle.Columns.Add(columnaFechaCertificado);

                DataTable comboBoxData = new DataTable();
                comboBoxData.Columns.Add("ID", typeof(int));
                comboBoxData.Columns.Add("Name", typeof(string));

                // Agregar filas al DataTable
                comboBoxData.Rows.Add(1, "Acreditado");
                comboBoxData.Rows.Add(2, "Trazabilidad");
                comboBoxData.Rows.Add(3, "Informe");
                comboBoxData.Rows.Add(0, "N/A");
                
                // Agregar columna de selección
                DataGridViewComboBoxColumn columnaSeleccion = new DataGridViewComboBoxColumn();
                columnaSeleccion.Name = "ColumnaTipo";
                columnaSeleccion.HeaderText = "Tipo servicio";
                columnaSeleccion.DataSource = comboBoxData; // Asignar el DataTable como fuente de datos
                columnaSeleccion.ValueMember = "ID"; // El valor que se guarda en la celda
                columnaSeleccion.DisplayMember = "Name"; // El texto que se muestra en el combo box
                columnaSeleccion.DisplayIndex = 11;
                columnaSeleccion.DefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
                columnaSeleccion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
            }
        }
        private void tablaDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (
                columnIndex == tablaDetalle.Columns["ColumnLavado"].Index ||
                columnIndex == tablaDetalle.Columns["ColumnnaComponentes"].Index ||
                columnIndex == tablaDetalle.Columns["columnaDesarme"].Index ||
                columnIndex == tablaDetalle.Columns["columnaEnsamblaje"].Index ||
                columnIndex == tablaDetalle.Columns["columnaCertificado"].Index ||
                columnIndex == tablaDetalle.Columns["columnaFechaCertificado"].Index || 
                columnIndex == tablaDetalle.Columns["ColumnaTipo"].Index
                )
            {
                tablaDetalle.EditMode = DataGridViewEditMode.EditOnEnter;
            }
            else
            {
                tablaDetalle.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
    }
}
