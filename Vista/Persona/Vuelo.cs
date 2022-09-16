using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Vuelo
    {


        DateTime horaDePartida;
        private Avion avion;
        private bool ofreceComida;
        private bool tieneWifi;
        private List<int> listaIdPasajes;
        private string codigoDeVuelo;
        private static List<Vuelo> listaDeVuelos;

        static Vuelo()
        {
            listaDeVuelos = new List<Vuelo>();  
        }

        public Vuelo(DateTime horaDePartida, Avion avion, bool ofreceComida, bool tieneWifi, string codigoDeVuelo)
        {
            this.horaDePartida = horaDePartida;
            this.avion = avion;
            this.ofreceComida = ofreceComida;
            this.tieneWifi = tieneWifi;
            this.listaIdPasajes = new List<int>();
            this.codigoDeVuelo = codigoDeVuelo;
        }

        public List<int> IdPasaje { get => listaIdPasajes; }
        public DateTime HoraDePartida { get => horaDePartida;}
        public Avion Avion { get => avion;}
        public bool OfreceComida { get => ofreceComida;}
        public bool TieneWifi { get => tieneWifi;}
        public List<int> ListaIdPasajes { get => listaIdPasajes;}
        public string CodigoDeVuelo { get => codigoDeVuelo;}





        //public static bool obtenerPasajesPorId();



        //public bool VueloLleno()
        //{
        //    if (avion.CantidadMaximaDePasajeros == pasajeros.Count)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}

        // Vuelo volar = new Vuelo();


        public List<Pasaje> obtenerListaDePasajes()
        {
            List<Pasaje> listaDePasajes = null;

            for(int i = 0; i < ListaIdPasajes.Count; i++)
            {
                listaDePasajes.Add(Pasaje.obtenerPasajePorId(codigoDeVuelo));
            }

            return listaDePasajes;

        }

        public List<Pasajero> obtenerListaDePasajeros()
        {   //lista que voy a devolver
            List<Pasajero> listaDePasajeros = null;
           //lista de pasajes del avion
            List<Pasaje> listaDePasajes = obtenerListaDePasajes();

            //recorro la lista de pasajes del avion, y de cada pasaje saco el dni, ese dni lo comparo con la lista generica de pasajeros
            //y me traigo cada pasajero y lo sumo a la lista.
            for (int i = 0; i < listaDePasajes.Count; i++)
            {
                if (listaDePasajes[i].DniDePasajero == Pasajero.ListaDePasajeros[i].Documento)
                {
                    listaDePasajeros.Add(Pasajero.ListaDePasajeros[i]);
                }
            }
            return listaDePasajeros;
        }




    }
}