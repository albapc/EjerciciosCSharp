using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Persona
    {
        public Persona()
        {}

        public Persona(string nombre, string apellido1, string apellido2, int edad, string fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.edad = edad;
            this.fechaNacimiento = DateTime.Parse(fechaNacimiento);
        }

        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public int edad { get; set; }
        public DateTime fechaNacimiento { get; set; }


        public override string ToString()
        {
            return "Datos:\n\tNombre: " + nombre + "\n\tApellidos: " + apellido1 + " " + apellido2 + "\n\tEdad: " + edad +
                "\n\tFecha de nacimiento: " + fechaNacimiento.ToString("d");
        }
    }
}
