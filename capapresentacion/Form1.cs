using capanegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capapresentacion
{
    public partial class Form1 : Form
    {
        private bool Esnuevo = false;
        private bool Eseditar = false;

        public Form1()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtNombre, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.txtApellido, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.comboGenero, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.dtFechaNacimiento, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.dtFechaIngreso, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.txtNacionalidad, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.comboEstatus, "** Campo Obligatorio **");
            this.ttMensaje.SetToolTip(this.txtFuncion, "** Campo Obligatorio **");

        }
        //Mostrar mensaje de confirmacion
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de Error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Metodo Limpiar

        private void Limpiar()
        {
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.MtxtTelefono.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.MtxtCedula.Text = string.Empty;
            this.comboGenero.Text = string.Empty;
            this.txtCondicionMedica.Text = string.Empty;
            this.dtFechaNacimiento.Text = string.Empty;
            this.dtFechaIngreso.Text = string.Empty;
            this.txtCorreoElectronico.Text = string.Empty;
            this.txtNacionalidad.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.comboEstatus.Text = string.Empty;
            this.txtFuncion.Text = string.Empty;
            this.txtNombre.Focus();

        }

        private void Habilitar(bool valor)
        {

            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.MtxtTelefono.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.MtxtCedula.ReadOnly = !valor;
            this.txtCondicionMedica.ReadOnly = !valor;
            this.txtCorreoElectronico.ReadOnly = !valor;
            this.txtNacionalidad.ReadOnly = !valor;
            this.txtTitulo.ReadOnly = !valor;
            this.txtFuncion.ReadOnly = !valor;
        }
        private void Botones()
        {
            if (this.Esnuevo || this.Eseditar)
            {
                this.Habilitar(true);
                this.BtnNuevo.Enabled = false;
                this.btnInsertar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnLimpiar.Enabled = true;
                this.btnCancelar.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.BtnNuevo.Enabled = true;
                this.btnInsertar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnLimpiar.Enabled = false;
                this.btnCancelar.Enabled = true;
            }

        }

        private void Ocultar()
        {
            //this.dtListado.Columns[0].Visible = false;
            //this.dtListado.Columns[1].Visible = false;
        }
        public void Mostrar()
        {
            this.dtListado.DataSource = NegocioAdministrativo.Mostrar();
            this.Ocultar();
            lblhola.Text = "total De registro:" + Convert.ToString(dtListado.Rows.Count);
        }

        public void BuscarNombre()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarNombre(this.txtListado.Text);

            this.Ocultar();
            lblhola.Text = "total De registro:" + Convert.ToString(dtListado.Rows.Count);
        }
        public void BuscarCedula()
        {
            this.dtListado.DataSource = NegocioAdministrativo.BuscarNombre(this.txtListado.Text);

            this.Ocultar();
            lblhola.Text = "total De registro:" + Convert.ToString(dtListado.Rows.Count);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.Esnuevo = true;
            this.Eseditar = false;
            this.Botones();
            this.Habilitar(true);
            this.Limpiar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty ||
                    this.comboGenero.Text == string.Empty || this.txtNacionalidad.Text == string.Empty ||
                    this.comboEstatus.Text == string.Empty || this.txtFuncion.Text == string.Empty)
                {

                    MessageBox.Show("No se pudo guardar de forma correcta el registro, Completar campos Obligatorios!");
                    erroricono.SetError(txtNombre, "**Campo Obligatorio**");
                    erroricono.SetError(txtApellido, "**Campo Obligatorio**");
                    erroricono.SetError(comboGenero, "**Campo Obligatorio**");
                    erroricono.SetError(txtNacionalidad, "**Campo Obligatorio**");
                    erroricono.SetError(comboEstatus, "**Campo Obligatorio**");
                    erroricono.SetError(txtFuncion, "**Campo Obligatorio**");

                }
                else
                {
                    if (this.Esnuevo)
                    {
                        respuesta = NegocioAdministrativo.Insertar(this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(),
                            this.MtxtTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.MtxtCedula.Text.Trim(), this.comboGenero.Text.Trim(),
                        this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
                    }
                    else
                    {
                        respuesta = NegocioAdministrativo.Editar(Convert.ToInt32(this.txtId.Text.Trim()), this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(),
                                                   this.MtxtTelefono.Text.Trim(), this.txtDireccion.Text.Trim(), this.MtxtCedula.Text.Trim(), this.comboGenero.Text.Trim(),
                                               this.txtCondicionMedica.Text.Trim(), this.dtFechaNacimiento.Value, this.dtFechaIngreso.Value, this.txtCorreoElectronico.Text.Trim(), this.txtNacionalidad.Text.Trim(), this.txtTitulo.Text.Trim(), this.comboEstatus.Text.Trim(), this.txtFuncion.Text.Trim());
                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.Esnuevo)
                        {
                            this.MensajeOK("Se inserto de forma correcta el registro.");
                        }
                        else
                        {
                            this.MensajeOK("Se Actualizo de forma correcta el registro.");
                        }

                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.Esnuevo = false;
                    this.Eseditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace + "Botom Insertar");
            }
        }

        private void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblhola_Click(object sender, EventArgs e)
        {

        }

        private void lblFornularioAdministrativo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
