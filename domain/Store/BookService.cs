using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public class BookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book[] GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))//IsIsbn желательно сделать в классе book так как может понадобится и там
                return bookRepository.GetAllByIsbn(query);
            return bookRepository.GetAllByTitleOrAuthor(query);
        }

    }
}
