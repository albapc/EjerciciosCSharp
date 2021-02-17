using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Perciforme : Pez
    {
        public Perciforme(string nombreComun, string nombreCientifico, int numAletas, string medio, bool esGregario, string ambGeografico,
            string color, string dieta)
            : base(nombreComun, nombreCientifico, numAletas, medio, esGregario, ambGeografico) {
            this.color = color;
            this.dieta = dieta;
        }

        public string color { get; set; }
        public string dieta { get; set; }

        public string getHabitat()
        {
            string habitat;
            switch(color)
            {
                case "rojo":
                    habitat = "arrecife";
                    break;
                case "verde":
                    habitat = "costa";
                    break;
                case "plateado":
                    habitat = "pelágico";
                    break;
                default:
                    habitat = "abisal";
                    break;
            }
            return habitat;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + color + ", " + dieta + ", " + getHabitat();
        }
    }
}
