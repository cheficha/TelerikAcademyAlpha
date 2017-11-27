using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsGetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int a = int.Parse(numbers[0]);
            int b= int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            if (a>=b&&b>=c)
            {
                GetMax(a,b);
            }
            else if (b>=c&&c>=a)
            {
                GetMax(b,c);
            }
            else 
            {
                GetMax(a,c);
            }

            
        }

        private static void GetMax(int number,int secNumber)
        {
            if (number>secNumber)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(secNumber);
            }
        }
    }
}
