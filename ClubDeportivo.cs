using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TP_Obligatorio_1
{
    internal class ClubDeportivo
    {
        // ATRIBUTOS
        public List<Actividad> actividades;
        public List<Socio> socios;

        // CONSTRUCTOR
        public ClubDeportivo()
        {
            this.actividades = new List<Actividad>();
            this.socios = new List<Socio>();
        }

        /*
         *            ACTIVIADES
         */


        // BUSCAR ACTIVIDAD DENTRO DE LA LISTA DEL CLUB
        public Actividad buscarActividad(string nombre)
        {
            Actividad actividadBuscada = null;
            int i = 0;
            while (i < actividades.Count && !actividades[i].getNombre().Equals(nombre))
                i++;
            if (i != actividades.Count)
                actividadBuscada = actividades[i];
            return actividadBuscada;
        }


        // AGREGAR ACTIVIDADES DENTRO DE LA LISTA DEL CLUB
        public bool agregarActividad(int id_actividad, string nombre, int cupo)
        {
            bool resultado = false;
            Actividad actividad;
            actividad = buscarActividad(nombre);
            if (actividad == null)
            {
                actividad = new Actividad(id_actividad, nombre, cupo);
                actividades.Add(actividad);
                mensajeSistema(nombre, "ACTIVIDAD AGREGADA CON EXITO");
                resultado = true;
            }
            else { mensajeSistema(nombre, "ERROR ACTIVIDAD YA EXISTE"); }
            return resultado;
        }

        // LISTAR LAS ACTIVIDADES DEL CLUB
        public void listarActividades()
        {
            Console.WriteLine("LISTADO DE ACTIVIDADES:");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var actividad in actividades)
            {
                Console.WriteLine(actividad);
            }
            Console.WriteLine("----------------------------------------------------------------------");
        }

        // ELIMINAR ACTIVIDAD DENTRO DE LA LISTA DEL CLUB   
        public bool eliminarActividad(string nombre)
        {
            bool resultado = false;
            Actividad actividad;
            actividad = buscarActividad(nombre);
            if (actividad != null)
            {
                actividades.Remove(actividad);
                mensajeSistema(nombre, "ACTIVIDAD ELIMINADA CON EXITO");
                resultado = true;
            }
            else { mensajeSistema(nombre, "ERROR ACTIVIDAD NO ENCONTRADA"); }
            return resultado;
        }


     

        /*
         *            SOCIOS
         */




        // BUSCAR SOCIO DENTRO DE LA LISTA DEL CLUB
        public Socio buscarSocio(string nombre)
        {
            Socio socioBuscado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].getNombre().Equals(nombre))
                i++;
            if (i != socios.Count)
                socioBuscado = socios[i];
            return socioBuscado;
        }

        public Socio buscarSocio(int id_socio)
        {
            Socio socioBuscado = null;
            int i = 0;
            while (i < socios.Count && !socios[i].getId().Equals(id_socio))
                i++;
            if (i != socios.Count)
                socioBuscado = socios[i];
            return socioBuscado;
        }


        // AGREGAR SOCIO DENTRO DE LA LISTA DEL CLUB
        public bool altaSocio(int id_socio, string nombre)
        {
            bool resultado = false;
            Socio socio;
            socio = buscarSocio(nombre);
            if (socio == null)
            {
                socio = new Socio(id_socio, nombre);
                socios.Add(socio);
                mensajeSistema(nombre, "SOCIO AGREGADO CON EXITO");
                resultado = true;
            }
            else { mensajeSistema(nombre, "ERROR SOCIO YA EXISTE"); }
            return resultado;
        }

        // LISTAR LAS SOCIOS DEL CLUB
        public void listarSocios()
        {
            Console.WriteLine("LISTADO DE SOCIOS:");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (var socio in socios)
            {
                Console.WriteLine(socio);
            }
            Console.WriteLine("----------------------------------------------------------------------");
        }

        // ELIMINAR SOCIO DENTRO DE LA LISTA DEL CLUB   
        public bool eliminarSocio(string nombre)
        {
            bool resultado = false;
            Socio socio;
            socio = buscarSocio(nombre);
            if (socio != null)
            {
                socios.Remove(socio);
                mensajeSistema(nombre, "SOCIO ELIMINADO CON EXITO");
                resultado = true;
            }
            else { mensajeSistema(nombre, "ERROR SOCIO NO ENCONTRADO"); }
            return resultado;
        }
        /*
           *            INSCRIPCION
           */

        public String inscribirActividad(int id_socio, string actividad)
        {
            string respuesta = "";
            Actividad actividadBuscada = buscarActividad(actividad);
            Socio socioBuscado = buscarSocio(id_socio);

            if (actividadBuscada != null && socioBuscado != null)
            {
                Console.WriteLine("eeeeyyyyyy");
                Console.WriteLine(actividadBuscada);
                actividadBuscada.agregarAlumno(id_socio);
                actividadBuscada.mostrarAlumnos();

            }
            return respuesta;
        }

        // MENSAJE DEL SISTEMA AL USUARIO
        public void mensajeSistema(string mensaje, string mensaje2)
        {
            int tam_espacio1 = (70 - mensaje.Length) / 2;
            string espacio1 = new string(' ', tam_espacio1);
            int tam_espacio2 = (70 - mensaje2.Length) / 2;
            string espacio2 = new string(' ', tam_espacio2);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*" + espacio1 + mensaje + espacio1 + "*");
            Console.WriteLine("*" + espacio2 + mensaje2 + espacio2 + "*");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine();
        }



    }
}
