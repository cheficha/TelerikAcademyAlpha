using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear7
{
    class Program
    {
        static StringBuilder sb;
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = input.Split(' ').Select(int.Parse).ToList();
         var dist = list.Distinct().ToList();
            for (int i = 0; i < dist.Count; i++)
            {
                var counter = list.Where(x => x == dist[i]).Count();
                 sb = new StringBuilder();
                sb.AppendLine($"{dist[i]}->>>>>>>{counter}");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
