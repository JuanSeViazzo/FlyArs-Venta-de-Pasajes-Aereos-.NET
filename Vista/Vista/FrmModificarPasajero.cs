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
    public partial class FrmModificarPasajero : Form
    {
        string documentoPasajero;
        Pasajero pasajeroAux;
        public FrmModificarPasajero(string documento)
        {
            InitializeComponent();
            this.documentoPasajero = documento;
        }

        private void ModificarPasajero_Load(object sender, EventArgs e)
        {
            
            pasajeroAux = GestionDeAerolinea.obtenerPasajeroPorDni(documentoPasajero);
            rtb_PasajeroAModificar.Text = pasajeroAux.Mostrar();


        }
    }
}
