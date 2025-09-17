using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    internal class LibraryUser:User
    {
        public LibraryUser(string name)
        {
            Name = name;
        }
        public LibraryCard Card { get; set; }
       
        public void BorrowBook(Book book,Library library)
        {
            //Add Logic
            library.BorrowBook(book);

        }
    }
}
