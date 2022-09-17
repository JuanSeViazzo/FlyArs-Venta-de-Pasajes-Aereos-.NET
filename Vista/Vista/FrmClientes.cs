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
    public partial class FrmClientes : Form
    {
        DataTable pasajeros = new DataTable();

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

            for (int i = 0; i < Pasajero.ListaDePasajeros.Count; i++)
            {

                pasajeros.Rows.Add(Pasajero.ListaDePasajeros[i].Nombre, Pasajero.ListaDePasajeros[i].Apellido, Pasajero.ListaDePasajeros[i].TipoDocumento1,
                Pasajero.ListaDePasajeros[i].Documento, Pasajero.ListaDePasajeros[i].Edad, Pasajero.ListaDePasajeros[i].Nacionalidad,
                Pasajero.ListaDePasajeros[i].FechaDeNacimiento, Pasajero.ListaDePasajeros[i].TipoDeSexo1);

            }

            dgv_clientes.DataSource = pasajeros;

            if (dgv_clientes.CurrentRow == null)
            {
                return;
            }
        }



        private void txt_filtroNombre_TextChanged(object sender, EventArgs e)
        {
            pasajeros.DefaultView.RowFilter = $"Edad LIKE '{txt_filtroNombre.Text}%'";

        }


        private void txt_FiltroDNI_TextChanged(object sender, EventArgs e)
        {
            pasajeros.DefaultView.RowFilter = $"Documento LIKE '{txt_FiltroDNI.Text}%'";

        }
        private void dgv_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string documento = Convert.ToString(this.dgv_clientes.SelectedRows[0].Cells[3].Value);
                MessageBox.Show(documento);
            }
            catch (Exception)
            {

                return;
            }
        }


    }
  


}
