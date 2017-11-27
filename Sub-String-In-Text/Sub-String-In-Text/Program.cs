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
            string input = Console.ReadLine();
            string text = Console.ReadLine();
            int counter = 1;
            string [] textArr = text.Split(' ');
            for (int i = 0; i < textArr.Length; i++)
            {
                if (textArr[i].Contains(input))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
