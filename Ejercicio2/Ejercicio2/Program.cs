using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("¿Número par o impar?");
                Console.WriteLine("Introduce un número:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 % 2 == 0)
                {
                    Console.WriteLine("Es par");
                }
                else
                {
                    Console.WriteLine("Es impar");
                }

            } catch(FormatException fe)
            {
                Console.WriteLine("Introduce solo numeros enteros");
            } finally
            {
                Console.ReadKey();
            }
        }
    }
}