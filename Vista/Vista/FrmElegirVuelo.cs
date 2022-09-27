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
        public FrmElegirVuelo()
        {
            InitializeComponent();
        }

        private void FrmElegirVuelo_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            string estado = "inactivo";

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
            vuelos.Columns.Add("Limite en Bodega");
            vuelos.Columns.Add("Wifi");
            vuelos.Columns.Add("Comida");
            vuelos.Columns.Add("Cantidad de baños");
            CargarItemsDataTable();
        }

        private void CargarItemsDataTable()
        {


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


                vuelos.Rows.Add(GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo, GestionDeAerolinea.ListaDeVuelos[i].Avion.Matricula,
                    GestionDeAerolinea.ListaDeVuelos[i].Origen,
                GestionDeAerolinea.ListaDeVuelos[i].Destino, GestionDeAerolinea.ListaDeVuelos[i].HoraDePartida.ToString("dd/MM/yyyy hh:mm tt"),
                GestionDeAerolinea.ListaDeVuelos[i].HoraDeLlegada.ToString("dd/MM/yyyy hh:mm tt"), ($"{GestionDeAerolinea.ListaDeVuelos[i].AsientosDisponiblesPremium}" +
                $"/{GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientosPremium}"), ($"{GestionDeAerolinea.ListaDeVuelos[i].AsientosDisponiblesTurista}" +
                $"/{GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeAsientosTurista}"),
                GestionDeAerolinea.ListaDeVuelos[i].Avion.CapacidadDeBodega, wifi, comida, GestionDeAerolinea.ListaDeVuelos[i].Avion.CantidadDeBanios);

            }

            dgv_clientes.DataSource = vuelos;

            if (dgv_clientes.CurrentRow == null)
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
                    codigoDeVuelo = dgv_clientes.Rows[row].Cells[0].Value.ToString();

                    ;
                    DialogResult resultado = MessageBox.Show($"{codigoDeVuelo}", "DNI N°: ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (DialogResult.Yes == resultado)
                    {
                        if (estado == "modificar")
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

  

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
        }

        private void btnVenderPasaje_Click(object sender, EventArgs e)
        {
            estado = "venta";

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            estado = "modificar";

        }

       
    }



        //private void txtFiltroDestino_TextChanged(object sender, EventArgs e)
        //{

        //    vuelos.DefaultView.RowFilter = $"Destino LIKE '{txtFiltroDestino.Text}%'";

        //}

        //private void txtFiltroFecha_TextChanged(object sender, EventArgs e)
        //{
        //    vuelos.DefaultView.RowFilter = $"Salida LIKE '{txtFiltroFecha.Text}%'";

        //}
    }

