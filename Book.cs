using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Book
    {
        public string title;
        public string description;
        public string author;
        public int  pages;

        //Constructor for the class
        public Book (string atitle, string adescription, string author, int apages)
        {
            //Initialising variables
            title = atitle;
            description = adescription;
            this.author = author;
            pages = apages;
        }
    }
}
