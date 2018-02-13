using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearchingLection
{
    public class Selection<T> where T : IComparable<T>
    {
        public static void Sort(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                var min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[min]) < 0)
                    {
                        min = j;
                    }
                }
                Swap(min,i,arr);

            }
        }
        private static void Swap(int i, int j, int[] arr)
        {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
        }
    }
}
