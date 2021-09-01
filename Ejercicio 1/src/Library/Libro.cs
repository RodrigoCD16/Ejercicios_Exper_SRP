using System;

namespace SRP
{
    public class Libro
    {
        /* 
        La clase Libro tiene demasiadas resposabilidades, deberia crearse una nueva clase biblioteca
        que se encargue de ver el sector y estante en que se deba almacenar el libro.
        */
        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        /* 
            Este metodo perteneceria a dicha nueva clase "biblioteca", la clase Libro es experta en crear libros, tiene la responsabilidad de
            conocer los datos necesarios para crear los objetos de tipo libro.
        */
        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
