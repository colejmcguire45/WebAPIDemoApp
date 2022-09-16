using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my peeps
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Cole", LastName = "McGuire", Id = 1 });
            people.Add(new Person { FirstName = "John", LastName = "Doe", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 3 });
            people.Add(new Person { FirstName = "Mike", LastName = "Honcho", Id = 4 });
        }

        /// <summary>
        /// Gets a list of the first names of all users.
        /// </summary>
        /// <returns>A list of first names...</returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames() 
        {
            return people.Select(p => p.FirstName).ToList();
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
