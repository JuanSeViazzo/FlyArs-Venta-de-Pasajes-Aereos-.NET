using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public abstract class Pasaje
    {


        private string codigoDeVuelo;
        private int dniDePasajero;
        private string nombrePasajero;
        private string apellidoDePasajero;
        private string origen;
        private string destino;
        private DateTime horaDeSalida;
        private DateTime horaDeLlegada;
        private float precioDePasaje;

        protected Pasaje(string codigoDeVuelo, int dniDePasajero, string nombrePasajero, string apellidoDePasajero, 
            string origen,DateTime horaDeSalida, string destino,DateTime horaDeLlegada, float precioDePasaje)
        {
            this.codigoDeVuelo = codigoDeVuelo;
            this.dniDePasajero = dniDePasajero;
            this.nombrePasajero = nombrePasajero;
            this.apellidoDePasajero = apellidoDePasajero;
            this.origen = origen;
            this.destino = destino;
            this.horaDeSalida = horaDeSalida;
            this.horaDeLlegada = horaDeLlegada;
            this.precioDePasaje = precioDePasaje;

        }

        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public int DniDePasajero { get => dniDePasajero;}
        public string NombrePasajero { get => nombrePasajero;}
        public string ApellidoDePasajero { get => apellidoDePasajero;}
        public string Origen { get => origen; }
        public string Destino { get => destino;}
        public DateTime HoraDeSalida { get => horaDeSalida;}
        public DateTime HoraDeLlegada { get => horaDeLlegada;}
        public float PrecioDePasaje { get => precioDePasaje;}

        public abstract string CargarCodigoDePasaje(string codigoDePasaje);
        public abstract float aplicarDescuento(int dni);
        
        public abstract float cobrarPasaje();




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Vuelo: {codigoDeVuelo}");
            sb.AppendLine($"Documento: {dniDePasajero}");
            sb.AppendLine($"Nombre: {nombrePasajero}");
            sb.AppendLine($"Apellido: {apellidoDePasajero}");
            sb.AppendLine($"Origen del vuelo: {origen}");
            sb.AppendLine($"Destino del vuelo: {destino}");
            sb.AppendLine($"Precio del pasaje: {precioDePasaje}");
            return sb.ToString();   
        }



    }
}