using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEstadisticas : Form
    {
        FrmMostrarHorasDeVueloPorAvion frmMostrarHorasDeVueloPorAvion;
        FrmDestinoPorFacturacion frmDestinoPorFacturacion;
        FrmDestinoFavorito frmDestinoFavorito;
        FrmPasajerosFrecuentes frmPasajerosFrecuentes;

        int dato;
        public FrmEstadisticas()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            frmMostrarHorasDeVueloPorAvion = new FrmMostrarHorasDeVueloPorAvion();
        }

        private void horasDeVueloPorAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarHorasDeVueloPorAvion frmMostrarEstadistica = new FrmMostrarHorasDeVueloPorAvion();
            frmMostrarEstadistica.MdiParent = this;
            frmMostrarEstadistica.Show();

        }

        private void destinosPorFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dato = 0;
            frmDestinoPorFacturacion = new FrmDestinoPorFacturacion(dato);
            frmDestinoPorFacturacion.MdiParent = this;
            frmDestinoPorFacturacion.Show();
        }

        private void horasDeVueloPorAvionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMostrarHorasDeVueloPorAvion.MdiParent = this;
            frmMostrarHorasDeVueloPorAvion.Show();
        }

        private void destinoFavoritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dato = 0;
            frmDestinoFavorito = new FrmDestinoFavorito(dato);
            frmDestinoFavorito.MdiParent = this;
            frmDestinoFavorito.Show();
        }

        private void listaDePasajerosFrecuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPasajerosFrecuentes frmPasajerosFrecuentes = new FrmPasajerosFrecuentes();
            frmPasajerosFrecuentes.MdiParent = this;
            frmPasajerosFrecuentes.Show();  


        }

        private void gananciasTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dato = 1;
            frmDestinoPorFacturacion = new FrmDestinoPorFacturacion(dato);
            frmDestinoPorFacturacion.MdiParent = this;
            frmDestinoPorFacturacion.Show();
        }
    }
}
