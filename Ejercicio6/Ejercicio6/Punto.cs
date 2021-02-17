using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Punto
    {
        public Punto()
        {

        }

        public Punto(string nombre, int x, int y, int z)
        {
            this.nombre += "Punto " + nombre;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public string nombre { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public override string ToString()
        {
            return "Coordenadas " + nombre + ":\nX => " + x + "\nY => " + y + "\nZ => " + z;
        }
    }
}
