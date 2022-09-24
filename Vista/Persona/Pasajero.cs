using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace Logica
{
    public class Pasajero
    {



        private int documento;
        private string codigoDePasaje;
        private string codigoDeVuelo;
        private List<Equipaje> listaDeEquipajes;
        private string nombreCliente;
        private string apellidoCliente;


        public Pasajero(int documento, string codigoDePasaje, string codigoDeVuelo, List<Equipaje> listaDeEquipajes, string nombreCliente, string apellidoCliente)
        {
            this.documento = documento;
            this.codigoDePasaje = codigoDePasaje;
            this.codigoDeVuelo = codigoDeVuelo;
            this.listaDeEquipajes = listaDeEquipajes;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;

        }

        public int Documento { get => documento;}
        public string CodigoDePasaje { get => codigoDePasaje;}
        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public List<Equipaje> ListaDeEquipajes { get => listaDeEquipajes;}
        public string NombreCliente { get => nombreCliente;}
        public string ApellidoCliente { get => apellidoCliente;}





        public override string ToString()
        {


            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine($"{codigoDePasaje} {nombreCliente} ");
            return sb.ToString();   







        }





    }
}
