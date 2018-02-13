using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerySimpleNto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            PrintNumbersReverse(1,n,sb);

        }
        public static void PrintNumbersReverse(int n,int m ,StringBuilder sb)
        {
            if (m<n)
            {
                Console.WriteLine(sb.ToString().Trim());
                return;
            }
            sb.Append($"{m} ");
            PrintNumbersReverse(n,m-1,sb);
        }
    }
}
