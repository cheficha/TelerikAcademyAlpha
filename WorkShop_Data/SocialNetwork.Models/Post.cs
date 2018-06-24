using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Post
    {
        public Post()
        {
            this.TaggedUsers = new HashSet<UserProfile>();
        }
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime PostedOn { get; set; }

        public ICollection<UserProfile> TaggedUsers { get; set; }
    }
}
