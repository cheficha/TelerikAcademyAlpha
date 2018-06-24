using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop_Data;

namespace SocialNetwork.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new SocialNetworkContext();
            ctx.Database.CreateIfNotExists();
            ctx.SaveChanges();
        }
    }
}
