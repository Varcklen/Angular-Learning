using Newtonsoft.Json;
using Online_Book_Store_Web.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Online_Book_Store_Web.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public void Get()
        {
            
        }

        // GET api/values/5
        public void Get(int id)
        {
            
        }

        // POST api/values
        public string Post([FromBody] string value)
        {
            return null;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
