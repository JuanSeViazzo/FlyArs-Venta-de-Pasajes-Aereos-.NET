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
    public partial class FrmVenderPasaje : Form
    {
        int documento;
        Persona clienteAux;
        string codigoDeVuelo;
        Vuelo vueloAux;
        Pasaje pasajeAux;
        Pasajero pasajeroAux;
        List<Equipaje> listaDeEquipaje;


        public Vuelo VueloAux { get => vueloAux;}

        public FrmVenderPasaje()
        {
            listaDeEquipaje = new List<Equipaje>();
            InitializeComponent();
        }

        public FrmVenderPasaje(int documento) : this()
        {
            this.documento = documento;
            clienteAux = GestionDeAerolinea.obtenerPasajeroPorDni(documento);
        }

        public FrmVenderPasaje(string codigoDeVuelo) : this()
        {
            this.codigoDeVuelo = codigoDeVuelo;
            vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);


        }


        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {


        }


        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            FrmListaDeClientes frmClientes = new FrmListaDeClientes();
            frmClientes.ShowDialog();
            if(frmClientes.DialogResult == DialogResult.OK)
            {
                clienteAux = frmClientes.clienteElegido;
                rtbCliente.Text = clienteAux.ToString();


            }
        }

        private void btnElegirVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            frmElegirVuelo.ShowDialog();
            if (frmElegirVuelo.DialogResult == DialogResult.OK)
            {
                vueloAux = frmElegirVuelo.vueloElegido;
                rtbVuelo.Text = vueloAux.ToString();
            }

        }

        private void btnCrearPasajero_Click(object sender, EventArgs e)
        {
            string codigoDePasaje = ($"{vueloAux.CodigoDeVuelo[0]}")+($"{vueloAux.CodigoDeVuelo[1]}");

            pasajeroAux = new Pasajero(clienteAux.Documento,codigoDePasaje,vueloAux.CodigoDeVuelo, listaDeEquipaje, clienteAux.Nombre, clienteAux.Apellido); ;
        rtbPasajero.Text = pasajeroAux.ToString();

            listaDeEquipaje.Reverse();

        }
    }
}

    