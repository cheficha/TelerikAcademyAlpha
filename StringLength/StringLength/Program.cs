using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder str = new StringBuilder(text);
            if (str.Length >= 20)
            {
                Console.WriteLine(text);
            }
            else if(str.Length<20)
            {
                while (str.Length!=20)
                {
                    str.Append("*");
                }
                Console.WriteLine(str.ToString());
            }
           
        }
    }
}
