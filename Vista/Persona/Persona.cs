using System;
using System.Text;
using System.Collections.Generic;
namespace Logica
{
    
  
    public abstract class Persona
    {

        public enum TipoDocumento
        {
            DNI,
            Pasaporte
        }
        public enum TipoDeSexo
        {
            
            Femenino,
            Masculino
        }

        private string nombre;
        private string apellido;
        private TipoDocumento tipoDeDocumento;
        private string documento;
        private string edad;
        private string nacionalidad;
        private DateTime fechaDeNacimiento;
        private TipoDeSexo tipoDeSexo;

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public TipoDocumento TipoDocumento1 { get => tipoDeDocumento;}
        public string Documento { get => documento;}
        public string Edad { get => edad;}
        public string Nacionalidad { get => nacionalidad;}
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento;}
        public TipoDeSexo TipoDeSexo1 { get => tipoDeSexo;}

        protected Persona(string nombre, string apellido, TipoDocumento tipoDocumento, string documento, string edad,string nacionalidad,DateTime fechaDeNacimiento,TipoDeSexo sexo)
        {

            try
            {
                Validaciones.ValidarString(nombre);
                this.nombre = nombre;

            }
            catch (Exception)
            {
                throw new Exception("Error en nombre");
            }

            try
            {
                Validaciones.ValidarString(apellido);
                this.apellido = apellido;

            }
            catch (Exception)
            {
                throw new Exception("Error en Apellido");
            }


            try
            {
                Validaciones.ValidarSoloNumero(documento);

                this.documento = documento;

            }
            catch (Exception)
            {

                throw new Exception("Error en Documento");
            }






            try
            {
                Validaciones.ValidarSoloNumero(edad);
                this.edad = edad;
            }
            catch (Exception)
            {

                throw new Exception("Error en Documento");
            }



            this.tipoDeDocumento = tipoDocumento;
            this.nacionalidad = nacionalidad;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.tipoDeSexo = sexo;
        }




        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {nombre}");
            sb.AppendLine($" --- Apellido: {apellido}");
            sb.AppendLine($"Sexo: {tipoDeSexo}");
            sb.AppendLine($"Tipo documento: {tipoDeDocumento}");
            sb.AppendLine($" --- Documento N°: {documento}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd-MM-yyyy")}");
            sb.AppendLine($"Edad: {edad}");
            sb.AppendLine($"Nacionalidad: {nacionalidad}");

            return sb.ToString();

        }









    }
}
