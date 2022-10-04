using System;
using System.Collections.Generic;

namespace Logica
{
    public static class BaseDeDatosHardCodeo
    {
        static BaseDeDatosHardCodeo()
        {
            BaseDeDatosHardCodeo.HarcodeoDeUsuarios();
            BaseDeDatosHardCodeo.HarcodeoDeDestinos();
            BaseDeDatosHardCodeo.Harcodeo();
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
                Airbus380, true, true, "BUELV380ULROM" ,15, 1001);
            Vuelo Airbus380BueMia = new Vuelo(DateTime.Today.AddMinutes(20), DateTime.Today,
                Airbus380, true, true, "BUELV380ULMIA", 15, 1003);
            Vuelo Airbus380BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today,
                Airbus380, true, true, "BUELV380ULACA", 15, 1002);
            Vuelo Airbus380BueRecFn = new Vuelo(new DateTime(2022, 10, 01), DateTime.Today,
                Airbus380, true, true, "BUELV380ULREC", 15, 1000);

            Vuelo Boeing777BueMia = new Vuelo(DateTime.Today.AddMinutes(20).AddDays(5), DateTime.Today,
                Boeing777, true, true, "BUELV777ULMIA", 15, 1003);
            Vuelo Boeing777BueAca = new Vuelo(DateTime.Today.AddMinutes(45), DateTime.Today,
                Boeing777, true, true, "BUELV777ULACA", 15, 1002);
            Vuelo Boeing777BueRec = new Vuelo(DateTime.Today.AddMinutes(35), DateTime.Today,
                Boeing777, true, true, "BUELV777ULREC", 15, 1000);
            Vuelo Boeing777BueRomaEx = new Vuelo(new DateTime(2022, 10, 01), DateTime.Today,
                Boeing777, true, true, "BUELV777ULROM", 15, 1001);


