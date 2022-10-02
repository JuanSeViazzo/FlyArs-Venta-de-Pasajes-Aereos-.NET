using System;
using System.Collections.Generic;

namespace Logica
{
    public static class BaseDeDatosHardCodeo
    {
        static BaseDeDatosHardCodeo()
        {
            BaseDeDatosHardCodeo.HarcodeoDeDestinos();
            BaseDeDatosHardCodeo.Harcodeo();
            BaseDeDatosHardCodeo.HarcodeoDeUsuarios();
            BaseDeDatosHardCodeo.HarcodeoDePasajeros();
        }

        public static int numero;


        public static void HarcodeoDeUsuarios()
        {
            Persona usuario1 = new Usuario("RodriguezL", "Pepepeposo*", "Lucas", "Rodriguez", 1001, Persona.TipoDocumento.DNI, 35232444, "30", "Argentina", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);
            Persona usuario2 = new Usuario("SmirlianI", "Lanusero*", "Ignacio", "Smirlian", 1002, Persona.TipoDocumento.DNI, 39023133, "26", "Argentina", new DateTime(1993, 7, 22), Persona.TipoDeSexo.Masculino);
            Persona usuario3 = new Usuario("PrietoE", "CuatroPilares*", "Esteban", "Prieto", 1003, Persona.TipoDocumento.DNI, 36541232, "29", "Argentina", new DateTime(1991, 3, 15), Persona.TipoDeSexo.Masculino);
            Persona usuario4 = new Usuario("CurcioO", "Medicina*", "Ornella", "Curcio", 1004, Persona.TipoDocumento.DNI, 37541389, "28", "Argentina", new DateTime(1994, 6, 8), Persona.TipoDeSexo.Femenino);
            Persona usuario5 = new Usuario("ViazzoJs", "Elciclon*", "Juan", "Viazzo", 1005, Persona.TipoDocumento.DNI, 34262507, "33", "Argentina", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            GestionDeAerolinea.ListaDePersonas.Add(usuario1);
            GestionDeAerolinea.ListaDePersonas.Add(usuario2);
            GestionDeAerolinea.ListaDePersonas.Add(usuario3);
            GestionDeAerolinea.ListaDePersonas.Add(usuario4);
            GestionDeAerolinea.ListaDePersonas.Add(usuario5);

        }


        public static void Harcodeo()
        {
            Random rand = new Random();

            Avion Airbus380 = new Avion(130, 524, "LV-380UL", 150000, 20);
            Avion Boeing777 = new Avion(110, 450, "LV-777UL", 13000, 18);
            Avion Boeing767 = new Avion(60, 244, "LV-767LA", 100000, 14);
            Avion AirbusA350 = new Avion(82, 330, "LV-350LA", 100000, 14);
            Avion Boeing737 = new Avion(44, 176, "LV-737MA", 5500, 8);
            Avion Airbus320 = new Avion(30, 120, "LV-320MA", 3750, 8);
            Avion Airbus330 = new Avion(68, 268, "LV-330MA", 7000, 10);
            Avion avionDePrueba = new Avion(2, 3, "Prueba", 30, 4);

            GestionDeAerolinea.ListaDeAviones.Add(Airbus380);
            GestionDeAerolinea.ListaDeAviones.Add(Airbus330);
            GestionDeAerolinea.ListaDeAviones.Add(Airbus320);
            GestionDeAerolinea.ListaDeAviones.Add(AirbusA350);
            GestionDeAerolinea.ListaDeAviones.Add(Boeing737);
            GestionDeAerolinea.ListaDeAviones.Add(Boeing767);
            GestionDeAerolinea.ListaDeAviones.Add(Boeing777);
            GestionDeAerolinea.ListaDeAviones.Add(avionDePrueba);

            Vuelo Airbus380BueRom = new Vuelo(DateTime.Today.AddMinutes(10).AddHours(10), DateTime.Today.AddHours(18).AddMinutes(25),
                Airbus380, true, true, "BUELV380ULROM", 15, 1001);
            Vuelo Airbus380BueMia = new Vuelo(DateTime.Today.AddMinutes(20), DateTime.Today,
                Airbus380, true, true, "BUELV380ULMIA", 15, 1003);
            Vuelo Airbus380BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today,
                Airbus380, true, true, "BUELV380ULACA", 15, 1002);
            Vuelo Airbus380BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today,
                Airbus380, true, true, "BUELV380ULREC", 15, 1000);

