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
    public partial class FrmDestinoPorFacturacion : Form
    {
        DataTable destinos = new DataTable();

        public FrmDestinoPorFacturacion()
        {
            InitializeComponent();

        }

        private void FrmDestinoPorFacturacion_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            destinos.Columns.Add("Destino");
            destinos.Columns.Add("Recaudacion", typeof(float));

            Estadisticas.DestinosOrdenadosPorFacturacion();
            dgvDestinosPorFacturacion.DataSource = destinos;
            SubirItemsDataGrid();

        }


        private void SubirItemsDataGrid()
        {


            foreach (KeyValuePair<string, float> item in Estadisticas.EstadisticasDeDestino)
            {
                destinos.Rows.Add(item.Key, item.Value);

            }


            dgvDestinosPorFacturacion.DataSource = destinos;

        }

     



    }
}
