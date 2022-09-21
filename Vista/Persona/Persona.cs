using System;
using System.Text;
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
        private int documento;
        private string edad;
        private string nacionalidad;
        private DateTime fechaDeNacimiento;
        private TipoDeSexo tipoDeSexo;

        public TipoDocumento TipoDocumento1 { get => tipoDeDocumento; }
        public string Nacionalidad { get => nacionalidad; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; }
        public TipoDeSexo TipoDeSexo1 { get => tipoDeSexo; }

        public string Nombre
        {
            get => nombre;
            private set
            {
                if (Validaciones.ValidarString(value))
                    this.nombre = value;
                else
                    throw new Exception("Error en nombre");
            }
        }
        public string Apellido
        {
            get => apellido;
            private set
            {
                if (Validaciones.ValidarString(value))
                    this.apellido = value;
                else
                    throw new Exception("Error en Apellido");

            }

        }
        public int Documento
        {
            get => documento;

            set
            {
                if (Validaciones.ValidarSoloDocumento(value))
                    this.documento = value;
                else
                    throw new Exception("Error en documento");
            }
        }
        public string Edad  
        { get => edad; 
            set
            {
                if (!Validaciones.ValidarSoloEdad(value))
                  this.edad = value;
                else
                    throw new Exception("Error en edad");

            }
        }
        protected Persona(string nombre, string apellido, TipoDocumento tipoDocumento, int documento, string edad, string nacionalidad, DateTime fechaDeNacimiento, TipoDeSexo sexo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Documento = documento;
            this.Edad = edad;




            this.tipoDeDocumento = tipoDocumento;
            this.nacionalidad = nacionalidad;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.tipoDeSexo = sexo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {nombre}");
            sb.AppendLine($" --- Apellido: {apellido}");
            sb.AppendLine($"Sexo: {tipoDeSexo}");
            sb.AppendLine($"Tipo documento: {tipoDeDocumento}");
            sb.AppendLine($" --- Documento N°: {documento}");
            sb.AppendLine($"Fecha de nacimiento: {fechaDeNacimiento.ToString("dd-MM-yyyy")}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Nacionalidad: {nacionalidad}");

            return sb.ToString();
        }


        public static void ObtenerPersonaPorDNI(string documento)
        {

        }






    }
}
