using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Library_System
{
    internal class Librarian:User
    {
        public Librarian(string name) 
        {
            Name = name;        
        }
        public int EmployeeNum { get; set; }
        public void AddBook(Book NewBook,Library library)
        {
            //Add Logic
            library.AddBook(NewBook);
        }
        public void RemoveBook(Book NewBook,Library library)
        {
            //Add Logic
            library.RemoveBook(NewBook);
        }
        


    }
}
