using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmEstadisticas : Form
    {
        FrmMostrarHorasDeVueloPorAvion frmMostrarHorasDeVueloPorAvion;
        FrmDestinoPorFacturacion frmDestinoPorFacturacion;

        public FrmEstadisticas()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            frmMostrarHorasDeVueloPorAvion = new FrmMostrarHorasDeVueloPorAvion();
            frmDestinoPorFacturacion = new FrmDestinoPorFacturacion();
        }

        private void horasDeVueloPorAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarHorasDeVueloPorAvion frmMostrarEstadistica = new FrmMostrarHorasDeVueloPorAvion();
            frmMostrarEstadistica.MdiParent = this;
            frmMostrarEstadistica.Show();

        }

        private void destinosPorFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDestinoPorFacturacion.MdiParent = this;
            frmDestinoPorFacturacion.Show();
        }

        private void horasDeVueloPorAvionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMostrarHorasDeVueloPorAvion.MdiParent = this;
            frmMostrarHorasDeVueloPorAvion.Show();
        }
    }
}
