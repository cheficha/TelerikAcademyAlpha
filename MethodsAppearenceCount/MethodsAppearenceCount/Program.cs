using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAppearenceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            GetCountOfNumber(size,input,number);
            
        }

        static void GetCountOfNumber(int size,string input,int number)
        {
            int counter = 0;

            List<string> list = new List<string>();
            string[] numbers = input.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                if (list.Count <= size)
                {

                    list.Add(numbers[i]);
                }
                }
            
            for (int j = 0; j < list.Count; j++)
            {
                
                 int a = int.Parse(list[j]);
                if (a==number)
                {
                    counter++;
                    
                }
                

            }
            Console.WriteLine(counter);




        }
    }
}
