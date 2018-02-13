using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = input[0];
            int m = input[1];
            List<int>[] childs = new List<int>[n];
            int[] parentsCount = new int[n];
            bool[] visited = new bool[n];
            for (int i = 0; i < m; i++)
            {
                var pair = Console.ReadLine().Split().Select(int.Parse).ToList();
                int parent = pair[0];
                int child = pair[1];
                parentsCount[child]++;
                if (childs[parent] == null)
                {
                    childs[parent] = new List<int>();

                }
                childs[parent].Add(child);

            }

            bool areVisited = false;
            while (!areVisited)
            {
                areVisited = true;
                for (int i = 0; i < n; i++)
                {
                    if (parentsCount[i]==0&&visited[i]==false)
                    {
                        Console.WriteLine(i);
                        visited[i] = true;
                        if (childs[i] != null)
                        {


                            foreach (var item in childs[i])
                            {
                                parentsCount[item]--;

                            }
                        }
                        areVisited = false;
                        break;
                    }
                }
            }


        }
        private static void BubbleSort(List<int> numbers)
        {
            bool swapped = false;
            while (!swapped)
            {
                swapped = true;
                for (int i = 0; i < numbers.Count-1; i++)
                {
                    if (numbers[i] > numbers[i+1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        swapped = false;
                    }
                }
            }
        }
    }
}
