using BookStore.Interfaces;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.ViewModels;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _books;
        private readonly IReviewRepository _reviews;

        public BookController(IBookRepository books, IReviewRepository review)
        {
            _books = books;
            _reviews = review;
        }

        [HttpGet("/Book/BookDetails/{id?}")]
        public IActionResult BookDetails(int id)
        {
            ReviewBookViewModel obj = new ReviewBookViewModel();
            obj.Book = _books.GetBookById(id);
            obj.Reviews = _reviews.Reviews.Where(r => r.Book.Id == id);
            return View(obj);
        }

    }
}
