using System;
using System.Collections.Generic;

namespace Logica
{
    public class GestionDeAerolinea
    {

        private static List<Pasajero> listaDePasajeros;
        private static List<Usuario> listaDeUsuarios;


        static GestionDeAerolinea()
        {
            listaDePasajeros = new List<Pasajero>();
            listaDeUsuarios = new List<Usuario>();
        }

        public static List<Pasajero> ListaDePasajeros { get => listaDePasajeros; }
        public static List<Usuario> ListaDeUsuarios { get => listaDeUsuarios; }




        public static Pasajero obtenerPasajeroPorDni(string dni)
        {
            Pasajero pasajero = null;
            for (int i = 0; i < GestionDeAerolinea.listaDePasajeros.Count; i++)
            {
                if (dni == listaDePasajeros[i].Documento)
                {
                    pasajero = listaDePasajeros[i];
                    break;
                }
            }
            return pasajero;
        }


        //public static Pasajero ModificarPasajero(Pasajero pasajero)
        //{
        //    if (pasajero is not null)
        //    {

        //    }
        //}








        public static bool CargarPasajeroEnLineaAerea(Pasajero pasajero)
        {

            if (!GestionDeAerolinea.ValidarPasajeroEnLineaAerea(pasajero.Documento))
            {
                GestionDeAerolinea.ListaDePasajeros.Add(pasajero);
                return true;
            }
            else
                throw new Exception("Pasajero ya cargado");

        }


        public static void ModificarPasajeroEnLineaAerea(Pasajero pasajero, string documento)
        {
            int flag = 0;

            if (pasajero is not null)
            {
                for (int i = 0; i < listaDePasajeros.Count; i++)
                {
                    if (listaDePasajeros[i].Documento == documento)
                    {
                        listaDePasajeros[i] = pasajero;
                        break;
                    }else
                    {
                        flag = 1;
                    }

                }
                if (flag ==1)
                {
                    throw new("Pasajero no encontrado en la lista,\n desea cargarlo con un nuevo DNI?");
                }
            }
            else
                throw new Exception("Pasajero incompleto");

        }




        public static bool ValidarPasajeroEnLineaAerea(string dni)
        {


            foreach (Pasajero item in GestionDeAerolinea.listaDePasajeros)
            {

                if (item.Documento == dni)
                {
                    return true;
                }

            }
            return false;

        }

        public static void HarcodeoPasajeros()
        {
            Pasajero pasajero1 = new Pasajero("Sebastian", "Viazzo", Persona.TipoDocumento.DNI, "34262507", "33", "argentino", new DateTime(1988, 12, 17), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero2 = new Pasajero("Lucas", "Rodriguez", Persona.TipoDocumento.DNI, "35003321", "30", "argentino", new DateTime(1990, 07, 15), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero3 = new Pasajero("Marina", "Rodriguez", Persona.TipoDocumento.DNI, "38000132", "33", "argentino", new DateTime(1992, 04, 22), Persona.TipoDeSexo.Femenino);
            Pasajero pasajero4 = new Pasajero("Ignacio", "Smirlian", Persona.TipoDocumento.Pasaporte, "37213986", "25", "Italiano", new DateTime(1998, 06, 10), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero5 = new Pasajero("Thierry", "Henry", Persona.TipoDocumento.Pasaporte, "34222503", "48", "Frances", new DateTime(1974, 03, 19), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero6 = new Pasajero("Diego", "Maradona", Persona.TipoDocumento.DNI, "24323788", "60", "argentino", new DateTime(1960, 01, 15), Persona.TipoDeSexo.Masculino);
            Pasajero pasajero7 = new Pasajero("Lionel", "Messi", Persona.TipoDocumento.DNI, "32198605", "35", "argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.ListaDePasajeros.Add(pasajero1);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero2);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero3);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero4);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero5);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero6);
            GestionDeAerolinea.ListaDePasajeros.Add(pasajero7);
        }

        public static void HarcodeoDeUsuarios()
        {
            Usuario usuario1 = new Usuario("LuquitaPeposo", "Rufruf123", "Lucas", "Rodriguez", "1001", Persona.TipoDocumento.DNI, "35232444", "30", "Argentino", new DateTime(1985, 11, 15), Persona.TipoDeSexo.Masculino);

            GestionDeAerolinea.listaDeUsuarios.Add(usuario1);



        }



        public static bool ValidarUsuario(string user)
        {

            foreach (Usuario item in GestionDeAerolinea.listaDeUsuarios)
            {
                if (item.User == user)
                {
                    return true;
                }

            }

            throw new Exception("Usuario Incorrecto");


        }









    }




}

