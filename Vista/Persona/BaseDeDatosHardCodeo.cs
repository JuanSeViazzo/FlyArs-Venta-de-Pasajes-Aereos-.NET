using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class BaseDeDatosHardCodeo
    {




        public static void HarcodeoDeClientes()
        {
            Persona cliente1 = new Cliente("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, 34262507, "33", "argentino", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente2 = new Cliente("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, 35003321, "30", "argentino", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente3 = new Cliente("Marina", "Rodriguez", Persona.TipoDocumento.DNI, 38000132, "33", "argentino", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente4 = new Cliente("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, 37213986, "25", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente5 = new Cliente("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, 34222503, "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente6 = new Cliente("Diego", "Maradona", Persona.TipoDocumento.DNI, 24323788, "60", "argentino", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente7 = new Cliente("Lionel", "Messi", Persona.TipoDocumento.DNI, 32198605, "35", "argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePersonas.Add(cliente1);
            GestionDeAerolinea.ListaDePersonas.Add(cliente2);
            GestionDeAerolinea.ListaDePersonas.Add(cliente3);
            GestionDeAerolinea.ListaDePersonas.Add(cliente4);
            GestionDeAerolinea.ListaDePersonas.Add(cliente5);
            GestionDeAerolinea.ListaDePersonas.Add(cliente6);
            GestionDeAerolinea.ListaDePersonas.Add(cliente7);
        }


        public static void HarcodeoDeUsuarios()
        {
            Persona usuario1 = new Usuario("LuquitaPeposo", "Rufruf123", "Lucas", "Rodriguez", 1001, Persona.TipoDocumento.DNI, 35232444, "30", "Argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePersonas.Add(usuario1);



        }


        public static void HarcodeoDeVuelos()
        {
            Avion Airbus380 = new Avion(656, "LV-380UL", 150000, 20);
            Avion Boeing777 = new Avion(550, "LV-777UL", 13000, 18);
            Avion Boeing767 = new Avion(304, "LV-767LA", 100000, 14);
            Avion AirbusA350 = new Avion(412, "LV-350LA", 100000, 14);
            Avion Boeing737 = new Avion(220, "LV-737MA",5500, 8);
            Avion Airbus320 = new Avion(150,"LV-320MA",3750,8);
            Avion Airbus330 = new Avion(335, "LV-330MA", 7000, 10);

            Vuelo Airbus380BueRom = new Vuelo(DateTime.Today.AddMinutes(10),DateTime.Today.AddHours(11).AddMinutes(25), 
                Airbus380, true,true,"BUELV380ULROM",DestinosNacionales.Buenos_Aires,DestinosInternacionales.Roma_Italia_);
            Vuelo Airbus380BueMia = new Vuelo(DateTime.Today.AddMinutes(20), DateTime.Today.AddHours(10), 
                Airbus380, true, true, "BUELV380ULMIA", DestinosNacionales.Buenos_Aires, DestinosInternacionales.Miami_EEUU_);
            Vuelo Airbus380BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today.AddHours(9), 
                Airbus380, true, true, "BUELV380ULACA", DestinosNacionales.Buenos_Aires, DestinosInternacionales.Acapulco_México_);
            Vuelo Airbus380BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today.AddHours(8), 
                Airbus380, true, true, "BUELV380ULREC", DestinosNacionales.Buenos_Aires, DestinosInternacionales.Recife_Brasil_);






            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRom);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRec);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueAca);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueMia);
        }

        public static void HarcodeoDeAviones()
        {






        }










    }
}
