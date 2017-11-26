using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] singleChar = input.ToCharArray();
            List<char> final = new List<char>();
            for (int i = 0; i <singleChar.Length-1; i++)
            {
                
                    if (singleChar[i]!=singleChar[i+1])
                    {
                        final.Add(singleChar[i]);
                    }
                
            }
            for (int j = 0; j <final.Count; j++)
            {
                Console.Write(final[j]);
            }
          
                Console.Write(singleChar[singleChar.Length-1]);
         
            Console.WriteLine();
        }
    }
}
