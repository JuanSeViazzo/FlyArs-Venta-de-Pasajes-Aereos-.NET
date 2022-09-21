﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Usuario : Persona
    { 


        private int legajoEmpleado;
        private string password;
        private string user;
        public int LegajoEmpleado { get => legajoEmpleado;}
        public string Password { get => password; }
        public string User { get => user;}


        public Usuario(string user, string password, string nombre, string apellido, int legajoEmpleado, TipoDocumento tipoDocumento, int dni, 
         string edad, string nacionalidad,DateTime fechaDeNacimiento,TipoDeSexo sexo) : base(nombre, apellido, tipoDocumento, dni, edad, nacionalidad, fechaDeNacimiento,sexo)
        {


            try
            {
                Validaciones.ValidarSoloDocumento(legajoEmpleado);
                this.legajoEmpleado = legajoEmpleado;   

            }
            catch (Exception)
            {

                throw new Exception("Legajo Incorrecto");
            }


            try
            {
                Validaciones.ValidarPassword(password);
                this.password = password;

            }
            catch (Exception)
            {

                throw new Exception("Contraseña invalida");
            }

            try
            {
                Validaciones.ValidarString(user);
                this.user = user;


            }
            catch (Exception)
            {

                throw new Exception("Usuario invalido");
            }

        }









       
    }
}
