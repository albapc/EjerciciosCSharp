using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Selaquimorfo : Pez
    {
        public Selaquimorfo(string nombreComun, string nombreCientifico, int numAletas, string medio, bool esGregario, string ambGeografico,
            int numDientes, string color, bool esPeligroso, int velocidad)
            : base(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico) {
            this.numDientes = numDientes;
            this.color = color;
            this.esPeligroso = esPeligroso;
            this.velocidad = velocidad;
        }

        public int numDientes { get; set; }
        public string color { get; set; }
        public bool esPeligroso { get; set; }
        public int velocidad { get; set; }

        public int calcularDesplazamientoDiario()
        {
            return velocidad * 1000;
        }

        public override string ToString()
        {
            return base.ToString() + ",  " + numDientes + ", " + color + ", " + esPeligroso + ", " + velocidad;
        }
    }
}
