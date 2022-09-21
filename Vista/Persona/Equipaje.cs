namespace Logica
{


    public class Equipaje
    {
        public enum TipoDeEquipaje
        {
            Veintiuno,
            Veinticinco,
            DeMano
        }

        private string codigoDePasaje;
        private int numeroDeOrden;
        private TipoDeEquipaje tipoDeEquipaje;

        public Equipaje(string codigoDePasaje, int numeroDeOrden, TipoDeEquipaje tipoDeEquipaje)
        {
            this.codigoDePasaje = codigoDePasaje;
            this.numeroDeOrden = numeroDeOrden;
            this.tipoDeEquipaje = tipoDeEquipaje;
        }

        public string CodigoDePasaje { get => codigoDePasaje; set => codigoDePasaje = value; }
        public int NumeroDeOrden { get => numeroDeOrden; set => numeroDeOrden = value; }
        public TipoDeEquipaje TipoDeEquipaje1 { get => tipoDeEquipaje; set => tipoDeEquipaje = value; }








    }
}