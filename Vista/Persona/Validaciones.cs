using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logica
{
    public static class Validaciones
    {
        private static Exception validarNumero;

        public static string ValidarString(string dato)
        {

            if (!String.IsNullOrEmpty(dato) && dato.All(char.IsLetter))
            {
                return dato;
            }
            else
            {
                throw new Exception();
            }

        }


        public static int ValidarSoloNumero(string dato)
        {
            int valor;

            if(int.TryParse(dato,out valor))
            {
                return valor;
            }else
            {
                throw new Exception();
            }

        }


        public static string ValidarPassword(string dato)
        {

            Match matchMayusculas = Regex.Match(dato, @"[A-Z]");
            Match matchEspeciales = Regex.Match(dato, @"[ñÑ\-_¿.#¡*@!=]");

            if (dato.Length == 8 && matchEspeciales.Success && matchEspeciales.Success)
            {
                return dato;
            }else
            {
                throw new Exception();
            }



        }

















    }
}
