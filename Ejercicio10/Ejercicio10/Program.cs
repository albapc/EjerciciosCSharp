using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Mamifero mamifero = new Mamifero();

                mamifero.caminar();
                mamifero.comer();
                mamifero.descripcion();
                mamifero.dormir();

                Ave ave = new Ave();
                ave.caminar();
                ave.comer();
                ave.descripcion();
                ave.dormir();

            } catch (Exception ex)
            {
                Console.WriteLine("Error de ejecucion");
            } finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
