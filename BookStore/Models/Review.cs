using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Review
    {
        public int Id { set; get; }
        public Book Book { set; get; }
        public string Author { set; get; }
        public string Content { set; get; }
        public DateTime PublishDate { set; get; }
    }
}
