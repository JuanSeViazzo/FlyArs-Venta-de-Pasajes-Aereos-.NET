using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        DataTable pasajeros = new DataTable();
        string estado = "inactivo";
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {

            pasajeros.Columns.Add("Nombre");
            pasajeros.Columns.Add("Apellido");
            pasajeros.Columns.Add("Tipo de Documento");
            pasajeros.Columns.Add("Documento");
            pasajeros.Columns.Add("Edad");
            pasajeros.Columns.Add("Nacionalidad");
            pasajeros.Columns.Add("Fecha de nacimiento");
            pasajeros.Columns.Add("Sexo");

            for (int i = 0; i < GestionDeAerolinea.ListaDePasajeros.Count; i++)
            {

                pasajeros.Rows.Add(GestionDeAerolinea.ListaDePasajeros[i].Nombre, GestionDeAerolinea.ListaDePasajeros[i].Apellido, GestionDeAerolinea.ListaDePasajeros[i].TipoDocumento1,
                GestionDeAerolinea.ListaDePasajeros[i].Documento, GestionDeAerolinea.ListaDePasajeros[i].Edad, GestionDeAerolinea.ListaDePasajeros[i].Nacionalidad,
                GestionDeAerolinea.ListaDePasajeros[i].FechaDeNacimiento, GestionDeAerolinea.ListaDePasajeros[i].TipoDeSexo1);

            }

            dgv_clientes.DataSource = pasajeros;

            if (dgv_clientes.CurrentRow == null)
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
            string documento;

            if (estado == "inactivo")
            {

            }
            else
            {
                try
                {
                    int row = e.RowIndex;
                    int column = e.ColumnIndex;
                    documento = dgv_clientes.Rows[row].Cells[3].Value.ToString();

                    ;
                    DialogResult resultado = MessageBox.Show($"{documento}", "DNI N°: ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (DialogResult.Yes == resultado && documento is not null)
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
