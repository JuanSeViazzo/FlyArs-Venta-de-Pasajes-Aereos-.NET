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

        protected Pasaje(string codigoDeVuelo, int dniDePasajero, string nombrePasajero, string apellidoDePasajero, 
            string origen,DateTime horaDeSalida, string destino,DateTime horaDeLlegada)
        {
            this.codigoDeVuelo = codigoDeVuelo;
            this.dniDePasajero = dniDePasajero;
            this.nombrePasajero = nombrePasajero;
            this.apellidoDePasajero = apellidoDePasajero;
            this.origen = origen;
            this.destino = destino;
            this.horaDeSalida = horaDeSalida;
            this.horaDeLlegada = horaDeLlegada;
        }

        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public int DniDePasajero { get => dniDePasajero;}
        public string NombrePasajero { get => nombrePasajero;}
        public string ApellidoDePasajero { get => apellidoDePasajero;}
        public string Origen { get => origen; }
        public string Destino { get => destino;}
        public DateTime HoraDeSalida { get => horaDeSalida;}
        public DateTime HoraDeLlegada { get => horaDeLlegada;}

        public abstract string CargarCodigoDePasaje(string codigoDePasaje);
        public abstract float cobrarPasaje();

        public abstract float aplicarDescuento(int dni);



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Vuelo: {codigoDeVuelo}");
            sb.AppendLine($"Documento: {dniDePasajero}");
            sb.AppendLine($"Nombre: {nombrePasajero}");
            sb.AppendLine($"Apellido: {apellidoDePasajero}");
            sb.AppendLine($"Origen del vuelo: {origen}");
            sb.AppendLine($"Destino del vuelo: {destino}");
            return sb.ToString();   
        }



    }
}