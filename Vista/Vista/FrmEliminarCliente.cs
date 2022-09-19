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
    public partial class FrmEliminarCliente : Form
    {
        Pasajero pasajeroAux;
        private FrmEliminarCliente()
        {
            InitializeComponent();
        }

        public FrmEliminarCliente(string documento) :this()
        {
            pasajeroAux = GestionDeAerolinea.obtenerPasajeroPorDni(documento);
        }

        private void FrmEliminarCliente_Load(object sender, EventArgs e)
        {
            rtbPasajeroAEliminar.Text = pasajeroAux.Mostrar();

        }
    } 
}
