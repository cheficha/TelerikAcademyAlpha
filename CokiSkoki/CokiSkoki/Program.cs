using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokiSkoki
{
    class Program
    {
        static int pos = 0;
        static int jump;
        static int[] seq;
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var buildings = input.Split(' ').Select(int.Parse).ToArray();
            seq = new int[num];
            for (int i = 0; i < num; i++)
            {
                var A = i;
                pos++;
                for (int j = pos; j < buildings.Length; j++)
                {
                    if (i+ 1 < buildings.Length)
                    {

                        if (buildings[A] < buildings[j])
                        {
                            jump++;
                            A = j;
                        }
                        
                    }
                }
                A = 0;
                seq[i] = jump;
                
               
                jump = 0;
            }
            Console.WriteLine(seq.Max());
            foreach (var item in seq)
            {
            
                Console.Write(item + " ");

            }
            Console.WriteLine();
           
        
        }

    }


    
}
