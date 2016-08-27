using Microsoft.Web.Helpers;
using System.Web;

namespace Web_API_03.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string  Text { get; set; }
        public string Email { get; set; }
        public string GravatarUrl
        {
            get
            {
                return HttpUtility.HtmlDecode(Gravatar.GetUrl(Email ?? "", 40, defaultImage: "retro", rating: GravatarRating.G));
            }
            set { }
        }
    }
}