using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



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
        public List<Pasajero> ListaDePasajerosPremium { get => listaDePasajerosPremium; set => listaDePasajerosPremium = value; }
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
        public double DuracionDeVuelo { get => (horaDeLlegada-horaDePartida).TotalHours;}

        private Vuelo()
        {
            listaDePasajerosTurista = new List<Pasajero>();
            listaDePasajerosPremium = new List<Pasajero>();
        }
        public Vuelo(DateTime horaDePartida, DateTime horaDeLlegada, Avion avion, bool ofreceComida, bool tieneWifi,
            string codigoDeVuelo, int origen, int destino) : this()
        {



            this.HoraDePartida = CargarOrigenConHora(horaDePartida);
            this.HoraDeLlegada = CargarDestinoNacionalEInternacionalConHora(HoraDePartida, destino);
            this.avion = avion;
            this.ofreceComida = ofreceComida;
            this.tieneWifi = tieneWifi;
            this.codigoDeVuelo = GenerarCodigoDeVuelo(avion,origen,destino);
            this.destino = CargarDestinoOrigen(destino);
            this.origen = CargarDestinoOrigen(origen);


        }

        private static string CargarDestinoOrigen(int valor)
        {

            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (item.Key == valor)
                {
                    return item.Value;
                }
            }

            throw new Exception("Error en cargar \n destino/origen");
        }


        public override string ToString()
        {
            string respuestaComida; 
            string respuestaWifi;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Vuelo {codigoDeVuelo}");
            sb.AppendLine($"Origen: {origen}");
            sb.AppendLine($"Destino: {destino}");
            sb.AppendLine($"Hora de partida: {horaDePartida}");
            sb.AppendLine($"Hora de llegada: {horaDeLlegada}");
            sb.AppendLine($"Ofrece comida: {respuestaComida = ((ofreceComida == true) ? "SI": "NO") }");
            sb.AppendLine($"Ofrece comida: {respuestaWifi = ((tieneWifi == true) ? "SI" : "NO") }");

            return sb.ToString();
        }


        public DateTime CargarOrigenConHora (DateTime fecha)
        {
            Random r = new Random();

            int horaInt = r.Next(1, 23);

            fecha = fecha.AddHours((double)horaInt);

            return fecha;

        }
        public DateTime CargarDestinoNacionalEInternacionalConHora(DateTime fecha, int destino)
        {

            if (destino >= 1000)
            {
                Random r = new Random();

                int horaInt = r.Next(8, 12);

                fecha = fecha.AddHours((double)horaInt);

                return fecha;
            }else
            {
                Random r = new Random();

                int horaInt = r.Next(1, 4);

                fecha = fecha.AddHours((double)horaInt);

                return fecha;
            }
           

        }


        public string GenerarCodigoDeVuelo(Avion avion, int origen, int destino)
        {
            //LV - 350LA
            //BUELV777ULMIA
            string codigoDeVuelo = avion.Matricula;
            string origenString = "";
            string destinoString= "";

            foreach (KeyValuePair<int,string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if(origen == item.Key)
                {
                    origenString = item.Value.Substring(0, 3);
                }
                if (destino == item.Key)
                {
                    destinoString = item.Value.Substring(0, 3);
                }

            }


            codigoDeVuelo = codigoDeVuelo.Replace("-","");
            codigoDeVuelo = codigoDeVuelo.Replace(" ", "");
            codigoDeVuelo = origenString + codigoDeVuelo;
            codigoDeVuelo = codigoDeVuelo + destinoString;
            codigoDeVuelo = codigoDeVuelo.ToUpper();


            return codigoDeVuelo;
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