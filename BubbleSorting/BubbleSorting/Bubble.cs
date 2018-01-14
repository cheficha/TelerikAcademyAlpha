using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class Bubble<T> where T : IComparable<T>
    {
        public static void Sort(T[]arr)
        {
            var isSwapDone = true;
            while (true)
            {
                isSwapDone = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i+1].CompareTo(arr[i])<0)
                    {
                        Swap(i,i+1,arr);
                        isSwapDone = true;
                    }
                }
            }
        }
        private static void Swap(int i, int j, T[] arr)
        {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }

    }
}
