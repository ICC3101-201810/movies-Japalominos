using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenamiento_de_peliculas
{
    public class Actor:Persona
    {
        public Actor(string nombre, string apellido, string fechaNacimiento, string biografia) : base(nombre, apellido, fechaNacimiento, biografia)
        {

        }
    }
}
