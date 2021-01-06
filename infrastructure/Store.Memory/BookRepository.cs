using System;
using System.Linq;


namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth" ,"Art Of Programming","Книга исскуство программирования.",7.19m ),
            new Book(2,"ISBN 12312-31232", "M. Fowler" ,"Refactoring","Книга по рефакторингу.", 12.45m),
            new Book(3,"ISBN 12312-31233", "B. Kernighan, D. Ritchie" ,"C Programming Language","Книга по языку программирования C.",13.98m)

        };

        Book[] IBookRepository.GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                .ToArray();
        }

        Book[] IBookRepository.GetAllByTitleOrAuthor(string titleOrAuthor)
        {
            return books.Where(book => book.Title.Contains(titleOrAuthor) 
                                    || book.Author.Contains(titleOrAuthor))
                         .ToArray();
        }


        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
