using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Mamifero : IAnimal
    {
        public void caminar()
        {
            Console.WriteLine("Los mamiferos caminan");
        }

        public void comer()
        {
            Console.WriteLine("Los mamiferos comen");
        }

        public void descripcion()
        {
            Console.WriteLine("Los mamiferos pueden ser herbivoros, carnivoros u omnivoros");
        }

        public void dormir()
        {
            Console.WriteLine("Los mamiferos duermen");
        }

        public void respirar()
        {
            Console.WriteLine("Los mamiferos necesitan respirar para vivir");
        }
    }
}
