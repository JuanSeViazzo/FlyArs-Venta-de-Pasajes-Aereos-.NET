﻿using System;
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
    public partial class FrmMenuPasajes : Form
    {
        public FrmMenuPasajes()
        {
            InitializeComponent();
        }

        private void btn_VenderPasaje_Click(object sender, EventArgs e)
        {
            FrmVentaPasaje formVentaPasaje = new FrmVentaPasaje();
            formVentaPasaje.ShowDialog();   
        }
    }
}
