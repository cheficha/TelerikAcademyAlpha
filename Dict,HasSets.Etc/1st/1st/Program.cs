using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var words = input.Split(' ').ToArray();
            var counter = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item,1);
                }

            }
            foreach (var item in counter)
            {
                Console.Write(item.Key+" is in the text "+item.Value+" times");
                Console.WriteLine();

            }

        }
    }
}
