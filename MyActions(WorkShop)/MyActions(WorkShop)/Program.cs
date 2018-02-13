using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyActions_WorkShop_
{
    class Program
    {
        static void Main(string[] args)
        {
            var inut = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = inut[0];
            var M = inut[1];
            bool[] used = new bool[N];
            var parentsCount = new int[N];
            var childs = new List<int>[N];
            Read(M, parentsCount, childs);

            bool allUsed = false;
            while (!allUsed)
            {
                allUsed = true;
                for (int i = 0; i < N; i++)

                {
                    if (parentsCount[i] == 0 && !used[i])
                    {
                        used[i] = true;
                        Console.WriteLine(i);
                        if (childs[i]!=null)
                        {
                            foreach (var item in childs[i])
                            {

                                parentsCount[item]--;
                            }
                        }
                        allUsed = false;
                        break;
                    }


                }

            }





        }

        private static void Read(int M, int[] parentsCount, List<int>[] childs)
        {
            for (int i = 0; i < M; i++)
            {

                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var parent = input[0];
                var child = input[1];
                parentsCount[child]++;
                if (childs[parent] == null)
                {
                    childs[parent] = new List<int>();
                }
                childs[parent].Add(child);

            }
        }
    }
}
