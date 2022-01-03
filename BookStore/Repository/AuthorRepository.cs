using BookStore.Interfaces;
using BookStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Mocks
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext _context;

        public AuthorRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> Authors
        {

            get
            {
                return _context.Authors;
            }

        }

        public Author GetAuthorById(int id)
        {
            return Authors.First(a => a.Id == id);
        }

        public IEnumerable<Book> BooksOfAuthor(IEnumerable<Book> books, int idAuthor)
        {
            return books.Where(b => b.Author.Id == idAuthor);
        }
    }
}
