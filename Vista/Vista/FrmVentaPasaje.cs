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
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }

        public FrmVentaPasaje(int documento) : this()
        {
            this.documento = documento;
            clienteAux = GestionDeAerolinea.obtenerPasajeroPorDni(documento);
        }

        private void btn_VenderPasaje_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
             frmAltaCliente.ShowDialog();    
        }

        private void btnTraerCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();   
        }

        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            if (clienteAux is not null)
            {
                rtbPasajero.Text = clienteAux.ToString();

            }

        }

        private void btnElegirVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            frmElegirVuelo.ShowDialog();    
        }
    }
}
