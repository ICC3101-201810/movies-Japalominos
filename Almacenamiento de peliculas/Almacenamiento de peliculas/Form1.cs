using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenamiento_de_peliculas
{
    public partial class Form1 : Form
    {
        BaseDeDatos b1;
        public Form1(BaseDeDatos b1)
        {
            this.b1 = b1;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (textBox1.Text.Length >= 3)
            {
                foreach(Actor i in b1.actors)
                {
                    if (true== i.nombre.Contains(Text) ||true == i.fechaNacimiento.Contains(Text) || true == i.apellido.Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Actor: "+i.nombre+" "+i.apellido);
                        }
                        
                    }
                }
                foreach (Director i in b1.directors)
                {
                    if (true == i.nombre.Contains(Text) || true== i.fechaNacimiento.Contains(Text) || true == i.apellido.Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Director: "+i.nombre+" "+i.apellido);
                        }

                    }
                }
                foreach (Productor i in b1.productors)
                {
                    if (true == i.nombre.Contains(Text) || true == i.fechaNacimiento.Contains(Text) || true == i.apellido.Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Productor: " +i.nombre+" "+i.apellido);
                        }

                    }
                }
                foreach (Estudio i in b1.estudios)
                {
                    if (true == i.nombre.Contains(Text) || true == i.fechaApertura.Contains(Text) || true == i.direccion.Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Estudio: "+i.nombre);
                        }

                    }
                }
                foreach (Pelicula i in b1.peliculas)
                {
                    if ( true == i.nombre.Contains(Text) || true == i.director.nombre.Contains(Text) || true == i.director.apellido.Contains(Text) || true == i.estudio.nombre.Contains(Text) || true == i.estudio.fechaApertura.Contains(Text) || true == i.fechaEstreno.Contains(Text) || true == i.presupuesto.ToString().Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Pelicula: "+i.nombre);
                        }

                    }
                }
                foreach (PeliculaActor i in b1.peliculaActors)
                {
                    if (true == i.actor.nombre.Contains(Text) || true== i.actor.apellido.Contains(Text) || true == i.actor.fechaNacimiento.Contains(Text) || true == i.pelicula.nombre.Contains(Text) || true == i.pelicula.director.nombre.Contains(Text) || true == i.pelicula.director.apellido.Contains(Text) || true == i.pelicula.estudio.nombre.Contains(Text) || true == i.pelicula.estudio.fechaApertura.Contains(Text) || true == i.pelicula.fechaEstreno.Contains(Text) || true == i.pelicula.presupuesto.ToString().Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Actor: "+i.actor.nombre+" "+i.actor.apellido+" ; Pelicula: "+i.pelicula.nombre);
                        }

                    }
                }
                foreach (PeliculaProductor i in b1.peliculaProductors)
                {
                    if (true == i.productor.nombre.Contains(Text) || true == i.productor.apellido.Contains(Text) || true == i.productor.fechaNacimiento.Contains(Text) || true == i.pelicula.nombre.Contains(Text) || true == i.pelicula.director.nombre.Contains(Text) || true == i.pelicula.director.apellido.Contains(Text) || true== i.pelicula.estudio.nombre.Contains(Text) || true== i.pelicula.estudio.fechaApertura.Contains(Text) || true == i.pelicula.fechaEstreno.Contains(Text) || true == i.pelicula.presupuesto.ToString().Contains(Text))
                    {
                        if (listBox1.Items.Count <= 50)
                        {
                            listBox1.Items.Add("Productor: " + i.productor.nombre + " " + i.productor.apellido + " ; Pelicula: " + i.pelicula.nombre);
                        }

                    }
                }

            }
            else
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void PeliButton_Click(object sender, EventArgs e)
        {

        }
    }
}
