using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pasajero
    {



        private string documento;
        private string codigoDePasaje;
        private string codigoDeVuelo;
        private List<Equipaje> listaDeEquipajes;

        public string Documento { get => documento; set => documento = value; }
        public string CodigoDePasaje { get => codigoDePasaje; set => codigoDePasaje = value; }
        public string CodigoDeVuelo { get => codigoDeVuelo; set => codigoDeVuelo = value; }
        public List<Equipaje> ListaDeEquipajes { get => listaDeEquipajes; set => listaDeEquipajes = value; }

        public Pasajero(string documento, string codigoDePasaje, string codigoDeVuelo, List<Equipaje> listaDeEquipajes)
        {
            this.Documento = documento;
            this.CodigoDePasaje = codigoDePasaje;
            this.CodigoDeVuelo = codigoDeVuelo;
            this.ListaDeEquipajes = listaDeEquipajes;
        }
















    }
}
