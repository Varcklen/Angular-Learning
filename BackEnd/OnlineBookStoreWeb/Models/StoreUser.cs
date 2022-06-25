using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Online_Book_Store_Web.Models
{
    public partial class StoreUser
    {
        public StoreUser()
        {
            BookOrder = new HashSet<BookOrder>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

        public virtual ICollection<BookOrder> BookOrder { get; set; }
    }
}
