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



        public static int obtenerCantidadDeViajesPorPasajero(Pasajero pasajeroAux)
        {

            Vuelo vueloAux;
            int sumaUno = 0;
            int sumaDos = 0;

            for (int j = 0; j < GestionDeAerolinea.ListaDeVuelos.Count; j++)
            {
               

                vueloAux = GestionDeAerolinea.ListaDeVuelos[j];
                sumaUno += IterarListaDePasajerosPremium(pasajeroAux, vueloAux);
                sumaDos += IterarListaDePasajerosTurista(pasajeroAux, vueloAux);



            }

            return sumaUno + sumaDos;

        }
        private static int IterarListaDePasajerosTurista(Pasajero pasajero, Vuelo vueloAux)
        {
            int contador = 0;
            foreach (var item in vueloAux.ListaDePasajerosTurista)
            {
                if (pasajero.Documento == item.Documento)
                {
                    contador++;
                    break;
                }
            }
            return contador;
        }
        private static int IterarListaDePasajerosPremium(Pasajero pasajero, Vuelo vueloAux)
        {
            int contador = 0;

            foreach (var item in vueloAux.ListaDePasajerosPremium)
            {
                if (pasajero.Documento == item.Documento)
                {
                    contador++;
                    break;
                }
            }
            return contador;
        }

    }






}
