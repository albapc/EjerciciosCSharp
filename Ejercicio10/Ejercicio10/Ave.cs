using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Ave : IAnimal
    {
        public void caminar()
        {
            Console.WriteLine("Las aves caminan");
        }

        public void comer()
        {
            Console.WriteLine("Las aves comen pescado");
        }

        public void descripcion()
        {
            Console.WriteLine("Las aves tienen 2 patas");
        }

        public void dormir()
        {
            Console.WriteLine("Las aves pueden dormir hasta 12 horas");
        }

        public void respirar()
        {
            Console.WriteLine("Las aves necesitan oxígeno para vivir");
        }
    }
}
