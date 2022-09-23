using System;
using System.Collections.Generic;

namespace Logica
{
    public class GestionDeAerolinea
    {

        private static List<Vuelo> listaDeVuelos;

        private static List<Persona> listaDePersonas;

        public static List<Persona> ListaDePersonas { get => listaDePersonas; set => listaDePersonas = value; }
        public static List<Vuelo> ListaDeVuelos { get => listaDeVuelos; set => listaDeVuelos = value; }
        public static Dictionary<int,string> listaDeAeropuertos;

        static GestionDeAerolinea()
        {
     
            listaDePersonas = new List<Persona>();
            listaDeVuelos = new List<Vuelo>();
            listaDeAeropuertos = new Dictionary<int, string>();

        }



        public static Cliente obtenerPasajeroPorDni(int dni)
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

        public static Vuelo obtenerVueloPorCodigo(string codigoDeVuelo)
        {
            Vuelo vuelo = null;

            for (int i = 0; i < ListaDeVuelos.Count; i++)
            {
                if(codigoDeVuelo == listaDeVuelos[i].CodigoDeVuelo)
                {
                    vuelo = (Vuelo)ListaDeVuelos[i];
                    break;
                }


            }

            return vuelo;
        }



        public static bool CargarPasajeroEnLineaAerea(Cliente pasajero)
        {

            if (!GestionDeAerolinea.ValidarPasajeroEnLineaAerea(pasajero.Documento))
            {
                GestionDeAerolinea.ListaDePersonas.Add(pasajero);
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
                    }else
                    {
                        flag = 1;
                    }

                }
                if (flag ==1)
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


            foreach (Cliente item in GestionDeAerolinea.ListaDePersonas)
            {

                if (item.Documento == dni)
                {
                    return true;
                }

            }
            return false;

        }

        

        



        public static bool ValidarUsuario(string user)
        {

            foreach (Usuario item in GestionDeAerolinea.listaDePersonas)
            {
                if (item.User == user)
                {
                    return true;
                }

            }

            throw new Exception("Usuario Incorrecto");


        }









    }




}

