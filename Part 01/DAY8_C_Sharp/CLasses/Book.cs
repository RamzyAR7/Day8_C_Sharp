using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }


        public Book()
        {
            Title = "";
            Author = "";
        }
        public Book(string title, string auther)
        {
            Title = title;
            Author = auther;
        }
        public Book(string title):this(title, "")
        {
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
