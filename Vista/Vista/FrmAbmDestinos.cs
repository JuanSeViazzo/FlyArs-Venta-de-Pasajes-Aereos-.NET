using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmAbmDestinos : Form
    {
        string dato;
        public FrmAbmDestinos(string dato)
        {
            InitializeComponent();
            this.dato = dato;
        }

        private void AbmDestinos_Load(object sender, EventArgs e)
        {
            cmbBoolNacOInt.Visible = false;
            cmbDestino.Visible = false;
            txtAlta.Visible = false;
            txtModificacion.Visible = false;
            txtPais.Visible = false;
            lblAlta.Visible = false;


            foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                cmbDestino.Items.Add(item.Value);
            }


            if (dato == "Alta")
            {
                lblAlta.Text = "Indique Si es Nacional o Internacional";
                cmbBoolNacOInt.Visible = true;
                cmbBoolNacOInt.Items.Add("Nacional");
                cmbBoolNacOInt.Items.Add("Internacional");
                txtAlta.Visible = true;

            }

            if (dato == "Baja")
            {
                cmbDestino.Visible = true;
                lblDestinoBajaModificacion.Text = "Seleccione el destino a dar de baja";
            }


            if (dato == "Modificacion")
            {
                cmbDestino.Visible = true;
                lblDestinoBajaModificacion.Text = "Seleccione el destino a modificar";
                txtModificacion.Visible = true;
                cmbBoolNacOInt.Visible = true;
                cmbBoolNacOInt.Items.Add("Nacional");
                cmbBoolNacOInt.Items.Add("Internacional");
                cmbDestino.Items.Clear();
            }


        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            string nuevo;
            string modificar;

            DialogResult resultado = MessageBox.Show("Desea confirmar los cambios?", $"{dato}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                try
                {
                    if (dato == "Alta")
                    {
                        nuevo = CargaDeAltaDestino();

                    }
                    if (dato == "Baja")
                    {
                        BajaDeDestino();

                    }
                    if (dato == "Modificacion")
                        modificar = ModificarDestino();

                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception ex)
                {
                    lblAlta.Visible = true;
                    lblAlta.Text = ex.Message;
                    this.DialogResult = DialogResult.None;
                }

                if (this.DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }

        }

        private string ModificarDestino()
        {
            string modificar;
            {

                if (cmbBoolNacOInt.SelectedIndex == 1)
                {
                    modificar = ModificarDestinoInternacional();
                }
                else
                {
                    modificar = ModificarDestinoNacional();
                }
            }

            return modificar;
        }

        private string ModificarDestinoNacional()
        {
            string modificar;
            if (cmbBoolNacOInt.SelectedIndex == 0)
            {


                if (Validaciones.ValidarString(txtModificacion.Text))
                {

                    string codigo = txtModificacion.Text.Substring(0, 3).ToUpper();
                    modificar = codigo + " " + txtModificacion.Text;
                    RecorrerDestinoYModificar(modificar);
                }
                else
                {
                    throw new Exception("El destino debe ser solo letras");
                }

            }
            else
            {
                throw new Exception("Debe elegir Nacional o Internacional");
            }

            return modificar;
        }

        private void RecorrerDestinoYModificar(string modificar)
        {
            foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (item.Value == (string)cmbDestino.SelectedItem)
                {
                    GestionDeAerolinea.DiccionarioDeAeropuertos[item.Key] = modificar;
                }

                break;

            }
        }

        private string ModificarDestinoInternacional()
        {
            string modificar;
            if (Validaciones.ValidarString(txtModificacion.Text) && Validaciones.ValidarString(txtModificacion.Text))
            {

                string codigo = txtModificacion.Text.Substring(0, 3).ToUpper();
                modificar = codigo + " " + txtModificacion.Text + ($"({txtPais.Text})");
                RecorrerDestinoYModificar(modificar);
            }
            else
            {
                throw new Exception("El destino debe ser solo letras");
            }

            return modificar;
        }

        private void BajaDeDestino()
        {
            if (cmbDestino.SelectedIndex < 0)
            {
                throw new Exception("Debe elegir un destino");
            }

            foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (item.Value == (string)cmbDestino.SelectedItem)
                {
                    GestionDeAerolinea.DiccionarioDeAeropuertos.Remove(item.Key);
                }
            }
        }

        private string CargaDeAltaDestino()
        {
            string nuevo;
            if (cmbBoolNacOInt.SelectedIndex == 1)
            {
                nuevo = ValidacionYCargaInternacional();
            }
            else
            {
                if (cmbBoolNacOInt.SelectedIndex == 0)
                {
                    nuevo = ValidacionYCargaNacional();

                }
                else
                {
                    throw new Exception("Debe elegir Nacional o Internacional");
                }
            }

            return nuevo;
        }

        private string ValidacionYCargaNacional()
        {
            string nuevo;
            if (Validaciones.ValidarString(txtAlta.Text))
            {

                string codigo = txtAlta.Text.Substring(0, 3).ToUpper();
                nuevo = codigo + " " + txtAlta.Text;
                RecorrerDestinosYCargarNuevo(nuevo);


            }
            else
            {
                throw new Exception("El destino debe ser solo letras");
            }

            return nuevo;
        }

        private string ValidacionYCargaInternacional()
        {
            string nuevo;
            if (Validaciones.ValidarString(txtAlta.Text) && Validaciones.ValidarString(txtPais.Text))
            {

                string codigo = txtAlta.Text.Substring(0, 3).ToUpper();
                nuevo = codigo + " " + txtAlta.Text + ($"({txtPais.Text})");
                RecorrerDestinosYCargarNuevo(nuevo);

            }
            else
            {
                throw new Exception("El destino debe ser solo letras");
            }

            return nuevo;
        }

        private static void RecorrerDestinosYCargarNuevo(string nuevo)
        {
            foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                KeyValuePair<int, string> itemLast = GestionDeAerolinea.DiccionarioDeAeropuertos.Last();
                GestionDeAerolinea.DiccionarioDeAeropuertos.Add(itemLast.Key + 1, nuevo);
                break;

            }
        }

        private void cmbBoolNacOInt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();

            if (cmbBoolNacOInt.SelectedIndex == 1)
            {
                txtPais.Visible = true;
                foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
                {
                    if (item.Key >= 1000)
                    {
                        cmbDestino.Items.Add(item.Value);
                    }
                }
            }else
            {
                foreach (var item in GestionDeAerolinea.DiccionarioDeAeropuertos)
                {
                    if (item.Key < 1000)
                    {
                        cmbDestino.Items.Add(item.Value);
                    }
                }
                txtPais.Visible = false;

            }
            lblAlta.Text = "";
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAlta.Text = "";

        }
    }
}
