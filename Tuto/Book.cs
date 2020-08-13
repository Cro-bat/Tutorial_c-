using System;
using System.Collections.Generic;
using System.Text;

namespace Tuto
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //CONSTRUCTOS
        public Book()
        {

        }
        
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
