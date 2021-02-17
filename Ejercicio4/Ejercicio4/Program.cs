using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena de texto:");
            string str = Console.ReadLine();
            foreach(char c in str)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
