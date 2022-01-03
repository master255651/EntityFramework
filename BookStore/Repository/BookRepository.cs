using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> Books
        {
            get
            {
                return _context.Books;
            }

        }

        public Book GetBookById(int id)
        {
            return Books.First(b => b.Id == id);
        }
    }
}
