using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] newtext = input.Split('"');
            newtext[0] = newtext[0].Replace(" <a href=", "[our site]");
            for (int i = 0; i <newtext.Length; i++)
            {
                Console.WriteLine(newtext[i]);
            }
        }
    }
}
