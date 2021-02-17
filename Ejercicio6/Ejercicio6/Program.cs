using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                List<Punto> lst = new List<Punto>();

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("Punto {0}", i);
                    Console.WriteLine("Introduce eje X");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce eje Y");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce eje Z");
                    int z = Convert.ToInt32(Console.ReadLine());
                    lst.Add(new Punto(i.ToString(), x, y, z));
                }

                foreach(Punto p in lst)
                {
                Console.WriteLine(p.ToString());
                }

            } catch (FormatException fe)
            {
                Console.WriteLine(fe.GetType().Name + ": Solo se pueden introducir números");
            } finally
            {
                Console.ReadKey();
            }
        }
    }
}
