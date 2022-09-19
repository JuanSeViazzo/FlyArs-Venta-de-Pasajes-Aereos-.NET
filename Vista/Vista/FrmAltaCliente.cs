using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaCliente : Form
    {
        Pasajero pasajero;
        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cmb_tipoDeDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));
            // cmb_TipoDeEquipaje.DataSource = Enum.GetValues(typeof(Equipaje.TipoDeEquipaje));

        }

        private void btn_aceptarPasajero_Click(object sender, EventArgs e)
        {
            Persona.TipoDeSexo sexoElegido = Persona.TipoDeSexo.Femenino;

            foreach (RadioButton radioButton in grpSex.Controls)
            {
                if (radioButton.Checked)
                {
                    sexoElegido = (Persona.TipoDeSexo)radioButton.TabIndex;
                    break;
                }
            }

            try
            {
                pasajero = new Pasajero(txtNombre.Text, txtApellido.Text, (Persona.TipoDocumento)cmb_tipoDeDocumento.SelectedItem,
                Txt_numeroDeDocumento.Text, txtEdad.Text, txtNacionalidad.Text, calMyDate.SelectionStart, sexoElegido);

                rtbPasajero.Text = pasajero.Mostrar();

                GestionDeAerolinea.CargarPasajeroEnLineaAerea(pasajero);

            }
            catch (Exception ex)
            {
                lbl_errorExcep.Text = ex.Message;
                rtbPasajero.Clear();

            }

            // pasajero.CargarEquipaje(txt_equipajeUno.Text);
            // pasajero.CargarEquipaje(txt_EquipajeDos.Text);


        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       







    }
}
