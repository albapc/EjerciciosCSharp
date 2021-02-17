using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Salmonido> s = new List<Salmonido>();
                List<Selaquimorfo> sel = new List<Selaquimorfo>();
                List<Perciforme> p = new List<Perciforme>();

                Console.WriteLine("¿Cuántas especies quieres añadir?");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("¿Qué especie quieres añadir?\n1.Salmonido\n2.Selaquimorfo\n3.Perciforme");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Introduce el nombre comun de la especie:");
                    string nombreComun = Console.ReadLine();
                    Console.WriteLine("Introduce el nombre cientifico:");
                    string nombreCientifico = Console.ReadLine();
                    Console.WriteLine("Introduce el numero de aletas:");
                    int numAletas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Introduce su medio:");
                    string medio = Console.ReadLine();
                    Console.WriteLine("Indica si es gregario (true o false):");
                    bool esGregario = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Introduce su ambito geografico:");
                    string ambGeografico = Console.ReadLine();

                    switch (opcion)
                    {
                        case 1:
                            s.Add(new Salmonido(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico));
                            break;
                        case 2:
                            Console.WriteLine("Introduce el numero de dientes:");
                            int numDientes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el color:");
                            string color = Console.ReadLine();
                            Console.WriteLine("Indica si es peligroso (true o false):");
                            bool esPeligroso = Convert.ToBoolean(Console.ReadLine());
                            Console.WriteLine("Introduce su velocidad:");
                            int velocidad = Convert.ToInt32(Console.ReadLine());
                            sel.Add(new Selaquimorfo(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico, numDientes, color, esPeligroso, velocidad));
                            break;
                        case 3:
                            Console.WriteLine("Introduce el color:");
                            color = Console.ReadLine();
                            Console.WriteLine("Introduce su dieta:");
                            string dieta = Console.ReadLine();
                            p.Add(new Perciforme(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico, color, dieta));
                            break;
                        default:
                            Console.WriteLine("Especie no valida");
                            break;
                    }
                }
                foreach (Salmonido salmonido in s)
                {
                    Console.WriteLine(salmonido.ToString());
                }

                foreach (Selaquimorfo selaquiformo in sel)
                {
                    Console.WriteLine(selaquiformo.ToString());
                }

                foreach (Perciforme perciforme in p)
                {
                    Console.WriteLine(perciforme.ToString());
                }
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
