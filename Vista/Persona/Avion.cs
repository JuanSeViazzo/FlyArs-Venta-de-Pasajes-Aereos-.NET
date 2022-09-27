using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Avion
    {

        //private Dictionary<int, string> destinosNacionales;
        //private Dictionary<int, string> destinosDesdeBuenosAires;

        private int cantidadDeAsientosTurista;
        private int cantidadDeAsientosPremium;
        private string matricula;
        private int capacidadDeBodega;
        private int cantidadDeBanios;

        public Avion(int cantidadDeAsientosPremium, int cantidadDeAsientosTurista, string matricula, int capacidadDeBodega, int cantidadDeBanios)
        {
            this.CantidadDeAsientosPremium = cantidadDeAsientosPremium;
            this.CantidadDeAsientosTurista = cantidadDeAsientosTurista;
            this.Matricula = matricula;
            this.CapacidadDeBodega = capacidadDeBodega;
            this.CantidadDeBanios = cantidadDeBanios;
        }

        public int CantidadDeAsientosTurista { get => cantidadDeAsientosTurista; set => cantidadDeAsientosTurista = value; }
        public int CantidadDeAsientosPremium { get => cantidadDeAsientosPremium; set => cantidadDeAsientosPremium = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int CapacidadDeBodega { get => capacidadDeBodega; set => capacidadDeBodega = value; }
        public int CantidadDeBanios { get => cantidadDeBanios; set => cantidadDeBanios = value; }








        //public Dictionary<int, string> DestinosNacionales { get => destinosNacionales; set => destinosNacionales = value; }
        //public Dictionary<int, string> DestinosDesdeBuenosAires { get => destinosDesdeBuenosAires; set => destinosDesdeBuenosAires = value; }










    }
}