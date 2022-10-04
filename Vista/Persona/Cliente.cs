using System.Collections.Generic;
using System;
using System.Text;


namespace Logica
{


    public class Cliente : Persona
    {
     
        private List<int> codigoDePasaje;
        private int cantidadDeVuelos;

        public List<int> CodigoDePasaje { get => codigoDePasaje; }
        public int CantidadDeVuelos { get => cantidadDeVuelos; set => cantidadDeVuelos = value; }

       

        public Cliente(string nombre, string apellido, TipoDocumento tipoDocumento, int documento, string edad, string nacionalidad, 
            DateTime fechaDeNacimiento,TipoDeSexo sexo) : base(nombre, apellido, tipoDocumento, documento, edad, nacionalidad, fechaDeNacimiento, sexo)
        {
            codigoDePasaje = new List<int>();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           return sb.Append(base.ToString()).ToString();
           
        }




    }
}
