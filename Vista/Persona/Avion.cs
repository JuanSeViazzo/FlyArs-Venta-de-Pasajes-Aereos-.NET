namespace Logica
{
    public class Avion
    {

        //private Dictionary<int, string> destinosNacionales;
        //private Dictionary<int, string> destinosDesdeBuenosAires;

        private int cantidadDeAsientosTurista;
        private int cantidadDeAsientosPremium;
        private string matricula;
        private int capacidadDeBodega;
        private int cantidadDeBanios;
        private double duracionDeVuelo;

        public Avion(int cantidadDeAsientosPremium, int cantidadDeAsientosTurista, string matricula, int capacidadDeBodega, int cantidadDeBanios)
        {
            this.CantidadDeAsientosPremium = cantidadDeAsientosPremium;
            this.CantidadDeAsientosTurista = cantidadDeAsientosTurista;
            this.Matricula = matricula;
            this.CapacidadDeBodega = capacidadDeBodega;
            this.CantidadDeBanios = cantidadDeBanios;
            this.duracionDeVuelo = 0;
        }

        public int CantidadDeAsientosTurista { get => cantidadDeAsientosTurista; set => cantidadDeAsientosTurista = value; }
        public int CantidadDeAsientosPremium { get => cantidadDeAsientosPremium; set => cantidadDeAsientosPremium = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public int CapacidadDeBodega { get => capacidadDeBodega; set => capacidadDeBodega = value; }
        public int CantidadDeBanios { get => cantidadDeBanios; set => cantidadDeBanios = value; }
        public double DuracionDeVuelo { get => duracionDeVuelo; set => duracionDeVuelo = value; }

     




    }
}