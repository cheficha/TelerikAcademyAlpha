using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = @"<a href=""";
            string another = @">""";
            text = text.Replace(word, "[");
            text = text.Replace(another, "]");
            Console.WriteLine(text);



        }
    }
}
