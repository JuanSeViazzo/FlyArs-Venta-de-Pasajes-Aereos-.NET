using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Vista
{
    public partial class FrmMostrarHorasDeVueloPorAvion : Form
    {
        DataTable vuelos = new DataTable();
        public FrmMostrarHorasDeVueloPorAvion()
        {
            InitializeComponent();
        }

        private void FrmMostrarEstadistica_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;


            vuelos.Columns.Add("Matricula De Avion");
            vuelos.Columns.Add("Horas totales",typeof(double));
            vuelos.Columns.Add("Asientos Premium");
            vuelos.Columns.Add("Asientos Turista");
            vuelos.Columns.Add("Capacidad de Bodega");

            dtgAvionesPorHora.DataSource = vuelos;
            SubirItemsDataGrid();



        }


        private void SubirItemsDataGrid()
        {

            List<double> numero = new List<double>();

            CargarRows();

            dtgAvionesPorHora.Sort(dtgAvionesPorHora.Columns[1], ListSortDirection.Descending);

            dtgAvionesPorHora.DataSource = vuelos;

        }

        private void CargarRows()
        {
            Avion avion;

            for (int i = 0; i < GestionDeAerolinea.ListaDeAviones.Count; i++)
            {

                avion = GestionDeAerolinea.ListaDeAviones[i];

                Estadisticas.HorasDeVueloPorAvion(avion);

                vuelos.Rows.Add(avion.Matricula, avion.DuracionDeVuelo, avion.CantidadDeAsientosPremium, avion.CantidadDeAsientosTurista, avion.CapacidadDeBodega);

            }

           
        }
    }
}


    
