using System;
using System.Collections.Generic;
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



        // AGREGAR ALUMNOS
        public void agregarAlumno(int id_alumno)
        {
            // CHEQUEAMOS QUE HAYA CUPO DISPONIBLE
            if (this.alumnos.Count < cupo)
            {
                this.alumnos.Add(id_alumno);
                mensajeSistema("INSCRIPCION EXITOSA", "CUPO RESERVADO EN LA ACTIVIDAD");
            }
            else
            {
                mensajeSistema("","ERROR. CUPO LLENO");
            }
        }

        // MOSTRAR ALUMNOS
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



        // SOBRECARGA
        public override string ToString()
        {
            return "Id: " + id_actividad + " / Actividad: " + nombre + " / Cupo: " + cupo;
        }
    }
}
