using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Obligatorio_1
{
    internal class Socio
    {
        // ATRIBUTOS
        private int id_socio;
        private String nombre;
        private List<Actividad> socioActividades;

        // CONSTRUCTOR
        public Socio(int id_socio, string nombre)
        {
            this.id_socio = id_socio;
            this.nombre = nombre;
            this.socioActividades = new List<Actividad>();
        }

        // SETTERS Y GETTERS
        public String getNombre()
        {
            return this.nombre;
        }
        public int getId()
        {
            return this.id_socio;
        }

        
        // CHEQUEAMOS CUPO DE ACTIVIDADES DISPONIBLE PARA EL SOCIO
        public bool chequeaCupoActividad()
        {
            // CHEQUEAMOS QUE HAYA CUPO DISPONIBLE
            bool hayCupo = false;
            if (this.socioActividades.Count < 3)
            {
                hayCupo = true;
            }
            else
            {
                mensajeSistema("ERROR", "TOPE DE (3) ACTIVIDADES ALCANZADO");
                Console.WriteLine();
                this.listarActividades();
            }
            return hayCupo;
        }

        public void agregarActividad(Actividad actividad)
        {
            this.socioActividades.Add(actividad);
   
        }

        public void listarActividades()
        {
            Console.WriteLine("ACTIVIDADES DEL SOCIO: "+ this.nombre);
            foreach (Actividad actividad in socioActividades)
            {
                Console.WriteLine(actividad.ToString());    
            }
        }

        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }




        // MENSAJE DEL SISTEMA AL USUARIO
        public void mensajeSistema(string mensaje, string mensaje2)
        {
            int tam_espacio1 = (71 - mensaje.Length) / 2;
            string espacio1 = new string(' ', tam_espacio1);
            int tam_espacio2 = (71 - mensaje2.Length) / 2;
            string espacio2 = new string(' ', tam_espacio2);
            Console.WriteLine("    ************************************************************************");
            Console.WriteLine("    *" + espacio1 + mensaje + espacio1 + "*");
            Console.WriteLine("    *" + espacio2 + mensaje2 + espacio2 + "*");
            Console.WriteLine("    ************************************************************************");
            Console.WriteLine();
        }


        // SOBRECARGA
        public override string ToString()
        {
            return "Id: " + id_socio + " / Nombre: " + nombre;

        }
    }
}
