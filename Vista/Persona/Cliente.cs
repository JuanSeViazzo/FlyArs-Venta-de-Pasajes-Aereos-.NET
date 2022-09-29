using System.Collections.Generic;
using System;
using System.Text;


namespace Logica
{


    public class Cliente : Persona
    {
     
        private List<int> codigoDePasaje;


        public List<int> CodigoDePasaje { get => codigoDePasaje; }

        public Cliente(string nombre, string apellido, TipoDocumento tipoDocumento, int documento, string edad, string nacionalidad, 
            DateTime fechaDeNacimiento,TipoDeSexo sexo) : base(nombre, apellido, tipoDocumento, documento, edad, nacionalidad, fechaDeNacimiento, sexo)
        {
            codigoDePasaje = new List<int>();

        }
        public bool CargarPasaje(string codigoDePasaje)
        {


            int codigo;
            if (int.TryParse(codigoDePasaje, out codigo))
            {
                this.codigoDePasaje.Add(codigo);
                return true;
            }
            else
                return false;
        }
        public bool EliminarPasaje(string codigoDePasaje)
        {
            int codigo;
            if (int.TryParse(codigoDePasaje, out codigo))
            {
                this.codigoDePasaje.Remove(codigo);
                return true;
            }
            else
                return false;
        }
  
  


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
           return sb.Append(base.ToString()).ToString();
           
        }




    }
}
