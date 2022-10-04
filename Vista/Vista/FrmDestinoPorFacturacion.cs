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
        int dato;
        DataTable categorias = new DataTable();

        public FrmDestinoPorFacturacion(int dato)
        {
            InitializeComponent();
            this.dato = dato;
           
        }

        private void FrmDestinoPorFacturacion_Load(object sender, EventArgs e)
        {

            this.Dock = DockStyle.Fill;

            if (dato == 0)
            {
            destinos.Columns.Add("Destino");
            destinos.Columns.Add("Recaudacion", typeof(float));
            Estadisticas.DestinosOrdenadosPorFacturacion();
            dgvDestinosPorFacturacion.DataSource = destinos;
            SubirItemsDestinosDataGrid();

            }

            if (dato != 0)
            {
                categorias.Columns.Add("Categoria");
                categorias.Columns.Add("Recaudacion", typeof(float));
                Estadisticas.FacturacionPorCategoria();
                dgvDestinosPorFacturacion.DataSource = categorias;
                SubirCategoriasFacturadasDataGrid();


            }




        }


        private void SubirItemsDestinosDataGrid()
        {


            foreach (KeyValuePair<string, float> item in Estadisticas.EstadisticasDeDestino)
            {
                destinos.Rows.Add(item.Key, item.Value);

            }

            dgvDestinosPorFacturacion.Sort(dgvDestinosPorFacturacion.Columns[1], ListSortDirection.Descending);

            dgvDestinosPorFacturacion.DataSource = destinos;

        }

     
        private void SubirCategoriasFacturadasDataGrid()
        {
            foreach (var item in Estadisticas.EstadisticaFacturacionPorCategoria)
            {
                categorias.Rows.Add(item.Key, item.Value);
            }

            dgvDestinosPorFacturacion.Sort(dgvDestinosPorFacturacion.Columns[1], ListSortDirection.Descending);

            dgvDestinosPorFacturacion.DataSource = categorias;


        }

        private void FrmDestinoPorFacturacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvDestinosPorFacturacion = null;
            Estadisticas.EstadisticasDeDestino.Clear();
            Estadisticas.EstadisticaFacturacionPorCategoria.Clear();

        }
    }
}
