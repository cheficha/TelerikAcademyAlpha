using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RrcursionTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            PrintNumbers(1,nums,sb);

        }
        public static void PrintNumbers(int n,int m,StringBuilder sb)
        {
            if (n>m)
            {
                Console.WriteLine(sb.ToString().Trim());
                return;
            }
            sb.Append($"{n} ");
            PrintNumbers(n+1,m,sb);
        }
    }
}
