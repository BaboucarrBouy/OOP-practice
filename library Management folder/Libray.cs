using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrayMangingSystem
{
    internal class Libray
    {
        public List<Book> allbooks = new List<Book>();
        public List<Member> allmembers = new List<Member>();
        
        public List<Book> bookscheckedout = new List<Book>();
        public List<Member> membercheckedout = new List<Member>();

        public void AddAbook(Book book)
        {
            allbooks.Add(book);
        }

        public void AddMember(Member member)
        {
            allmembers.Add(member);
        }

        
        public void Borrowbook(Book book, Member member)
        {
            if (member.BorrowCount > 0 && book.AvailabilityStatus == true && book.NumberOfCopies != 0)
            {
                member.BorrowCount--;
                book.NumberOfCopies--;
                Console.WriteLine($"You have succesfully borrowed {book.Title} Which now has {book.NumberOfCopies} Copies Available");
                bookscheckedout.Add(book);
                membercheckedout.Add(member);


                if (book.NumberOfCopies == 0)
                {
                    book.AvailabilityStatus = false;
                    
                }
            }
            
            else if (member.BorrowCount == 0)
            {
                Console.WriteLine("You Cannot Borrow as You have reached a max of 3 books");
            }
            else if (book.AvailabilityStatus == false)
                {
                Console.WriteLine($"You Cannot Borrow {book.Title} as No Copies of books are available");
            }
        }

      public void ReturnBook (Book book, Member member)

        {
            if (bookscheckedout.Contains(book) && membercheckedout.Contains(member))
            {
                member.BorrowCount++;
                book.NumberOfCopies++;
                Console.WriteLine($"Thank you for Returning {book.Title} Which now has {book.NumberOfCopies} Copies Available");
            }
            else
            {
                Console.WriteLine("You cannot return a book thats not checked out or you did not check out");
                DisplayAllbooksout();



            }


        }


        public void displayAllbook()
        {
            Console.WriteLine("Library Items");
            foreach (Book book in allbooks)
            {
                Console.WriteLine($"{book.Title} - ID:{book.UniqueID} - has a total of {book.NumberOfCopies} Copies Available");
            }
            Console.WriteLine("---------------------------");
        }

        public void DisplayAllbooksout()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Books Checked out");
            foreach(Book book in allbooks)
            {
             foreach (Member member in allmembers)

                if (bookscheckedout.Contains(book) && membercheckedout.Contains(member))
                {
                    Console.WriteLine($"{book.Title} - ID:{book.UniqueID} - {member.Name}");
                }
            }
        } 

    }
}
