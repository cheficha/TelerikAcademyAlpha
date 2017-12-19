using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvisibleNubmers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numbers = new Numbers(arr);
            numbers.Divisible();
            var timer = new Chefo(Timer.Time);
            timer(2);
        }
    }
}
