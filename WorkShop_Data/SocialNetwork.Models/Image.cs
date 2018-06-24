using SocialNetwork.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models
{
    public class Image
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(4)]
        public string FileExtension { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int UserProfileID { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
