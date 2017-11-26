using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Sub_String_In_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(Console.ReadLine());
            string text = Console.ReadLine();
            int counter = 0;
            foreach (Match match in regex.Matches(text))
            {
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
