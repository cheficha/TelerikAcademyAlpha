using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Message
    {
        public int ID { get; set; }
        [Required]
        public UserProfile Author { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime SentOn { get; set; }
        public DateTime SeenOn { get; set; }
    }
}
