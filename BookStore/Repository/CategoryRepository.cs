using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreContext _context;

        public CategoryRepository(BookStoreContext context)
        {
            _context = context;
        }


        public IEnumerable<Category> Categories
        {
            get
            {
                return _context.Categories;
            }

        }

        public Category GetCategoryById(int id)
        {
            return Categories.First(c => c.Id == id);
        }

        public IEnumerable<Book> BooksOfCategory(IEnumerable<Book> books, int idCategory)
        {
            List<Book> booksOfCategory = new List<Book>();

            foreach(Book book in books)
            {
                foreach (Category category in book.Categories)
                {
                    if(category.Id == idCategory)
                    {
                        booksOfCategory.Add(book);
                    }
                }
            }
            return booksOfCategory;
        }
    }
}
