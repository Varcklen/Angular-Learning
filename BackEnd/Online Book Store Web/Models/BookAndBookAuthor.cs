using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class BookAndBookAuthor
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public virtual BookAuthor Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
