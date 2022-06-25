using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class BookOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime ByingDate { get; set; }

        public virtual Book Book { get; set; }
        public virtual StoreUser User { get; set; }
    }
}
