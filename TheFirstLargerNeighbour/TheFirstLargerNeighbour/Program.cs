using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstLargerNeighbour
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Take(size).Select(int.Parse).ToArray();
            FirstLargerNeighbour(size,arr);
        }

        static void FirstLargerNeighbour(int size, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i - 1 >= 0 && i + 1 <= arr.Length - 1)
                {
                    if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
           
        }
    }
}
