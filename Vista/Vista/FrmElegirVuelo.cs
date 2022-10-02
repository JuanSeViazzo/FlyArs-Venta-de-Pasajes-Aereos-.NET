using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmElegirVuelo : Form
    {
        DataTable vuelos = new DataTable();
        string estado = "inactivo";
        public Vuelo vueloElegido;
        private FrmElegirVuelo()
        {
            InitializeComponent();
        }
        public FrmElegirVuelo(int numero) : this()
        {
            if (numero == 1)
            {
                btnSeleccionarVuelo.Visible = false;
            }else
                btnCargarVuelo.Visible = false;
        }


        private void FrmElegirVuelo_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            string estado = "inactivo";
            lblDestino.Text = "Filtrar por Destino";
            lblOrigen.Text = "Filtrar por Origen";
            lblFechaDePartida.Text = "Filtrar por Fecha de Partida";

        }

        private void CargarDataGrid()
        {
            vuelos.Columns.Add("Codigo De Vuelo");
            vuelos.Columns.Add("Matricula De Avion");
            vuelos.Columns.Add("Origen");
            vuelos.Columns.Add("Destino");
            vuelos.Columns.Add("Salida");
            vuelos.Columns.Add("Llegada");
            vuelos.Columns.Add("Lugares Premium");
            vuelos.Columns.Add("Lugares Turistas");
            vuelos.Columns.Add("Disponible en Bodega");
            vuelos.Columns.Add("Wifi");
            vuelos.Columns.Add("Comida");
            vuelos.Columns.Add("Cantidad de baños");
            dgv_vuelos.DataSource = vuelos;


            CargarItemsDataTable();
        }

        private void CargarItemsDataTable()
        {


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
                    GestionDeAerolinea.ListaDeVuelos[i].Origen,
                GestionDeAerolinea.ListaDeVuelos[i].Destino, GestionDeAerolinea.ListaDeVuelos[i].HoraDePartida.ToString("dd/MM/yyyy hh:mm tt"),
                GestionDeAerolinea.ListaDeVuelos[i].HoraDeLlegada.ToString("dd/MM/yyyy hh:mm tt"), ($"{GestionDeAerolinea.ListaDeVuelos[i].AsientosDisponiblesPremium}" +
                $"/{GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientosPremium}"), ($"{GestionDeAerolinea.ListaDeVuelos[i].AsientosDisponiblesTurista}" +
                $"/{GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientosTurista}"),
                ($"{GestionDeAerolinea.ListaDeVuelos[i].EspacioBodegaDisponible}/{GestionDeAerolinea.ListaDeVuelos[i].Avion.CapacidadDeBodega}")
                , wifi, comida, GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeBanios);

            }

            dgv_vuelos.DataSource = vuelos;

            if (dgv_vuelos.CurrentRow == null)
            {
                return;
            }
        }

        private void txtFiltroOrigen_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltroOrigen.Text))
            {
                vuelos.DefaultView.RowFilter = $"Origen LIKE '{txtFiltroOrigen.Text}%'";
            }
            if (!string.IsNullOrEmpty(txtFiltroDestino.Text))
            {
                vuelos.DefaultView.RowFilter = $"Destino LIKE '{txtFiltroDestino.Text}%'";

            }
            if (!string.IsNullOrEmpty(txtFiltroFecha.Text))
            {
                vuelos.DefaultView.RowFilter = $"Salida LIKE '{txtFiltroFecha.Text}%' AND Origen LIKE '{txtFiltroOrigen.Text}%' AND Destino LIKE '{txtFiltroDestino.Text}%'";

            }


        }

        private void dgv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigoDeVuelo;

            if (estado == "inactivo")
            {

            }
            else
            {
                try
                {
                    int row = e.RowIndex;
                    int column = e.ColumnIndex;
                    codigoDeVuelo = dgv_vuelos.Rows[row].Cells[0].Value.ToString();

                    ;
                    DialogResult resultado = MessageBox.Show($"Codigo De Vuelo: {codigoDeVuelo} \n desea avanzar? ", "Vuelo Elegido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado)
                    {
                        if (estado == "venderVuelo")
                        {
                            vueloElegido = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);
                            this.DialogResult = DialogResult.OK;
                        }
                        //else
                        //{
                        //    if (estado == "eliminar")
                        //    {
                        //        FrmEliminarCliente frmEliminarCliente = new FrmEliminarCliente(documento);
                        //        this.Hide();
                        //        frmEliminarCliente.ShowDialog();
                        //    }
                        //    else
                        //    {
                        //       vueloElegido = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);
                        //         this.DialogResult = DialogResult.OK;
                        //    }

                        //}

                    }
                }
                catch (Exception)
                {

                    return;
                }
            }


        }




        private void btnSeleccionarVuelo_Click_1(object sender, EventArgs e)
        {
            estado = "venderVuelo";

        }


        private void btnCargarVuelo_Click(object sender, EventArgs e)
        {
            FrmCargarVuelo frmCargarVuelo = new FrmCargarVuelo();
            frmCargarVuelo.ShowDialog();


        }
    }

}

