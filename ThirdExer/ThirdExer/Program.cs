using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdExer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] field = Console.ReadLine().Split(new[] { ", " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfdirections = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfdirections; i++)
            {
                int position = 0;
                int carrots = 0;               
                int[] directions = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
               

            }

        }
    }
}
