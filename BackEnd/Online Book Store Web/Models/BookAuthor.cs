using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class BookAuthor
    {
        public BookAuthor()
        {
            BookAndBookAuthor = new HashSet<BookAndBookAuthor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<BookAndBookAuthor> BookAndBookAuthor { get; set; }
    }
}
