using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
    public class BookPlace
    {
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }

        public BookPlace(string Sector, string Shelve)
        {
            this.LibrarySector = Sector;
            this.LibraryShelve = Shelve;
        }

    }

}

