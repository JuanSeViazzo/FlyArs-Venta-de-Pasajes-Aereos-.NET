using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCargarEquipaje : Form
    {
        public Pasajero pasajeroAux;
        int flag = 0;
        private FrmCargarEquipaje()
        {
            InitializeComponent();
        }

        public FrmCargarEquipaje(Pasajero pasajero) : this()
        {
            pasajeroAux = pasajero;

        }

        private void FrmCargarEquipaje_Load(object sender, EventArgs e)
        {

            if (pasajeroAux.ClaseDePasajero1 == ClaseDePasajero.Turista)
            {
                nmrSegundoEquipaje.Enabled = false;

            }
            else
            {
                nmrPrimerEquipaje.Maximum = 21;
            }

            rtbCliente.Text = pasajeroAux.ToString();
            lblMaximo.Visible = false;
            pasajeroAux.ListaDeEquipajes.Clear();

        }

        private void btnConfirmarCarga_Click(object sender, EventArgs e)
        {
            lblMaximo.Visible = false;
            
            Equipaje equipajeDeMano = null;
            Equipaje primerEquipaje = null;
            Equipaje segundoEquipaje = null;

            if (flag == 1)
            {
                DialogResult resultado = MessageBox.Show("Desea Cargar un nuevo Equipaje?","Equipaje ya Cargado",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

               
                if (resultado == DialogResult.Yes)
                {
                    lstEquipaje.Items.Clear();
                    equipajeDeMano = null;
                    primerEquipaje = null;
                    segundoEquipaje = null;
                }

            }
            else
            {
                int suma = (int)nmrSegundoEquipaje.Value + (int)nmrPrimerEquipaje.Value;
                Vuelo vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(pasajeroAux.CodigoDeVuelo);

                if (suma < vueloAux.Avion.CapacidadDeBodega)
                {


                    if (nmrDeMano.Value > 0)
                    {
                        equipajeDeMano = new Equipaje(0, pasajeroAux.Documento, 3);
                        pasajeroAux.ListaDeEquipajes.Add(equipajeDeMano);
                    }

                    if (nmrPrimerEquipaje.Value > 0)
                    {
                        primerEquipaje = new Equipaje(1, pasajeroAux.Documento, (int)nmrPrimerEquipaje.Value);
                        pasajeroAux.ListaDeEquipajes.Add(primerEquipaje);
                    }

                    if (nmrSegundoEquipaje.Value > 0)
                    {
                        segundoEquipaje = new Equipaje(2, pasajeroAux.Documento, (int)nmrSegundoEquipaje.Value);
                        pasajeroAux.ListaDeEquipajes.Add(segundoEquipaje);
                    }

                    if (equipajeDeMano != null)
                        lstEquipaje.Items.Add(equipajeDeMano);
                    if (primerEquipaje != null)
                        lstEquipaje.Items.Add(primerEquipaje);
                    if (segundoEquipaje != null)
                        lstEquipaje.Items.Add(segundoEquipaje);

                }
                else
                {
                    lblMaximo.Visible = true;
                    lblMaximo.Text = "Capacidad de Bodega Exedida";
                }



                flag = 1;
            }


        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
