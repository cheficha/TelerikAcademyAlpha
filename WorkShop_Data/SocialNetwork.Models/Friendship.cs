using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Friendship
    {
        public Friendship()
        {
            this.Messages = new HashSet<Message>();
        }
        public int ID { get; set; }


        public int SenderId { get; set; }

        [ForeignKey("SenderId")]
        public UserProfile Sender { get; set; }

        public int ReceiverId { get; set; }

        [ForeignKey("ReceiverId")]
        public UserProfile Receiver { get; set; }

        public bool ApprovedStatus { get; set; }

        public DateTime? FriendsSince { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
    }
}
