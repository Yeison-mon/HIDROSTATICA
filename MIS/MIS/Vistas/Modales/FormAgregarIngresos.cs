

using MIS.Helpers;
using MIS.Vistas.Modales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MIS.Modelos.Registros.Modales
{
    public partial class FormAgregarIngresos : Form
    {
        private int idcliente = 0;
        private int idrecepcion = 0;
        private int idingreso = 0;
        private int idmagnitudprincipal = 0;

        public FormAgregarIngresos(int _idcliente, int _idrecepcion, int _idingreso, int _idmagnitudprincipal)
        {
            InitializeComponent();
            idcliente = _idcliente;
            idrecepcion = _idrecepcion;
            idingreso = _idingreso;
            idmagnitudprincipal = _idmagnitudprincipal;
            cbIntervalo2.Visible = false;
            tlpQuinto.Visible = false;
            labelIntervalo2.Visible = false;
            cbSerie.SelectedIndex = 0;
            if (idingreso == 0)
            {
                limpiar();
            }
            else
            {
                txtSerie.ReadOnly = true;
                BuscarIngreso(idingreso);
            }
        }
        
        private void limpiar()
        {
            btnCancelar.Visible = false;
            btnAgregar.Visible = false;
            cbMagnitudes.Enabled = false;
            cbEquipos.Enabled = false;
            cbMarcas.Enabled = false;
            cbModelos.Enabled = false;
            cbMaterial.SelectedIndex = 0;
            cbMaterial.Enabled = false;
            cbObservaciones.Enabled = false;
            cbAccesorios.Enabled = false;
            cbIntervalo.Enabled = false;
            cbIntervalo2.Enabled = false;
            cbTipoIndicacion.Enabled = false;
            cbTipoServicio.Enabled = false;
            labelEquipo.Enabled = false;
            labelMagnitud.Enabled = false;
            labelMarca.Enabled = false;
            labelModelo.Enabled = false;
            labelAccesorios.Enabled = false;
            labelObsercaviones.Enabled = false;
            labelIntervalo1.Enabled = false;
            labelIntervalo2.Enabled = false;
            lbTipoIndicacion.Enabled = false;
            lbTipoServicio.Enabled = false;
            txtCodigo.Enabled = false;
            txtTipoServicio.Enabled = false;
            txtObservacion.Enabled = false;
            txtAccesorios.Enabled = false;
            txtAccesorios.Text = "";
            txtObservacion.Text = "";
            txtTipoServicio.Text = "";
            txtMaterial.Text = "";
            cbMagnitudes.DataSource = null;
            cbMagnitudes.Items.Clear();
            cbEquipos.DataSource = null;
            cbEquipos.Items.Clear();
            cbMarcas.DataSource = null;
            cbMarcas.Items.Clear();
            cbModelos.DataSource = null;
            cbModelos.Items.Clear();
            cbObservaciones.DataSource = null;
            cbObservaciones.Items.Clear();
            cbAccesorios.DataSource = null;
            cbAccesorios.Items.Clear();
            cbTipoIndicacion.DataSource = null; 
            cbTipoIndicacion.Items.Clear();
            cbTipoServicio.DataSource = null;
            cbTipoServicio.Items.Clear();
            txtCodigo.Text = "Sin Información";
            cbSerie.SelectedIndex = 0;
            Combos();
        }
        private async void Combos()
        {
            await FG.CargarCombos(cbEquipos, "equipos", "", 0);
            await FG.CargarCombos(cbMagnitudes, "magnitudes", "", 0);
            await FG.CargarCombos(cbMarcas, "marcas", "", 0);
            await FG.CargarCombos(cbModelos, "modelos", "", 0);
            await FG.CargarCombos(cbObservaciones, "observaciones", "", 0);
            await FG.CargarCombos(cbAccesorios, "accesorios", "", 0);
            await FG.CargarCombos(cbIntervalo, "intervalos", "", 0);
            await FG.CargarCombos(cbIntervalo2, "intervalos", "", 0);
            await FG.CargarCombos(cbTipoIndicacion, "tipo_indicacion", "", 0);
            await FG.CargarCombos(cbTipoServicio, "tipo_servicio", "", 0);
        }
        private async void BuscarIngreso(int id)
        {
            RecepcionRepository data = new RecepcionRepository();
            DataTable ingreso = await data.BuscarIngreso(id);
            if(ingreso != null)
            {
                if (ingreso.Rows.Count > 0)
                { 
                    cbMagnitudes.Enabled = true;
                    cbEquipos.Enabled = true;
                    cbMarcas.Enabled = true;
                    cbModelos.Enabled = true;
                    btnCancelar.Visible = true;
                    btnAgregar.Visible = true;
                    cbMaterial.Enabled = true;
                    cbObservaciones.Enabled = true;
                    cbAccesorios.Enabled = true;
                    cbIntervalo.Enabled = true;
                    cbIntervalo2.Enabled = true;
                    txtCodigo.Enabled = true;
                    txtTipoServicio.Enabled = true;
                    txtObservacion.Enabled = true;
                    labelMaterial.Enabled = true;
                    labelCodigo.Enabled = true;
                    labelEquipo.Enabled = true;
                    labelMagnitud.Enabled = true;
                    labelMarca.Enabled = true;
                    labelModelo.Enabled = true;
                    labelAccesorios.Enabled = true;
                    labelObsercaviones.Enabled = true;
                    labelIntervalo1.Enabled = true;
                    labelIntervalo2.Enabled = true;
                    txtSerie.Text = ingreso.Rows[0]["serie"].ToString();
                    txtCodigo.Text = ingreso.Rows[0]["codigo"].ToString();
                    cbSerie.SelectedIndex = ingreso.Rows[0]["con_serie"].ToString() == "SI" ? 0 : 1;
                    cbMaterial.SelectedIndex = ingreso.Rows[0]["material"].ToString() == "NO" ? 0 : 1;
                    txtAccesorios.Text = ingreso.Rows[0]["accesorios"].ToString();
                    txtObservacion.Text = ingreso.Rows[0]["observacion"].ToString();
                    txtTipoServicio.Text = ingreso.Rows[0]["tipo_servicio"].ToString();
                    await FG.CargarCombos(cbMagnitudes, "magnitudes", "", (int)ingreso.Rows[0]["idmagnitud"]);
                    await FG.CargarCombos(cbEquipos, "equipos", ingreso.Rows[0]["idmagnitud"].ToString(), (int)ingreso.Rows[0]["idequipo"]);
                    await FG.CargarCombos(cbMarcas, "marcas", "", (int)ingreso.Rows[0]["idmarca"]);
                    await FG.CargarCombos(cbModelos, "modelos", "", (int)ingreso.Rows[0]["idmodelo"]);
                    await FG.CargarCombos(cbObservaciones, "observaciones", "", 0);
                    await FG.CargarCombos(cbAccesorios, "accesorios", "", 0);
                    await FG.CargarCombos(cbTipoServicio, "tipo_servicio", "", 0);
                    await FG.CargarCombos(cbTipoIndicacion, "tipo_indicacion", "", (int)ingreso.Rows[0]["idtipoindicacion"]);
                    await FG.CargarCombos(cbIntervalo, "intervalos", ingreso.Rows[0]["idmagnitud"].ToString(), (int)ingreso.Rows[0]["idintervalo1"]);
                    //await FG.CargarCombos(cbIntervalo2, "intervalos", ingreso.Rows[0]["idmagnitud"].ToString(), (int)ingreso.Rows[0]["idintervalo2"]);

                }
            }
        }
        public event EventHandler IngresoAgregado;
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            string serie = txtSerie.Text;
            string codigo = txtCodigo.Text == "Sin Información" ? "" : txtCodigo.Text;
            int idequipo = 0;
            int idmagnitud= 0;
            int idmarca = 0;
            int idmodelo = 0;
            int idintervalo = 0;
            int idintervalo2 = 0;
            int idtipoindicacion = 0;
            string Material = cbMaterial.GetItemText(cbMaterial.SelectedItem).Trim();
            if (Material == "NO")
            {
                if (cbEquipos.SelectedValue != null)
                {
                    idequipo = (int)cbEquipos.SelectedValue;
                }

                if (cbMagnitudes.SelectedValue != null)
                {
                    idmagnitud = (int)cbMagnitudes.SelectedValue;
                }

                if (cbMarcas.SelectedValue != null)
                {
                    idmarca = (int)cbMarcas.SelectedValue;
                }

                if (cbModelos.SelectedValue != null)
                {
                    idmodelo = (int)cbModelos.SelectedValue;
                }

                if (cbIntervalo.SelectedValue != null)
                {
                    idintervalo = (int)cbIntervalo.SelectedValue;
                }

                if (cbIntervalo2.SelectedValue != null)
                {
                    idintervalo2 = (int)cbIntervalo2.SelectedValue;
                }

                if (cbTipoIndicacion.SelectedValue != null)
                {
                    idtipoindicacion = (int)cbTipoIndicacion.SelectedValue;
                }
                bool material = cbMaterial.Text != "NO";
                string accesorios = txtAccesorios.Text;
                string observaciones = txtObservacion.Text;
                string tipo_servicio = txtTipoServicio.Text;
                if (idmagnitudprincipal != idmagnitud && idmagnitudprincipal > 0)
                {
                    MessageBox.Show("Los siguientes registros deben de ser de la misma magnitud");
                    limpiar();
                }
                if (idequipo == 0)
                {
                    MessageBox.Show("Debe de seleccionar el equipo", "Alerta", MessageBoxButtons.OK);
                    cbEquipos.Focus();
                }
                else if (idmagnitud == 0)
                {
                    MessageBox.Show("Debe de seleccionar la magnitud", "Alerta", MessageBoxButtons.OK);
                    cbMagnitudes.Focus();
                }
                else if (idmarca == 0)
                {
                    MessageBox.Show("Debe de seleccionar la marca", "Alerta", MessageBoxButtons.OK);
                    cbMarcas.Focus();
                }
                else if (idmodelo == 0)
                {
                    MessageBox.Show("Debe de seleccionar el modelo", "Alerta", MessageBoxButtons.OK);
                    cbModelos.Focus();
                }
                else if (observaciones == "")
                {
                    MessageBox.Show("Debe de agregar la(s) observaciones", "Alerta", MessageBoxButtons.OK);
                    cbModelos.Focus();
                }
                else if (idtipoindicacion == 0)
                {
                    MessageBox.Show("Debe elegir el tipo de indicación del equipo", "Alerta", MessageBoxButtons.OK);
                    cbTipoIndicacion.Focus();
                }
                else if (txtTipoServicio.Text == "")
                {
                    MessageBox.Show("Debe elegir el tipo de servicio del equipo", "Alerta", MessageBoxButtons.OK);
                    cbTipoServicio.Focus();
                }
                else
                {
                    RecepcionRepository guardar = new RecepcionRepository();
                    bool guardado = await guardar.GuardarIngreso(idingreso, idrecepcion, idcliente, serie, codigo, idequipo, idmagnitud, idintervalo, idintervalo2, idmarca, idmodelo, "", material, accesorios, observaciones, idtipoindicacion, tipo_servicio);
                    if (guardado)
                    {
                        txtSerie.Text = "";
                        limpiar();
                        txtSerie.Focus();
                        OnIngresoAgregado();
                    }
                }
            } else
            {
                string descripcion = txtMaterial.Text;
                if (descripcion == "")
                {
                    MessageBox.Show("Debe de llenar la descripción del Patrón/Material de referencia");
                } else
                {
                    RecepcionRepository guardar = new RecepcionRepository();
                    bool guardado = await guardar.GuardarMaterial(idingreso, idrecepcion, idcliente, descripcion, serie, codigo);
                    if (guardado)
                    {
                        txtSerie.Text = "";
                        BuscarSerie(sender, e);
                        OnIngresoAgregado();
                    }
                }
            }
            
        }
        protected virtual void OnIngresoAgregado()
        {
            IngresoAgregado?.Invoke(this, EventArgs.Empty);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                BuscarSerie(sender, e);
                cbMagnitudes.Focus();
            }
        }
        private async void BuscarSerie(object sender, EventArgs e)
        {
            string valor = cbSerie.GetItemText(cbSerie.SelectedItem).Trim();
            if (txtSerie.Text != "")
            {
                RecepcionRepository buscar = new RecepcionRepository();
                bool encontrado = await buscar.BuscarSerie(txtSerie.Text, idcliente, idrecepcion);
                if (encontrado)
                {
                    MessageBox.Show("Ya existe esta serie en la tabla actual", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }
            if ((txtSerie.Text.Length > 0 && valor == "SI") || valor == "NO")
            {
                cbMagnitudes.Enabled = true;
                cbEquipos.Enabled = true;
                cbMarcas.Enabled = true;
                cbModelos.Enabled = true;
                btnAgregar.Enabled = true;
                txtSerie.ReadOnly = true;
                txtObservacion.Enabled = true;
                txtAccesorios.Enabled = true;
                txtMaterial.Enabled = true;
                txtCodigo.Enabled = true;
                cbMaterial.Enabled = true;
                labelEquipo.Enabled = true;
                labelMagnitud.Enabled = true;
                labelMarca.Enabled = true;
                labelModelo.Enabled = true;
                labelAccesorios.Enabled = true;
                labelObsercaviones.Enabled = true;
                cbObservaciones.Enabled = true;
                cbAccesorios.Enabled = true;
                cbIntervalo.Enabled = true;
                cbIntervalo2.Enabled = true;
                labelIntervalo1.Enabled = true;
                labelIntervalo2.Enabled = true;
                lbTipoServicio.Enabled = true;
                lbTipoIndicacion.Enabled = true;
                cbTipoServicio.Enabled = true;
                cbTipoIndicacion.Enabled = true;        
            } else if (idingreso == 0 && txtSerie.Text.Length == 0 && valor == "SI")
            {
                cbMagnitudes.Enabled = false;
                cbEquipos.Enabled = false;
                cbMarcas.Enabled = false;
                cbModelos.Enabled = false;
                btnCancelar.Visible = false;
                btnAgregar.Visible = false;
                cbMaterial.SelectedIndex = 0;
                cbMaterial.Enabled = false;
                cbObservaciones.Enabled = false;
                cbAccesorios.Enabled = false;
                cbIntervalo.Enabled = false;
                cbIntervalo2.Enabled = false;
                labelEquipo.Enabled = false;
                labelMagnitud.Enabled = false;
                labelMarca.Enabled = false;
                labelModelo.Enabled = false;
                labelAccesorios.Enabled = false;
                labelObsercaviones.Enabled = false;
                labelIntervalo1.Enabled = false;
                labelIntervalo2.Enabled = false;
                lbTipoServicio.Enabled = false;
                lbTipoIndicacion.Enabled = false;
                cbTipoServicio.Enabled = false;
                cbTipoIndicacion.Enabled = false;
                txtAccesorios.Text = "";
                txtObservacion.Text = "";
                txtTipoServicio.Text = "";
                txtMaterial.Text = "";
                txtCodigo.Text = "Sin Información";
                txtSerie.Text = "";
                txtObservacion.Enabled = false;
                txtAccesorios.Enabled = false;
                txtMaterial.Enabled = false;
                txtSerie.ReadOnly = false;
                Combos();
            }
        }
        private void txtSerie_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbSerie.Focused)
                return;

            if (string.IsNullOrEmpty(txtSerie.Text) && cbSerie.SelectedIndex == 0)
            {
                MessageBox.Show("Debe de agregar la serie del equipo", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            } else
            {
                btnAgregar.Visible = true;
                btnCancelar.Visible = true;
            }
            
        }
        private async void cbMagnitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMagnitudes.DataSource != null)
            {
                string id = cbMagnitudes.SelectedValue.ToString();
                await FG.CargarCombos(cbEquipos, "equipos", id, 0);
                await FG.CargarCombos(cbIntervalo, "intervalos", id, 0);
            }
        }
        private async void cbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEquipos.DataSource != null)
            {
                int id = (int)cbEquipos.SelectedValue;
                if (id > 0 && !((int)cbMagnitudes.SelectedValue > 0))
                {
                    await FG.CargarCombos(cbMagnitudes, "magnitudes", $"{id}", 0);
                }
            }
            
        }
        private async void cbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMarcas.DataSource != null)
            {
                int id = (int)cbMarcas.SelectedValue;
                await FG.CargarCombos(cbModelos, "modelos", $"{id}", 0);
            }
        }
        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cbMaterial.GetItemText(cbMaterial.SelectedItem).Trim();
            if (valor == "SI")
            {
                tlpSegundo.Visible = false;
                tlpTercero.Visible = false;
                tlpCuarto.Visible = false;
                tlpQuinto.Visible = true;
                tlpSexto.Visible = false;
                tlpSeptimo.Visible = false;
            }
            else
            {
                tlpSegundo.Visible = true;
                tlpTercero.Visible = true;
                tlpCuarto.Visible = true;
                tlpQuinto.Visible = false;
                tlpSexto.Visible = true;
                tlpSeptimo.Visible = true;
            }
        }
        #region Agregar Items Combos
        private async void labelMagnitud_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("magnitudes", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbMagnitudes, "magnitudes", "", 0);
                        cbMagnitudes.SelectedItem = texto;
                    }
                }
            }
            
        }
        private async void labelEquipo_Click(object sender, EventArgs e)
        {
            if((int)cbMagnitudes.SelectedValue > 0)
            {
                string id = cbMagnitudes.SelectedValue.ToString();
                using (FormAgregarDescripciones form = new FormAgregarDescripciones())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        string texto = form.TextoIngresado;
                        bool guardadoExitoso = await combosRepository.GuardarNuevoValor("equipos", texto, id);
                        if (guardadoExitoso)
                        {

                            await FG.CargarCombos(cbEquipos, "equipos", id, 0);
                            cbEquipos.SelectedItem = texto;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Debe de seleccionar la magnitud", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMagnitudes.Focus();
            }
            
        }
        private async void labelMarca_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("marcas", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbMarcas, "marcas", "", 0);
                        cbMarcas.SelectedItem = texto;
                    }
                }
            }
        }
        private async void labelModelo_Click(object sender, EventArgs e)
        {
            if((int)cbMarcas.SelectedValue > 0)
            {
                string id = cbMarcas.SelectedValue.ToString();
                using (FormAgregarDescripciones form = new FormAgregarDescripciones())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        string texto = form.TextoIngresado;
                        bool guardadoExitoso = await combosRepository.GuardarNuevoValor("modelos", texto, id);
                        if (guardadoExitoso)
                        {

                            await FG.CargarCombos(cbModelos, "modelos", id, 0);
                            cbModelos.SelectedItem = texto;
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Debe de seleccionar la magnitud", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMarcas.Focus();
            }
            
        }
        private async void labelAccesorios_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("accesorios", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbAccesorios, "accesorios", "", 0);
                        cbAccesorios.SelectedItem = texto;
                    }
                }
            }
        }
        private void cbAccesorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = this.cbAccesorios.GetItemText(this.cbAccesorios.SelectedItem);
            if (valor != "--SELECCIONE--")
            {
                string texto = txtAccesorios.Text;
                if (texto != "")
                {
                    string[] palabras = texto.Split(',');
                    if (!palabras.Contains(valor))
                    {
                        txtAccesorios.Text += ", " + valor;
                    }
                }
                else
                {
                    txtAccesorios.Text = valor;
                }
            }

        }
        private void cbObservaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = this.cbObservaciones.GetItemText(this.cbObservaciones.SelectedItem);
            if (valor != "--SELECCIONE--")
            {
                string texto = txtObservacion.Text;
                if (texto != "")
                {
                    string[] palabras = texto.Split(',');
                    if (!palabras.Contains(valor))
                    {
                        txtObservacion.Text += ", " + valor;
                    }
                }
                else
                {
                    txtObservacion.Text = valor;
                }
            }

        }
        private async void labelObsercaviones_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("observaciones", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbObservaciones, "observaciones", "", 0);
                        cbObservaciones.SelectedItem = texto;
                    }
                }
            }
        }
        private async void labelIntervalo1_Click(object sender, EventArgs e)
        {
            if ((int)cbMagnitudes.SelectedValue == 0) 
            {
                MessageBox.Show("Debe de Seleccionar la magnitud", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMagnitudes.Focus();
            } else
            {
                using (FormAgregarIntervalos form = new FormAgregarIntervalos((int)cbMagnitudes.SelectedValue))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        CombosRepository combosRepository = new CombosRepository();
                        bool guardadoExitoso = await combosRepository.GuardarIntervalos(form.desde, form.hasta, form.medida, (int)cbMagnitudes.SelectedValue);
                        if (guardadoExitoso)
                        {
                            await FG.CargarCombos(cbIntervalo, "intervalos", "", 0);
                            await FG.CargarCombos(cbIntervalo2, "intervalos", "", 0);
                        }
                    }
                }
            }
            
        }
        private async void lbTipoServicio_Click(object sender, EventArgs e)
        {
            using (FormAgregarDescripciones form = new FormAgregarDescripciones())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    CombosRepository combosRepository = new CombosRepository();
                    string texto = form.TextoIngresado;
                    bool guardadoExitoso = await combosRepository.GuardarNuevoValor("tipo_servicio", texto, "");
                    if (guardadoExitoso)
                    {

                        await FG.CargarCombos(cbTipoServicio, "tipo_servicio", "", 0);
                        cbObservaciones.SelectedItem = texto;
                    }
                }
            }
        }
        private void cbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = cbTipoServicio.GetItemText(cbTipoServicio.SelectedItem).Trim();

            if (valor != "--SELECCIONE--")
            {
                string texto = txtTipoServicio.Text.Trim();
                if (texto != "")
                {
                    List<string> palabras = texto.Split(',').Select(p => p.Trim()).ToList();
                    if (palabras.Contains(valor))
                        palabras.RemoveAll(p => p == valor);
                    else
                        palabras.Add(valor);
                    texto = string.Join(", ", palabras);
                }
                else
                {
                    texto = valor;
                }
                txtTipoServicio.Text = texto;
                cbTipoServicio.SelectedIndex = 0;
            }
        }
        #endregion
        #region Funcionalidades del formulario
        private bool mouseDown;
        private Point lastLocation;
        private void Tittle_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Tittle_Bar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Tittle_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calcula la diferencia entre la posición actual del mouse y la última posición registrada
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;

                // Mueve el formulario a la nueva posición
                this.Left += deltaX;
                this.Top += deltaY;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void labelSerie_Click(object sender, EventArgs e)
        {
            txtSerie.ReadOnly = false;
            txtSerie.Focus();
        }

        private void cbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSerie.SelectedIndex == 1)
            {
                txtSerie.Text = "";
                txtSerie.Enabled = false;
                btnAgregar.Visible = true;
                btnCancelar.Visible = true;
            }
            else
            {
                txtSerie.Enabled = true;
                txtSerie.Focus();
            }
            BuscarSerie(sender, e);
        }
    }
}