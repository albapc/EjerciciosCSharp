using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> lst = new List<Persona>();
                Console.WriteLine("¿Cuántas personas quieres añadir?");
                int num = Convert.ToInt32(Console.ReadLine());

                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine("Introduce el nombre de la persona:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Introduce el primer apellido:");
                    string apellido1 = Console.ReadLine();
                    Console.WriteLine("Introduce el segundo apellido:");
                    string apellido2 = Console.ReadLine();
                    Console.WriteLine("Introduce la edad:");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce la fecha de nacimiento:");
                    string fechaNacimiento = Console.ReadLine();
                    lst.Add(new Persona(nombre, apellido1, apellido2, edad, fechaNacimiento));
                }

                foreach (Persona p in lst)
                {
                    Console.WriteLine(p.ToString());
                }

            } catch (FormatException fe)
            {
                Console.WriteLine(fe.GetType().Name + ": Formato de dato introducido no válido");
            } finally
            {
                Console.ReadKey();
            }
            
        }
    }
}