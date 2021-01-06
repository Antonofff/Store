using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string titlePart);

        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);

        Book GetById(int id);

    }
}
