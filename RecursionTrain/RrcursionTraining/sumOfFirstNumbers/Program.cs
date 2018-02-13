using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfFirstNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            SumOfNumbers(n,1,sum);
        }
        public static void SumOfNumbers(int n,int m,int sum )
        {
            if (n<m)
            {
                Console.WriteLine(sum);
                return;
            }
            sum += m;
            SumOfNumbers(n,m+1,sum);

            
        }
    }
}
