﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    public class PasajeTurista : Pasaje
    {

        private string codigoDePasaje;
        private string categoriaPasaje;

        public PasajeTurista(string codigoDePasaje,string codigoDeVuelo, int dniDePasajero, string nombrePasajero, string apellidoDePasajero, 
            string origen,DateTime horaDeSalida, string destino,DateTime horaDeLlegada,string categoriaPasaje,float precioDePasaje)
            : base(codigoDeVuelo, dniDePasajero, nombrePasajero, apellidoDePasajero, origen,horaDeSalida, destino,horaDeSalida,precioDePasaje)
        {
            this.CodigoDePasaje = codigoDePasaje;
            this.categoriaPasaje = categoriaPasaje;


        }

        public string CategoriaPasaje { get => categoriaPasaje; }
        public string CodigoDePasaje { get => codigoDePasaje;
           
            set 
            {
                codigoDePasaje = CargarCodigoDePasaje(CodigoDeVuelo);
            }
        }

        public override float aplicarDescuento(int dni)
        {
            Cliente cliente;

            cliente = GestionDeAerolinea.obtenerClientePorDni(dni);

            if (cliente.CodigoDePasaje.Count > 10)
            {
                switch (cliente.CodigoDePasaje.Count)
                {
                    case 10:
                        return 10;
                    case 11:
                        return 15;
                    case 12:
                        return 20;
                    default:
                        return 25;
                }
            }else
                return 0;
        }

        public override string CargarCodigoDePasaje(string codigoDeVuelo)
        {
            return $"TURI{codigoDeVuelo}";
        }
        public override float cobrarPasaje()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Codigo del pasaje: {codigoDePasaje}");
            sb.AppendLine($"Categoria: {categoriaPasaje}");

            return sb.ToString();   
        }
    }
}
