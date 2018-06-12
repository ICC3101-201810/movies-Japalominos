using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenamiento_de_peliculas
{
    public abstract class Persona
    {
        public string nombre;
        public string apellido;
        public string fechaNacimiento;
        public string biografia;
        public Persona(string nombre, string apellido, string fechaNacimiento, string biografia)
        {
            this.nombre=nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
            this.biografia = biografia;
        }
    }
}
