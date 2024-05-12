using System;
using System.Collections.Generic;

namespace TP_Obligatorio_1
{
    internal class Test
    {
        /*
        Tipo: Trabajo práctico obligatorio - Entrega en la semana 7
        Formato: TP1_ComX_GrupoX_Apellido1_Apellido2_Apellido3_Apellido4_Apellido5.zip o rar.
        
        MUY IMPORTANTE RESPETAR EL NOMBRE DE LA ENTREGA PARA SU POSTERIOR ORGANIZACIÓN Y SEGUIMIENTO.
        
            Entrega un representante del equipo, respetando los que registraron oportunamente en la planilla
           (corregirla de ser necesario). Envío de todos los archivos correspondientes DENTRO de un archivo
           comprimido, indicando la comisión, el número del grupo y los apellidos de los integrantes del mismo.
        
        Objetivo:  
        
        Descripción:

            Usando el ejemplo de la biblioteca visto durante la semana en la explicación, el club deportivo
            administra una colección de socios registrados.
     OK     - De los socios, se conoce su nombre y número de identificación.
            - Cada socio puede participar en un máximo de 3 actividades deportivas simultáneamente.
            - Cuando un socio se inscribe en una actividad deportiva, se reserva un cupo para él en esa actividad.
            Es decir, se debe retirar el cupo de la lista de cupos disponibles de la actividad deportiva para
            asignarlo al socio inscripto.
        
        Para hacer:

            - Realizar el UML considerando el ejemplo de la Biblioteca pero incluyendo además los nuevos requerimientos.

     OK     - Desarrollar el método "altaSocio" que, pasándole los parámetros necesarios, registre a un socio en la
            lista de socios si no estaba previamente registrado.

     OK     - Desarrollar el método "inscribirActividad" de la clase ClubDeportivo, el cual recibe por parámetro el
            nombre de la actividad deportiva y el número de identificación del socio que desea inscribirse, y retorna
            una cadena de texto con los posibles valores:

     OK         - "INSCRIPCIÓN EXITOSA" (en este caso, el socio se ha inscrito correctamente en la actividad deportiva
                    y se ha reservado un cupo para él).
     OK         - "ACTIVIDAD INEXISTENTE" (cuando la actividad deportiva no se encuentra dentro de la colección de 
                    actividades en el club deportivo).
     OK         - "TOPE DE ACTIVIDADES ALCANZADO" (cuando el socio ya participa en tres actividades deportivas).
     OK         - "SOCIO INEXISTENTE" (cuando el socio no se encuentra registrado dentro de la colección de socios en
                    el club deportivo).
         */




        static void Main(string[] args)
        {
            
            Actividad act1 = new Actividad(1, "Futbol", 50);
            Socio soc1 = new Socio(1, "Cristian");

            // CREAMOS EL CLUB
            Console.WriteLine();
            Console.WriteLine("---> CREAMOS EL CLUB");
            ClubDeportivo miClub = new ClubDeportivo();

            // AGREGAMOS 5 ACTIVIDADES AL CLUB
            Console.WriteLine();
            Console.WriteLine("---> AGREGAMOS 5 ACTIVIDADES AL CLUB");
            miClub.agregarActividad(1, "Futbol", 2);
            miClub.agregarActividad(2, "Basquet", 20);
            miClub.agregarActividad(3, "Zumba", 50);
            miClub.agregarActividad(4, "Funcional", 40);
            miClub.agregarActividad(5, "Pilates", 15);

            // AGREGAMOS UNA ACTIVIDAD REPETIDA PARA COMPROBAR QUE NO NOS DEJE
            Console.WriteLine();
            Console.WriteLine("---> AGREGAMOS UNA ACTIVIDAD REPETIDA PARA COMPROBAR QUE NO NOS DEJE");
            miClub.agregarActividad(1, "Futbol", 30);
            Console.WriteLine();

            // LISTAMOS LAS ACTIVIDADES DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> LISTAMOS LAS ACTIVIDADES DEL CLUB");
            miClub.listarActividades();
            Console.WriteLine();

            // ELIMINAMOS UNA ACTIVIDAD DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> ELIMINAMOS UNA ACTIVIDAD DEL CLUB");
            miClub.eliminarActividad("Zumba");
            Console.WriteLine();

            // VOLVEMOS A LISTAR LAS ACTIVIDADES DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> VOLVEMOS A LISTAR LAS ACTIVIDADES DEL CLUB");
            miClub.listarActividades();
            Console.WriteLine();

            // AGREGAMOS 5 SOCIOS AL CLUB
            Console.WriteLine();
            Console.WriteLine("---> AGREGAMOS 5 SOCIOS AL CLUB");
            miClub.altaSocio(1, "Cristian Orihuela");
            miClub.altaSocio(2, "Jazmin de Valle");
            miClub.altaSocio(3, "Hector Cidito");
            miClub.altaSocio(4, "Laura Tanga");
            miClub.altaSocio(5, "Lucas Pozo");
            Console.WriteLine();

            // LISTAMOS LOS SOCIOS DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> LISTAMOS LOS SOCIOS DEL CLUB");
            miClub.listarSocios();
            Console.WriteLine();

            // ELIMINAMOS UN SOCIO DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> ELIMINAMOS UN SOCIO DEL CLUB");
            miClub.eliminarSocio("Lucas Pozo");
            Console.WriteLine();

            // VOLVEMOS A LISTAR LOS SOCIOS DEL CLUB
            Console.WriteLine();
            Console.WriteLine("---> VOLVEMOS A LISTAR LOS SOCIOS DEL CLUB");
            miClub.listarSocios();
            Console.WriteLine();

            // INSCRIBIMOS A SOCIOS EN UNA ACTIVIDAD
            Console.WriteLine("---> INSCRIBIMOS A SOCIOS EN UNA ACTIVIDAD");
            miClub.inscribirActividad(1, "Basquet");
            miClub.inscribirActividad(2, "Futbol");
            miClub.inscribirActividad(3, "Futbol");
            miClub.inscribirActividad(3, "Basquet");
            miClub.inscribirActividad(3, "Funcional");
            // EL CUPO DE FUTBOL ES 2
            Console.WriteLine("---> EL CUPO DE FUTBOL ES 2");
            miClub.inscribirActividad(4, "Futbol");

            // INSCRIBIMOS A UN SOCIO EN UN ACTIVIDAD QUE NO EXISTE
            Console.WriteLine();
            Console.WriteLine("---> INSCRIBIMOS A UN SOCIO EN UN ACTIVIDAD QUE NO EXISTE");
            miClub.inscribirActividad(4, "Futbol 5");

            // INSCRIBIMOS A UN SOCIO EN SU CUARTA ACTIVIDAD
            Console.WriteLine();
            Console.WriteLine("---> INSCRIBIMOS A UN SOCIO EN SU CUARTA ACTIVIDAD");
            
            miClub.inscribirActividad(3, "Pilates");

            // INSCRIBIMOS A UN SOCIO QUE NO EXISTE
            Console.WriteLine();
            Console.WriteLine("---> INSCRIBIMOS A UN SOCIO QUE NO EXISTE");
            miClub.inscribirActividad(10, "Pilates");

        }
    }
}
