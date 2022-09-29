using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Windows.Forms;

namespace Vista
{

    public partial class FrmFacturar : Form
    {
        Pasajero pasajeroAux;
        Vuelo vueloAux;
        public string montoFacturado;
        public float montoParcial;
        public float montoFinal;

        private FrmFacturar()
        {
            InitializeComponent();
        }

        public FrmFacturar(Pasajero pasajero, Vuelo vuelo) : this()
        {
            this.pasajeroAux = pasajero;
            this.vueloAux = vuelo;  
        }

        private void FrmFacturar_Load(object sender, EventArgs e)
        {
            
            rtbPasajero.Text = pasajeroAux.ToString();  


        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {

           float montoSinImpuesto = Facturacion.FacturarSinImpuestos(pasajeroAux, vueloAux);
            float montoConImpuesto = Facturacion.FacturarConImpuestos(montoSinImpuesto);
            montoParcial = montoSinImpuesto;
            montoFinal = montoConImpuesto;
                montoFacturado = $"Monto sin impuesto: {montoParcial} \n Monto con Impuestos: {montoFinal}";
                rtbFacturacion.Text = montoFacturado;

        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
