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
        string documentoPasajero;
        Pasajero pasajeroAux;
        Pasajero pasajeroNuevo;
        public FrmModificarCliente(string documento)
        {
            InitializeComponent();
            this.documentoPasajero = documento;
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            
            pasajeroAux = GestionDeAerolinea.obtenerPasajeroPorDni(documentoPasajero);
            rtb_PasajeroAModificar.Text = pasajeroAux.Mostrar();
            cmbTipoDeDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            MostrarPasajero();

        }


        private void MostrarPasajero()
        {
            txtNombre.Text = pasajeroAux.Nombre;
            txtApellido.Text = pasajeroAux.Apellido;
            txtEdad.Text = pasajeroAux.Edad;    
            txtNacionalidad.Text = pasajeroAux.Nacionalidad;
            txtDocumento.Text = pasajeroAux.Documento;
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
            Pasajero pasajero;

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
                pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, (Persona.TipoDocumento)cmbTipoDeDocumento.SelectedItem,
                txtDocumento.Text, txtEdad.Text, txtNacionalidad.Text, calMyDate.SelectionStart, sexoElegido);
                pasajeroNuevo = pasajero;

                rtb_PasajeroAModificar.Text = pasajero.Mostrar();

                GestionDeAerolinea.ModificarPasajeroEnLineaAerea(pasajero, txtDocumento.Text);

            }
            catch (Exception ex)
            {
                lbl_errorExcep.Text = ex.Message;
                rtb_PasajeroAModificar.Clear();
                DialogResult resultado = MessageBox.Show("Confirmar carga", "Opcion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (resultado is DialogResult.OK)
                {
                    GestionDeAerolinea.ListaDePasajeros.Add(pasajeroNuevo);
                }
            }
          
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
    }
}
