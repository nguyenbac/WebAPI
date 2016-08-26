using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_API_03.Models
{
    public class DictionaryCommentRespository : ICommentRespository
    {
        int nextID = 0;
        Dictionary<int, Comment> comments = new Dictionary<int, Comment>();
        // get all of them 
        public IEnumerable<Comment> Get()
        {
            return comments.Values.OrderBy(p => p.ID);
        }

        // try get \
        public bool TryGet(int id, out Comment comment)
        {
            return comments.TryGetValue(id, out comment);
        }
        // add 
        public Comment Add(Comment cmt)
        {
            cmt.ID = nextID++;
            comments[cmt.ID] = cmt;
            return cmt;
        }
        // Delete 
        public bool Delete(int id)
        {
            return comments.Remove(id);
        }
        // Update 
        public bool Update(Comment cmt)
        {
            bool update = comments.ContainsKey(cmt.ID);
            comments[cmt.ID] = cmt;
            return update;
        }


    }
}