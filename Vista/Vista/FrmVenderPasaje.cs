using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmVenderPasaje : Form
    {
        DataTable pasajeros = new DataTable();

        int documento;
        Persona clienteAux;
        string codigoDeVuelo;
        Vuelo vueloAux;
        Pasaje pasajeAux;
        Pasajero pasajeroAux;
        List<Pasajero> listaDePasajeros;
        List<Pasaje> listaDePasajes;
        string facturacion;
        float montoFacturado;


        public Vuelo VueloAux { get => vueloAux; }

        public FrmVenderPasaje()
        {
            InitializeComponent();
            listaDePasajes = new List<Pasaje>();   
            listaDePasajeros = new List<Pasajero>();

        }

        public FrmVenderPasaje(int documento) : this()
        {
            this.documento = documento;
            clienteAux = GestionDeAerolinea.obtenerClientePorDni(documento);
        }

        public FrmVenderPasaje(string codigoDeVuelo) : this()
        {
            this.codigoDeVuelo = codigoDeVuelo;
            vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(codigoDeVuelo);


        }
        private void FrmVentaPasaje_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            btnCargarPasajero.Enabled = false;
            btnCargarEquipaje.Enabled = false;
            btnFacturar.Enabled = false;
            btnSubirPasajero.Enabled = false;
            btnAceptarModificacion.Enabled = false;
            btnCargarOtroPasajero.Enabled = false;
        }
        private void CargarDataGrid()
        {
            pasajeros.Columns.Add("Codigo De Vuelo");
            pasajeros.Columns.Add("codigo De Pasaje");
            pasajeros.Columns.Add("Categoria Pasaje");
            pasajeros.Columns.Add("Precio");
            pasajeros.Columns.Add("Documento");
            pasajeros.Columns.Add("Nombre");
            pasajeros.Columns.Add("Apellido");
            pasajeros.Columns.Add("Origen");
            pasajeros.Columns.Add("Hora de Salida");
            pasajeros.Columns.Add("Destino");
            pasajeros.Columns.Add("Hora de Llegada");
            dgvListaDePasajes.DataSource = pasajeros;   
            //CargarItemsDataTable();
        }

        private void CargarItemsDataTable()
        {
            dgvListaDePasajes.DataSource = null;

            foreach (Pasaje item in listaDePasajes)
            {
                if (item is PasajeTurista pasajeAux)
                {
                    pasajeros.Rows.Add(pasajeAux.CodigoDeVuelo, pasajeAux.CodigoDePasaje,pasajeAux.CategoriaPasaje,pasajeAux.PrecioDePasaje,
                        pasajeAux.DniDePasajero, pasajeAux.NombrePasajero, pasajeAux.ApellidoDePasajero,
                                        pasajeAux.Origen, pasajeAux.HoraDeSalida, pasajeAux.Destino, pasajeAux.HoraDeLlegada);

                }
                if (item is PasajePremium pasajeAuxP)
                {
                    pasajeros.Rows.Add(pasajeAuxP.CodigoDeVuelo, pasajeAuxP.CodigoDePasaje, pasajeAuxP.CategoriaPasaje, pasajeAuxP.PrecioDePasaje,
                        pasajeAuxP.DniDePasajero, pasajeAuxP.NombrePasajero, pasajeAuxP.ApellidoDePasajero,
                                        pasajeAuxP.Origen, pasajeAuxP.HoraDeSalida, pasajeAuxP.Destino, pasajeAuxP.HoraDeLlegada);

                }
            }

            dgvListaDePasajes.DataSource = pasajeros;

        }





        private void btnElegirVuelo_Click(object sender, EventArgs e)
        {
            FrmElegirVuelo frmElegirVuelo = new FrmElegirVuelo(2);
            frmElegirVuelo.ShowDialog();
            if (frmElegirVuelo.DialogResult == DialogResult.OK)
            {
                vueloAux = frmElegirVuelo.vueloElegido;
                rtbVuelo.Text = vueloAux.ToString();
                btnCargarPasajero.Enabled = true;
            }

        }

        private void btnCargarPasajero_Click(object sender, EventArgs e)
        {

            frmCargarPasajero frmCargarPasajero = new frmCargarPasajero(vueloAux.CodigoDeVuelo);
            frmCargarPasajero.ShowDialog();
            if (frmCargarPasajero.DialogResult == DialogResult.OK)
            {
                pasajeroAux = frmCargarPasajero.pasajeroElegido;
                rtbPasajero.Text = pasajeroAux.ToString();
                btnCargarEquipaje.Enabled = true;
            }


        }

        private void btnCargarEquipaje_Click(object sender, EventArgs e)
        {

            FrmCargarEquipaje frmCargarEquipaje = new FrmCargarEquipaje(pasajeroAux);
            frmCargarEquipaje.ShowDialog();
            if (frmCargarEquipaje.DialogResult == DialogResult.OK)
            {
                pasajeroAux = frmCargarEquipaje.pasajeroAux;
                rtbEquipaje.Text = pasajeroAux.ToString();
                listaDePasajeros.Add(pasajeroAux);
                btnFacturar.Enabled = true;

            }

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturar frmFacturar = new FrmFacturar(pasajeroAux, vueloAux);
            frmFacturar.ShowDialog();
            if (frmFacturar.DialogResult == DialogResult.OK)
                rtbFacturacion.Text = frmFacturar.montoFacturado;
            montoFacturado = frmFacturar.montoFinal;
            btnSubirPasajero.Enabled = true;    


        }

        private void btnSubirPasajero_Click(object sender, EventArgs e)
        {
            Pasaje pasajeAux = null;

            if (pasajeroAux.ClaseDePasajero1 == ClaseDePasajero.Turista)
            {
                pasajeAux = new PasajeTurista(pasajeroAux.CodigoDePasaje, vueloAux.CodigoDeVuelo, pasajeroAux.Documento, pasajeroAux.NombreCliente,
                                   pasajeroAux.ApellidoCliente, vueloAux.Origen, vueloAux.HoraDePartida, vueloAux.Destino, 
                                   vueloAux.HoraDeLlegada, "Turista", montoFacturado);
            }
            else
            {
                pasajeAux = new PasajePremium(pasajeroAux.CodigoDePasaje, vueloAux.CodigoDeVuelo, pasajeroAux.Documento, pasajeroAux.NombreCliente,
                                   pasajeroAux.ApellidoCliente, vueloAux.Origen, vueloAux.HoraDePartida, vueloAux.Destino,
                                   vueloAux.HoraDeLlegada, "Premium", montoFacturado);

            }


            if (pasajeAux is PasajeTurista pasajeAuxT)
            {
                pasajeros.Rows.Add(pasajeAuxT.CodigoDeVuelo, pasajeAuxT.CodigoDePasaje, pasajeAuxT.CategoriaPasaje, pasajeAuxT.PrecioDePasaje,
                    pasajeAuxT.DniDePasajero, pasajeAuxT.NombrePasajero, pasajeAuxT.ApellidoDePasajero,
                                    pasajeAuxT.Origen, pasajeAuxT.HoraDeSalida, pasajeAuxT.Destino, pasajeAuxT.HoraDeLlegada);

            }
            if (pasajeAux is PasajePremium pasajeAuxP)
            {
                pasajeros.Rows.Add(pasajeAuxP.CodigoDeVuelo, pasajeAuxP.CodigoDePasaje, pasajeAuxP.CategoriaPasaje, pasajeAuxP.PrecioDePasaje,
                    pasajeAuxP.DniDePasajero, pasajeAuxP.NombrePasajero, pasajeAuxP.ApellidoDePasajero,
                                    pasajeAuxP.Origen, pasajeAuxP.HoraDeSalida, pasajeAuxP.Destino, pasajeAuxP.HoraDeLlegada);

            }
            listaDePasajes.Add(pasajeAux);

            btnAceptarModificacion.Enabled = true;
            btnCargarOtroPasajero.Enabled = true;



        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            GestionDeAerolinea.SubirPasajeroAlAvion(listaDePasajes,listaDePasajeros);

            for (int i = 0; i < listaDePasajes.Count; i++)
            {
                for (int j = 0; j < vueloAux.ListaDePasajes.Count; j++)
                {
                    if (vueloAux.ListaDePasajes[j] != null && vueloAux.CodigoDeVuelo == listaDePasajes[i].CodigoDeVuelo)
                    {
                        vueloAux.ListaDePasajes.Add(listaDePasajes[i]);
                    }
                }


            }

            this.Close();


        }

        private void btnCargarOtroPasajero_Click(object sender, EventArgs e)
        {
            rtbEquipaje.Clear();
            rtbFacturacion.Clear();
            rtbPasajero.Clear();
            rtbVuelo.Clear();   
        }
    }



}


