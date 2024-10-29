using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrayMangingSystem
{
    internal class Book : LibraryItem
    {
        public string Author { get; set; }

        public int ISBN { get; set; }

        public Book(string title, int uniqueID, int publicationYear, int numberofCopies, string author, int iSBN) : base(title, uniqueID, publicationYear, numberofCopies)
        {
            Author = author;
            ISBN = iSBN;
        }

        public override void DisplayInfo()
        {

                Console.WriteLine($"{Title} - ID:{UniqueID} - has a total of {NumberOfCopies} Copies Available");
        }






    }

    

}
