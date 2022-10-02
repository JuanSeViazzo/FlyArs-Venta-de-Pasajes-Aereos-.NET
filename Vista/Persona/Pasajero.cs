using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace Logica
{
    public enum ClaseDePasajero
    {
        Turista,
        Premium
    }

    public class Pasajero
    {
     


        private int documento;
        private string codigoDePasaje;
        private string codigoDeVuelo;
        private List<Equipaje> listaDeEquipajes;
        private string nombreCliente;
        private string apellidoCliente;
        private ClaseDePasajero claseDePasajero;

        public Pasajero(Cliente cliente,List<Equipaje>listaDeEquipajes,string codigoDePasaje,string codigoDeVuelo,ClaseDePasajero claseDePasajero)
        {
            this.documento = cliente.Documento;
            this.nombreCliente = cliente.Nombre;
            this.apellidoCliente = cliente.Apellido;
            this.listaDeEquipajes = listaDeEquipajes;
            this.codigoDeVuelo = codigoDeVuelo; 
            this.codigoDePasaje = codigoDePasaje;
            this.claseDePasajero = claseDePasajero;

        }

        public Pasajero(int documento, string codigoDePasaje, string codigoDeVuelo, List<Equipaje> listaDeEquipajes, string nombreCliente, string apellidoCliente, ClaseDePasajero claseDePasajero)
        {
            this.documento = documento;
            this.codigoDePasaje = codigoDePasaje;
            this.codigoDeVuelo = codigoDeVuelo;
            this.listaDeEquipajes = listaDeEquipajes;
            this.nombreCliente = nombreCliente;
            this.apellidoCliente = apellidoCliente;
            this.claseDePasajero = claseDePasajero; 
        }

        public int Documento { get => documento;}
        public string CodigoDePasaje { get => codigoDePasaje;}
        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public List<Equipaje> ListaDeEquipajes { get => listaDeEquipajes;}
        public string NombreCliente { get => nombreCliente;}
        public string ApellidoCliente { get => apellidoCliente;}
        public ClaseDePasajero ClaseDePasajero1 { get => claseDePasajero;}

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Pasaje: {codigoDePasaje}");
            sb.AppendLine($"Codigo de Vuelo: {codigoDeVuelo} ");
            sb.AppendLine($"Nombre: {nombreCliente}");
            sb.AppendLine($"Apellido: {apellidoCliente}"); 
            sb.AppendLine($"Clase de Pasajero: {claseDePasajero}\n");

            foreach (Equipaje item in listaDeEquipajes)
            {
                sb.AppendLine($"{item}");
            }
            
            
            return sb.ToString();   








        }





    }
}
