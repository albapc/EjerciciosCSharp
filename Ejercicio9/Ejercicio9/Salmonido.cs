using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Salmonido: Pez
    {

        public Salmonido(string nombreComun, string nombreCientifico, int numAletas, string medio, bool esGregario, string ambGeografico) 
            : base(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico) { }

        public override double calcularPeso(double cm)
        {
            return base.calcularPeso(cm);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
