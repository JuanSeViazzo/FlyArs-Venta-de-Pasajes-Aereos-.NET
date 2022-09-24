using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        private FrmMenuPrincipal()
        {
            InitializeComponent();
            
        }

        public FrmMenuPrincipal(string dato) :this()
        {
            this.lbl_Usuario.Text= dato;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            ManejoDeVista.PausarMusica();

        }

        private void btn_MenuPasajes_Click(object sender, EventArgs e)
        {
            FrmMenuPasajes frmMenuPasajes = new FrmMenuPasajes();
            frmMenuPasajes.ShowDialog();    


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_MenuPasajeros_Click(object sender, EventArgs e)
        {
            FrmListaDeClientes frmClientes = new FrmListaDeClientes();
            frmClientes.ShowDialog();   
        }

        private void btn_MenuVuelos_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo();
            frmElegirVuelo.ShowDialog();
        }
    }
}
