using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmListaDePasajeros : Form
    {
        DataTable pasajeros = new DataTable();
        string estado = "inactivo";
        public Cliente pasajeroElegido;
        private FrmListaDePasajeros()
        {
            InitializeComponent();
        }

        public FrmListaDePasajeros(int dato) : this()
        {
            
        }


        private void FrmClientes_Load(object sender, EventArgs e)
        {
            IniciarDataGrid();
            CargarDataGrid();
        }

        private void IniciarDataGrid()
        {
            //        public Pasajero(int documento, string codigoDePasaje, string codigoDeVuelo, List<Equipaje> listaDeEquipajes, string nombreCliente, string apellidoCliente, ClaseDePasajero claseDePasajero)

            pasajeros.Columns.Add("Documento");
            pasajeros.Columns.Add("Nombre");
            pasajeros.Columns.Add("Apellido");
            pasajeros.Columns.Add("Categoria");
            pasajeros.Columns.Add("Codigo de Pasaje");
            pasajeros.Columns.Add("Codigo de Vuelo");
            pasajeros.Columns.Add("Equipaje de Mano");
            pasajeros.Columns.Add("1er Equipaje");
            pasajeros.Columns.Add("2do Equipaje");
        }

        private void CargarDataGrid()
        {


            


            for (int i = 0; i < GestionDeAerolinea.ListaDePersonas.Count; i++)
            {
                Pasajero pasajeroAux = GestionDeAerolinea.ListaDePasajeros[i];
                {
                    pasajeros.Rows.Add(pasajeroAux.Documento, pasajeroAux.NombreCliente, pasajeroAux.ApellidoCliente,
                    pasajeroAux.ClaseDePasajero1, pasajeroAux.CodigoDePasaje, pasajeroAux.CodigoDeVuelo);

                    for (int j = 0; j < pasajeroAux.ListaDeEquipajes.Count; j++)
                    {
                        pasajeros.Rows.Add(pasajeroAux.ListaDeEquipajes[i]);
                    }

                }



            }

            dgvPasajeros.DataSource = pasajeros;

            if (dgvPasajeros.CurrentRow == null)
            {
                return;
            }
        }

        private void txt_filtroNombre_TextChanged(object sender, EventArgs e)
        {
            pasajeros.DefaultView.RowFilter = $"Nacionalidad LIKE '{txt_filtroNombre.Text}%'";

        }

        private void txt_FiltroDNI_TextChanged(object sender, EventArgs e)
        {
            pasajeros.DefaultView.RowFilter = $"Documento LIKE '{txt_FiltroDNI.Text}%'";

        }


        private void dgv_clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int documento;

            if (estado == "inactivo")
            {

            }
            else
            {
                try
                {
                    int row = e.RowIndex;
                    int column = e.ColumnIndex;
                    documento = int.Parse(dgvPasajeros.Rows[row].Cells[3].Value.ToString());

                    ;
                    DialogResult resultado = MessageBox.Show($"DNI N°{documento} desea avanzar?", "Cliente Seleccionado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult.Yes == resultado && documento > 10000000)
                    {
                        if (estado == "modificar")
                        {
                            FrmModificarCliente frmModificarCliente = new FrmModificarCliente(documento);
                            this.Hide();
                            frmModificarCliente.ShowDialog();
                        }
                        else
                        {
                            if (estado == "eliminar")
                            {
                                FrmEliminarCliente frmEliminarCliente = new FrmEliminarCliente(documento);
                                this.Hide();
                                frmEliminarCliente.ShowDialog();
                            }
                            else
                            {
                                pasajeroElegido = GestionDeAerolinea.obtenerClientePorDni(documento);
                                this.DialogResult = DialogResult.OK;
                            }

                        }

                    }
                }
                catch (Exception)
                {

                    return;
                }
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            estado = "modificar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
        }


    }



}
