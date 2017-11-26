using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraketsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            const char Left = '(';
            const char Right = ')';
            string input = Console.ReadLine();
            char[] text = input.ToCharArray();
            uint counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Equals(Left))
                {
                    counter++;
                }
                else if (text[i].Equals(Right))
                {
                    counter--;
                }
            }
            if (counter!=0)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
