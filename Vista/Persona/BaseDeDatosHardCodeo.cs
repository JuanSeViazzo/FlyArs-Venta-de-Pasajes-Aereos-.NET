using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class BaseDeDatosHardCodeo
    {




        public static void HarcodeoPasajeros()
        {
            Persona pasajero1 = new Cliente("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, 34262507, "33", "argentino", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona pasajero2 = new Cliente("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, 35003321, "30", "argentino", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona pasajero3 = new Cliente("Marina", "Rodriguez", Persona.TipoDocumento.DNI, 38000132, "33", "argentino", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona pasajero4 = new Cliente("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, 37213986, "25", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona pasajero5 = new Cliente("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, 34222503, "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona pasajero6 = new Cliente("Diego", "Maradona", Persona.TipoDocumento.DNI, 24323788, "60", "argentino", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona pasajero7 = new Cliente("Lionel", "Messi", Persona.TipoDocumento.DNI, 32198605, "35", "argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePersonas.Add(pasajero1);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero2);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero3);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero4);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero5);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero6);
            GestionDeAerolinea.ListaDePersonas.Add(pasajero7);
        }


        public static void HarcodeoDeUsuarios()
        {
            Persona usuario1 = new Usuario("LuquitaPeposo", "Rufruf123", "Lucas", "Rodriguez", 1001, Persona.TipoDocumento.DNI, 35232444, "30", "Argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePersonas.Add(usuario1);



        }


        public static void HarcodeoDeVuelos()
        {
            Avion avioneta = new Avion(200, "A165FVN", 10000, 8);

            Vuelo Flight956 = new Vuelo(DateTime.Today,new DateTime(2022,9,21,01,32,00),avioneta,true,true,"A165FVN01BS02RA",DestinosNacionales.Buenos_Aires,DestinosInternacionales.Roma_Italia);

            GestionDeAerolinea.ListaDeVuelos.Add(Flight956);
        }

        public static void HarcodeoDeAviones()
        {
            Avion avioneta = new Avion(200, "A165FVN", 10000, 8);

        }










    }
}
