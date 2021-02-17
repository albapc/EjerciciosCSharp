using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    enum Combustible
    {
        Diésel,
        Gasolina,
        Eléctrico
    }

    class Vehiculo
    {
        public Vehiculo()
        {

        }


        public Vehiculo(string marca, string modelo, int kilometros, Combustible combustible)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.kilometros = kilometros;
            this.combustible = combustible;
        }

        public string marca { get; set; }
        public string modelo { get; set; }
        public int kilometros { get; set; }
        public Combustible combustible { get; set; }

        public int calcularEdadCoche(string fechaMatriculacion)
        {
            DateTime fecha = Convert.ToDateTime(fechaMatriculacion);

            int edad = 0;
            edad = DateTime.Now.Year - fecha.Year;
            if (DateTime.Now.DayOfYear < fecha.DayOfYear)
                edad -= 1;

            return edad;
        }

        public override string ToString()
        {
            return "Marca " + marca + ", modelo: " + modelo + ", kilometros " + kilometros + ", combustible " + combustible;
        }
    }
}
