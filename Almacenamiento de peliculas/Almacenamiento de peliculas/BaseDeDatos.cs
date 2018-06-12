using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenamiento_de_peliculas
{
    public class BaseDeDatos
    {
        public List<Director> directors;
        public List<Actor> actors;
        public List<Productor> productors;
        public List<Pelicula> peliculas;
        public List<Estudio> estudios;
        public List<PeliculaActor> peliculaActors;
        public List<PeliculaProductor> peliculaProductors;
        public BaseDeDatos(List<Director> directors, List<Actor> actors, List<Productor> productors, List<Pelicula> peliculas, List<Estudio> estudios, List<PeliculaActor> peliculaActors, List<PeliculaProductor> peliculaProductors)
        {
            this.directors = directors;
            this.actors = actors;
            this.productors = productors;
            this.peliculas = peliculas;
            this.estudios = estudios;
            this.peliculaActors = peliculaActors;
            this.peliculaProductors = peliculaProductors;
        }
    }
}
