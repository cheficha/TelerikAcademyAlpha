using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            char[] reversed = new char[word.Length];
            var word1 = word.ToCharArray();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed[i] = word[i];
            }

            var result = word1.Equals(reversed);
            if (result==true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
     
    }
}
