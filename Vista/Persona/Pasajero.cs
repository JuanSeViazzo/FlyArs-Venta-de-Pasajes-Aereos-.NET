using System.Collections.Generic;
using System;
using System.Text;


namespace Logica
{


    public class Pasajero : Persona
    {
     
        private List<int> codigoDePasaje;
        private List<int> codigoEquipaje;
        


        public List<int> CodigoDePasaje { get => codigoDePasaje; }
        public List<int> CodigoEquipaje { get => codigoEquipaje;}

        public Pasajero(string nombre, string apellido, TipoDocumento tipoDocumento, string documento, string edad, string nacionalidad, 
            DateTime fechaDeNacimiento,TipoDeSexo sexo) : base(nombre, apellido, tipoDocumento, documento, edad, nacionalidad, fechaDeNacimiento, sexo)
        {
            codigoDePasaje = new List<int>();
            codigoEquipaje = new List<int>();

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
        public bool CargarEquipaje(string codigoEquipaje)
        {
            int codigo;
            if (int.TryParse(codigoEquipaje, out codigo))
            {
                this.codigoEquipaje.Add(codigo);
                return true;
            }
            else
                return false;
        }
        public bool EliminarEquipaje(string codigoEquipaje)
        {
            int codigo;
            if (int.TryParse(codigoEquipaje, out codigo))
            {
                this.codigoEquipaje.Remove(codigo);
                return true;
            }
            else
                return false;
        }
  


        public override string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
             sb.Append(base.Mostrar());
            sb.AppendLine($"Codigo de Equipaje \n *---------* ");
            foreach (int item in codigoEquipaje)
            {
                sb.AppendLine($"{item}");
            }

            return sb.ToString();   

        }




    }
}
