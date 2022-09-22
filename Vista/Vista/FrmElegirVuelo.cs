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
            vuelos.Columns.Add("Cantidad de baños");

            for (int i = 0; i < GestionDeAerolinea.ListaDeVuelos.Count; i++)
            {
                string wifi;
                string comida;
                string destino;
                string origen;

                if (GestionDeAerolinea.ListaDeVuelos[i].TieneWifi)
                    wifi = "Si";
                else
                    wifi = "No";


                if (GestionDeAerolinea.ListaDeVuelos[i].OfreceComida)
                    comida = "Si";
                else
                    comida = "No";

                if (GestionDeAerolinea.ListaDeVuelos[i].DestinosNacionales.ToString().Contains('_'))
                {
                    origen = GestionDeAerolinea.ListaDeVuelos[i].DestinosNacionales.ToString().Replace('_',' ');
                }
                else
                    origen = GestionDeAerolinea.ListaDeVuelos[i].DestinosNacionales.ToString();

                if (GestionDeAerolinea.ListaDeVuelos[i].DestinosInternacionales.ToString().Contains('_'))
                {
                    destino = GestionDeAerolinea.ListaDeVuelos[i].DestinosInternacionales.ToString().Replace('_', '|');
                }
                else
                    destino = GestionDeAerolinea.ListaDeVuelos[i].DestinosNacionales.ToString();

                vuelos.Rows.Add(GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo, GestionDeAerolinea.ListaDeVuelos[i].Avion.Matricula,
                    origen,
                destino, GestionDeAerolinea.ListaDeVuelos[i].HoraDePartida.ToString("MM/dd/yyyy hh:mm tt"),
                GestionDeAerolinea.ListaDeVuelos[i].HoraDeLlegada.ToString("MM/dd/yyyy hh:mm tt"), GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientos,
                GestionDeAerolinea.ListaDeVuelos[i].Avion.CapacidadDeBodega,wifi,comida,GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeBanios);

            }

            dgv_clientes.DataSource = vuelos;

            if (dgv_clientes.CurrentRow == null)
            {
                return;
            }

        }
    }
}