            Vuelo Boeing777BueRoma = new Vuelo(DateTime.Today.AddMinutes(10).AddDays(2), DateTime.Today,
                Boeing777, true, true, "BUELV777ULROM", 15, 1001);
            Vuelo Boeing777BueMia = new Vuelo(DateTime.Today.AddMinutes(20).AddDays(5), DateTime.Today,
                Boeing777, true, true, "BUELV777ULMIA", 15, 1003);
            Vuelo Boeing777BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today,
                Boeing777, true, true, "BUELV777ULACA", 15, 1002);
            Vuelo Boeing777BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today,
                Boeing777, true, true, "BUELV777ULREC", 15, 1000);

            Vuelo Boeing767RsaBrc = new Vuelo(DateTime.Today.AddMinutes(38), DateTime.Today,
                Boeing767, true, true, "RSALV767LABRC", 0, 1);
            Vuelo Boeing767CnoCor = new Vuelo(DateTime.Today.AddMinutes(41), DateTime.Today,
                Boeing767, true, true, "CNOLV767LACOR", 2, 3);
            Vuelo Boeing767JujMdz = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today,
                Boeing767, true, true, "JUJLV767LAMDZ", 4, 5);
            Vuelo Boeing767IgrDry = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today,
                Boeing767, true, true, "IGRLV767LADRY", 8, 13);

            Vuelo AirbusA350RsaBrc = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(38), DateTime.Today,
                AirbusA350, true, true, "RSALV350LABRC", 0, 1);
            Vuelo AirbusA350CnoCor = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(41), DateTime.Today,
                AirbusA350, true, true, "CNOLV350LACOR", 2, 3);
            Vuelo AirbusA350JujMdz = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today,
                AirbusA350, true, true, "JUJLV350LAMDZ", 4, 5);
            Vuelo AirbusA350IgrDry = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today,
                AirbusA350, true, true, "IGRLV350LADRY", 8, 13);

            Vuelo Airbus737RsaCor = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today,
                Boeing737, true, true, "RSALV737MACOR", 0, 3);
            Vuelo Airbus737CnoBrc = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today,
                Boeing737, true, true, "CNOLV737MABRC", 2, 1);
            Vuelo Airbus737JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today,
                Boeing737, true, true, "JUJLV737MAIGR", 4, 8);
            Vuelo Airbus737MdzDry = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                Boeing737, true, true, "MDZLV737MADRY", 5, 14);

            Vuelo Airbus320TucTre = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today,
                Airbus320, true, true, "TUCLV737MATRE", 12, 11);
            Vuelo Airbus320JujBrc = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today,
                Airbus320, true, true, "JUJLV737MABRC", 4, 1);
            Vuelo Airbus320JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today,
                Airbus320, true, true, "JUJLV737MAIGR", 4, 8);
            Vuelo Airbus320MdzDry = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                Airbus320, true, true, "MDZLV737MADRY", 5, 13);

            Vuelo Airbus330JujBrc = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "JUJLVL330MABRC", 4, 1);
            Vuelo Airbus330CorRsa = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "CORLVL330MARSA", 3, 0);
            Vuelo Airbus330DryBue = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "DRYLVL330MABUE", 13, 15);
            Vuelo Airbus330MdzBue = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "MZALVL330MABUE", 5, 15);





            Vuelo VueloDePrueba = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                avionDePrueba, true, true, "MDZLV737ALDRY", 5, 4);


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
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330CorRsa);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330JujBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330DryBue);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330MdzBue);
            GestionDeAerolinea.ListaDeVuelos.Add(VueloDePrueba);


            Persona cliente1 = new Cliente("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, 34260217, "33", "Argentina", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente2 = new Cliente("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, 35003321, "30", "Argentina", new DateTime(1992, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente3 = new Cliente("Marina", "Rodriguez", Persona.TipoDocumento.DNI, 38456409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente4 = new Cliente("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, 37213986, "24", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente5 = new Cliente("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, 34220213, "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente6 = new Cliente("Diego", "Maradona", Persona.TipoDocumento.DNI, 24323788, "62", "Argentina", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente7 = new Cliente("Lionel", "Messi", Persona.TipoDocumento.DNI, 32198605, "37", "Argentina", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente8 = new Cliente("Angel", "Flores", Persona.TipoDocumento.DNI, 34260217, "33", "Argentina", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente9 = new Cliente("Pablo", "Avil", Persona.TipoDocumento.DNI, 35003321, "32", "Argentina", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente10 = new Cliente("Claudia", "Gutierrez", Persona.TipoDocumento.DNI, 38456409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente11 = new Cliente("Fernando", "Sanchez", Persona.TipoDocumento.Pasaporte, 37213986, "64", "Italiano", new DateTime(1958, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente12 = new Cliente("Martin", "Piroli", Persona.TipoDocumento.Pasaporte, 34220213, "88", "Frances", new DateTime(1934, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente13 = new Cliente("Andres", "Marsena", Persona.TipoDocumento.DNI, 24323788, "53", "Argentina", new DateTime(1969, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente14 = new Cliente("Jose", "Mestalo", Persona.TipoDocumento.DNI, 32198605, "34", "Argentina", new DateTime(1987, 11, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente15 = new Cliente("Pablo", "Ramos", Persona.TipoDocumento.Pasaporte, 34260217, "33", "uruguayo", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente16 = new Cliente("Lucas", "Raimundi", Persona.TipoDocumento.Pasaporte, 35003321, "31", "uruguayo", new DateTime(1991, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente17 = new Cliente("Mariana", "Torrico", Persona.TipoDocumento.DNI, 38456409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente18 = new Cliente("Hernan", "Caferato", Persona.TipoDocumento.Pasaporte, 37213986, "24", "Italiano", new DateTime(1998, 06, 11), Persona.TipoDeSexo.Masculino);
            Persona cliente19 = new Cliente("Marcos", "Colivan", Persona.TipoDocumento.Pasaporte, 34220213, "50", "Frances", new DateTime(1972, 03, 09), Persona.TipoDeSexo.Masculino);
            Persona cliente20 = new Cliente("Eduardo", "Parato", Persona.TipoDocumento.DNI, 24323788, "61", "Argentina", new DateTime(1961, 01, 05), Persona.TipoDeSexo.Masculino);
            Persona cliente21 = new Cliente("Lautaro", "Danelo", Persona.TipoDocumento.DNI, 32198605, "37", "Argentina", new DateTime(1985, 11, 25), Persona.TipoDeSexo.Masculino);
            Persona cliente22 = new Cliente("Jeremias", "Pizzoto", Persona.TipoDocumento.DNI, 34002507, "23", "Argentina", new DateTime(1999, 12, 27), Persona.TipoDeSexo.Masculino);
            Persona cliente23 = new Cliente("Matias", "Anastalo", Persona.TipoDocumento.DNI, 35003321, "24", "Argentina", new DateTime(1998, 07, 25), Persona.TipoDeSexo.Masculino);
            Persona cliente24 = new Cliente("Florencia", "Rodrigues", Persona.TipoDocumento.DNI, 38456255, "21", "Argentina", new DateTime(2001, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente25 = new Cliente("Roman", "Rimendi", Persona.TipoDocumento.Pasaporte, 37213986, "20", "Italiano", new DateTime(2002, 06, 30), Persona.TipoDeSexo.Masculino);
            Persona cliente26 = new Cliente("Andres", "Pasculi", Persona.TipoDocumento.Pasaporte, 34222503, "49", "Frances", new DateTime(1973, 03, 29), Persona.TipoDeSexo.Masculino);
            Persona cliente27 = new Cliente("Pablo", "Peroda", Persona.TipoDocumento.DNI, 24323788, "54", "Argentina", new DateTime(1968, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente28 = new Cliente("Javier", "Salatino", Persona.TipoDocumento.DNI, 32198605, "56", "Argentina", new DateTime(1966, 11, 13), Persona.TipoDeSexo.Masculino);
            Persona cliente29 = new Cliente("Fernando", "Parana", Persona.TipoDocumento.DNI, 34262507, "38", "Argentina", new DateTime(1984, 12, 12), Persona.TipoDeSexo.Masculino);
            Persona cliente30 = new Cliente("Gabriel", "Mascena", Persona.TipoDocumento.DNI, 35003321, "29", "Argentina", new DateTime(1993, 07, 14), Persona.TipoDeSexo.Masculino);
            Persona cliente31 = new Cliente("Mauricio", "Pachorita", Persona.TipoDocumento.DNI, 38456255, "30", "Argentina", new DateTime(1992, 03, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente32 = new Cliente("Agustin", "Avianto", Persona.TipoDocumento.Pasaporte, 37213986, "28", "Italiano", new DateTime(1994, 05, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente33 = new Cliente("Mariano", "Astrosi", Persona.TipoDocumento.Pasaporte, 34222503, "45", "Frances", new DateTime(1977, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente34 = new Cliente("Jorge", "Frandilo", Persona.TipoDocumento.DNI, 24323788, "62", "Argentina", new DateTime(1960, 02, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente35 = new Cliente("Flavio", "Peduto", Persona.TipoDocumento.DNI, 32198605, "37", "Argentina", new DateTime(1985, 12, 09), Persona.TipoDeSexo.Masculino);
            Persona cliente36 = new Cliente("Romina", "Rubin", Persona.TipoDocumento.Pasaporte, 36456255, "30", "uruguayo", new DateTime(1992, 07, 08), Persona.TipoDeSexo.Femenino);
            Persona cliente37 = new Cliente("Marina", "Corso", Persona.TipoDocumento.Pasaporte, 37456671, "29", "español", new DateTime(1993, 06, 15), Persona.TipoDeSexo.Femenino);
            Persona cliente38 = new Cliente("Liliana", "Calvo", Persona.TipoDocumento.Pasaporte, 38219671, "31", "aleman", new DateTime(1991, 05, 16), Persona.TipoDeSexo.Femenino);
            Persona cliente39 = new Cliente("Paola", "Fernandez", Persona.TipoDocumento.DNI, 38219671, "72", "Argentina", new DateTime(1950, 04, 17), Persona.TipoDeSexo.Femenino);
            Persona cliente40 = new Cliente("Lucia", "Ramirez", Persona.TipoDocumento.DNI, 38219274, "30", "Argentina", new DateTime(1992, 05, 18), Persona.TipoDeSexo.Femenino);
            Persona cliente41 = new Cliente("Agustina", "Barreto", Persona.TipoDocumento.DNI, 38219254, "28", "Argentina", new DateTime(1994, 08, 14), Persona.TipoDeSexo.Femenino);
            Persona cliente42 = new Cliente("Valentina", "Caceres", Persona.TipoDocumento.DNI, 38658254, "29", "Argentina", new DateTime(1993, 07, 24), Persona.TipoDeSexo.Femenino);
            Persona cliente43 = new Cliente("Pamela", "Pailof", Persona.TipoDocumento.DNI, 38358233, "33", "Argentina", new DateTime(1991, 06, 25), Persona.TipoDeSexo.Femenino);
            Persona cliente44 = new Cliente("Estefania", "Miranda", Persona.TipoDocumento.Pasaporte, 38358233, "30", "italiano", new DateTime(1992, 04, 26), Persona.TipoDeSexo.Femenino);
            Persona cliente45 = new Cliente("Carla", "Pirota", Persona.TipoDocumento.Pasaporte, 38020788, "30", "frances", new DateTime(1992, 01, 27), Persona.TipoDeSexo.Femenino);
            Persona cliente46 = new Cliente("Roxana", "Fleitas", Persona.TipoDocumento.DNI, 38025426, "60", "Argentina", new DateTime(1962, 01, 21), Persona.TipoDeSexo.Femenino);
            Persona cliente47 = new Cliente("Sandra", "Vallejos", Persona.TipoDocumento.DNI, 38999187, "40", "Argentina", new DateTime(1982, 03, 04), Persona.TipoDeSexo.Femenino);
            Persona cliente48 = new Cliente("Virgina", "Vazquez", Persona.TipoDocumento.DNI, 31399187, "43", "Argentina", new DateTime(1979, 02, 02), Persona.TipoDeSexo.Femenino);
            Persona cliente49 = new Cliente("Mariela", "Prandi", Persona.TipoDocumento.Pasaporte, 38044187, "39", "ingles", new DateTime(1983, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente50 = new Cliente("Patricia", "Ferraro", Persona.TipoDocumento.DNI, 38358187, "37", "Argentina", new DateTime(1985, 04, 15), Persona.TipoDeSexo.Femenino);




            GestionDeAerolinea.ListaDePersonas.Add(cliente1);
            GestionDeAerolinea.ListaDePersonas.Add(cliente2);
            GestionDeAerolinea.ListaDePersonas.Add(cliente3);
            GestionDeAerolinea.ListaDePersonas.Add(cliente4);
            GestionDeAerolinea.ListaDePersonas.Add(cliente5);
            GestionDeAerolinea.ListaDePersonas.Add(cliente6);
            GestionDeAerolinea.ListaDePersonas.Add(cliente7);
            GestionDeAerolinea.ListaDePersonas.Add(cliente8);
            GestionDeAerolinea.ListaDePersonas.Add(cliente9);
            GestionDeAerolinea.ListaDePersonas.Add(cliente10);
            GestionDeAerolinea.ListaDePersonas.Add(cliente11);
            GestionDeAerolinea.ListaDePersonas.Add(cliente12);
            GestionDeAerolinea.ListaDePersonas.Add(cliente13);
            GestionDeAerolinea.ListaDePersonas.Add(cliente14);
            GestionDeAerolinea.ListaDePersonas.Add(cliente15);
            GestionDeAerolinea.ListaDePersonas.Add(cliente16);
            GestionDeAerolinea.ListaDePersonas.Add(cliente17);
            GestionDeAerolinea.ListaDePersonas.Add(cliente18);
            GestionDeAerolinea.ListaDePersonas.Add(cliente19);
            GestionDeAerolinea.ListaDePersonas.Add(cliente20);
            GestionDeAerolinea.ListaDePersonas.Add(cliente21);
            GestionDeAerolinea.ListaDePersonas.Add(cliente22);
            GestionDeAerolinea.ListaDePersonas.Add(cliente23);
            GestionDeAerolinea.ListaDePersonas.Add(cliente24);
            GestionDeAerolinea.ListaDePersonas.Add(cliente25);
            GestionDeAerolinea.ListaDePersonas.Add(cliente26);
            GestionDeAerolinea.ListaDePersonas.Add(cliente27);
            GestionDeAerolinea.ListaDePersonas.Add(cliente28);
            GestionDeAerolinea.ListaDePersonas.Add(cliente29);
            GestionDeAerolinea.ListaDePersonas.Add(cliente30);
            GestionDeAerolinea.ListaDePersonas.Add(cliente31);
            GestionDeAerolinea.ListaDePersonas.Add(cliente32);
            GestionDeAerolinea.ListaDePersonas.Add(cliente33);
            GestionDeAerolinea.ListaDePersonas.Add(cliente34);
            GestionDeAerolinea.ListaDePersonas.Add(cliente35);
            GestionDeAerolinea.ListaDePersonas.Add(cliente36);
            GestionDeAerolinea.ListaDePersonas.Add(cliente37);
            GestionDeAerolinea.ListaDePersonas.Add(cliente38);
            GestionDeAerolinea.ListaDePersonas.Add(cliente39);
            GestionDeAerolinea.ListaDePersonas.Add(cliente40);
            GestionDeAerolinea.ListaDePersonas.Add(cliente41);
            GestionDeAerolinea.ListaDePersonas.Add(cliente42);
            GestionDeAerolinea.ListaDePersonas.Add(cliente43);
            GestionDeAerolinea.ListaDePersonas.Add(cliente44);
            GestionDeAerolinea.ListaDePersonas.Add(cliente45);
            GestionDeAerolinea.ListaDePersonas.Add(cliente46);
            GestionDeAerolinea.ListaDePersonas.Add(cliente47);
            GestionDeAerolinea.ListaDePersonas.Add(cliente48);
            GestionDeAerolinea.ListaDePersonas.Add(cliente49);
            GestionDeAerolinea.ListaDePersonas.Add(cliente50);



            Equipaje equipajePre1A = new Equipaje(0, cliente1.Documento, 3);
            Equipaje equipajePre1B = new Equipaje(1, cliente1.Documento, 24);
            Equipaje equipajePre2A = new Equipaje(0, cliente2.Documento, 3);
            Equipaje equipajePre2B = new Equipaje(1, cliente2.Documento, 24);
            Equipaje equipajePre3A = new Equipaje(0, cliente3.Documento, 3);
            Equipaje equipajePre3B = new Equipaje(1, cliente3.Documento, 24);
            Equipaje equipajePre4A = new Equipaje(0, cliente4.Documento, 3);
            Equipaje equipajePre4B = new Equipaje(1, cliente4.Documento, 24);
            Equipaje equipajePre5A = new Equipaje(0, cliente5.Documento, 3);
            Equipaje equipajePre5B = new Equipaje(1, cliente5.Documento, 24);
            Equipaje equipajePre6A = new Equipaje(0, cliente6.Documento, 3);
            Equipaje equipajePre6B = new Equipaje(1, cliente6.Documento, 24);
            Equipaje equipajePre7A = new Equipaje(0, cliente7.Documento, 3);
            Equipaje equipajePre7B = new Equipaje(1, cliente7.Documento, 24);
            Equipaje equipajePre8A = new Equipaje(0, cliente8.Documento, 3);
            Equipaje equipajePre8B = new Equipaje(1, cliente8.Documento, 24);

            List<Equipaje> listaDeEquipajesPremium1 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium2 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium3 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium4 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium5 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium6 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium7 = new List<Equipaje>();
            List<Equipaje> listaDeEquipajesPremium8 = new List<Equipaje>();

            listaDeEquipajesPremium1.Add(equipajePre1A);
            listaDeEquipajesPremium1.Add(equipajePre1B);
            listaDeEquipajesPremium2.Add(equipajePre2A);
            listaDeEquipajesPremium2.Add(equipajePre2B);
            listaDeEquipajesPremium3.Add(equipajePre3A);
            listaDeEquipajesPremium3.Add(equipajePre3B);
            listaDeEquipajesPremium4.Add(equipajePre4A);
            listaDeEquipajesPremium4.Add(equipajePre4B);
            listaDeEquipajesPremium5.Add(equipajePre5A);
            listaDeEquipajesPremium5.Add(equipajePre5B);
            listaDeEquipajesPremium6.Add(equipajePre6A);
            listaDeEquipajesPremium6.Add(equipajePre6B);
            listaDeEquipajesPremium7.Add(equipajePre7A);
            listaDeEquipajesPremium7.Add(equipajePre7B);
            listaDeEquipajesPremium8.Add(equipajePre8A);
            listaDeEquipajesPremium8.Add(equipajePre8B);

            List<Equipaje> listaDeEquipajesPremium9 = new List<Equipaje>();
            listaDeEquipajesPremium9.Add(new Equipaje(1, cliente9.Documento, 3));
            listaDeEquipajesPremium9.Add(new Equipaje(1, cliente9.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium10 = new List<Equipaje>();
            listaDeEquipajesPremium10.Add(new Equipaje(1, cliente10.Documento, 3));
            listaDeEquipajesPremium10.Add(new Equipaje(1, cliente10.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium11 = new List<Equipaje>();
            listaDeEquipajesPremium11.Add(new Equipaje(1, cliente11.Documento, 3));
            listaDeEquipajesPremium11.Add(new Equipaje(1, cliente11.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium12 = new List<Equipaje>();
            listaDeEquipajesPremium12.Add(new Equipaje(1, cliente12.Documento, 3));
            listaDeEquipajesPremium12.Add(new Equipaje(1, cliente12.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium13 = new List<Equipaje>();
            listaDeEquipajesPremium13.Add(new Equipaje(1, cliente13.Documento, 3));
            listaDeEquipajesPremium13.Add(new Equipaje(1, cliente13.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium14 = new List<Equipaje>();
            listaDeEquipajesPremium14.Add(new Equipaje(1, cliente14.Documento, 3));
            listaDeEquipajesPremium14.Add(new Equipaje(1, cliente14.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium15 = new List<Equipaje>();
            listaDeEquipajesPremium15.Add(new Equipaje(1, cliente15.Documento, 3));
            listaDeEquipajesPremium15.Add(new Equipaje(1, cliente15.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium16 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente16.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente16.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium17 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente17.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente17.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium18 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente18.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente18.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium19 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente19.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente19.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium20 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente20.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente20.Documento, 24));

            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR130BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR129BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR128BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR127BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR126BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR125BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR124BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR5123BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR122BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR121BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR120BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR119BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR118BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR117BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR116BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR115BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesPremium17, "FAR118BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesPremium18, "FAR117BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesPremium19, "FAR116BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR115BUELV380ULROM", "BUELV380ULROM", ClaseDePasajero.Premium));
            
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR110BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR109BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR108BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR107BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR106BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR105BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR104BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR103BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR102BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR101BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR100BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR099BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR098BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR097BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR096BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));
            GestionDeAerolinea.ListaDePasajeros.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR095BUELV777ULREC", "BUELV777ULREC", ClaseDePasajero.Premium));

            //Codigo de Vuelo: BUELV380ULROM


            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente1.Documento, cliente1.Nombre, cliente1.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente2.Documento, cliente2.Nombre, cliente2.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente3.Documento, cliente3.Nombre, cliente3.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente4.Documento, cliente4.Nombre, cliente4.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente5.Documento, cliente5.Nombre, cliente5.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente6.Documento, cliente6.Nombre, cliente6.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente7.Documento, cliente7.Nombre, cliente7.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente8.Documento, cliente8.Nombre, cliente8.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente9.Documento, cliente9.Nombre, cliente9.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente10.Documento, cliente10.Nombre, cliente10.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente11.Documento, cliente11.Nombre, cliente11.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV380ULROM", "BUELV380ULROM", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Premium", 1300));

            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "TUCLV737MATRE", cliente1.Documento, cliente1.Nombre, cliente1.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente2.Documento, cliente2.Nombre, cliente2.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "TURIum", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente3.Documento, cliente3.Nombre, cliente3.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente4.Documento, cliente4.Nombre, cliente4.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente5.Documento, cliente5.Nombre, cliente5.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente6.Documento, cliente6.Nombre, cliente6.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente7.Documento, cliente7.Nombre, cliente7.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente8.Documento, cliente8.Nombre, cliente8.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente9.Documento, cliente9.Nombre, cliente9.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente10.Documento, cliente10.Nombre, cliente10.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente11.Documento, cliente11.Nombre, cliente11.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURITUCLV737MATRE", "TUCLV737MATRE", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, Airbus320TucTre.Origen,
                Airbus320TucTre.HoraDePartida, Airbus320TucTre.Destino, Airbus320TucTre.HoraDeLlegada, "Premium", 1100));






        }



        public static void HarcodeoDeDestinos()
        {
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(0, "Santa Rosa");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1, "Bariloche");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(2, "Corrientes");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(3, "Córdoba");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(4, "Jujuy");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(5, "Mendoza");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(6, "Neuquén");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(7, "Posadas");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(8, "Iguazú");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(9, "Salta");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(10, "Santiago del Estero");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(11, "Trelew");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(12, "Tucumán");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(13, "Puerto Madryn");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(14, "Ushuaia");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(15, "Buenos Aires");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1000, "Recife(Brasil)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1001, "Roma(Italia)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1002, "Acapulco(Mexico)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1003, "Miami(EEUU)");

        }




        public static void HarcodeoDePasajeros()
        {


            for (int j = 0; j < GestionDeAerolinea.ListaDePasajeros.Count; j++)
            {
                for (int i = 0; i < GestionDeAerolinea.ListaDeVuelos.Count; i++)
                {

                    if (GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo == GestionDeAerolinea.ListaDePasajeros[j].CodigoDeVuelo)
                        GestionDeAerolinea.ListaDeVuelos[i].ListaDePasajerosPremium.Add(GestionDeAerolinea.ListaDePasajeros[j]);





                }
            }
        }





    }
}
