using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingLection
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var arr = Enumerable.Range(1, 1000).Select(x =>x=rand.Next(0,1001)).ToArray();
            Selection<int>.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
