using Online_Book_Store_Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Http;

namespace Online_Book_Store_Web.Controllers
{
    public class BookController : ApiController
    {

        public List<Book> Get()
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.Book.ToList();
                if (list.Count > 0)
                {
                    //return list.Select(field => field.Name).ToList();
                    return list;
                }
            }
            return null;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.Book.ToList();

                if (list.Count > 0)
                {
                    Book book = list.Where(x => x.Id == id).FirstOrDefault();
                    return book;
                }
            }
            return null;
        }

        [Route("api/book/GetAllBookNames")]
        [HttpGet]
        public List<string> GetAllBookNames()
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.Book.ToList();

                if (list.Count > 0)
                {
                    List<string> booksNames = list.Select(x => x.Name).ToList();
                    return booksNames;
                }
            }
            return null;
        }

        // POST api/values
        public string Post(Book book)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    database.Book.Add(book);
                    database.SaveChanges();
                    return "Book added Successfull";
                }
            }
            catch (Exception e)
            {
                return $"Failed to add! {e}";
            }
        }

        // PUT api/values/5
        public string Put(int id, Book bookChange)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    Book book = database.Book.Find(id);
                    if (book != null)
                    {
                        if (bookChange.Name != null) book.Name = bookChange.Name;
                        if (bookChange.Description != null) book.Description = bookChange.Description;
                        if (bookChange.Cost != 0) book.Cost = bookChange.Cost;
                        if (bookChange.PublisherId != 0) book.PublisherId = bookChange.PublisherId;

                        database.SaveChanges();
                        return "Putted Successfull";
                    }
                    else
                    {
                        return "You don't have a book with this id";
                    }
                }
            }
            catch (Exception e)
            {
                return $"Failed to put! {e}";
            }
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    Book book = database.Book.Find(id);
                    if (book != null)
                    {
                        database.Book.Remove(book);
                        database.SaveChanges();
                        return "Deleted Successfull";
                    }
                    else
                    {
                        return "You don't have a book with this id";
                    }
                }
            }
            catch (Exception e)
            {
                return $"Failed to delete! {e}";
            }
        }
    }
}
