using Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmClientes : Form
    {
        DataTable clientes = new DataTable();
        string estado = "inactivo";
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {

            clientes.Columns.Add("Nombre");
            clientes.Columns.Add("Apellido");
            clientes.Columns.Add("Tipo de Documento");
            clientes.Columns.Add("Documento");
            clientes.Columns.Add("Edad");
            clientes.Columns.Add("Nacionalidad");
            clientes.Columns.Add("Fecha de nacimiento");
            clientes.Columns.Add("Sexo");

            for (int i = 0; i < GestionDeAerolinea.ListaDePersonas.Count; i++)
            {

                clientes.Rows.Add(GestionDeAerolinea.ListaDePersonas[i].Nombre, GestionDeAerolinea.ListaDePersonas[i].Apellido, GestionDeAerolinea.ListaDePersonas[i].TipoDocumento1,
                GestionDeAerolinea.ListaDePersonas[i].Documento, GestionDeAerolinea.ListaDePersonas[i].Edad, GestionDeAerolinea.ListaDePersonas[i].Nacionalidad,
                GestionDeAerolinea.ListaDePersonas[i].FechaDeNacimiento, GestionDeAerolinea.ListaDePersonas[i].TipoDeSexo1);

            }

            dgv_clientes.DataSource = clientes;

            if (dgv_clientes.CurrentRow == null)
            {
                return;
            }
        }




        private void txt_filtroNombre_TextChanged(object sender, EventArgs e)
        {
            clientes.DefaultView.RowFilter = $"Nacionalidad LIKE '{txt_filtroNombre.Text}%'";

        }

        private void txt_FiltroDNI_TextChanged(object sender, EventArgs e)
        {
            clientes.DefaultView.RowFilter = $"Documento LIKE '{txt_FiltroDNI.Text}%'";

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
                    documento = int.Parse(dgv_clientes.Rows[row].Cells[3].Value.ToString());

                    ;
                    DialogResult resultado = MessageBox.Show($"{documento}", "DNI N°: ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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
                            }else
                            {
                                FrmVentaPasaje frmVentaPasaje = new FrmVentaPasaje(documento);
                                this.Hide();
                                frmVentaPasaje.ShowDialog();    
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

        private void button1_Click(object sender, EventArgs e)
        {
            estado = "venta";

        }
    }

}
