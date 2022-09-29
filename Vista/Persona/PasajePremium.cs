using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PasajePremium : Pasaje
    {

        private string codigoDePasaje;
        private string categoriaPasaje;
        private float precioDePasaje;

        public PasajePremium(string codigoDePasaje,string codigoDeVuelo, int dniDePasajero, string nombrePasajero, string apellidoDePasajero, 
            string origen,DateTime horaDeSalida, string destino,DateTime horaDeLlegada,string categoriaPasaje,float precioDePasaje)
            : base(codigoDeVuelo, dniDePasajero, nombrePasajero, apellidoDePasajero, origen,horaDeSalida ,destino,horaDeLlegada)
        {
            this.CodigoDePasaje = codigoDePasaje;
            this.categoriaPasaje = categoriaPasaje;
            this.precioDePasaje= precioDePasaje;
        }


        public float PrecioDePasaje { get => precioDePasaje; }
        public string CategoriaPasaje { get => categoriaPasaje; }
        public string CodigoDePasaje { get => codigoDePasaje;
            private set 
            {
                codigoDePasaje = CargarCodigoDePasaje(CodigoDeVuelo);
            }
        }

        public override float aplicarDescuento(int dni)
        {
            Cliente cliente;

            cliente = GestionDeAerolinea.obtenerClientePorDni(dni);

            if (cliente.CodigoDePasaje.Count > 5)
            {
                switch (cliente.CodigoDePasaje.Count)
                {
                    case 4:
                        return 10;
                    case 5:
                        return 15;
                    case 6:
                        return 20;
                    default:
                        return 25;
                }
            }else
                return 0;
        }

        public override string CargarCodigoDePasaje(string codigoDePasaje)
        {
            return $"PREMI{codigoDePasaje}";
        }

        public override float cobrarPasaje()
        {
            throw new NotImplementedException();
        }
    }
}
