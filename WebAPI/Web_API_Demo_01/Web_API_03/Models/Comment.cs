using Microsoft.Web.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Web_API_03.Models
{
    public class Comment
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="it seems too long")]
        public string Author { get; set; }
        [Required]
        public string  Text { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string GravatarUrl
        {
            get
            {
                return HttpUtility.HtmlDecode(Gravatar.GetUrl(Email ?? " ", 40, defaultImage: "retro", rating: GravatarRating.G));
            }
            set { }
        }
    }
}