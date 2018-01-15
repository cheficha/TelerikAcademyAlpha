using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear5
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int[] arr = str.Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>=0)
                {
                    list.Add(arr[i]);
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
