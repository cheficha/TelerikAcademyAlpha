using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIsplayDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var sb = new StringBuilder();
            Digits(num,sb);

        }
        public static void Digits(string num,StringBuilder sb)
        {
            if (num.Length==0)
            {
                Console.WriteLine(sb.ToString().Trim());
                return;
            }
            sb.Append($"{num[0]} ");
            num = num.Substring(1,num.Length-1);
            Digits(num,sb);
        }
    }
}
