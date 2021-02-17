using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //instanciamos los objetos para utilizarlos varias veces
                Persona p1 = new Persona("Alba", "Perez", "Cesar", 27, "15/10/1993");
                Persona p2 = new Persona("Juan", "Rodriguez", "Perez", 70, "10/02/1950");
                Persona p3 = new Persona("Sonia", "Sanchez", "Castro", 45, "10/02/1985");
                Persona p4 = new Persona("Iago", "Gonzalez", "Iglesias", 30, "10/02/1980");
                Persona p5 = new Persona("Carlos", "Rodriguez", "Perez", 55, "10/02/1961");

                //creamos la cola e introducimos a las personas en esta
                Queue<Persona> personas = new Queue<Persona>();
                personas.Enqueue(p1);
                personas.Enqueue(p2);
                personas.Enqueue(p3);
                personas.Enqueue(p4);
                personas.Enqueue(p5);


                Console.WriteLine("Cola");
                foreach (Persona persona in personas)
                {
                
                    Console.WriteLine(persona);
                }
           

                /* El codigo devuelve a las personas en el mismo orden que entraron en la cola (o túnel):

                 Alba
                 Juan
                 Sonia
                 Iago
                 Carlos

                */

                //creamos la pila e introducimos a las personas en esta
                Stack<Persona> personas2 = new Stack<Persona>();
                personas2.Push(p1);
                personas2.Push(p2);
                personas2.Push(p3);
                personas2.Push(p4);
                personas2.Push(p5);


                Console.WriteLine("Pila");
                foreach (Persona p in personas2)
                {
                    Console.WriteLine(p);
                }

                    /* El codigo devuelve primero a los últimos que entraron y los primeros que entraron serían los últimos en salir de la pila (o metro):

                     Carlos
                     Iago
                     Sonia
                     Juan
                     Alba

                    */

            } catch(Exception ex)
            {
                Console.WriteLine("Error de ejecución");
            } finally
            {
                Console.ReadKey();
            }

            
        }
    }
}
