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
            this.lbl_HoraActualMenuPrincipal.Text= DateTime.Now.ToString("yyyy-MM-dd");
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
        private void btnMenuClientes_Click(object sender, EventArgs e)
        {
            FrmListaDeClientes frmClientes = new FrmListaDeClientes(0);
            frmClientes.ShowDialog();   
        }

        private void btn_MenuVuelos_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo(1);
            frmElegirVuelo.ShowDialog();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog(); 
        }

       
    }
}
