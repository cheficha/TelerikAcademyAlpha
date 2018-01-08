using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NnestedLoops
{
    class Program
    {
        static int numberOfLoops;
        static int elements;
        static int[] loops;
        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
             elements = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestLoop(0);

        }
        public static void NestLoop(int n)
        {
            if (n==numberOfLoops)
            {
                Print();
                return;
            }
            for (int i = 1; i <= elements; i++)
            {
                loops[n] = i;
                 NestLoop(n+1);
            }

        }
        public static void Print()
        {
            foreach (var item in loops)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
