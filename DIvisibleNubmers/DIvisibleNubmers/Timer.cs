using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
namespace DIvisibleNubmers
{
   public  class Timer
    {
        public static void Time(int sec)
        {
            var interval = new Stopwatch();
            interval.Start();
            while (true)
            {
                if (interval.ElapsedMilliseconds == sec * 1000)
                {
                    Console.WriteLine("Cheficha e gotin");
                    interval.Restart();
                }
             
            }
        }
    }
}
