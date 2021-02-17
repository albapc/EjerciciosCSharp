using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //asignacion multiple
            Vehiculo v = new Vehiculo("Citroen", "Xsara", 100, Combustible.Diésel);
            Console.WriteLine("Tu coche tiene {0} años ", v.calcularEdadCoche("15/10/1993"));
            Console.WriteLine(v.ToString());

            //asignacion individual
            Vehiculo veh = new Vehiculo();
            veh.marca = "Volkswagen";
            veh.modelo = "Polo";
            veh.kilometros = 800;
            veh.combustible = Combustible.Gasolina;
            Console.WriteLine("Tu coche tiene {0} años ", veh.calcularEdadCoche("20/02/1950"));
            Console.WriteLine(veh.ToString());

            Console.ReadKey();
        }
    }
}
