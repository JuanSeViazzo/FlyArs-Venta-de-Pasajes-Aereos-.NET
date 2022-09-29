using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Vista
{
    public partial class FrmModificarCliente : Form
    {
        int documentoPasajero;
        Persona pasajeroAux;
        Persona pasajeroNuevo;
        public FrmModificarCliente(int documento)
        {
            InitializeComponent();
            this.documentoPasajero = documento;
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            
            pasajeroAux = GestionDeAerolinea.obtenerClientePorDni(documentoPasajero);
            rtb_PasajeroAModificar.Text = pasajeroAux.ToString();
            cmbTipoDeDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            MostrarPasajero();

        }


        private void MostrarPasajero()
        {
            txtNombre.Text = pasajeroAux.Nombre;
            txtApellido.Text = pasajeroAux.Apellido;
            txtEdad.Text = pasajeroAux.Edad;    
            txtNacionalidad.Text = pasajeroAux.Nacionalidad;
            txtDocumento.Text = Convert.ToString(pasajeroAux.Documento);
            cmbTipoDeDocumento.SelectedIndex = (int)pasajeroAux.TipoDocumento1;
            calMyDate.SelectionStart = pasajeroAux.FechaDeNacimiento;
            if (pasajeroAux.TipoDeSexo1 is Persona.TipoDeSexo.Femenino)
            {
                rdbFemenino.Select();
            }else
                rdbMasculino.Select();
        }

        private void btn_ModificarPasajero_Click(object sender, EventArgs e)
        {
            Cliente cliente;

            Persona.TipoDeSexo sexoElegido;

            if(rdbFemenino.Checked)
            {
                sexoElegido = Persona.TipoDeSexo.Femenino;
            }else
            {
                sexoElegido = Persona.TipoDeSexo.Masculino;
            }

            try 
            {
                //Persona.Nombre = txtNombre;


                cliente = new Cliente(txtNombre.Text, txtApellido.Text, (Persona.TipoDocumento)cmbTipoDeDocumento.SelectedItem,
                int.Parse(txtDocumento.Text), txtEdad.Text, txtNacionalidad.Text, calMyDate.SelectionStart, sexoElegido);
                pasajeroNuevo = cliente;

                rtb_PasajeroAModificar.Text = cliente.ToString();

                GestionDeAerolinea.ModificarPasajeroEnLineaAerea(cliente, int.Parse(txtDocumento.Text));

            }
            catch (Exception ex)
            {
                lbl_errorExcep.Text = ex.Message;
                rtb_PasajeroAModificar.Clear();
                DialogResult resultado = MessageBox.Show("Confirmar carga", "Opcion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado is DialogResult.OK)
                {
                    GestionDeAerolinea.ListaDePersonas.Add(pasajeroNuevo);
                }
            }
          
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
