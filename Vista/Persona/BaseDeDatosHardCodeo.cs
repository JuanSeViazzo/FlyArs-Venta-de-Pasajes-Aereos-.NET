using System;

namespace Logica
{
    public static class BaseDeDatosHardCodeo
    {
        static BaseDeDatosHardCodeo()
        {
            BaseDeDatosHardCodeo.HarcodeoDeClientes();
            BaseDeDatosHardCodeo.HarcodeoDeDestinos();
            BaseDeDatosHardCodeo.HarcodeoDeVuelos();

        }

        public static string nombre;



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
            Random rand = new Random();

            Avion Airbus380 = new Avion(130, 524, "LV-380UL", 150000, 20);
            Avion Boeing777 = new Avion(110, 450, "LV-777UL", 13000, 18);
            Avion Boeing767 = new Avion(60, 244, "LV-767LA", 100000, 14);
            Avion AirbusA350 = new Avion(82, 330, "LV-350LA", 100000, 14);
            Avion Boeing737 = new Avion(44, 176, "LV-737MA", 5500, 8);
            Avion Airbus320 = new Avion(30, 120, "LV-320MA", 3750, 8);
            Avion Airbus330 = new Avion(68, 268, "LV-330MA", 7000, 10);

            Vuelo Airbus380BueRom = new Vuelo(DateTime.Today.AddMinutes(10).AddHours(10), DateTime.Today.AddHours(18).AddMinutes(25),
                Airbus380, true, true, "BUELV380ULROM", 17, 1001);
            Vuelo Airbus380BueMia = new Vuelo(DateTime.Today.AddMinutes(20), DateTime.Today.AddHours(9),
                Airbus380, true, true, "BUELV380ULMIA", 17, 1003);
            Vuelo Airbus380BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today.AddHours(9),
                Airbus380, true, true, "BUELV380ULACA", 17, 1002);
            Vuelo Airbus380BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today.AddHours(8),
                Airbus380, true, true, "BUELV380ULREC", 17, 1000);

            Vuelo Boeing777BueRoma = new Vuelo(DateTime.Today.AddMinutes(10).AddDays(4), DateTime.Today.AddHours(11).AddMinutes(25).AddDays(4),
                Boeing777, true, true, "BUELV777ULROM", 17, 1001);
            Vuelo Boeing777BueMia = new Vuelo(DateTime.Today.AddMinutes(20), DateTime.Today.AddHours(10),
                Boeing777, true, true, "BUELV777ULMIA", 17, 1003);
            Vuelo Boeing777BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today.AddHours(9),
                Boeing777, true, true, "BUELV777ULACA", 17, 1002);
            Vuelo Boeing777BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today.AddHours(8),
                Boeing777, true, true, "BUELV777ULREC", 17, 1000);

            Vuelo Boeing767RsaBrc = new Vuelo(DateTime.Today.AddMinutes(38), DateTime.Today.AddHours(2),
                Boeing767, true, true, "RSALV767LABRC", 1, 2);
            Vuelo Boeing767CnoCor = new Vuelo(DateTime.Today.AddMinutes(41), DateTime.Today.AddHours(2),
                Boeing767, true, true, "CNOLV767LACOR", 3, 4);
            Vuelo Boeing767JujMdz = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today.AddHours(3),
                Boeing767, true, true, "JUJLV767ALMDZ", 5, 6);
            Vuelo Boeing767IgrDry = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today.AddHours(3),
                Boeing767, true, true, "IGRLV767ALDRY", 9, 15);

            Vuelo AirbusA350RsaBrc = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(38), DateTime.Today.AddHours(2).AddDays(1),
                AirbusA350, true, true, "RSALV350LABRC", 1, 2);
            Vuelo AirbusA350CnoCor = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(41), DateTime.Today.AddHours(2).AddDays(1),
                AirbusA350, true, true, "CNOLV350LACOR", 3, 4);
            Vuelo AirbusA350JujMdz = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today.AddHours(3).AddDays(1).AddMinutes(30),
                AirbusA350, true, true, "JUJLV350ALMDZ", 5, 6);
            Vuelo AirbusA350IgrDry = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today.AddHours(3).AddDays(1),
                AirbusA350, true, true, "IGRLV350ALDRY", 9, 15);

            Vuelo Airbus737RsaCor = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today.AddHours(2).AddDays(3),
                Boeing737, true, true, "RSALV737LACOR", 1, 4);
            Vuelo Airbus737CnoBrc = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today.AddHours(2).AddDays(2),
                Boeing737, true, true, "CNOLV737LABRC", 3, 2);
            Vuelo Airbus737JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today.AddHours(3).AddDays(4),
                Boeing737, true, true, "JUJLV737ALIGR", 5, 9);
            Vuelo Airbus737MdzDry = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today.AddHours(3).AddDays(5),
                Boeing737, true, true, "MDZLV737ALDRY", 6, 15);

            Vuelo Airbus320TucTre = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today.AddHours(2).AddDays(3),
                Airbus320, true, true, "TUCLV737LATRE", 13, 14);
            Vuelo Airbus320JujBrc = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today.AddHours(2).AddDays(2),
                Airbus320, true, true, "JUJLV737LABRC", 5, 2);
            Vuelo Airbus320JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today.AddHours(3).AddDays(4),
                Airbus320, true, true, "JUJLV737ALIGR", 5, 9);
            Vuelo Airbus320MdzDry = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today.AddHours(3).AddDays(5),
                Airbus320, true, true, "MDZLV737ALDRY", 6, 15);

            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRom);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRec);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueAca);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueMia);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueRec);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueAca);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueRoma);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueMia);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767IgrDry);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767JujMdz);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767CnoCor);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767RsaBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350IgrDry);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350CnoCor);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350JujMdz);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350RsaBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus737RsaCor);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus737CnoBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus737MdzDry);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus737JujIgr);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320MdzDry);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320JujIgr);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320TucTre);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320JujBrc);

        }

        public static void HarcodeoDeAviones()
        {





        }


        public static void HarcodeoDeDestinos()
        {
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1, "Santa Rosa");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(2, "Bariloche");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(3, "Corrientes");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(4, "Córdoba");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(5, "Jujuy");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(6, "Mendoza");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(7, "Neuquén");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(8, "Posadas");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(9, "Iguazú");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(10, "Salta");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(11, "Santiago del Estero");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(12, "Trelew");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(13, "Tucumán");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(14, "Trelew");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(15, "Puerto Madryn");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(16, "Ushuaia");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(17, "Buenos Aires");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1000, "Recife(Brasil)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1001, "Roma(Italia)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1002, "Acapulco(Mexico)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1003, "Miami(EEUU)");

        }







    }
}
