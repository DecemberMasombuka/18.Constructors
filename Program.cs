using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling the constructor and passing its appropriate parameters
            Book book1 = new Book("God of good","Book about good of good","Makhanda",5544);
            Book book2 = new Book("Impossible is void", "Discusses the motivation needed", "Tim Sukile", 6447);
          
            Display(book1);
            Display(book2);


            Console.Read();
        }

        //Display fucntion
        static void Display(Book book)
        {
            Console.WriteLine(book.title);
            Console.WriteLine(book.author);
            Console.WriteLine(book.description);
            Console.WriteLine(book.pages + "  Pages");

            Console.WriteLine();
        }
    }
}
