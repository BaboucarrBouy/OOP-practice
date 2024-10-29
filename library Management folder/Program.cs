using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibrayMangingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libray libray = new Libray();

            Book book1 = new Book("Game of Thrones", 1111, 2012, 3, "George RR Martin", 1245656);
            Book book2 = new Book("Harry Potter", 2222, 2001, 2, "Jeff K Rowling", 14545655);
            Book book3 = new Book("Mice and Men", 3333, 1996, 1, "Justin Iyke", 1775445);
            Book book4 = new Book("Rich Dad Poor Dad", 4444, 1993, 5, "Jeremy Dunn", 15675465);
            Book book5 = new Book("Macbeth", 5555, 1678, 3, "Jake Lunnunn", 7655465);

          
            Member member1 = new Member("John Doe", 1, 0658855);
            Member member2 = new Member("Jeff Row", 2, 06563354);
            Member member3 = new Member("Adna Taal", 3, 03666544);

            libray.AddAbook(book1);
            libray.AddAbook(book2);
            libray.AddAbook(book3);
            libray.AddAbook(book4);
            libray.AddAbook(book5);

            book2.DisplayInfo();
          
            libray.AddMember(member1);
            libray.AddMember(member2);
            libray.AddMember(member3);

            libray.displayAllbook();
            libray.Borrowbook(book2, member1);
            libray.Borrowbook(book2, member1);
            libray.Borrowbook(book4, member1);
            libray.Borrowbook(book3, member1);
            libray.ReturnBook(book4, member1);
            libray.Borrowbook(book3, member1);
            libray.Borrowbook(book1, member1);
            libray.ReturnBook(book3, member2);
           
            









        }
    }
}
