using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
        IEnumerable<Book> BooksOfCategory(IEnumerable<Book> books, int id);
        Category GetCategoryById(int id);
    }
}
