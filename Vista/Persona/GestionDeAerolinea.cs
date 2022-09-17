using System;
using System.Collections.Generic;

namespace Logica
{
    public class GestionDeAerolinea
    {

        private static List<Pasajero> listaDePasajeros;

        static GestionDeAerolinea()
        {
            listaDePasajeros = new List<Pasajero>();
        }

        public static List<Pasajero> ListaDePasajeros { get => listaDePasajeros; }

        public static Pasajero obtenerPasajeroPorDni(string dni)
        {
            Pasajero pasajero = null;
            for (int i = 0; i < GestionDeAerolinea.listaDePasajeros.Count; i++)
            {
                if (dni == listaDePasajeros[i].Documento)
                {
                    pasajero = listaDePasajeros[i];
                    break;
                }
            }
            return pasajero;
        }


        public static bool CargarPasajeroEnLineaAerea(Pasajero pasajero)
        {

            if (!GestionDeAerolinea.ValidarPasajeroEnLineaAerea(pasajero.Documento))
            {
                GestionDeAerolinea.ListaDePasajeros.Add(pasajero);
                return true;
            }
            else
                throw new Exception("Pasajero ya cargado");

        }


        public static bool ValidarPasajeroEnLineaAerea(string dni)
        {


            foreach (Pasajero item in GestionDeAerolinea.listaDePasajeros)
            {

                if (item.Documento == dni)
                {
                    return true;
                }

            }
            return false;
            
        }



    }




}

