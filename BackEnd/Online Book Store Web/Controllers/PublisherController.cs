using Online_Book_Store_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Online_Book_Store_Web.Controllers
{
    public class PublisherController : ApiController
    {
        // GET: api/Publisher
        public List<Publishers> Get()
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.Publishers.ToList();
                if (list.Count > 0)
                {
                    return list;
                }
            }
            return null;
        }

        // GET api/values/5
        public Publishers Get(int id)
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.Publishers.ToList();

                if (list.Count > 0)
                {
                    Publishers publisher = list.Where(x => x.Id == id).FirstOrDefault();
                    return publisher;
                }
            }
            return null;
        }

        // POST api/values
        public string Post(Publishers publisher)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    database.Publishers.Add(publisher);
                    database.SaveChanges();
                    return "Added Successfull";
                }
            }
            catch (Exception e)
            {
                return $"Failed to add! {e}";
            }
        }

        // PUT api/values/5
        public string Put(int id, Publishers publisherChange)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    Publishers publisher = database.Publishers.Find(id);
                    if (publisher != null)
                    {
                        if (publisherChange.Name != null) publisher.Name = publisherChange.Name;
                        if (publisherChange.City != null) publisher.City = publisherChange.City;

                        database.SaveChanges();
                        return "Putted Successfull";
                    }
                    else
                    {
                        return "You don't have a publisher with this id";
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
                    Publishers publisher = database.Publishers.Find(id);
                    if (publisher != null)
                    {
                        database.Publishers.Remove(publisher);
                        database.SaveChanges();
                        return "Deleted Successfull";
                    }
                    else
                    {
                        return "You don't have a publisher with this id";
                    }
                }
            }
            catch (Exception e)
            {
                return $"Failed to delete! {e}";
            }
        }


        //Загружает файл в папку по пути ...\Online Book Store Web\Photos
        [Route("api/publisher/SaveFile")]
        public string SaveFile()
        {
            try
            {
                var httpRequest = HttpContext.Current.Request;
                var postedFile = httpRequest.Files[0];
                string fileName = postedFile.FileName;
                var physicalPath = HttpContext.Current.Server.MapPath($"~/Photos/{fileName}");

                postedFile.SaveAs(physicalPath);

                return $"Succesfull: {fileName}";
            }
            catch (Exception e)
            {
                return $"Error! {e}";
            }
        }
    }
}
