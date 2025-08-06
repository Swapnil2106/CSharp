using LibraryManagementSystem.Classes;
using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookLendingService library = new Library();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Library Management System =====");
                Console.WriteLine("1. Show Available Books");
                Console.WriteLine("2. Borrow a Book");
                Console.WriteLine("3. Return a Book");
                Console.WriteLine("4. View Member's Borrowed Books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var availableBooks = library.GetAvailableBooks();
                        Console.WriteLine("\nAvailable Books:");
                        foreach (var book in availableBooks)
                        {
                            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}");
                        }
                        break;

                    case "2":
                        Console.Write("Enter member name: ");
                        string borrower = Console.ReadLine();
                        Console.Write("Enter book title to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        library.LendBook(borrowTitle, borrower);
                        break;

                    case "3":
                        Console.Write("Enter member name: ");
                        string returner = Console.ReadLine();
                        Console.Write("Enter book title to return: ");
                        string returnTitle = Console.ReadLine();
                        library.ReturnBook(returnTitle, returner);
                        break;

                    case "4":
                        Console.Write("Enter member name: ");
                        string memberName = Console.ReadLine();
                        var borrowedBooks = library.GetBorrowedBooksByMember(memberName);
                        foreach (var book in borrowedBooks)
                        {
                            Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting the system. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
