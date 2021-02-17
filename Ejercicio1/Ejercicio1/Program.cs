using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Cálculo de divisiones");
                Console.WriteLine("Introduce un número:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Resultado: {0} / {1} = {2}", num1, num2, (num1 / num2));
                

            } catch (DivideByZeroException dbze)
            {
                Console.WriteLine("Error: Introduce un número distinto a 0");
            } finally
            {
                Console.ReadKey();
            }
        }
    }
}
