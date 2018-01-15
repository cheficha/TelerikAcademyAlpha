using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var arr = input.Split(' ').Select(int.Parse).ToArray();
            var list = new List<int>();
            FindSeq(arr,list);
           
        }
        public static void FindSeq(int [] arr,List<int>list)
        {
            var counter = 0;
            var max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i+1<arr.Length)
                {
                    if (arr[i]==arr[i+1])
                    {
                        counter++;
                        if (counter < max)
                        {
                            list.Clear();
                        }
                        else if (counter>max)
                        {
                            max = counter;
                        }
                        list.Add(arr[i]);
                    }
                    else if (arr[i]!=arr[i+1])
                    {
                        list.Add(arr[i]);
                        counter++;
                        
                      
                    }
                }

            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
