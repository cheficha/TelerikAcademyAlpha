using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JediMeditation
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            var input = Console.ReadLine();
            List<string>list = input.Split(' ').ToList();
            var sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0]=='M')
                {
                    sb.Append($"{list[i]} ");
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0] == 'K')
                {
                    sb.Append($"{list[i]} ");

                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i][0] == 'P')
                {
                    sb.Append($"{list[i]} ");

                }
            }

            sb.AppendLine();
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
