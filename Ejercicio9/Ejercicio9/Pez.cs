using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Pez
    {
        public Pez() { }

        public Pez(string nombreComun, string nombreCientifico, int numAletas, string medio, bool esGregario, string ambGeografico)
        {
            this.nombreComun = nombreComun;
            this.nombreCientifico = nombreCientifico;
            this.numAletas = numAletas;
            this.medio = medio;
            this.esGregario = esGregario;
            this.ambGeografico = ambGeografico;
        }

        public string nombreComun { get; set; }
        public string nombreCientifico { get; set; }
        public int numAletas { get; set; }
        public string medio { get; set; }
        public bool esGregario { get; set; }
        public string ambGeografico { get; set; }

        public virtual double calcularPeso(int edad, double cm)
        {
            return edad * cm * 20;
        }

        public virtual double calcularPeso(double cm)
        {
            return cm * 10;
        }

        public override string ToString()
        {
            return nombreComun + ", " + nombreCientifico + ", " + numAletas + ", " + medio + ", " + esGregario + ", " + ambGeografico;
        }
    }
}
