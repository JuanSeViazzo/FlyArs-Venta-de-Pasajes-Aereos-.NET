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

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {
            
            frmCargarPasajero frmCargarPasajero = new frmCargarPasajero(vueloAux.CodigoDeVuelo);
            frmCargarPasajero.ShowDialog();
            if(frmCargarPasajero.DialogResult == DialogResult.OK)
            {
                pasajeroAux = frmCargarPasajero.pasajeroElegido;
                rtbPasajero.Text = pasajeroAux.ToString();
            }


        }

        

       
    }
}

    