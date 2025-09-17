using System.ComponentModel;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Library_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Library System");
            Library library = new Library();
            Console.WriteLine("Are You Reguler Or Librarian(R/L)");
            char UserType = Console.ReadLine().ToUpper()[0];

            if (UserType == 'L')
            {
                Console.WriteLine("Enter Your Name");
                string LibrarianName = Console.ReadLine();
                Librarian l1 = new Librarian(LibrarianName);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please Choose To Add Book(A) / Remove Book(R) /Disply Books(D)");
                    char Choise = Console.ReadLine().ToUpper()[0];
                    switch (Choise)
                    {
                        case 'A':
                            Console.WriteLine("Enter Book Details");
                            string bookName = Console.ReadLine();
                            string bookAuther = Console.ReadLine();
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Auther = bookAuther,
                                Year = bookYear,
                            };
                            l1.AddBook(book, library);

                            break;
                        case 'R':
                            Console.WriteLine("Enter Book Details To Remove");
                            bookName = Console.ReadLine();
                            bookAuther = Console.ReadLine();
                            bookYear = int.Parse(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Auther = bookAuther,
                                Year = bookYear,
                            };
                            l1.AddBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The Book List Is ");
                            l1.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            else if (UserType == 'R')
            {
                Console.WriteLine("Enter Your Name");
                string name = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(name);
                Console.WriteLine($"Welcome User {u1.Name}");

                //Add Logic
                while (true)
                {
                    Console.WriteLine("Please Choose To Disply Books(D) / Borrow Books(B)");
                    char Choise = Console.ReadLine().ToUpper()[0];
                    switch (Choise)
                    {
                        case 'B':
                            Console.WriteLine("Enter Book Details To Borrow");
                            string bookName = Console.ReadLine();
                            string bookAuther = Console.ReadLine();
                            int bookYear = int.Parse(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Auther = bookAuther,
                                Year = bookYear,
                            };
                            u1.BorrowBook(book, library);

                            break;
                        case 'D':
                            Console.WriteLine("The Book List Is ");
                            u1.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }


                }
            }
            else
            {
                Console.WriteLine("Please Enter Correct Value(L OR R)");
            }

            }
        
    }
}
