using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_System
{
    internal class Library
    {
        private Book[] Books = new Book[100];
        private int currentbookcount = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int currentborrowbookcount = 0;
        public void DisplyBook( )
        {
            // Add Logic
            for ( int i = 0; i < currentbookcount; i++ )
            {
                Console.WriteLine(Books[i].Title);

            }

        }
        public void AddBook(Book book)
        {
            // Add Logic
            if (currentbookcount < Books.Length)
            {
                Books[currentbookcount] = book; 
                currentbookcount++;
                Console.WriteLine("Book Added Successfully .");
            }
            else
               {
                Console.WriteLine("Library Is Full ,Can't Add New Books .");
               }
        }
        public void RemoveBook(Book book)
        {
            // Add Logic
            int index = Array.IndexOf(Books , book);
            Books[index] = null;
            currentbookcount--;
            Console.WriteLine("Book Removed ");
        }
        public void BorrowBook(Book book)
        {
            if (currentborrowbookcount < BorrowedBooks.Length)
            {
                BorrowedBooks[currentborrowbookcount] = book;
                currentborrowbookcount++;
                Console.WriteLine("Book Borrowed Successfully .");
            }
            
            else
            {
                Console.WriteLine("Sorry,Can't Borrow More Books .");
            }

        }
    }
}
