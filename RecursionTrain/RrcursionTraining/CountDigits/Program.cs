using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var sum = 0;
            CountOfDigits(num,sum);
        }
        public static void CountOfDigits(string num , int sum)
        {
            if (num.Length==0)
            {
                Console.WriteLine(sum);
                return;
            }
            sum++;
            num = num.Substring(1,num.Length-1);
            CountOfDigits(num,sum);
        }
    }
}
