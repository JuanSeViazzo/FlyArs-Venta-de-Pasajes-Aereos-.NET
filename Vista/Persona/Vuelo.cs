using System;
using System.Collections.Generic;

namespace Logica
{
    public enum DestinosNacionales
    {
        SantaRosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        Santiago_del_Estero,
        Trelew,
        Tucumán,
        Puerto_Madryn,
        Ushuaia,
        Buenos_Aires
    }

    public enum DestinosInternacionales
    {
        Recife_Brasil_,
        Roma_Italia_,
        Acapulco_México_,
        Miami_EEUU_
    }

    public class Vuelo
    {


        DateTime horaDePartida;
        DateTime horaDeLlegada;
        private Avion avion;
        private bool ofreceComida;
        private bool tieneWifi;
        private List<Pasajero> listaDePasajeros;
        private string codigoDeVuelo;
        private DestinosInternacionales destinosInternacionales;
        private DestinosNacionales destinosNacionales;

        public DateTime HoraDePartida { get => horaDePartida; set => horaDePartida = value; }
        public DateTime HoraDeLlegada { get => horaDeLlegada; set => horaDeLlegada = value; }
        public Avion Avion { get => avion; set => avion = value; }
        public bool OfreceComida { get => ofreceComida; set => ofreceComida = value; }
        public bool TieneWifi { get => tieneWifi; set => tieneWifi = value; }
        public List<Pasajero> ListaDePasajeros { get => listaDePasajeros; set => listaDePasajeros = value; }
        public string CodigoDeVuelo { get => codigoDeVuelo; set => codigoDeVuelo = value; }
        
        public DestinosInternacionales DestinosInternacionales 
        { get => 
                destinosInternacionales;

             set
            {
             
                destinosInternacionales = value;    
            }
        }
        public DestinosNacionales DestinosNacionales { get => destinosNacionales; set => destinosNacionales = value; }

        private Vuelo()
        {
            listaDePasajeros = new List<Pasajero>();
        }
        public Vuelo(DateTime horaDePartida, DateTime horaDeLlegada, Avion avion, bool ofreceComida, bool tieneWifi, 
            string codigoDeVuelo, DestinosNacionales destinosNacionales, DestinosInternacionales destinosInternacionales) : this()
        {



            this.horaDePartida = horaDePartida;
            this.horaDeLlegada = horaDeLlegada;
            this.avion = avion;
            this.ofreceComida = ofreceComida;
            this.tieneWifi = tieneWifi;
            this.codigoDeVuelo = codigoDeVuelo;
            this.DestinosInternacionales = destinosInternacionales;
            this.DestinosNacionales = destinosNacionales;

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