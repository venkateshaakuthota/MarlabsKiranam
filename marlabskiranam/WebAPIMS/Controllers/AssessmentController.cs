using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIMS.Models;
using System.Data;

namespace WebAPIMS.Controllers
{
    public class AssessmentController : ApiController
    {
        private AssContext context = new AssContext();

     // get all list
        [HttpGet]
        public IEnumerable<fb_users> Get()
        {
            return context.fb_users.ToList<fb_users>();
        }

    // Get by ID

        public fb_users Get(string id)
        {
            return context.fb_users.FirstOrDefault(b => b.user_id == id);
        }

     // Create data into database

        public void Post([FromBody] fb_users fb_user)
        {
            context.fb_users.Add(fb_user);
            context.SaveChanges();
        }

     // Delete a record from database

        public void Delete(string id)
        {
            context.fb_users.Remove(context.fb_users.FirstOrDefault(b => b.user_id == id));
            context.SaveChanges();
        }

    // Update a record into database

        public void Put(string id,[FromBody]fb_users fb_user)
        {
            var user = context.fb_users.FirstOrDefault(e => e.user_id == id);
            user.user_id = fb_user.user_id;
            user.pwd = fb_user.pwd;
            context.SaveChanges();
        }

    }
}
