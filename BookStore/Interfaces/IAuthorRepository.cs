using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> Authors { get; }
        IEnumerable<Book> BooksOfAuthor(IEnumerable<Book> books, int id);
        Author GetAuthorById(int id);
    }
}
