using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class Book
    {
        public Book()
        {
            BookAndBookAuthor = new HashSet<BookAndBookAuthor>();
            BookOrder = new HashSet<BookOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public int PublisherId { get; set; }

        public virtual Publishers Publisher { get; set; }
        public virtual ICollection<BookAndBookAuthor> BookAndBookAuthor { get; set; }
        public virtual ICollection<BookOrder> BookOrder { get; set; }
    }
}
