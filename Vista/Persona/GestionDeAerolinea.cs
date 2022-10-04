using System;
using System.Collections.Generic;

namespace Logica
{
    public static class GestionDeAerolinea
    {

        private static List<Vuelo> listaDeVuelos;
        private static Dictionary<int, string> listaDeAeropuertos;
        private static List<Persona> listaDePersonas;
        private static List<Pasaje> listaDePasajes;
        private static List<Avion> listaDeAviones;
        private static List<Pasajero> listaDePasajeros;

        public static List<Persona> ListaDePersonas { get => listaDePersonas; set => listaDePersonas = value; }
        public static List<Vuelo> ListaDeVuelos { get => listaDeVuelos; set => listaDeVuelos = value; }
        public static List<Pasaje> ListaDePasajes { get => listaDePasajes; set => listaDePasajes = value; }
        public static Dictionary<int, string> DiccionarioDeAeropuertos { get => listaDeAeropuertos; set => listaDeAeropuertos = value; }
        public static List<Avion> ListaDeAviones { get => listaDeAviones; set => listaDeAviones = value; }
        public static List<Pasajero> ListaDePasajeros { get => listaDePasajeros; set => listaDePasajeros = value; }

        static GestionDeAerolinea()
        {
            listaDePasajeros = new List<Pasajero>();
            listaDePasajes = new List<Pasaje>();
            listaDePersonas = new List<Persona>();
            listaDeVuelos = new List<Vuelo>();
            listaDeAviones = new List<Avion>();
            listaDeAeropuertos = new Dictionary<int, string>();

        }



        public static Cliente obtenerClientePorDni(int dni)
        {
            Cliente pasajero = null;
            for (int i = 0; i < ListaDePersonas.Count; i++)
            {
                if (dni == ListaDePersonas[i].Documento)
                {
                    pasajero = (Cliente)ListaDePersonas[i];
                    break;
                }
            }
            return pasajero;
        }

        public static Avion ObtenerAvionPorMatricula(string matricula)
        {
            Avion avion = null;

            foreach (Avion item in listaDeAviones)
            {
                if (matricula == item.Matricula)
                {
                    avion = item;
                    break;
                }
            }

            return avion;


        }

        public static void SubirPasajeroAlAvion(List<Pasaje> listaDePasajes, List<Pasajero> listaDePasajeros)
        {
            Vuelo vueloAux;

            foreach (Pasaje itemPasaje in listaDePasajes)
            {
                vueloAux = GestionDeAerolinea.obtenerVueloPorCodigo(itemPasaje.CodigoDeVuelo);

                foreach (Pasajero itemPasajeros in listaDePasajeros)
                {
                    if (itemPasaje.DniDePasajero == itemPasajeros.Documento && itemPasaje.HoraDeSalida == vueloAux.HoraDePartida)
                    {
                        if (itemPasaje is PasajePremium)
                            vueloAux.ListaDePasajerosPremium.Add(itemPasajeros);
                        else
                            vueloAux.ListaDePasajerosTurista.Add(itemPasajeros);
                    }

                }

            }
        }





        public static Vuelo obtenerVueloPorCodigo(string codigoDeVuelo)
        {
            Vuelo vuelo = null;

            for (int i = 0; i < ListaDeVuelos.Count; i++)
            {
                if (codigoDeVuelo == listaDeVuelos[i].CodigoDeVuelo)
                {
                    vuelo = ListaDeVuelos[i];
                    break;
                }


            }

            return vuelo;
        }



        public static bool CargarClienteEnLineaAerea(Cliente cliente)
        {

            if (!GestionDeAerolinea.ValidarPasajeroEnLineaAerea(cliente.Documento))
            {
                GestionDeAerolinea.ListaDePersonas.Add(cliente);
                return true;
            }
            else
                throw new Exception("Pasajero ya cargado");

        }


        public static void ModificarPasajeroEnLineaAerea(Cliente pasajero, int documento)
        {
            int flag = 0;

            if (pasajero is not null)
            {
                for (int i = 0; i < ListaDePersonas.Count; i++)
                {
                    if (ListaDePersonas[i].Documento == documento)
                    {
                        ListaDePersonas[i] = pasajero;
                        break;
                    }
                    else
                    {
                        flag = 1;
                    }

                }
                if (flag == 1)
                {
                    throw new("Pasajero no encontrado en la lista,\n desea cargarlo con un nuevo DNI?");
                }
            }
            else
                throw new Exception("Pasajero incompleto");

        }


        public static void EliminarPasajeroEnLineaAerea(int documento)
        {
            if (documento > 10000000)
            {
                for (int i = 0; i < ListaDePersonas.Count; i++)
                {
                    if (ListaDePersonas[i].Documento == documento)
                    {
                        ListaDePersonas.Remove(ListaDePersonas[i]);
                        break;
                    }
                }
            }
        }





        public static bool ValidarPasajeroEnLineaAerea(int dni)
        {


            foreach (Persona item in GestionDeAerolinea.ListaDePersonas)
            {
                if (item is Cliente itemAux)
                {
                    if (itemAux.Documento == dni)
                    {
                        return true;
                    }

                }


            }
            return false;

        }










    }




}

