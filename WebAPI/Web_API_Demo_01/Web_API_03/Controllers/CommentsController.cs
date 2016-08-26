using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_03.Models;

namespace Web_API_03.Controllers
{
    //[Authorize]
    public class CommentsController : ApiController
    {
        public ICommentRespository res = new DictionaryCommentRespository();
        // GET api/values
        public IEnumerable<Comment> Get()
        {
            return res.Get();
        }

        // GET api/values/5
        public Comment Get(int id)
        {
            var res = new DictionaryCommentRespository();
            Comment comment;
            if (!res.TryGet(id, out comment))
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return comment;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
