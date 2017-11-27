using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighboursMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Take(n).Select(int.Parse).ToArray();
            LargerThanNextOrBefore(n,arr);
        }

           static void LargerThanNextOrBefore(int size,int [] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i - 1 >= 0 && i + 1 <= arr.Length - 1)
                {
                    if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
