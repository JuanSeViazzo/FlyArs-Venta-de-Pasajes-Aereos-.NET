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
        Persona clienteAux;
        int documentoAux;
        private FrmEliminarCliente()
        {
            InitializeComponent();
        }

        public FrmEliminarCliente(int documento) :this()
        {
            documentoAux = documento;
            clienteAux = GestionDeAerolinea.obtenerClientePorDni(documento);
        }

        private void FrmEliminarCliente_Load(object sender, EventArgs e)
        {
            rtbPasajeroAEliminar.Text = clienteAux.ToString();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            GestionDeAerolinea.EliminarPasajeroEnLineaAerea(documentoAux);

        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
