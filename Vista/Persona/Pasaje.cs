using System;
using System.Text;
using System.Collections.Generic;

namespace Logica
{
    public class Pasaje
    {


        private string codigoDeVuelo;
        private static List<Pasaje> listaDePasajes;
        private int dniDePasajero;
        private string codigoDePasaje;
        
        static Pasaje()
        {
            listaDePasajes = new List<Pasaje>();    
        }
        
        public string CodigoDeVuelo { get => codigoDeVuelo;}
        public static List<Pasaje> ListaDePasajes { get => listaDePasajes;}
        public static List<Pasaje> ListaDePasajes1 { get => listaDePasajes;}
        public int DniDePasajero { get => dniDePasajero;}
        public string CodigoDePasaje { get => codigoDePasaje;}

        internal static Pasaje obtenerPasajePorId(string id)
        {
            Pasaje pasaje = null;

            for (int i = 0; i < Pasaje.ListaDePasajes.Count; i++)
            {
                if (id == ListaDePasajes[i].codigoDeVuelo)
                {
                    pasaje = Pasaje.ListaDePasajes[i];
                    break;
                }
            }
            return pasaje;
        }




    }
}