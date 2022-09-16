using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Avion
    {

        private Dictionary<int, string> destinosNacionales;
        private Dictionary<int, string> destinosDesdeBuenosAires;

        private int cantidadMaximaDePasajeros;

        public int CantidadMaximaDePasajeros { get => cantidadMaximaDePasajeros;}
        public Dictionary<int, string> DestinosNacionales { get => destinosNacionales; set => destinosNacionales = value; }
        public Dictionary<int, string> DestinosDesdeBuenosAires { get => destinosDesdeBuenosAires; set => destinosDesdeBuenosAires = value; }
    }
}