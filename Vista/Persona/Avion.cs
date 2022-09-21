using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Avion
    {

        //private Dictionary<int, string> destinosNacionales;
        //private Dictionary<int, string> destinosDesdeBuenosAires;

        private int cantidadDeAsientos;
        private string matricula;
        private int capacidadDeBodega;
        private int cantidadDeBanios;

        public Avion(int cantidadDeAsientos, string matricula, int capacidadDeBodega, int cantidadDeBanios)
        {
            this.CantidadDeAsientos = cantidadDeAsientos;
            this.Matricula = matricula;
            this.CapacidadDeBodega = capacidadDeBodega;
            this.CantidadDeBanios = cantidadDeBanios;
        }

        public int CantidadDeAsientos { get => cantidadDeAsientos; set => cantidadDeAsientos = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int CapacidadDeBodega { get => capacidadDeBodega; set => capacidadDeBodega = value; }
        public int CantidadDeBanios { get => cantidadDeBanios; set => cantidadDeBanios = value; }








        //public Dictionary<int, string> DestinosNacionales { get => destinosNacionales; set => destinosNacionales = value; }
        //public Dictionary<int, string> DestinosDesdeBuenosAires { get => destinosDesdeBuenosAires; set => destinosDesdeBuenosAires = value; }










    }
}