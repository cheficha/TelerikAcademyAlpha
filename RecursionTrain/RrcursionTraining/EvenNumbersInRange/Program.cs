using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(':').ToList();
            var start = int.Parse(input[0]);
            var end = int.Parse(input[1]);
            var sb = new StringBuilder();
            EvenNumbers(start,end,sb);

        }
        public static void EvenNumbers(int start,int end ,StringBuilder sb)
        {
            if (start==end)
            {
                Console.WriteLine(sb.ToString().Trim());
                return;
            }
            if (start%2==0)
            {
                sb.Append($"{start} ");
            }
            start++;
            EvenNumbers(start,end,sb);
        }
    }
}
