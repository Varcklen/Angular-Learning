using Microsoft.EntityFrameworkCore;
using Online_Book_Store_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Online_Book_Store_Web.Controllers
{
    public class UserController : ApiController
    {
        // GET: api/Publisher
        public List<StoreUser> Get()
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.StoreUser.AsNoTracking().ToList();
                if (list.Count > 0)
                {
                    return list;
                }
            }
            return null;
        }

        // GET api/values/5
        public StoreUser Get(int id)
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.StoreUser.AsNoTracking().ToList();

                if (list.Count > 0)
                {
                    StoreUser user = list.Where(x => x.Id == id).FirstOrDefault();
                    return user;
                }
            }
            return null;
        }

        // GET api/values/email/password
        /*[Route("api/user/IsUserExcist")]
        [HttpGet]
        public string IsUserExcist(string email, string password)
        {
            using (var database = new OnlineBookStore2Context())
            {
                var list = database.StoreUser.AsNoTracking().ToList();
                //StoreUser user = list.FirstOrDefault(x => x.Email == email && x.Password == password);

                if (user != null)
                {
                    return "true";//true;
                }
            }
            return "false";//false;
        }*/

        // POST api/values
        public string Post(StoreUser user)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    user.RegistrationDate = DateTime.Now;
                    database.StoreUser.Add(user);
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
        public string Put(int id, StoreUser userChange)
        {
            try
            {
                using (var database = new OnlineBookStore2Context())
                {
                    StoreUser user = database.StoreUser.Find(id);
                    if (user != null)
                    {
                        if (userChange.Login != null) user.Login = userChange.Login;
                        if (userChange.Password != null) user.Password = userChange.Password;
                        if (userChange.Name != null) user.Name = userChange.Name;
                        if (userChange.Surname != null) user.Surname = userChange.Surname;
                        if (userChange.Email != null) user.Email = userChange.Email;
                        database.SaveChanges();
                        return "Putted Successfull";
                    }
                    else
                    {
                        return "You don't have a user with this id";
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
                    StoreUser user = database.StoreUser.Find(id);
                    if (user != null)
                    {
                        database.StoreUser.Remove(user);
                        database.SaveChanges();
                        return "Deleted Successfull";
                    }
                    else
                    {
                        return "You don't have a user with this id";
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
