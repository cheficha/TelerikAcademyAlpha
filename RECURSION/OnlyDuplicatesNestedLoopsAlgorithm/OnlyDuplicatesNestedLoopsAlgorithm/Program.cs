using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyDuplicatesNestedLoopsAlgorithm
{
    class Program
    {
        static int LoopsN;
        static int CountK;
        static int[] loops;
        static void Main(string[] args)
        {
            Console.WriteLine("N: ");
            LoopsN = int.Parse(Console.ReadLine());
            Console.WriteLine("K:");
            CountK = int.Parse(Console.ReadLine());
            loops = new int[LoopsN];
            NotDuplicates(0);

        }
        public static void NotDuplicates(int currentLoop)
        {
            if (currentLoop==LoopsN)
            {
                Print();
                return;
            }
            for (int i = 1; i <= CountK; i++)
            {
                loops[currentLoop] = i;
                NotDuplicates(currentLoop+1);
            }
        }
        public static void Print()
        {
            for (int i = 0; i < loops.Length; i++)
            {
                if (i + 1 <= loops.Length - 1)
                {
                    if (loops[i] != loops[i + 1])
                    {
                        Console.Write(loops[i] + " "+loops[i+1]);
                        Console.WriteLine();
                    }
                    
                }
            }
        }
    }
}
