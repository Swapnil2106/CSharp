using LibraryManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Classes
{
    internal class Library : IBookLendingService
    {
        List<Book> books = new List<Book>()
        {
            new Book { Id = 1, Author = "Author 1", Title = "Title 1", IsAvailable = true },
            new Book { Id = 2, Author = "Author 2", Title = "Title 2", IsAvailable = true },
            new Book { Id = 3, Author = "Author 3", Title = "Title 3", IsAvailable = true },
            new Book { Id = 4, Author = "Author 4", Title = "Title 4", IsAvailable = true },
            new Book { Id = 5, Author = "Author 5", Title = "Title 5", IsAvailable = true },
            new Book { Id = 6, Author = "Author 6", Title = "Title 6", IsAvailable = true },
            new Book { Id = 7, Author = "Author 7", Title = "Title 7", IsAvailable = false },
            new Book { Id = 8, Author = "Author 8", Title = "Title 8", IsAvailable = true },
            new Book { Id = 9, Author = "Author 9", Title = "Title 9", IsAvailable = false },
            new Book { Id = 10, Author = "Author 10", Title = "Title 10", IsAvailable = true },
            new Book { Id = 11, Author = "Author 11", Title = "Title 11", IsAvailable = true },
            new Book { Id = 12, Author = "Author 12", Title = "Title 12", IsAvailable = false },
            new Book { Id = 13, Author = "Author 13", Title = "Title 13", IsAvailable = true },
            new Book { Id = 14, Author = "Author 14", Title = "Title 14", IsAvailable = true },
            new Book { Id = 15, Author = "Author 15", Title = "Title 15", IsAvailable = true },
            new Book { Id = 16, Author = "Author 16", Title = "Title 16", IsAvailable = false },
            new Book { Id = 17, Author = "Author 17", Title = "Title 17", IsAvailable = true },
            new Book { Id = 18, Author = "Author 18", Title = "Title 18", IsAvailable = false },
            new Book { Id = 19, Author = "Author 19", Title = "Title 19", IsAvailable = true },
            new Book { Id = 20, Author = "Author 20", Title = "Title 20", IsAvailable = true },
            new Book { Id = 21, Author = "Author 21", Title = "Title 21", IsAvailable = false },
            new Book { Id = 22, Author = "Author 22", Title = "Title 22", IsAvailable = true },
            new Book { Id = 23, Author = "Author 23", Title = "Title 23", IsAvailable = true },
            new Book { Id = 24, Author = "Author 24", Title = "Title 24", IsAvailable = true },
            new Book { Id = 25, Author = "Author 25", Title = "Title 25", IsAvailable = true },
            new Book { Id = 26, Author = "Author 26", Title = "Title 26", IsAvailable = true },
            new Book { Id = 27, Author = "Author 27", Title = "Title 27", IsAvailable = false },
            new Book { Id = 28, Author = "Author 28", Title = "Title 28", IsAvailable = true },
            new Book { Id = 29, Author = "Author 29", Title = "Title 29", IsAvailable = true },
            new Book { Id = 30, Author = "Author 30", Title = "Title 30", IsAvailable = false },
            new Book { Id = 31, Author = "Author 31", Title = "Title 31", IsAvailable = true },
            new Book { Id = 32, Author = "Author 32", Title = "Title 32", IsAvailable = true },
            new Book { Id = 33, Author = "Author 33", Title = "Title 33", IsAvailable = false },
            new Book { Id = 34, Author = "Author 34", Title = "Title 34", IsAvailable = true },
            new Book { Id = 35, Author = "Author 35", Title = "Title 35", IsAvailable = true },
            new Book { Id = 36, Author = "Author 36", Title = "Title 36", IsAvailable = false },
            new Book { Id = 37, Author = "Author 37", Title = "Title 37", IsAvailable = true },
            new Book { Id = 38, Author = "Author 38", Title = "Title 38", IsAvailable = true },
            new Book { Id = 39, Author = "Author 39", Title = "Title 39", IsAvailable = false },
            new Book { Id = 40, Author = "Author 40", Title = "Title 40", IsAvailable = true },
            new Book { Id = 41, Author = "Author 41", Title = "Title 41", IsAvailable = true },
            new Book { Id = 42, Author = "Author 42", Title = "Title 42", IsAvailable = true },
            new Book { Id = 43, Author = "Author 43", Title = "Title 43", IsAvailable = true },
            new Book { Id = 44, Author = "Author 44", Title = "Title 44", IsAvailable = false },
            new Book { Id = 45, Author = "Author 45", Title = "Title 45", IsAvailable = true },
            new Book { Id = 46, Author = "Author 46", Title = "Title 46", IsAvailable = true },
            new Book { Id = 47, Author = "Author 47", Title = "Title 47", IsAvailable = true },
            new Book { Id = 48, Author = "Author 48", Title = "Title 48", IsAvailable = true },
            new Book { Id = 49, Author = "Author 49", Title = "Title 49", IsAvailable = true },
            new Book { Id = 50, Author = "Author 50", Title = "Title 50", IsAvailable = false },
            new Book { Id = 51, Author = "Author 51", Title = "Title 51", IsAvailable = true },
            new Book { Id = 52, Author = "Author 52", Title = "Title 52", IsAvailable = true },
            new Book { Id = 53, Author = "Author 53", Title = "Title 53", IsAvailable = true },
            new Book { Id = 54, Author = "Author 54", Title = "Title 54", IsAvailable = false },
            new Book { Id = 55, Author = "Author 55", Title = "Title 55", IsAvailable = true },
            new Book { Id = 56, Author = "Author 56", Title = "Title 56", IsAvailable = true },
            new Book { Id = 57, Author = "Author 57", Title = "Title 57", IsAvailable = false },
            new Book { Id = 58, Author = "Author 58", Title = "Title 58", IsAvailable = true },
            new Book { Id = 59, Author = "Author 59", Title = "Title 59", IsAvailable = true },
            new Book { Id = 60, Author = "Author 60", Title = "Title 60", IsAvailable = false },
            new Book { Id = 61, Author = "Author 61", Title = "Title 61", IsAvailable = true },
            new Book { Id = 62, Author = "Author 62", Title = "Title 62", IsAvailable = true },
            new Book { Id = 63, Author = "Author 63", Title = "Title 63", IsAvailable = false },
            new Book { Id = 64, Author = "Author 64", Title = "Title 64", IsAvailable = true },
            new Book { Id = 65, Author = "Author 65", Title = "Title 65", IsAvailable = false },
            new Book { Id = 66, Author = "Author 66", Title = "Title 66", IsAvailable = true },
            new Book { Id = 67, Author = "Author 67", Title = "Title 67", IsAvailable = true },
            new Book { Id = 68, Author = "Author 68", Title = "Title 68", IsAvailable = true },
            new Book { Id = 69, Author = "Author 69", Title = "Title 69", IsAvailable = false },
            new Book { Id = 70, Author = "Author 70", Title = "Title 70", IsAvailable = true },
            new Book { Id = 71, Author = "Author 71", Title = "Title 71", IsAvailable = true },
            new Book { Id = 72, Author = "Author 72", Title = "Title 72", IsAvailable = false },
            new Book { Id = 73, Author = "Author 73", Title = "Title 73", IsAvailable = true },
            new Book { Id = 74, Author = "Author 74", Title = "Title 74", IsAvailable = true },
            new Book { Id = 75, Author = "Author 75", Title = "Title 75", IsAvailable = false },
            new Book { Id = 76, Author = "Author 76", Title = "Title 76", IsAvailable = true },
            new Book { Id = 77, Author = "Author 77", Title = "Title 77", IsAvailable = true },
            new Book { Id = 78, Author = "Author 78", Title = "Title 78", IsAvailable = false },
            new Book { Id = 79, Author = "Author 79", Title = "Title 79", IsAvailable = true },
            new Book { Id = 80, Author = "Author 80", Title = "Title 80", IsAvailable = true },
            new Book { Id = 81, Author = "Author 81", Title = "Title 81", IsAvailable = true },
            new Book { Id = 82, Author = "Author 82", Title = "Title 82", IsAvailable = false },
            new Book { Id = 83, Author = "Author 83", Title = "Title 83", IsAvailable = true },
            new Book { Id = 84, Author = "Author 84", Title = "Title 84", IsAvailable = true },
            new Book { Id = 85, Author = "Author 85", Title = "Title 85", IsAvailable = false },
            new Book { Id = 86, Author = "Author 86", Title = "Title 86", IsAvailable = true },
            new Book { Id = 87, Author = "Author 87", Title = "Title 87", IsAvailable = true },
            new Book { Id = 88, Author = "Author 88", Title = "Title 88", IsAvailable = false },
            new Book { Id = 89, Author = "Author 89", Title = "Title 89", IsAvailable = true },
            new Book { Id = 90, Author = "Author 90", Title = "Title 90", IsAvailable = true },
            new Book { Id = 91, Author = "Author 91", Title = "Title 91", IsAvailable = true },
            new Book { Id = 92, Author = "Author 92", Title = "Title 92", IsAvailable = false },
            new Book { Id = 93, Author = "Author 93", Title = "Title 93", IsAvailable = true },
            new Book { Id = 94, Author = "Author 94", Title = "Title 94", IsAvailable = true },
            new Book { Id = 95, Author = "Author 95", Title = "Title 95", IsAvailable = false },
            new Book { Id = 96, Author = "Author 96", Title = "Title 96", IsAvailable = true },
            new Book { Id = 97, Author = "Author 97", Title = "Title 97", IsAvailable = true },
            new Book { Id = 98, Author = "Author 98", Title = "Title 98", IsAvailable = true },
            new Book { Id = 99, Author = "Author 99", Title = "Title 99", IsAvailable = false },
            new Book { Id = 100, Author = "Author 100", Title = "Title 100", IsAvailable = true }
        };

        List<Member> members = new List<Member>()
        {
            new Member { Id = 1, Name = "Member 1", Email = "Member1@gmail.com",
                         BorrowedBooks = new List<Book>()
                         {
                             new Book { Id = 7, Author = "Author 7", Title = "Title 7", IsAvailable = false },
                             new Book { Id = 12, Author = "Author 12", Title = "Title 12", IsAvailable = false },
                             new Book { Id = 16, Author = "Author 16", Title = "Title 16", IsAvailable = false }
                         }
            },
            new Member { Id = 2, Name = "Member 2", Email = "Member2@gmail.com",
                         BorrowedBooks = new List<Book>()
                         {
                             new Book { Id = 18, Author = "Author 18", Title = "Title 18", IsAvailable = false },
                             new Book { Id = 21, Author = "Author 21", Title = "Title 21", IsAvailable = false }
                         }
            },
            new Member { Id = 3, Name = "Member 3", Email = "Member3@gmail.com",
                         BorrowedBooks = new List<Book>()
                         {
                             new Book { Id = 57, Author = "Author 57", Title = "Title 57", IsAvailable = false },
                             new Book { Id = 60, Author = "Author 60", Title = "Title 60", IsAvailable = false },
                             new Book { Id = 65, Author = "Author 65", Title = "Title 65", IsAvailable = false }
                         }
            }
        };

        private bool IsBookAvailable(string title)
        {
            return books.Any(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && b.IsAvailable);
        }

        public void LendBook(string title, string memberName)
        {
            if(IsBookAvailable(title))
            {
                var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (book != null)
                {
                    book.IsAvailable = false;
                    var member = members.FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));
                    if(member != null)
                    {
                        member.BorrowedBooks.Add(book);
                        Console.WriteLine($"Book '{title}' has been lent to member '{memberName}'.");
                    }
                    else
                    {
                        Console.WriteLine($"Member '{memberName}' is not found in the library.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Book '{title}' is not found in the library.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{title}' is not available for lending.");
            }
        }

        public void ReturnBook(string title, string memberName)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null && book.IsAvailable == false)
            {
                var member = members.FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));
                if (member != null && member.BorrowedBooks.Any(b => b.Id == book.Id))
                {
                    book.IsAvailable = true;
                    member.BorrowedBooks.RemoveAll(b => b.Id == book.Id);
                    Console.WriteLine($"Book '{title}' has been returned by member '{memberName}'.");
                }
                else
                {
                    Console.WriteLine($"Member '{memberName}' has not borrowed the book '{title}'.");
                }
            }
            else
            {
                Console.WriteLine($"Book '{title}' does not belong to the library.");
            }
        }

        public List<Book> GetAvailableBooks()
        {
            return books.Where(b => b.IsAvailable).ToList();
        }

        public List<Book> GetBorrowedBooksByMember(string memberName)
        {
            var member = members.FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase));
            if(member != null)
            {
                Console.WriteLine($"Borrowed books by member '{memberName}':");
                return member.BorrowedBooks;
            }
            else
            {
                Console.WriteLine($"Member '{memberName}' is not found in the library.");
                return new List<Book>();
            }
        }
    }
}
