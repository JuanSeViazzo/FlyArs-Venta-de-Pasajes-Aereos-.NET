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
    public partial class FrmDestinos : Form
    {
        public FrmDestinos()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        private void altaDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmDestinos abmDestinos = new FrmAbmDestinos("Alta");
            abmDestinos.MdiParent = this;
            abmDestinos.Show();
        }

        private void bajaDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmDestinos abmDestinos = new FrmAbmDestinos("Baja");
            abmDestinos.MdiParent = this;
            abmDestinos.Show();

        }

        private void modificacionDestinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmDestinos abmDestinos = new FrmAbmDestinos("Modificacion");
            abmDestinos.MdiParent = this;
            abmDestinos.Show();

        }
    }
}
