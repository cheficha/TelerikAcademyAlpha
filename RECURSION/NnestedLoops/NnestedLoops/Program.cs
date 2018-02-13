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
        static string[] loops;
        static string[] strings;
        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            elements = int.Parse(Console.ReadLine());

            loops = new string [numberOfLoops];
            for (int i = 0; i < numberOfLoops; i++)
            {
                var input = Console.ReadLine();
                loops[i] = input;
            }
            NestLoop(0);

        }
        public static void NestLoop(int n)
        {
            if (n==numberOfLoops)
            {
                Print();
                return;
            }
            for (int i = 0; i <= elements; i++)
            {

                strings[i] = loops[i];
                    NestLoop(n + 1);

                
            }

        }
        public static void Print()
        {
            foreach (var item in loops)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
        }
    }
}
