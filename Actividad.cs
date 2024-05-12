using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace TP_Obligatorio_1
{
    internal class Actividad
    {
        // ATRIBUTOS
        private int id_actividad;
        private String nombre;
        private int cupo;
        private List<int> alumnos;

        // CONSTRUCTOR
        public Actividad(int id_actividad, string nombre, int cupo)
        {
            this.id_actividad = id_actividad;
            this.nombre = nombre;
            this.cupo = cupo;
            this.alumnos = new List<int>();
        }

        // SETTERS Y GETTERS
        public String getNombre()
        {
            return this.nombre;  
        }

        // CHEQUEAMOS CUPO DE ALUMNOS DISPONIBLE EN LAS ACTIVIDAD
        public bool chequeaCupoActividad()
        {
            // CHEQUEAMOS QUE HAYA CUPO DISPONIBLE
            bool hayCupo = false;
            if (this.alumnos.Count < cupo)
            {
                hayCupo = true;
            }
            else
            {
                mensajeSistema("ERROR","CUPO LLENO");
            }
            return hayCupo;
        }

        public void agregarActividad(int id_alumno)
        {
                this.alumnos.Add(id_alumno);
                // mensajeSistema("INSCRIPCION  EXITOSA", "CUPO RESERVADO EN LA ACTIVIDAD");
        }




        // MOSTRAR ALUMNOS INSCRIPTOS EN LAS ACTIVIDADES
        public void mostrarAlumnos()
        {
            foreach (var alumno in alumnos)
            {
                Console.WriteLine(alumno);

            }
        }

        // MENSAJE DEL SISTEMA AL USUARIO
        public void mensajeSistema(string mensaje, string mensaje2)
        {
            int tam_espacio1 = (71 - mensaje.Length) / 2;
            string espacio1 = new string(' ', tam_espacio1);
            int tam_espacio2 = (71 - mensaje2.Length) / 2;
            string espacio2 = new string(' ', tam_espacio2);
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*" + espacio1 + mensaje + espacio1 + "*");
            Console.WriteLine("*" + espacio2 + mensaje2 + espacio2 + "*");
            Console.WriteLine("************************************************************************");
            Console.WriteLine();
        }



        // SOBRECARGA
        public override string ToString()
        {
            return "Id: " + id_actividad + " / Actividad: " + nombre + " / Cupo: " + cupo;
        }
    }
}
