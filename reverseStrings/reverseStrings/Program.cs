using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] text = str.ToCharArray();
            char [] reverse = new char [text.Length];
            int a = 0;
            for (int i = text.Length-1; i >=0; i--)
            {
                reverse[a]=text[i];
                a++;
            }
            for (int j = 0; j < reverse.Length; j++)
            {
                Console.Write(reverse[j]);
            }
            Console.WriteLine();
        }
    }
}
