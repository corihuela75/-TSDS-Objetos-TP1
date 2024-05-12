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
        
        // CONSTRUCTOR
        public Socio(int id_socio, string nombre)
        {
            this.id_socio = id_socio;
            this.nombre = nombre;
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

        // MENSAJE DEL SISTEMA AL USUARIO
        public void mensajeSistema(string mensaje)
        {
            int tam_espacio = (70 - mensaje.Length) / 2;
            Console.WriteLine(tam_espacio);
            string espacio = new string(' ', tam_espacio);
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("*" + espacio + mensaje + espacio + "*");
            Console.WriteLine("***********************************************************************");
        }

        // SOBRECARGA
        public override string ToString()
        {
            return "Id: " + id_socio + " / Nombre: " + nombre;

        }
    }
}
