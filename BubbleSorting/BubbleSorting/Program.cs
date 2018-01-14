using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            long arr = TimeFind();
        }
        private static long TimeFind()
        {
            var rand = new Random();
            var arr = Enumerable.Range(0, 1000).Select(x => rand.Next(0, 1001)).ToArray();
            var sw = new Stopwatch();
            var elapsed = 0L;
            for (int i = 0; i < 1; i++)
            {
                sw.Restart();
                Bubble<int>.Sort(arr);

            }
        }
    }
}
