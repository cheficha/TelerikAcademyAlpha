using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedNumbersMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        private static void ReverseNumber(string number)
        {
            char[] reversed = number.ToCharArray();
            
            for (int i = reversed.Length-1; i >=0; i--)
            {
                Console.Write(reversed[i]);
            }
            Console.WriteLine();
        }
    }
}
