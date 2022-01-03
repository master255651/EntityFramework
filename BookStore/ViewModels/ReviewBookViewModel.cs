using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModels
{
    public class ReviewBookViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
