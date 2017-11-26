using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string URL = Console.ReadLine();
            string [] protocol=URL.Split(':');
            Console.WriteLine("[protocol] = {0}",protocol[0]);
            StringBuilder str = new StringBuilder();
            string[] server = URL.Split('/');
            Console.WriteLine("[server] = {0}",server[2]);
            for (int i = 3; i < server.Length; i++)
            {
                str.Append("/");
                str.Append(server[i]);
            }
            Console.WriteLine("[resource] = {0}",str.ToString());

          
        }
    }
}
