using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Models.Contracts
{
   public interface IImage
    {
        int UserId { get; set; }
        UserProfile User { get; set; }
    }
}
