using BookStore.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBookRepository _books;
        private readonly IAuthorRepository _author;

        public AuthorController(IBookRepository books, IAuthorRepository author)
        {
            _books = books;
            _author = author;
        }

        [HttpGet("/Author/AuthorBooks/{id?}")]
        public IActionResult AuthorBooks(int id)
        {
            var books = _author.BooksOfAuthor(_books.Books, id);
            return View(books);
        }
    }
}
