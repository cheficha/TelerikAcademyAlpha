using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int sum = 1;
            Fact(num,sum);
        }
        public static void Fact(int num,int sum)
        {
            if (num==1)
            {
                Console.WriteLine(sum);
                return;
            }
            sum *= num;
            Fact(num-1,sum);
        }
    }
}
