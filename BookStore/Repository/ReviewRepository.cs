using BookStore.Interfaces;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Mocks
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly BookStoreContext _context;

        public ReviewRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Review> Reviews
        {
            get
            {
                return _context.Reviews;
            }

        }
    }
}
