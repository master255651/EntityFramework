using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get;}
        Book GetBookById(int id);
    }
}
