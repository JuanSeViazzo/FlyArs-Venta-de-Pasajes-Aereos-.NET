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
    public partial class FrmVentaPasaje : Form
    {
        int documento;
        Persona clienteAux;
        string codigoDeVuelo;
        Vuelo vueloAux;
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }

        public FrmVentaPasaje(int documento) : this()
        {
            this.documento = documento;
            clienteAux = GestionDeAerolinea.obtenerPasajeroPorDni(documento);
        }

        public FrmVentaPasaje(string codigoDeVuelo) : this()
        {
            this.codigoDeVuelo = codigoDeVuelo;
            vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);
        }

        private void btn_VenderPasaje_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
             frmAltaCliente.ShowDialog();    
        }

        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();   
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            if (clienteAux is not null)
            {
                rtbPasajero.Text = clienteAux.ToString();

            }
            if(vueloAux is not null)
            {
                rtbVuelo.Text = vueloAux.ToString();    
            }


        }

        private void btnElegirVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            frmElegirVuelo.Show();    
        }
    }
}
