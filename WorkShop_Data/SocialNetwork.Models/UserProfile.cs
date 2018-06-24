using SocialNetwork.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace SocialNetwork.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            this.Images = new HashSet<Image>();
        }
        public ICollection<Image> Images { get; set; }

        public int ID { get; set; }
        [Required]
        [Index(IsUnique=true)]
        [StringLength(20, MinimumLength = 4)]
        public string Username { get; set; }

        [StringLength(50,MinimumLength =2)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set;}

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public DateTime RegisteredOn { get; set; }
        
        
    }
}
