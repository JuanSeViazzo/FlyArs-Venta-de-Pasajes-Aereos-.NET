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
    public partial class FrmPasajerosFrecuentes : Form
    {
        DataTable pasajeros = new DataTable();  

        public FrmPasajerosFrecuentes()
        {
            InitializeComponent();
            
        }

        private void FrmPasajerosFrecuentes_Load(object sender, EventArgs e)
        {
            Estadisticas.EstadisticasDeClientesFrecuentesSegunViajes();
            this.Dock = DockStyle.Fill;
            pasajeros.Columns.Add("Nombre");
            pasajeros.Columns.Add("Apellido");
            pasajeros.Columns.Add("Documento");
            pasajeros.Columns.Add("Nacionalidad");
            pasajeros.Columns.Add("Cantidad de destinos", typeof(int));
            dgvDestinosPorFacturacion.DataSource = pasajeros;
            SubirItemsPasajerosFrecuentesDataGrid();
        }

        private void SubirItemsPasajerosFrecuentesDataGrid()
        {
            foreach (var item in GestionDeAerolinea.ListaDePersonas)
            {
                if (item is Cliente clienteAux)
                {
                pasajeros.Rows.Add(clienteAux.Nombre, clienteAux.Apellido, clienteAux.Documento, clienteAux.Nacionalidad, clienteAux.CantidadDeVuelos);

                }

            }

            dgvDestinosPorFacturacion.Sort(dgvDestinosPorFacturacion.Columns[4], ListSortDirection.Descending);

            dgvDestinosPorFacturacion.DataSource = pasajeros;
        }

        private void FrmPasajerosFrecuentes_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvDestinosPorFacturacion = null;

        }
    }
}
