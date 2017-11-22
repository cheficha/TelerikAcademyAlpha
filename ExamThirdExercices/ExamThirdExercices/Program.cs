using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamThirdExercices
{
    class Program
    {
        static void Main(string[] args)

        {
            string input = Console.ReadLine();
            string [] tokens = input.Split(' ');
            int[] numbers = Array.ConvertAll(tokens, int.Parse);
            int a = 0;
            
            List<int> AbsValues = new List<int>();
          
            while (a<=numbers.Length)
            {
                int value = 0;
                if (a + 1 < numbers.Length)
                {
                    

                    value = Math.Abs(numbers[a + 1] - numbers[a]);
                    AbsValues.Add(value);
                    a++;
                }
                else
                {
                    value = Math.Abs(numbers[numbers.Length - 1]) - numbers[numbers.Length - 2];
                    break;
                }
            }
            
            int distance = 0;
            int sum = 0;
            for (int i = 0; i < AbsValues.Count; i++)
            {
                
                if (i + 1 < AbsValues.Count)
                {
                    distance = Math.Abs( AbsValues[i] - AbsValues[i+1]);

                    if (distance % 2 == 0)
                    {
                        
                        sum += distance;
                    }
                    
                   
                }
                else {
                    distance = Math.Abs(AbsValues[AbsValues.Count - 1] - AbsValues[i]);
                    if (distance%2==0)
                    {
                        sum += distance;
                    }
                    

                }
               
            }
            Console.WriteLine(sum);


           
           
           
        }
    }
}
