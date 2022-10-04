
using System.Text;

namespace Logica 
{


    public class Equipaje
    {
      

        private int numeroDeOrden;
        private int dniDelPasajero;
        private int pesoDelEquipaje;

        public Equipaje(int numeroDeOrden , int dniDelPasajero,int pesoDelEquipaje)
        {
            this.numeroDeOrden = numeroDeOrden;
            this.dniDelPasajero = dniDelPasajero;
            this.pesoDelEquipaje = pesoDelEquipaje;
        }

        public int NumeroDeOrden { get => numeroDeOrden;}
        public int DniDelPasajero { get => dniDelPasajero;}
        public int PesoDelEquipaje { get => pesoDelEquipaje;}


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"N°: {numeroDeOrden}");
            sb.AppendLine($"Peso: {pesoDelEquipaje}");

            return sb.ToString();   


        }


    }
}