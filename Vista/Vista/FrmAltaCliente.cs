using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAltaCliente : Form
    {
        public Persona cliente;
        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            cmb_tipoDeDocumento.DataSource = Enum.GetValues(typeof(Persona.TipoDocumento));

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
                cliente = new Cliente(txtNombre.Text, txtApellido.Text, (Persona.TipoDocumento)cmb_tipoDeDocumento.SelectedItem,
                int.Parse(Txt_numeroDeDocumento.Text), txtEdad.Text, txtNacionalidad.Text, calMyDate.SelectionStart, sexoElegido);

                rtbPasajero.Text = cliente.ToString();

                GestionDeAerolinea.CargarClienteEnLineaAerea((Cliente)cliente);

                this.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                lbl_errorExcep.Text = ex.Message;
                rtbPasajero.Clear();

            }



        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       







    }
}
