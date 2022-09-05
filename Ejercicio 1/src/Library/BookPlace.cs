using System;

namespace SRP;

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
