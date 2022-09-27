using Logica;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Vista
{
    public partial class frmCargarPasajero : Form
    {
        Persona clienteAux;
        public Pasajero pasajeroElegido;
        string codigoDeVuelo;
        Vuelo vueloAux;

        public frmCargarPasajero(string codigoDeVuelo)
        {
            InitializeComponent();
            this.codigoDeVuelo = codigoDeVuelo;

        }

        private void frmCargarPasajero_Load(object sender, EventArgs e)
        {
            vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);
        }


        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            FrmListaDeClientes frmClientes = new FrmListaDeClientes();
            frmClientes.ShowDialog();
            if (frmClientes.DialogResult == DialogResult.OK)
            {
                clienteAux = frmClientes.clienteElegido;
                rtbCliente.Text = clienteAux.ToString();


            }
        }

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            int numeroDeOrdenPasaje=0;
            ClaseDePasajero clasePasajero = ClaseDePasajero.Premium;

            if (rdbPremium.Checked)
            {
                numeroDeOrdenPasaje = vueloAux.AsientosDisponiblesPremium;
                clasePasajero = ClaseDePasajero.Premium;
    

            }
            else
                if (rdbTurista.Checked)
            {
                numeroDeOrdenPasaje = vueloAux.AsientosDisponiblesTurista;
                clasePasajero = ClaseDePasajero.Turista;
            }

            string stringDeOrdenPasaje = numeroDeOrdenPasaje.ToString();



            Pasajero pasajero = new Pasajero(clienteAux.Documento, $"{numeroDeOrdenPasaje.ToString()}+{vueloAux.CodigoDeVuelo}", vueloAux.CodigoDeVuelo, new List<Equipaje>(), clienteAux.Nombre, clienteAux.Apellido, clasePasajero);


            rtbPasajero.Text = pasajero.ToString();



        }





        //string codigoDePasaje = ($"{vueloAux.CodigoDeVuelo[0]}") + ($"{vueloAux.CodigoDeVuelo[1]}");

        //pasajeroAux = new Pasajero(clienteAux.Documento, codigoDePasaje, vueloAux.CodigoDeVuelo, listaDeEquipaje, clienteAux.Nombre, clienteAux.Apellido, claseDePasajero); ;
        //rtbPasajero.Text = pasajeroAux.ToString();

        //    listaDeEquipaje.Reverse();



    }
}
