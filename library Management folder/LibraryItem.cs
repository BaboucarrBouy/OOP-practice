using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrayMangingSystem
{
    internal abstract class LibraryItem
    {
        public string Title { get; set; }

        public int UniqueID { get; set; }

        public int PublicationYear { get; set; }

        public int NumberOfCopies { get; set; }

        public bool AvailabilityStatus { get; set; }

        public LibraryItem(string title, int uniqueID, int publicationYear, int numberofCopies) 
        { 
            this.Title = title;
            this.UniqueID = uniqueID;
            this.PublicationYear = publicationYear;
            this.NumberOfCopies = numberofCopies;
            AvailabilityStatus = true;
        }

        public abstract void DisplayInfo();

        

        

    }
}
