using System.Collections.Generic;

namespace Logica
{
    public static class Estadisticas
    {

        static Dictionary<string, float> estadisticasDeDestino;

        public static Dictionary<string, float> EstadisticasDeDestino { get => estadisticasDeDestino; set => estadisticasDeDestino = value; }

        static Estadisticas()
        {
            EstadisticasDeDestino = new Dictionary<string, float>();
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

            foreach (KeyValuePair<int, string> item in GestionDeAerolinea.DiccionarioDeAeropuertos)
            {
            float acumulador = 0;
                for (int j = 0; j < GestionDeAerolinea.ListaDePasajes.Count; j++)
                {

                    if (item.Value == GestionDeAerolinea.ListaDePasajes[j].Destino)
                    {
                        acumulador += GestionDeAerolinea.ListaDePasajes[j].PrecioDePasaje;
                    }
                    



                    // primero deberia comparar el destino de destinos, contra los de pasajes
                    //recorro todos los pasajes y digo ...Pasaje.destino == Destino.destino
                    //entonces voy a acumular solo los de 1 destino, y cuando salgo del for de pasajes, lo acumulado se lo guardo en value y en key el destino.
                }

                estadisticasDeDestino.Add(item.Value, acumulador);

            }



        }



    }


}



