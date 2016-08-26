using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_02.Controllers
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName  { get; set; }
    }
    //[Authorize]
    public class PersonController : ApiController
    {
        // GET api/values
        public IEnumerable<Person> Get()
        {
            return new List<Person>
            {
                new Person { ID =1,FirstName="Nguyen", LastName="Hinh"},
                 new Person { ID =2,FirstName="Le", LastName="Bac"},
                  new Person { ID =3,FirstName="Tran", LastName="Hai"},
            };
        }

        // GET api/values/5
        public Person Get(int id)
        {
            return null;
        }

        // POST api/values
        public void Post([FromBody]Person value)
        {

        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Person value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
