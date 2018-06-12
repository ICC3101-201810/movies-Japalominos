using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenamiento_de_peliculas
{
    public class Estudio
    {
        public string nombre;
        public string direccion;
        public string fechaApertura;
        public Estudio(string nombre, string direccion, string fechaApertura)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fechaApertura = fechaApertura;
        }
    }
}
