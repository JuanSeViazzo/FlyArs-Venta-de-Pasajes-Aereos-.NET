using System.Collections.Generic;

namespace Logica
{
    public static class Facturacion
    {

        static List<float> historialFacturadoSinImpuestos;
        static float precioSinImpuestos;
        static float precioConImpuestos;
        static List<float> historialFacturadoConImpuestos;

        static Facturacion()
        {
            historialFacturadoSinImpuestos = new List<float>();
            historialFacturadoConImpuestos = new List<float>();
            precioSinImpuestos = 0;
            precioConImpuestos = 0;
        }

        public static float FacturarSinImpuestos(Pasajero pasajeroAux, Vuelo vueloAux)
        {

            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                if (item.Key < 1000)
                    precioSinImpuestos = (float)vueloAux.DuracionDeVuelo * 50;          
                else              
                    precioSinImpuestos = (float)vueloAux.DuracionDeVuelo * 100;
                
            }
            #region           
            //if (vueloAux.DuracionDeVuelo > 4)
            //{
            //    precioSinImpuestos = (float)vueloAux.DuracionDeVuelo * 100;
            //}
            //else
            //{
            //    precioSinImpuestos = (float)vueloAux.DuracionDeVuelo * 50;
            //}
            #endregion

            if (pasajeroAux.ClaseDePasajero1 != ClaseDePasajero.Turista)
                precioSinImpuestos = precioSinImpuestos * 1.15f;
            

            historialFacturadoSinImpuestos.Add(precioSinImpuestos); 

            return precioSinImpuestos;

        }


        public static float FacturarConImpuestos(float precioSinImpuestos)
        {

            precioConImpuestos = precioSinImpuestos * 1.52f;

            historialFacturadoConImpuestos.Add(precioConImpuestos);
            return precioConImpuestos;

        }






    }






}
