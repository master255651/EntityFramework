using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public float Price { set; get; }
        public string Image { set; get; }
        public int PublishDate { set; get; }
        public Author Author { set; get; }
        public List<Category> Categories { set; get; }
        public List<Review> Reviews { set; get; }

    }
}
