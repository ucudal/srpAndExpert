using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","1");
            Book book2 = new Book("Pro C#","Troelsen","2");
            BookPlace book1Place = new BookPlace("A","7");
            BookPlace book2Place = new BookPlace("B","3");
            Console.WriteLine($"El libro {book1.Title} está en {book1Place.LibrarySector},{book1Place.LibraryShelve}");
        }
    }
}