            Vuelo Boeing767RsaBrc = new Vuelo(DateTime.Today.AddMinutes(38), DateTime.Today,
                Boeing767, true, true, "RSALV767LABRC", 0, 1);
            Vuelo Boeing767SlaCor = new Vuelo(DateTime.Today.AddMinutes(41), DateTime.Today,
                Boeing767, true, true, "SLALV767LACOR", 9, 3);
            Vuelo Boeing767JujMdz = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today,
                Boeing767, true, true, "JUJLV767LAMDZ", 4, 5);
            Vuelo Boeing767IgrPmy = new Vuelo(DateTime.Today.AddMinutes(24), DateTime.Today,
                Boeing767, true, true, "IGRLV767LAPMY", 8, 13);

            Vuelo AirbusA350RsaBrc = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(38), DateTime.Today,
                AirbusA350, true, true, "RSALV350LABRC", 0, 1);
            Vuelo AirbusA350CnqCor = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(41), DateTime.Today,
                AirbusA350, true, true, "CNQLV350LACOR", 2, 3);
            Vuelo AirbusA350JujMdz = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today,
                AirbusA350, true, true, "JUJLV350LAMDZ", 4, 5);
            Vuelo AirbusA350IgrPmy = new Vuelo(DateTime.Today.AddDays(1).AddMinutes(24), DateTime.Today,
                AirbusA350, true, true, "IGRLV350LAPMY", 8, 13);

            Vuelo Boeing737RsaCnq = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today,
                Boeing737, true, true, "RSALV737MACNQ", 0, 2);
            Vuelo Boeing737CnqJuj = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today,
                Boeing737, true, true, "CNQLV737MAJUJ", 2, 4);
            Vuelo Boeing737JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today,
                Boeing737, true, true, "JUJLV737MAIGR", 4, 8);
            Vuelo Boeing737MdzPMY = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                Boeing737, true, true, "MDZLV737MAPMY", 5, 14);
            Vuelo Boeing737RelPss = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                 Boeing737, true, true, "RELLV737MAPSS", 11, 7);

            Vuelo Airbus320TucRel = new Vuelo(DateTime.Today.AddDays(3), DateTime.Today,
                Airbus320, true, true, "TUCLV320MAREL", 12, 11);
            Vuelo Airbus320JujNqn = new Vuelo(DateTime.Today.AddDays(2), DateTime.Today,
                Airbus320, true, true, "JUJLV320MANQN", 4, 6);
            Vuelo Airbus320JujIgr = new Vuelo(DateTime.Today.AddDays(4), DateTime.Today,
                Airbus320, true, true, "JUJLV320MAIGR", 4, 8);
            Vuelo Airbus320MdzTuc = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                Airbus320, true, true, "MDZLV320MATUC", 5, 12);
            Vuelo Airbus320SdeSla = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                Airbus320, true, true, "SDELV320MASLA", 10, 9);

            Vuelo Airbus330JujPss = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "JUJLV330MAPSS", 4, 7);
            Vuelo Airbus330CorRsa = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "CORLV330MARSA", 3, 0);
            Vuelo Airbus330PmyBue = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "MPYLV330MABUE", 13, 15);
            Vuelo Airbus330MdzBue = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "MZALV330MABUE", 5, 15);
            Vuelo Airbus330PmySde = new Vuelo(DateTime.Today.AddMinutes(21).AddDays(11), DateTime.Today,
                Airbus330, false, false, "PMYLV330MASDE", 13, 10);



            Vuelo VueloDePrueba = new Vuelo(DateTime.Today.AddDays(5), DateTime.Today,
                avionDePrueba, true, true, "MDZPRUEBAJUJ", 5, 4);


            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRom);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueAca);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueMia);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueRec);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueAca);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueMia);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767IgrPmy);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767JujMdz);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767SlaCor);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing767RsaBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350IgrPmy);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350CnqCor);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350JujMdz);
            GestionDeAerolinea.ListaDeVuelos.Add(AirbusA350RsaBrc);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing737RsaCnq);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing737CnqJuj);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing737MdzPMY);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing737JujIgr);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing737RelPss);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320MdzTuc);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320JujIgr);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320TucRel);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320JujNqn);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus320SdeSla);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330CorRsa);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330JujPss);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330PmyBue);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330MdzBue);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus330PmySde);
            GestionDeAerolinea.ListaDeVuelos.Add(Airbus380BueRecFn);
            GestionDeAerolinea.ListaDeVuelos.Add(Boeing777BueRomaEx);

            GestionDeAerolinea.ListaDeVuelos.Add(VueloDePrueba);


            Persona cliente1 = new Cliente("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, 34260217, "33", "Argentina", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente2 = new Cliente("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, 25003321, "30", "Argentina", new DateTime(1992, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente3 = new Cliente("Marina", "Rodriguez", Persona.TipoDocumento.DNI, 38456409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente4 = new Cliente("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, 37213986, "24", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente5 = new Cliente("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, 34330213, "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente6 = new Cliente("Diego", "Maradona", Persona.TipoDocumento.DNI, 24323788, "62", "Argentina", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente7 = new Cliente("Lionel", "Messi", Persona.TipoDocumento.DNI, 92198605, "37", "Argentina", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente8 = new Cliente("Angel", "Flores", Persona.TipoDocumento.DNI, 30060217, "33", "Argentina", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente9 = new Cliente("Pablo", "Avil", Persona.TipoDocumento.DNI, 45003321, "32", "Argentina", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente10 = new Cliente("Claudia", "Gutierrez", Persona.TipoDocumento.DNI, 38196409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente11 = new Cliente("Fernando", "Sanchez", Persona.TipoDocumento.Pasaporte, 37003986, "64", "Italiano", new DateTime(1958, 06, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente12 = new Cliente("Martin", "Piroli", Persona.TipoDocumento.Pasaporte, 34220000, "88", "Frances", new DateTime(1934, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente13 = new Cliente("Andres", "Marsena", Persona.TipoDocumento.DNI, 84323788, "53", "Argentina", new DateTime(1969, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente14 = new Cliente("Jose", "Mestalo", Persona.TipoDocumento.DNI, 22198605, "34", "Argentina", new DateTime(1987, 11, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente15 = new Cliente("Pablo", "Ramos", Persona.TipoDocumento.Pasaporte, 31260217, "33", "uruguayo", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Persona cliente16 = new Cliente("Lucas", "Raimundi", Persona.TipoDocumento.Pasaporte, 55003321, "31", "uruguayo", new DateTime(1991, 07, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente17 = new Cliente("Mariana", "Torrico", Persona.TipoDocumento.DNI, 38996409, "30", "Argentina", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente18 = new Cliente("Hernan", "Caferato", Persona.TipoDocumento.Pasaporte, 37553986, "24", "Italiano", new DateTime(1998, 06, 11), Persona.TipoDeSexo.Masculino);
            Persona cliente19 = new Cliente("Marcos", "Colivan", Persona.TipoDocumento.Pasaporte, 34220213, "50", "Frances", new DateTime(1972, 03, 09), Persona.TipoDeSexo.Masculino);
            Persona cliente20 = new Cliente("Eduardo", "Parato", Persona.TipoDocumento.DNI, 04323788, "61", "Argentina", new DateTime(1961, 01, 05), Persona.TipoDeSexo.Masculino);
            Persona cliente21 = new Cliente("Lautaro", "Danelo", Persona.TipoDocumento.DNI, 12198605, "37", "Argentina", new DateTime(1985, 11, 25), Persona.TipoDeSexo.Masculino);
            Persona cliente22 = new Cliente("Jeremias", "Pizzoto", Persona.TipoDocumento.DNI, 34002507, "23", "Argentina", new DateTime(1999, 12, 27), Persona.TipoDeSexo.Masculino);
            Persona cliente23 = new Cliente("Matias", "Anastalo", Persona.TipoDocumento.DNI, 35113321, "24", "Argentina", new DateTime(1998, 07, 25), Persona.TipoDeSexo.Masculino);
            Persona cliente24 = new Cliente("Florencia", "Rodrigues", Persona.TipoDocumento.DNI, 38456255, "21", "Argentina", new DateTime(2001, 04, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente25 = new Cliente("Roman", "Rimendi", Persona.TipoDocumento.Pasaporte, 37210086, "20", "Italiano", new DateTime(2002, 06, 30), Persona.TipoDeSexo.Masculino);
            Persona cliente26 = new Cliente("Andres", "Pasculi", Persona.TipoDocumento.Pasaporte, 30002503, "49", "Frances", new DateTime(1973, 03, 29), Persona.TipoDeSexo.Masculino);
            Persona cliente27 = new Cliente("Pablo", "Peroda", Persona.TipoDocumento.DNI, 14323788, "54", "Argentina", new DateTime(1968, 01, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente28 = new Cliente("Javier", "Salatino", Persona.TipoDocumento.DNI, 42198605, "56", "Argentina", new DateTime(1966, 11, 13), Persona.TipoDeSexo.Masculino);
            Persona cliente29 = new Cliente("Fernando", "Parana", Persona.TipoDocumento.DNI, 34262507, "38", "Argentina", new DateTime(1984, 12, 12), Persona.TipoDeSexo.Masculino);
            Persona cliente30 = new Cliente("Gabriel", "Mascena", Persona.TipoDocumento.DNI, 35883321, "29", "Argentina", new DateTime(1993, 07, 14), Persona.TipoDeSexo.Masculino);
            Persona cliente31 = new Cliente("Mauricio", "Pachorita", Persona.TipoDocumento.DNI, 38411255, "30", "Argentina", new DateTime(1992, 03, 22), Persona.TipoDeSexo.Femenino);
            Persona cliente32 = new Cliente("Agustin", "Avianto", Persona.TipoDocumento.Pasaporte, 37999986, "28", "Italiano", new DateTime(1994, 05, 10), Persona.TipoDeSexo.Masculino);
            Persona cliente33 = new Cliente("Mariano", "Astrosi", Persona.TipoDocumento.Pasaporte, 34222503, "45", "Frances", new DateTime(1977, 03, 19), Persona.TipoDeSexo.Masculino);
            Persona cliente34 = new Cliente("Jorge", "Frandilo", Persona.TipoDocumento.DNI, 44323788, "62", "Argentina", new DateTime(1960, 02, 15), Persona.TipoDeSexo.Masculino);
            Persona cliente35 = new Cliente("Flavio", "Peduto", Persona.TipoDocumento.DNI, 32198605, "37", "Argentina", new DateTime(1985, 12, 09), Persona.TipoDeSexo.Masculino);
            Persona cliente36 = new Cliente("Romina", "Rubin", Persona.TipoDocumento.Pasaporte, 36456255, "30", "uruguayo", new DateTime(1992, 07, 08), Persona.TipoDeSexo.Femenino);
            Persona cliente37 = new Cliente("Marina", "Corso", Persona.TipoDocumento.Pasaporte, 37456671, "29", "español", new DateTime(1993, 06, 15), Persona.TipoDeSexo.Femenino);
            Persona cliente38 = new Cliente("Liliana", "Calvo", Persona.TipoDocumento.Pasaporte, 98019671, "31", "aleman", new DateTime(1991, 05, 16), Persona.TipoDeSexo.Femenino);
            Persona cliente39 = new Cliente("Paola", "Fernandez", Persona.TipoDocumento.DNI, 38219671, "72", "Argentina", new DateTime(1950, 04, 17), Persona.TipoDeSexo.Femenino);
            Persona cliente40 = new Cliente("Lucia", "Ramirez", Persona.TipoDocumento.DNI, 38219274, "30", "Argentina", new DateTime(1992, 05, 18), Persona.TipoDeSexo.Femenino);
            Persona cliente41 = new Cliente("Agustina", "Barreto", Persona.TipoDocumento.DNI, 38219254, "28", "Argentina", new DateTime(1994, 08, 14), Persona.TipoDeSexo.Femenino);
            Persona cliente42 = new Cliente("Valentina", "Caceres", Persona.TipoDocumento.DNI, 38658254, "29", "Argentina", new DateTime(1993, 07, 24), Persona.TipoDeSexo.Femenino);
            Persona cliente43 = new Cliente("Pamela", "Pailof", Persona.TipoDocumento.DNI, 38358233, "33", "Argentina", new DateTime(1991, 06, 25), Persona.TipoDeSexo.Femenino);
            Persona cliente44 = new Cliente("Estefania", "Miranda", Persona.TipoDocumento.Pasaporte, 38358033, "30", "italiano", new DateTime(1992, 04, 26), Persona.TipoDeSexo.Femenino);
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

            //EQUIPAJES PREMIUM

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
            listaDeEquipajesPremium9.Add(new Equipaje(0, cliente9.Documento, 3));
            listaDeEquipajesPremium9.Add(new Equipaje(1, cliente9.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium10 = new List<Equipaje>();
            listaDeEquipajesPremium10.Add(new Equipaje(0, cliente10.Documento, 3));
            listaDeEquipajesPremium10.Add(new Equipaje(1, cliente10.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium11 = new List<Equipaje>();
            listaDeEquipajesPremium11.Add(new Equipaje(0, cliente11.Documento, 3));
            listaDeEquipajesPremium11.Add(new Equipaje(1, cliente11.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium12 = new List<Equipaje>();
            listaDeEquipajesPremium12.Add(new Equipaje(0, cliente12.Documento, 3));
            listaDeEquipajesPremium12.Add(new Equipaje(1, cliente12.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium13 = new List<Equipaje>();
            listaDeEquipajesPremium13.Add(new Equipaje(0, cliente13.Documento, 3));
            listaDeEquipajesPremium13.Add(new Equipaje(1, cliente13.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium14 = new List<Equipaje>();
            listaDeEquipajesPremium14.Add(new Equipaje(0, cliente14.Documento, 3));
            listaDeEquipajesPremium14.Add(new Equipaje(1, cliente14.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium15 = new List<Equipaje>();
            listaDeEquipajesPremium15.Add(new Equipaje(0, cliente15.Documento, 3));
            listaDeEquipajesPremium15.Add(new Equipaje(1, cliente15.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium16 = new List<Equipaje>();
            listaDeEquipajesPremium16.Add(new Equipaje(0, cliente16.Documento, 3));
            listaDeEquipajesPremium16.Add(new Equipaje(1, cliente16.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium17 = new List<Equipaje>();
            listaDeEquipajesPremium17.Add(new Equipaje(0, cliente17.Documento, 3));
            listaDeEquipajesPremium17.Add(new Equipaje(1, cliente17.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium18 = new List<Equipaje>();
            listaDeEquipajesPremium18.Add(new Equipaje(0, cliente18.Documento, 3));
            listaDeEquipajesPremium18.Add(new Equipaje(1, cliente18.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium19 = new List<Equipaje>();
            listaDeEquipajesPremium19.Add(new Equipaje(0, cliente19.Documento, 3));
            listaDeEquipajesPremium19.Add(new Equipaje(1, cliente19.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium20 = new List<Equipaje>();
            listaDeEquipajesPremium20.Add(new Equipaje(0, cliente20.Documento, 3));
            listaDeEquipajesPremium20.Add(new Equipaje(1, cliente20.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium21 = new List<Equipaje>();
            listaDeEquipajesPremium21.Add(new Equipaje(0, cliente21.Documento, 3));
            listaDeEquipajesPremium21.Add(new Equipaje(1, cliente21.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium22 = new List<Equipaje>();
            listaDeEquipajesPremium22.Add(new Equipaje(0, cliente22.Documento, 3));
            listaDeEquipajesPremium22.Add(new Equipaje(1, cliente22.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium23 = new List<Equipaje>();
            listaDeEquipajesPremium23.Add(new Equipaje(0, cliente23.Documento, 3));
            listaDeEquipajesPremium23.Add(new Equipaje(1, cliente23.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium24 = new List<Equipaje>();
            listaDeEquipajesPremium24.Add(new Equipaje(0, cliente24.Documento, 3));
            listaDeEquipajesPremium24.Add(new Equipaje(1, cliente24.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium25 = new List<Equipaje>();
            listaDeEquipajesPremium25.Add(new Equipaje(0, cliente25.Documento, 3));
            listaDeEquipajesPremium25.Add(new Equipaje(1, cliente25.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium26 = new List<Equipaje>();
            listaDeEquipajesPremium26.Add(new Equipaje(0, cliente26.Documento, 3));
            listaDeEquipajesPremium26.Add(new Equipaje(1, cliente26.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium27 = new List<Equipaje>();
            listaDeEquipajesPremium27.Add(new Equipaje(0, cliente27.Documento, 3));
            listaDeEquipajesPremium27.Add(new Equipaje(1, cliente27.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium28 = new List<Equipaje>();
            listaDeEquipajesPremium28.Add(new Equipaje(0, cliente28.Documento, 3));
            listaDeEquipajesPremium28.Add(new Equipaje(1, cliente28.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium29 = new List<Equipaje>();
            listaDeEquipajesPremium29.Add(new Equipaje(0, cliente29.Documento, 3));
            listaDeEquipajesPremium29.Add(new Equipaje(1, cliente29.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium30 = new List<Equipaje>();
            listaDeEquipajesPremium30.Add(new Equipaje(0, cliente30.Documento, 3));
            listaDeEquipajesPremium30.Add(new Equipaje(1, cliente30.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium31 = new List<Equipaje>();
            listaDeEquipajesPremium31.Add(new Equipaje(0, cliente31.Documento, 3));
            listaDeEquipajesPremium31.Add(new Equipaje(1, cliente31.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium32 = new List<Equipaje>();
            listaDeEquipajesPremium32.Add(new Equipaje(0, cliente32.Documento, 3));
            listaDeEquipajesPremium32.Add(new Equipaje(1, cliente32.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium33 = new List<Equipaje>();
            listaDeEquipajesPremium33.Add(new Equipaje(0, cliente33.Documento, 3));
            listaDeEquipajesPremium33.Add(new Equipaje(1, cliente33.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium34 = new List<Equipaje>();
            listaDeEquipajesPremium34.Add(new Equipaje(0, cliente34.Documento, 3));
            listaDeEquipajesPremium34.Add(new Equipaje(1, cliente34.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium35 = new List<Equipaje>();
            listaDeEquipajesPremium35.Add(new Equipaje(0, cliente35.Documento, 3));
            listaDeEquipajesPremium35.Add(new Equipaje(1, cliente35.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium36 = new List<Equipaje>();
            listaDeEquipajesPremium36.Add(new Equipaje(0, cliente36.Documento, 3));
            listaDeEquipajesPremium36.Add(new Equipaje(1, cliente36.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium37 = new List<Equipaje>();
            listaDeEquipajesPremium37.Add(new Equipaje(0, cliente37.Documento, 3));
            listaDeEquipajesPremium37.Add(new Equipaje(1, cliente37.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium38 = new List<Equipaje>();
            listaDeEquipajesPremium38.Add(new Equipaje(0, cliente38.Documento, 3));
            listaDeEquipajesPremium38.Add(new Equipaje(1, cliente38.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium39 = new List<Equipaje>();
            listaDeEquipajesPremium39.Add(new Equipaje(0, cliente39.Documento, 3));
            listaDeEquipajesPremium39.Add(new Equipaje(1, cliente39.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium40 = new List<Equipaje>();
            listaDeEquipajesPremium40.Add(new Equipaje(0, cliente40.Documento, 3));
            listaDeEquipajesPremium40.Add(new Equipaje(1, cliente40.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium41 = new List<Equipaje>();
            listaDeEquipajesPremium41.Add(new Equipaje(0, cliente41.Documento, 3));
            listaDeEquipajesPremium41.Add(new Equipaje(1, cliente41.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium42 = new List<Equipaje>();
            listaDeEquipajesPremium42.Add(new Equipaje(0, cliente42.Documento, 3));
            listaDeEquipajesPremium42.Add(new Equipaje(1, cliente42.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium43 = new List<Equipaje>();
            listaDeEquipajesPremium43.Add(new Equipaje(0, cliente43.Documento, 3));
            listaDeEquipajesPremium43.Add(new Equipaje(1, cliente43.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium44 = new List<Equipaje>();
            listaDeEquipajesPremium44.Add(new Equipaje(0, cliente44.Documento, 3));
            listaDeEquipajesPremium44.Add(new Equipaje(1, cliente44.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium45 = new List<Equipaje>();
            listaDeEquipajesPremium45.Add(new Equipaje(0, cliente45.Documento, 3));
            listaDeEquipajesPremium45.Add(new Equipaje(1, cliente45.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium46 = new List<Equipaje>();
            listaDeEquipajesPremium46.Add(new Equipaje(0, cliente46.Documento, 3));
            listaDeEquipajesPremium46.Add(new Equipaje(1, cliente46.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium47 = new List<Equipaje>();
            listaDeEquipajesPremium47.Add(new Equipaje(0, cliente47.Documento, 3));
            listaDeEquipajesPremium47.Add(new Equipaje(1, cliente47.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium48 = new List<Equipaje>();
            listaDeEquipajesPremium48.Add(new Equipaje(0, cliente48.Documento, 3));
            listaDeEquipajesPremium48.Add(new Equipaje(1, cliente48.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium49 = new List<Equipaje>();
            listaDeEquipajesPremium49.Add(new Equipaje(0, cliente49.Documento, 3));
            listaDeEquipajesPremium49.Add(new Equipaje(1, cliente49.Documento, 24));
            List<Equipaje> listaDeEquipajesPremium50 = new List<Equipaje>();
            listaDeEquipajesPremium50.Add(new Equipaje(0, cliente50.Documento, 3));
            listaDeEquipajesPremium50.Add(new Equipaje(1, cliente50.Documento, 24));


            //EQUIPAJES TURISTA

            List<Equipaje> listaDeEquipajesTurista1 = new List<Equipaje>();
            listaDeEquipajesTurista1.Add(new Equipaje(0, cliente1.Documento, 3));
            listaDeEquipajesTurista1.Add(new Equipaje(1, cliente1.Documento, 21));
            listaDeEquipajesTurista1.Add(new Equipaje(2, cliente1.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista2 = new List<Equipaje>();
            listaDeEquipajesTurista2.Add(new Equipaje(0, cliente2.Documento, 3));
            listaDeEquipajesTurista2.Add(new Equipaje(1, cliente2.Documento, 21));
            listaDeEquipajesTurista2.Add(new Equipaje(2, cliente2.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista3 = new List<Equipaje>();
            listaDeEquipajesTurista3.Add(new Equipaje(0, cliente3.Documento, 3));
            listaDeEquipajesTurista3.Add(new Equipaje(1, cliente3.Documento, 21));
            listaDeEquipajesTurista3.Add(new Equipaje(2, cliente3.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista4 = new List<Equipaje>();
            listaDeEquipajesTurista4.Add(new Equipaje(0, cliente4.Documento, 3));
            listaDeEquipajesTurista4.Add(new Equipaje(1, cliente4.Documento, 21));
            listaDeEquipajesTurista4.Add(new Equipaje(2, cliente4.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista5 = new List<Equipaje>();
            listaDeEquipajesTurista5.Add(new Equipaje(0, cliente5.Documento, 3));
            listaDeEquipajesTurista5.Add(new Equipaje(1, cliente5.Documento, 21));
            listaDeEquipajesTurista5.Add(new Equipaje(2, cliente5.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista6 = new List<Equipaje>();
            listaDeEquipajesTurista6.Add(new Equipaje(0, cliente6.Documento, 3));
            listaDeEquipajesTurista6.Add(new Equipaje(1, cliente6.Documento, 21));
            listaDeEquipajesTurista6.Add(new Equipaje(2, cliente6.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista7 = new List<Equipaje>();
            listaDeEquipajesTurista7.Add(new Equipaje(0, cliente7.Documento, 3));
            listaDeEquipajesTurista7.Add(new Equipaje(1, cliente7.Documento, 21));
            listaDeEquipajesTurista7.Add(new Equipaje(2, cliente7.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista8 = new List<Equipaje>();
            listaDeEquipajesTurista8.Add(new Equipaje(0, cliente8.Documento, 3));
            listaDeEquipajesTurista8.Add(new Equipaje(1, cliente8.Documento, 21));
            listaDeEquipajesTurista8.Add(new Equipaje(2, cliente8.Documento, 21));


            List<Equipaje> listaDeEquipajesTurista9 = new List<Equipaje>();
            listaDeEquipajesTurista9.Add(new Equipaje(0, cliente9.Documento, 3));
            listaDeEquipajesTurista9.Add(new Equipaje(1, cliente9.Documento, 21));
            listaDeEquipajesTurista9.Add(new Equipaje(2, cliente9.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista10 = new List<Equipaje>();
            listaDeEquipajesTurista10.Add(new Equipaje(0, cliente10.Documento, 3));
            listaDeEquipajesTurista10.Add(new Equipaje(1, cliente10.Documento, 21));
            listaDeEquipajesTurista10.Add(new Equipaje(2, cliente10.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista11 = new List<Equipaje>();
            listaDeEquipajesTurista11.Add(new Equipaje(0, cliente11.Documento, 3));
            listaDeEquipajesTurista11.Add(new Equipaje(1, cliente11.Documento, 21));
            listaDeEquipajesTurista11.Add(new Equipaje(2, cliente11.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista12 = new List<Equipaje>();
            listaDeEquipajesTurista12.Add(new Equipaje(0, cliente12.Documento, 3));
            listaDeEquipajesTurista12.Add(new Equipaje(1, cliente12.Documento, 21));
            listaDeEquipajesTurista12.Add(new Equipaje(2, cliente12.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista13 = new List<Equipaje>();
            listaDeEquipajesTurista13.Add(new Equipaje(0, cliente13.Documento, 3));
            listaDeEquipajesTurista13.Add(new Equipaje(1, cliente13.Documento, 21));
            listaDeEquipajesTurista13.Add(new Equipaje(2, cliente13.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista14 = new List<Equipaje>();
            listaDeEquipajesTurista14.Add(new Equipaje(0, cliente14.Documento, 3));
            listaDeEquipajesTurista14.Add(new Equipaje(1, cliente14.Documento, 21));
            listaDeEquipajesTurista14.Add(new Equipaje(2, cliente13.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista15 = new List<Equipaje>();
            listaDeEquipajesTurista15.Add(new Equipaje(0, cliente15.Documento, 3));
            listaDeEquipajesTurista15.Add(new Equipaje(1, cliente15.Documento, 21));
            listaDeEquipajesTurista15.Add(new Equipaje(2, cliente15.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista16 = new List<Equipaje>();
            listaDeEquipajesTurista16.Add(new Equipaje(0, cliente16.Documento, 3));
            listaDeEquipajesTurista16.Add(new Equipaje(1, cliente16.Documento, 21));
            listaDeEquipajesTurista16.Add(new Equipaje(2, cliente16.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista17 = new List<Equipaje>();
            listaDeEquipajesTurista17.Add(new Equipaje(0, cliente17.Documento, 3));
            listaDeEquipajesTurista17.Add(new Equipaje(1, cliente17.Documento, 21));
            listaDeEquipajesTurista17.Add(new Equipaje(2, cliente17.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista18 = new List<Equipaje>();
            listaDeEquipajesTurista18.Add(new Equipaje(0, cliente18.Documento, 3));
            listaDeEquipajesTurista18.Add(new Equipaje(1, cliente18.Documento, 21));
            listaDeEquipajesTurista18.Add(new Equipaje(2, cliente18.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista19 = new List<Equipaje>();
            listaDeEquipajesTurista19.Add(new Equipaje(0, cliente19.Documento, 3));
            listaDeEquipajesTurista19.Add(new Equipaje(1, cliente19.Documento, 21));
            listaDeEquipajesTurista19.Add(new Equipaje(2, cliente19.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista20 = new List<Equipaje>();
            listaDeEquipajesTurista20.Add(new Equipaje(0, cliente20.Documento, 3));
            listaDeEquipajesTurista20.Add(new Equipaje(1, cliente20.Documento, 21));
            listaDeEquipajesTurista20.Add(new Equipaje(2, cliente20.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista21 = new List<Equipaje>();
            listaDeEquipajesTurista21.Add(new Equipaje(0, cliente21.Documento, 3));
            listaDeEquipajesTurista21.Add(new Equipaje(1, cliente21.Documento, 21));
            listaDeEquipajesTurista21.Add(new Equipaje(2, cliente21.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista22 = new List<Equipaje>();
            listaDeEquipajesTurista22.Add(new Equipaje(0, cliente22.Documento, 3));
            listaDeEquipajesTurista22.Add(new Equipaje(1, cliente22.Documento, 21));
            listaDeEquipajesTurista22.Add(new Equipaje(2, cliente22.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista23 = new List<Equipaje>();
            listaDeEquipajesTurista23.Add(new Equipaje(0, cliente23.Documento, 3));
            listaDeEquipajesTurista23.Add(new Equipaje(1, cliente23.Documento, 21));
            listaDeEquipajesTurista23.Add(new Equipaje(2, cliente23.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista24 = new List<Equipaje>();
            listaDeEquipajesTurista24.Add(new Equipaje(0, cliente24.Documento, 3));
            listaDeEquipajesTurista24.Add(new Equipaje(1, cliente24.Documento, 21));
            listaDeEquipajesTurista24.Add(new Equipaje(2, cliente24.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista25 = new List<Equipaje>();
            listaDeEquipajesTurista25.Add(new Equipaje(0, cliente25.Documento, 3));
            listaDeEquipajesTurista25.Add(new Equipaje(1, cliente25.Documento, 21));
            listaDeEquipajesTurista25.Add(new Equipaje(2, cliente25.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista26 = new List<Equipaje>();
            listaDeEquipajesTurista26.Add(new Equipaje(0, cliente26.Documento, 3));
            listaDeEquipajesTurista26.Add(new Equipaje(1, cliente26.Documento, 21));
            listaDeEquipajesTurista26.Add(new Equipaje(2, cliente26.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista27 = new List<Equipaje>();
            listaDeEquipajesTurista27.Add(new Equipaje(0, cliente27.Documento, 3));
            listaDeEquipajesTurista27.Add(new Equipaje(1, cliente27.Documento, 21));
            listaDeEquipajesTurista27.Add(new Equipaje(2, cliente27.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista28 = new List<Equipaje>();
            listaDeEquipajesTurista28.Add(new Equipaje(0, cliente28.Documento, 3));
            listaDeEquipajesTurista28.Add(new Equipaje(1, cliente28.Documento, 21));
            listaDeEquipajesTurista28.Add(new Equipaje(2, cliente28.Documento, 21));


            List<Equipaje> listaDeEquipajesTurista29 = new List<Equipaje>();
            listaDeEquipajesTurista29.Add(new Equipaje(0, cliente29.Documento, 3));
            listaDeEquipajesTurista29.Add(new Equipaje(1, cliente29.Documento, 21));
            listaDeEquipajesTurista29.Add(new Equipaje(2, cliente29.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista30 = new List<Equipaje>();
            listaDeEquipajesTurista30.Add(new Equipaje(0, cliente30.Documento, 3));
            listaDeEquipajesTurista30.Add(new Equipaje(1, cliente30.Documento, 21));
            listaDeEquipajesTurista30.Add(new Equipaje(2, cliente30.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista31 = new List<Equipaje>();
            listaDeEquipajesTurista31.Add(new Equipaje(0, cliente31.Documento, 3));
            listaDeEquipajesTurista31.Add(new Equipaje(1, cliente31.Documento, 21));
            listaDeEquipajesTurista31.Add(new Equipaje(2, cliente31.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista32 = new List<Equipaje>();
            listaDeEquipajesTurista32.Add(new Equipaje(0, cliente32.Documento, 3));
            listaDeEquipajesTurista32.Add(new Equipaje(1, cliente32.Documento, 21));
            listaDeEquipajesTurista32.Add(new Equipaje(2, cliente32.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista33 = new List<Equipaje>();
            listaDeEquipajesTurista33.Add(new Equipaje(0, cliente33.Documento, 3));
            listaDeEquipajesTurista33.Add(new Equipaje(1, cliente33.Documento, 21));
            listaDeEquipajesTurista33.Add(new Equipaje(2, cliente33.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista34 = new List<Equipaje>();
            listaDeEquipajesTurista34.Add(new Equipaje(0, cliente34.Documento, 3));
            listaDeEquipajesTurista34.Add(new Equipaje(1, cliente34.Documento, 21));
            listaDeEquipajesTurista34.Add(new Equipaje(2, cliente34.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista35 = new List<Equipaje>();
            listaDeEquipajesTurista35.Add(new Equipaje(0, cliente35.Documento, 3));
            listaDeEquipajesTurista35.Add(new Equipaje(1, cliente35.Documento, 21));
            listaDeEquipajesTurista35.Add(new Equipaje(2, cliente35.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista36 = new List<Equipaje>();
            listaDeEquipajesTurista36.Add(new Equipaje(0, cliente36.Documento, 3));
            listaDeEquipajesTurista36.Add(new Equipaje(1, cliente36.Documento, 21));
            listaDeEquipajesTurista36.Add(new Equipaje(2, cliente36.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista37 = new List<Equipaje>();
            listaDeEquipajesTurista37.Add(new Equipaje(0, cliente37.Documento, 3));
            listaDeEquipajesTurista37.Add(new Equipaje(1, cliente37.Documento, 21));
            listaDeEquipajesTurista37.Add(new Equipaje(2, cliente37.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista38 = new List<Equipaje>();
            listaDeEquipajesTurista38.Add(new Equipaje(0, cliente38.Documento, 3));
            listaDeEquipajesTurista38.Add(new Equipaje(1, cliente38.Documento, 21));
            listaDeEquipajesTurista38.Add(new Equipaje(2, cliente38.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista39 = new List<Equipaje>();
            listaDeEquipajesTurista39.Add(new Equipaje(0, cliente39.Documento, 3));
            listaDeEquipajesTurista39.Add(new Equipaje(1, cliente39.Documento, 21));
            listaDeEquipajesTurista39.Add(new Equipaje(2, cliente39.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista40 = new List<Equipaje>();
            listaDeEquipajesTurista40.Add(new Equipaje(0, cliente40.Documento, 3));
            listaDeEquipajesTurista40.Add(new Equipaje(1, cliente40.Documento, 21));
            listaDeEquipajesTurista40.Add(new Equipaje(2, cliente40.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista41 = new List<Equipaje>();
            listaDeEquipajesTurista41.Add(new Equipaje(0, cliente41.Documento, 3));
            listaDeEquipajesTurista41.Add(new Equipaje(1, cliente41.Documento, 21));
            listaDeEquipajesTurista41.Add(new Equipaje(2, cliente41.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista42 = new List<Equipaje>();
            listaDeEquipajesTurista42.Add(new Equipaje(0, cliente42.Documento, 3));
            listaDeEquipajesTurista42.Add(new Equipaje(1, cliente42.Documento, 21));
            listaDeEquipajesTurista42.Add(new Equipaje(2, cliente42.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista43 = new List<Equipaje>();
            listaDeEquipajesTurista43.Add(new Equipaje(0, cliente43.Documento, 3));
            listaDeEquipajesTurista43.Add(new Equipaje(1, cliente43.Documento, 21));
            listaDeEquipajesTurista43.Add(new Equipaje(2, cliente43.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista44 = new List<Equipaje>();
            listaDeEquipajesTurista44.Add(new Equipaje(0, cliente44.Documento, 3));
            listaDeEquipajesTurista44.Add(new Equipaje(1, cliente44.Documento, 21));
            listaDeEquipajesTurista44.Add(new Equipaje(2, cliente44.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista45 = new List<Equipaje>();
            listaDeEquipajesTurista45.Add(new Equipaje(0, cliente45.Documento, 3));
            listaDeEquipajesTurista45.Add(new Equipaje(1, cliente45.Documento, 21));
            listaDeEquipajesTurista45.Add(new Equipaje(2, cliente45.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista46 = new List<Equipaje>();
            listaDeEquipajesTurista46.Add(new Equipaje(0, cliente46.Documento, 3));
            listaDeEquipajesTurista46.Add(new Equipaje(1, cliente46.Documento, 21));
            listaDeEquipajesTurista46.Add(new Equipaje(2, cliente46.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista47 = new List<Equipaje>();
            listaDeEquipajesTurista47.Add(new Equipaje(0, cliente47.Documento, 3));
            listaDeEquipajesTurista47.Add(new Equipaje(1, cliente47.Documento, 21));
            listaDeEquipajesTurista47.Add(new Equipaje(2, cliente47.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista48 = new List<Equipaje>();
            listaDeEquipajesTurista48.Add(new Equipaje(0, cliente48.Documento, 3));
            listaDeEquipajesTurista48.Add(new Equipaje(1, cliente48.Documento, 21));
            listaDeEquipajesTurista48.Add(new Equipaje(2, cliente48.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista49 = new List<Equipaje>();
            listaDeEquipajesTurista49.Add(new Equipaje(0, cliente49.Documento, 3));
            listaDeEquipajesTurista49.Add(new Equipaje(1, cliente49.Documento, 21));
            listaDeEquipajesTurista49.Add(new Equipaje(2, cliente49.Documento, 21));

            List<Equipaje> listaDeEquipajesTurista50 = new List<Equipaje>();
            listaDeEquipajesTurista50.Add(new Equipaje(0, cliente50.Documento, 3));
            listaDeEquipajesTurista50.Add(new Equipaje(1, cliente50.Documento, 21));
            listaDeEquipajesTurista50.Add(new Equipaje(2, cliente50.Documento, 21));

            //PASAJEROS PREMIUM
            //1
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR130BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR129BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR128BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR127BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR126BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR125BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR124BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR5123BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR122BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR121BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR120BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR110BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR118BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR117BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR116BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR115BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesPremium17, "FAR118BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesPremium18, "FAR117BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR116BUELV380ULROM", ClaseDePasajero.Premium));
            Airbus380BueRom.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR115BUELV380ULROM", ClaseDePasajero.Premium));





            //2
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR110BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR109BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR108BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR107BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR106BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR105BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR104BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR103BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR102BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR101BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR100BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR099BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR098BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR097BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR096BUELV777ULREC", ClaseDePasajero.Premium));
            Boeing777BueRec.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR095BUELV777ULREC", ClaseDePasajero.Premium));
            //3
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR130RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR129RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesPremium30, "FAR128RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesPremium40, "FAR127RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR126RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR125RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR124RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR123RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR122RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR121RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR120RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente42, listaDeEquipajesPremium42, "FAR119RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR118RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR117RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente45, listaDeEquipajesPremium45, "FAR116RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesPremium46, "FAR115RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR118RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR117RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR116RSALV767LABRC", ClaseDePasajero.Premium));
            Boeing767RsaBrc.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesPremium28, "FAR115RSALV767LABRC", ClaseDePasajero.Premium));
            //4

            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR82IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR81IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesPremium30, "FAR80IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesPremium40, "FAR79IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR78IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR77IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR76IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR75IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR74IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR73IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR72IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente42, listaDeEquipajesPremium42, "FAR71IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR70IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR69IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente45, listaDeEquipajesPremium45, "FAR68IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesPremium46, "FAR67IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR66IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR65IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR64IGRLV350LAPMY", ClaseDePasajero.Premium));
            AirbusA350IgrPmy.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesPremium28, "FAR63IGRLV350LAPMY", ClaseDePasajero.Premium));
            //5,,,
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR82PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR81PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR80PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente41, listaDeEquipajesPremium41, "FAR79PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR78PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR77PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR76PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR75PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR74PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR73PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR72PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR71PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR70PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR69PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente36, listaDeEquipajesPremium36, "FAR68PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente35, listaDeEquipajesPremium35, "FAR67PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente34, listaDeEquipajesPremium34, "FAR66PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente33, listaDeEquipajesPremium33, "FAR65PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesPremium23, "FAR64PMYLV330MASDE", ClaseDePasajero.Premium));
            Airbus330PmySde.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesPremium22, "FAR63PMYLV330MASDE", ClaseDePasajero.Premium));

            //6,,,
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR82SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR81SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR80SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente41, listaDeEquipajesPremium41, "FAR79SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR78SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR77SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR76SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR75SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR74SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR73SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR72SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR71SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR70SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR69SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente36, listaDeEquipajesPremium36, "FAR68SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente35, listaDeEquipajesPremium35, "FAR67SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente34, listaDeEquipajesPremium34, "FAR66SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente33, listaDeEquipajesPremium33, "FAR65SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesPremium23, "FAR64SDELV320MASLA", ClaseDePasajero.Premium));
            Airbus320SdeSla.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesPremium22, "FAR63SDELV320MASLA", ClaseDePasajero.Premium));

            //7,,,
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR121RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR120RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR119RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR118RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR117RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR116RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR115RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesPremium17, "FAR118RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesPremium18, "FAR117RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesPremium19, "FAR116RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR115RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR74RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR73RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR72RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR71RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR70RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR69RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente36, listaDeEquipajesPremium36, "FAR68RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente35, listaDeEquipajesPremium35, "FAR67RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente34, listaDeEquipajesPremium34, "FAR66RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente33, listaDeEquipajesPremium33, "FAR65RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesPremium23, "FAR64RELLV737MAPSS", ClaseDePasajero.Premium));
            Boeing737RelPss.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesPremium22, "FAR63RELLV737MAPSS", ClaseDePasajero.Premium));
            //8,,,
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR130BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR129BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR128BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR127BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR126BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR125BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR124BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR5123BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR122BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR121BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR120BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR119BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR118BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR117BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR116BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR115BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesPremium17, "FAR118BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesPremium18, "FAR117BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesPremium19, "FAR116BUELV380ULACA", ClaseDePasajero.Premium));
            Airbus380BueAca.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR115BUELV380ULACA", ClaseDePasajero.Premium));

            //9,,,
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesPremium1, "FAR110BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesPremium2, "FAR109BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesPremium3, "FAR108BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesPremium4, "FAR107BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesPremium5, "FAR106BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesPremium6, "FAR105BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesPremium7, "FAR104BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesPremium8, "FAR103BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesPremium9, "FAR102BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR101BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesPremium11, "FAR100BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesPremium12, "FAR099BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesPremium13, "FAR098BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesPremium14, "FAR097BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesPremium15, "FAR096BUELV777ULMIA", ClaseDePasajero.Premium));
            Boeing777BueMia.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesPremium16, "FAR095BUELV777ULMIA", ClaseDePasajero.Premium));

            //10,,,
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR130SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR129SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesPremium30, "FAR128SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesPremium40, "FAR127SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR126SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR125SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR124SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR123SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR122SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR121SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR120SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente42, listaDeEquipajesPremium42, "FAR119SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR118SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR117SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente45, listaDeEquipajesPremium45, "FAR116SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesPremium46, "FAR115SLALV767LACOR", ClaseDePasajero.Premium));
            Boeing767SlaCor.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR118SLALV767LACOR", ClaseDePasajero.Premium));

            //11,,,
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesPremium10, "FAR82JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesPremium20, "FAR81JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesPremium30, "FAR80JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesPremium40, "FAR79JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente50, listaDeEquipajesPremium50, "FAR78JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesPremium49, "FAR77JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesPremium47, "FAR76JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesPremium48, "FAR75JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesPremium39, "FAR74JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesPremium21, "FAR73JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesPremium31, "FAR72JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente42, listaDeEquipajesPremium42, "FAR71JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesPremium43, "FAR70JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente44, listaDeEquipajesPremium44, "FAR69JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente45, listaDeEquipajesPremium45, "FAR68JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesPremium46, "FAR67JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente37, listaDeEquipajesPremium37, "FAR66JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesPremium38, "FAR65JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesPremium29, "FAR64JUJLV350LAMDZ", ClaseDePasajero.Premium));
            AirbusA350JujMdz.ListaDePasajerosPremium.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesPremium28, "FAR63JUJLV350LAMDZ", ClaseDePasajero.Premium));



            //PASAJEROS TURISTA

            //1
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR524BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR523BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesTurista31, "FAR522BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente41, listaDeEquipajesTurista41, "FAR521BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesTurista49, "FAR520BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesTurista46, "FAR519BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesTurista47, "FAR518BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesTurista48, "FAR517BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesTurista39, "FAR516BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente38, listaDeEquipajesTurista38, "FAR515BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR514BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR513BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR512BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente24, listaDeEquipajesTurista24, "FAR511BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente25, listaDeEquipajesTurista25, "FAR510BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente26, listaDeEquipajesTurista26, "FAR509BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente27, listaDeEquipajesTurista27, "FAR508BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesTurista28, "FAR507BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesTurista29, "FAR506BUELV380ULROM", ClaseDePasajero.Turista));
            Airbus380BueRom.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesTurista40, "FAR505BUELV380ULROM", ClaseDePasajero.Turista));

            //2
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR450BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR449BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR448BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente24, listaDeEquipajesTurista24, "FAR447BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente25, listaDeEquipajesTurista25, "FAR446BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente26, listaDeEquipajesTurista26, "FAR445BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente27, listaDeEquipajesTurista27, "FAR444BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesTurista28, "FAR443BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesTurista29, "FAR442BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesTurista30, "FAR441BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesTurista31, "FAR440BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente32, listaDeEquipajesTurista32, "FAR439BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente33, listaDeEquipajesTurista33, "FAR438BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente34, listaDeEquipajesTurista34, "FAR437BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente35, listaDeEquipajesTurista35, "FAR436BUELV777ULREC", ClaseDePasajero.Turista));
            Boeing777BueRec.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente36, listaDeEquipajesTurista36, "FAR435BUELV777ULREC", ClaseDePasajero.Turista));


            //3
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR123RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR121RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR120RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116RSALV767LABRC", ClaseDePasajero.Turista));
            Boeing767RsaBrc.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR115RSALV767LABRC", ClaseDePasajero.Turista));
            //4,,,
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR123IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR121IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR120IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350IgrPmy.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR115IGRLV350LADRY", ClaseDePasajero.Turista));

            //5,,,
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR123PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesTurista10, "FAR121PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente42, listaDeEquipajesTurista42, "FAR120PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR119PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR118PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente25, listaDeEquipajesTurista25, "FAR117PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116PMYLV330MASDE", ClaseDePasajero.Turista));
            Airbus330PmySde.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente43, listaDeEquipajesTurista43, "FAR115PMYLV330MASDE", ClaseDePasajero.Turista));


            //6,,,
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR5123SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesTurista10, "FAR121SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR120SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116SDELV320MASLA", ClaseDePasajero.Turista));
            Airbus320SdeSla.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesTurista20, "FAR115SDELV320MASLA", ClaseDePasajero.Turista));



           //7,,,
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR5123RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente10, listaDeEquipajesTurista10, "FAR121RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR120RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116RELLV737MAPSS", ClaseDePasajero.Turista));
            Boeing737RelPss.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente20, listaDeEquipajesTurista20, "FAR115RELLV737MAPSS", ClaseDePasajero.Turista));


            //8,,,
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR524BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR523BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesTurista31, "FAR522BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente41, listaDeEquipajesTurista41, "FAR521BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente49, listaDeEquipajesTurista49, "FAR520BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente46, listaDeEquipajesTurista46, "FAR519BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente47, listaDeEquipajesTurista47, "FAR518BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente48, listaDeEquipajesTurista48, "FAR517BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente39, listaDeEquipajesTurista39, "FAR516BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesTurista30, "FAR515BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR514BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR513BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR512BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente24, listaDeEquipajesTurista24, "FAR511BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente25, listaDeEquipajesTurista25, "FAR510BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente26, listaDeEquipajesTurista26, "FAR509BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente27, listaDeEquipajesTurista27, "FAR508BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesTurista28, "FAR507BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesTurista29, "FAR506BUELV380ULACA", ClaseDePasajero.Turista));
            Airbus380BueAca.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente40, listaDeEquipajesTurista40, "FAR505BUELV380ULACA", ClaseDePasajero.Turista));

            //9,,,

            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente21, listaDeEquipajesTurista21, "FAR450BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR449BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR448BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente24, listaDeEquipajesTurista24, "FAR447BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente25, listaDeEquipajesTurista25, "FAR446BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente26, listaDeEquipajesTurista26, "FAR445BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente27, listaDeEquipajesTurista27, "FAR444BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente28, listaDeEquipajesTurista28, "FAR443BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente29, listaDeEquipajesTurista29, "FAR442BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente30, listaDeEquipajesTurista30, "FAR441BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente31, listaDeEquipajesTurista31, "FAR440BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente32, listaDeEquipajesTurista32, "FAR439BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente33, listaDeEquipajesTurista33, "FAR438BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente34, listaDeEquipajesTurista34, "FAR437BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente35, listaDeEquipajesTurista35, "FAR436BUELV777ULMIA", ClaseDePasajero.Turista));
            Boeing777BueMia.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente36, listaDeEquipajesTurista36, "FAR435BUELV777ULMIA", ClaseDePasajero.Turista));
            //10,,,

            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR123SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR121SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR120SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente17, listaDeEquipajesTurista17, "FAR118SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente18, listaDeEquipajesTurista18, "FAR117SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente19, listaDeEquipajesTurista19, "FAR116SLALV767LACOR", ClaseDePasajero.Turista));
            Boeing767SlaCor.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente23, listaDeEquipajesTurista23, "FAR115SLALV767LACOR", ClaseDePasajero.Turista));


            //11,,,
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente1, listaDeEquipajesTurista1, "FAR130IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente2, listaDeEquipajesTurista2, "FAR129IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente3, listaDeEquipajesTurista3, "FAR128IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente4, listaDeEquipajesTurista4, "FAR127IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente5, listaDeEquipajesTurista5, "FAR126IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente6, listaDeEquipajesTurista6, "FAR125IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente7, listaDeEquipajesTurista7, "FAR124IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente8, listaDeEquipajesTurista8, "FAR123IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente9, listaDeEquipajesTurista9, "FAR122IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente11, listaDeEquipajesTurista11, "FAR121IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente22, listaDeEquipajesTurista22, "FAR120IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente12, listaDeEquipajesTurista12, "FAR119IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente13, listaDeEquipajesTurista13, "FAR118IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente14, listaDeEquipajesTurista14, "FAR117IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente15, listaDeEquipajesTurista15, "FAR116IGRLV350LADRY", ClaseDePasajero.Turista));
            AirbusA350JujMdz.ListaDePasajerosTurista.Add(new Pasajero((Cliente)cliente16, listaDeEquipajesTurista16, "FAR115IGRLV350LADRY", ClaseDePasajero.Turista));




            //PASAJES PREMIUM DENTRO DEL VUELO

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

            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente10.Documento, cliente10.Nombre, cliente10.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente11.Documento, cliente11.Nombre, cliente11.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIBUELV380ULROM", "BUELV380ULROM", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, Airbus380BueRom.Origen,
                Airbus380BueRom.HoraDePartida, Airbus380BueRom.Destino, Airbus380BueRom.HoraDeLlegada, "Turista", 1300));






            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, Boeing777BueRec.Origen,
            Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajePremium("PREMIBUELV777ULREC", "BUELV777ULREC", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, Boeing777BueRec.Origen,
                Boeing777BueRec.HoraDePartida, Boeing777BueRec.Destino, Boeing777BueRec.HoraDeLlegada, "Premium", 1300));



            //PASAJES TURISTAS DENTRO DEL VUELO

            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente1.Documento, cliente1.Nombre, cliente1.Apellido, Boeing737RelPss.Origen,
                     Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente2.Documento, cliente2.Nombre, cliente2.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente3.Documento, cliente3.Nombre, cliente3.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente4.Documento, cliente4.Nombre, cliente4.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente5.Documento, cliente5.Nombre, cliente5.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente6.Documento, cliente6.Nombre, cliente6.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente7.Documento, cliente7.Nombre, cliente7.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente8.Documento, cliente8.Nombre, cliente8.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente9.Documento, cliente9.Nombre, cliente9.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente10.Documento, cliente10.Nombre, cliente10.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente11.Documento, cliente11.Nombre, cliente11.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIRELLV737MAPSS", "RELLV737MAPSS", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, Boeing737RelPss.Origen,
                Boeing737RelPss.HoraDePartida, Boeing737RelPss.Destino, Boeing737RelPss.HoraDeLlegada, "Turista", 1100));


            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente1.Documento, cliente1.Nombre, cliente1.Apellido, AirbusA350IgrPmy.Origen,
                     AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente2.Documento, cliente2.Nombre, cliente2.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente3.Documento, cliente3.Nombre, cliente3.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente4.Documento, cliente4.Nombre, cliente4.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente5.Documento, cliente5.Nombre, cliente5.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente6.Documento, cliente6.Nombre, cliente6.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente7.Documento, cliente7.Nombre, cliente7.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente8.Documento, cliente8.Nombre, cliente8.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente9.Documento, cliente9.Nombre, cliente9.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente10.Documento, cliente10.Nombre, cliente10.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente11.Documento, cliente11.Nombre, cliente11.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Premium", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente12.Documento, cliente12.Nombre, cliente12.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente13.Documento, cliente13.Nombre, cliente13.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente14.Documento, cliente14.Nombre, cliente14.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente15.Documento, cliente15.Nombre, cliente15.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente16.Documento, cliente16.Nombre, cliente16.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente17.Documento, cliente17.Nombre, cliente17.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente18.Documento, cliente18.Nombre, cliente18.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente19.Documento, cliente19.Nombre, cliente19.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));
            GestionDeAerolinea.ListaDePasajes.Add(new PasajeTurista("TURIIGRLV350LAPMY", "IGRLV350LAPMY", cliente20.Documento, cliente20.Nombre, cliente20.Apellido, AirbusA350IgrPmy.Origen,
                AirbusA350IgrPmy.HoraDePartida, AirbusA350IgrPmy.Destino, AirbusA350IgrPmy.HoraDeLlegada, "Turista", 1100));








        }



        public static void HarcodeoDeDestinos()
        {
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(0, "RSA Santa Rosa");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1, "BRCBariloche");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(2, "CNQ Corrientes");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(3, "COR Córdoba");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(4, "JUJ Jujuy");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(5, "MDZ Mendoza");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(6, "NQN Neuquén");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(7, "PSS Posadas");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(8, "IGR Iguazú");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(9, "SLA Salta");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(10, "SDE Santiago del Estero");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(11, "REL Trelew");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(12, "TUC Tucumán");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(13, "PMY Puerto Madryn");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(14, "USH Ushuaia");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(15, "BUE Buenos Aires");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1000, "REC Recife(Brasil)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1001, "ROM Roma(Italia)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1002, "ACA Acapulco(Mexico)");
            GestionDeAerolinea.DiccionarioDeAeropuertos.Add(1003, "MIA Miami(EEUU)");



        }




        public static void HarcodeoDePasajeros()
        {
            for (int i = 0; i < GestionDeAerolinea.ListaDeVuelos.Count; i++)
            {

                for (int j = 0; j < GestionDeAerolinea.ListaDePasajeros.Count; j++)

                {
                    if (GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo == GestionDeAerolinea.ListaDePasajeros[j].CodigoDeVuelo &&
                        GestionDeAerolinea.ListaDePasajeros[j].ClaseDePasajero1 == ClaseDePasajero.Premium)
                        GestionDeAerolinea.ListaDeVuelos[i].ListaDePasajerosPremium.Add(GestionDeAerolinea.ListaDePasajeros[j]);
                    else
                    {
                        if (GestionDeAerolinea.ListaDeVuelos[i].CodigoDeVuelo == GestionDeAerolinea.ListaDePasajeros[j].CodigoDeVuelo &&
                        GestionDeAerolinea.ListaDePasajeros[j].ClaseDePasajero1 == ClaseDePasajero.Turista)
                        {
                            GestionDeAerolinea.ListaDeVuelos[i].ListaDePasajerosTurista.Add(GestionDeAerolinea.ListaDePasajeros[j]);

                        }
                    }




                }
            }


        }





    }
}
