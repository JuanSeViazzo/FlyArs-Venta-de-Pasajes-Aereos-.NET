using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario : Persona
    { 


        private int legajoEmpleado;
        public int LegajoEmpleado { get => legajoEmpleado; }



        public Usuario(string nombre, string apellido,int legajoEmpleado, TipoDocumento tipoDocumento, string dni, 
         string edad, string nacionalidad,DateTime fechaDeNacimiento,TipoDeSexo sexo) : base(nombre, apellido, tipoDocumento, dni, edad, nacionalidad, fechaDeNacimiento,sexo)
        {
            this.legajoEmpleado = legajoEmpleado;
        }

    }
}
