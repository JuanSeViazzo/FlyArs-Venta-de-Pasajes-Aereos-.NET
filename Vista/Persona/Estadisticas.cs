using System.Collections.Generic;

namespace Logica
{
    public static class Estadisticas
    {

        static Dictionary<string, float> estadisticasDeDestino;
        static Dictionary<string, int> estadisticasDestinoFavorito;
        static Dictionary<string, float> estadisticafacturacionPorCategoria;

        public static Dictionary<string, float> EstadisticasDeDestino { get => estadisticasDeDestino; set => estadisticasDeDestino = value; }
        public static Dictionary<string, int> EstadisticasDestinoFavorito { get => estadisticasDestinoFavorito; set => estadisticasDestinoFavorito = value; }
        public static Dictionary<string, float> EstadisticaFacturacionPorCategoria { get => estadisticafacturacionPorCategoria; set => estadisticafacturacionPorCategoria = value; }

        public static int numero;

        static Estadisticas()
        {
            EstadisticasDeDestino = new Dictionary<string, float>();
            estadisticasDestinoFavorito = new Dictionary<string, int>();
            estadisticafacturacionPorCategoria = new Dictionary<string, float>();
        }


        public static void HorasDeVueloPorAvion(Avion avion)
        {
            foreach (Vuelo vuelo in GestionDeAerolinea.ListaDeVuelos)
            {
                if (vuelo.Avion.Matricula == avion.Matricula)

                    avion.DuracionDeVuelo += vuelo.DuracionDeVuelo;
            }
        }



        public static void DestinosOrdenadosPorFacturacion()
        {
            AcumularPrecioPorDestino();

        }

        private static void AcumularPrecioPorDestino()
        {
            EstadisticasDeDestino.Clear();

            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                float acumulador = 0;

                for (int j = 0; j < GestionDeAerolinea.ListaDePasajes.Count; j++)
                {
                    if (item.Value == GestionDeAerolinea.ListaDePasajes[j].Destino)
                    {
                        acumulador += GestionDeAerolinea.ListaDePasajes[j].PrecioDePasaje;
                    }
                }
                if (estadisticasDeDestino.ContainsKey(item.Value) == false)
                {
                    estadisticasDeDestino.Add(item.Value, acumulador);
                }
                else
                {
                    EstadisticasDeDestino.Clear();
                    estadisticasDeDestino.Add(item.Value, acumulador);
                }
            }

        }


        public static void DestinosOrdenadosFavoritos()
        {

            ContarDestinoFavorito();
        }

        private static void ContarDestinoFavorito()
        {


            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
                int acumulador = 0;

                for (int i = 0; i < GestionDeAerolinea.ListaDeVuelos.Count; i++)
                {
                    if (item.Value == GestionDeAerolinea.ListaDeVuelos[i].Destino)
                    {

                        acumulador += GestionDeAerolinea.ListaDeVuelos[i].ListaDePasajerosPremium.Count + GestionDeAerolinea.ListaDeVuelos[i].ListaDePasajerosTurista.Count;

                    }
                }
                estadisticasDestinoFavorito.Add(item.Value, acumulador);
            }
        }



        public static void FacturacionPorCategoria()
        {
            float acumuladorPremium = 0;
            float acumuladorTurista = 0;

            foreach (var item in GestionDeAerolinea.ListaDePasajes)
            {


                if (item is PasajePremium pasajePremiumAux)
                {
                    acumuladorPremium += pasajePremiumAux.PrecioDePasaje;
                }
                else
                {
                    if (item is PasajeTurista pasajeTuristaAux)
                    {
                        acumuladorTurista += pasajeTuristaAux.PrecioDePasaje;
                    }
                }
            }
            estadisticafacturacionPorCategoria.Add("Premium", acumuladorPremium);
            estadisticafacturacionPorCategoria.Add("Turista", acumuladorTurista);

        }


        public static void EstadisticasDeClientesFrecuentesSegunViajes()
        {
            Persona clienteAux;

            for (int i = 0; i < GestionDeAerolinea.ListaDePersonas.Count; i++)
            {
                clienteAux = GestionDeAerolinea.ListaDePersonas[i];

                if (clienteAux is Cliente cliente)
                {
                    cliente.CantidadDeVuelos = 0;

                    IterarListaDeVuelos(cliente);
                }
            }
        }
        private static void IterarListaDeVuelos(Cliente cliente)
        {
            Vuelo vueloAux;
            for (int j = 0; j < GestionDeAerolinea.ListaDeVuelos.Count; j++)
            {
                vueloAux = GestionDeAerolinea.ListaDeVuelos[j];
                IterarListaDePasajerosPremium(cliente, vueloAux);
                IterarListaDePasajerosTurista(cliente, vueloAux);

            }

        }
        private static void IterarListaDePasajerosTurista(Cliente cliente, Vuelo vueloAux)
        {
            foreach (var item in vueloAux.ListaDePasajerosTurista)
            {
                if (cliente.Documento == item.Documento)
                {
                    cliente.CantidadDeVuelos += 1;
                }
            }
        }
        private static void IterarListaDePasajerosPremium(Cliente cliente, Vuelo vueloAux)
        {
            foreach (var item in vueloAux.ListaDePasajerosPremium)
            {
                if (cliente.Documento == item.Documento)
                {
                    cliente.CantidadDeVuelos += 1;
                }
            }
        }
    }


}

