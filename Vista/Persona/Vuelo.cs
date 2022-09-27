using System;
using System.Collections.Generic;
using System.Text;


namespace Logica
{


    public class Vuelo
    {



        DateTime horaDePartida;
        DateTime horaDeLlegada;
        private Avion avion;
        private bool ofreceComida;
        private bool tieneWifi;
        private List<Pasajero> listaDePasajerosPremium;
        private List<Pasajero> listaDePasajerosTurista;
        private string codigoDeVuelo;
        private string destino;
        private string origen;
        private int asientosDisponibles;


        public Avion Avion { get => avion; set => avion = value; }
        public bool OfreceComida { get => ofreceComida; set => ofreceComida = value; }
        public bool TieneWifi { get => tieneWifi; set => tieneWifi = value; }
        public List<Pasajero> ListaDePasajeros { get => listaDePasajerosPremium; set => listaDePasajerosPremium = value; }
        public List<Pasajero> ListaDePasajerosTurista { get => listaDePasajerosTurista; set => listaDePasajerosTurista = value; }
        public string CodigoDeVuelo { get => codigoDeVuelo; set => codigoDeVuelo = value; }

        public DateTime HoraDePartida { get => horaDePartida; set => horaDePartida = value; }
        public DateTime HoraDeLlegada { get => horaDeLlegada; set => horaDeLlegada = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Origen { get => origen; set => origen = value; }
        public int AsientosDisponiblesPremium
        {
            get => asientosDisponibles = avion.CantidadDeAsientosPremium - listaDePasajerosPremium.Count;

        }
        public int AsientosDisponiblesTurista
        {
            get => asientosDisponibles = avion.CantidadDeAsientosTurista - listaDePasajerosTurista.Count;

        }



        private Vuelo()
        {
            listaDePasajerosTurista = new List<Pasajero>();
            listaDePasajerosPremium = new List<Pasajero>();
        }
        public Vuelo(DateTime horaDePartida, DateTime horaDeLlegada, Avion avion, bool ofreceComida, bool tieneWifi,
            string codigoDeVuelo, int origen, int destino) : this()
        {



            this.horaDePartida = horaDePartida;
            this.horaDeLlegada = horaDeLlegada;
            this.avion = avion;
            this.ofreceComida = ofreceComida;
            this.tieneWifi = tieneWifi;
            this.codigoDeVuelo = codigoDeVuelo;
            this.destino = CargarDestinoOrigen(destino);
            this.origen = CargarDestinoOrigen(origen);


        }

        private static string CargarDestinoOrigen(int valor)
        {

            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.ListaDeAeropuertos)
            {
                if (item.Key == valor)
                {
                    return item.Value;
                }
            }

            throw new Exception("Error en cargar destino/origen");
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Vuelo {codigoDeVuelo}");

            return sb.ToString();
        }



















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


        //public List<Pasaje> obtenerListaDePasajes()
        //{
        //    List<Pasaje> listaDePasajes = null;

        //    for (int i = 0; i < listaIdPasajes.Count; i++)
        //    {
        //        listaDePasajes.Add(Pasaje.obtenerPasajePorId(codigoDeVuelo));
        //    }

        //    return listaDePasajes;

        //}

        //public List<Cliente> obtenerListaDePersonas()
        //{   //lista que voy a devolver
        //    List<Cliente> ListaDePersonas = null;
        //    //lista de pasajes del avion
        //    List<Pasaje> listaDePasajes = obtenerListaDePasajes();

        //    //recorro la lista de pasajes del avion, y de cada pasaje saco el dni, ese dni lo comparo con la lista generica de pasajeros
        //    //y me traigo cada pasajero y lo sumo a la lista.
        //    for (int i = 0; i < listaDePasajes.Count; i++)
        //    {
        //        if (listaDePasajes[i].DniDePasajero == GestionDeAerolinea.ListaDePersonas[i].Documento)
        //        {
        //            GestionDeAerolinea.ListaDePersonas.Add(GestionDeAerolinea.ListaDePersonas[i]);
        //        }
        //    }
        //    return ListaDePersonas;
        //}




    }
}