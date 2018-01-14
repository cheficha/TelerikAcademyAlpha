using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteDict
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        {
            string text = "a text some text just some text";
            var arr = text.Split(' ').ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict.Add(item,1);
                }
            }
            foreach (var item in dict)
            {
                Console.Write(item.Key+"->");
                Console.WriteLine(item.);
            }
        }
    }
}
