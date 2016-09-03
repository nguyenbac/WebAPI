using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Comments.Models;
using System.Web.Http;
using Web_API_03.Models;
using System.Collections.Generic;

namespace Web_API_03.Controllers
{
    //[Authorize]
    public class CommentsController : ApiController
    {
        ICommentRepository repository = new InitialData();
        public CommentsController()
        {

        }
        public CommentsController(ICommentRepository repository)
        {
            this.repository = repository;
        }

        #region GET
        //[Queryable]
        public IQueryable<Comment> GetComments()
        {
            return repository.Get().AsQueryable();
        }
        #endregion
        #region Paging get
        public IEnumerable<Comment> Getcomments(int pageindex, int pagesize)
        {
            return repository.Get().Skip(pageindex * pagesize).Take(pagesize);
        }
        #endregion
        public Comment GetComment(int id)
        {
            Comment comment;
            if (!repository.TryGet(id, out comment))
                throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
            return comment;
        }

        // POST api/values

       public HttpResponseMessage Post(Comment comment)
        {
            repository.Add(comment);
            var response = new HttpResponseMessage (HttpStatusCode.Created);
            response.Headers.Location = new Uri(Request.RequestUri, "api/comments/" + comment.ID.ToString());
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public Comment Delete(int id)
        {
            Comment comment;
            if (!repository.TryGet(id, out comment))
                throw new HttpResponseException(HttpStatusCode.NotFound);
            repository.Delete(id);
            return comment;
        }
       
    }
}
