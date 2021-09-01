using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            biblioteca.AlmacenarLibro(libro1);
            biblioteca.AlmacenarLibro(libro2);
            

        }
    }
}
