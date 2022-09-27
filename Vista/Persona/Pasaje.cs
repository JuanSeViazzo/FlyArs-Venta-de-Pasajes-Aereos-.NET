using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Pasaje
    {


        private string codigoDeVuelo;
        private int dniDePasajero;
        private string codigoDePasaje;
        private string nombrePasajero;
        private string apellidoDePasajero;
        private float precioDePasaje;
        private string origen;
        private string destino;
        private string categoriaPasaje;



        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public int DniDePasajero { get => dniDePasajero;}
        public string CodigoDePasaje { get => codigoDePasaje;}
        public string NombrePasajero { get => nombrePasajero;}
        public float PrecioDePasaje { get => precioDePasaje;}
        public string ApellidoDePasajero { get => apellidoDePasajero;}
        public string Origen { get => origen; }
        public string Destino { get => destino;}
        public string CategoriaPasaje { get => categoriaPasaje; }
    }
}