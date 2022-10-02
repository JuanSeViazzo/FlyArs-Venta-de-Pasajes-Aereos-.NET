using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Vista
{
    public partial class FrmCargarVuelo : Form
    {
        Vuelo vueloAux;

        public FrmCargarVuelo()
        {
            InitializeComponent();
        }

        private void FrmCargarVuelo_Load(object sender, EventArgs e)
        {
            mncFechaDePartida.MinDate = DateTime.Today;

            foreach (Avion item in GestionDeAerolinea.ListaDeAviones)
            {
                cmbAvion.Items.Add(item.Matricula);

            }


            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (item.Key < 1000)
                    cmbOrigen.Items.Add(item.Value);

            }
            btnAceptarCargaVuelo.Enabled = false;
        }

        private void cmbOrigen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbDestino.Items.Clear();
            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (cmbOrigen.SelectedIndex != 15)
                {
                    if (item.Key < 1000)
                        cmbDestino.Items.Add(item.Value);
                }
                else
                {
                    cmbDestino.Items.Add(item.Value);
                }
                if (cmbOrigen.SelectedIndex == item.Key)
                {
                    cmbDestino.Items.Remove(item.Value);
                }
            }




        }

        private void btnCargar_Click(object sender, EventArgs e)
        {


            try
            {
                Avion avionAux;

                avionAux = GestionDeAerolinea.ObtenerAvionPorMatricula((string)cmbAvion.SelectedItem);

                if (avionAux != null)
                {
                    DateTime fecha = mncFechaDePartida.SelectionStart;

                    vueloAux = new Vuelo(fecha, fecha, avionAux, chkComida.Checked, chkWifi.Checked, "", cmbOrigen.SelectedIndex, cmbDestino.SelectedIndex);

                    rtbVuelo.Text = vueloAux.ToString();
                    btnAceptarCargaVuelo.Enabled = true;
                }
                else
                {
                    throw new Exception("Faltan datos");
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }




        }

        private void btnAceptarCargaVuelo_Click(object sender, EventArgs e)
        {
            GestionDeAerolinea.ListaDeVuelos.Add(vueloAux);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
