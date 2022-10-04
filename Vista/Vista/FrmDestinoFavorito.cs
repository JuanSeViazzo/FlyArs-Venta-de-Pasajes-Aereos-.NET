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
    public partial class FrmDestinoFavorito : Form
    {
        DataTable destinos = new DataTable();
        int dato;


        public FrmDestinoFavorito(int dato)
        {
            InitializeComponent();
            this.dato = dato;   
        }

        private void FrmDestinoFavorito_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            if (dato == 0)
            {
                destinos.Columns.Add("Destino");
                destinos.Columns.Add("Pasajeros", typeof(int));

                Estadisticas.DestinosOrdenadosFavoritos();
                dgvDestinosFavoritos.DataSource = destinos;
                SubirItemsDataGrid();
            }


        }


        private void SubirItemsDataGrid()
        {
            foreach (KeyValuePair<string, int> item in Estadisticas.EstadisticasDestinoFavorito)
            {
                destinos.Rows.Add(item.Key, item.Value);

            }
            dgvDestinosFavoritos.Sort(dgvDestinosFavoritos.Columns[1], ListSortDirection.Descending);


            dgvDestinosFavoritos.DataSource = destinos;

        }

        private void FrmDestinoFavorito_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvDestinosFavoritos.DataSource = null;
            Estadisticas.EstadisticasDestinoFavorito.Clear();
        }
    }
}
