using DatabaseApi.Models;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseApi.Controllers
{
    public class UsersController : ApiController
    {
        User[] users = new User[]
        {
            new User {Id="obj1",Username="dcg",Password="dcg",FirstName="Dhrumesh",LastName="Gandhi" },
            new User {Id="obj2",Username="sdp",Password="sdp",FirstName="Shubh",LastName="Patel" }
        };
        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }
        public IHttpActionResult GetUser(string Id)
        {
            var user = users.FirstOrDefault((p) => p.Id == Id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
    }
}
