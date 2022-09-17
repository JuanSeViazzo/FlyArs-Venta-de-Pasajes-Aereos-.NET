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
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            
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


        public void MostrarUsuario(string Usuario)
        {
            
            this.lbl_Usuario.Text = this.lbl_Usuario.Text + "  " + Usuario;
        }

        public void MostrarHora(string Hora)
        {

            this.lbl_HoraActualMenuPrincipal.Text = this.lbl_HoraActualMenuPrincipal.Text + "  " + Hora;
            
            
        }

        private void btn_MenuPasajeros_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();    
            frmClientes.ShowDialog();   
        }
    }
}
