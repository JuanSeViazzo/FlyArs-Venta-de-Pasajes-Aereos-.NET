using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmElegirVuelo : Form
    {
        public FrmElegirVuelo()
        {
            InitializeComponent();
        }

        private void FrmElegirVuelo_Load(object sender, EventArgs e)
        {
            DataTable vuelos = new DataTable();
            string estado = "inactivo";


            vuelos.Columns.Add("Codigo De Vuelo");
            vuelos.Columns.Add("Matricula De Avion");
            vuelos.Columns.Add("Origen");
            vuelos.Columns.Add("Destino");
            vuelos.Columns.Add("Salida");
            vuelos.Columns.Add("Llegada");
            vuelos.Columns.Add("Cantidad Maxima de Pasajeros");
            vuelos.Columns.Add("Limite en Bodega");
            vuelos.Columns.Add("Wifi");
            vuelos.Columns.Add("Comida");

            for (int i = 0; i < GestionDeAerolinea.ListaDeVuelos.Count; i++)
            {
                string wifi;
                string comida;

                if (GestionDeAerolinea.ListaDeVuelos[i].TieneWifi)
                    wifi = "Si";
                else
                    wifi = "No";


                if (GestionDeAerolinea.ListaDeVuelos[i].OfreceComida)
                    comida = "Si";
                else
                    comida = "No";

                vuelos.Rows.Add(GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo, GestionDeAerolinea.ListaDeVuelos[i].Avion.Matricula,
                    GestionDeAerolinea.ListaDeVuelos[i].DestinosNacionales,
                GestionDeAerolinea.ListaDeVuelos[i].DestinosInternacionales, GestionDeAerolinea.ListaDeVuelos[i].HoraDePartida,
                GestionDeAerolinea.ListaDeVuelos[i].HoraDeLlegada, GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientos,
                GestionDeAerolinea.ListaDeVuelos[i].Avion.CapacidadDeBodega,wifi, GestionDeAerolinea.ListaDeVuelos[i].OfreceComida);

            }

            dgv_clientes.DataSource = vuelos;

            if (dgv_clientes.CurrentRow == null)
            {
                return;
            }

        }
    }
}
