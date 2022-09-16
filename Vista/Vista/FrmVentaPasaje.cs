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
    public partial class FrmVentaPasaje : Form
    {
        public FrmVentaPasaje()
        {
            InitializeComponent();
        }

        private void btn_VenderPasaje_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frmAltaCliente = new FrmAltaCliente();
             frmAltaCliente.ShowDialog();    
        }
    }
}
