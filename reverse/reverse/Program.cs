using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "1+ ( 2 - ( 2 + 3 ) * 4 / ( 3 + 1 ) ) * 5";
            Stack<int> stack = new Stack<int>();
            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='(')
                {
                    stack.Push(i);
                }
                if (input[i]==')')
                {
                    int start = stack.Pop();
                    int end = i;
                    for (int j = start; j <=end; j++)
                    {
                        sb.Append(input[j]);
                      
                    }
                    Console.WriteLine(sb.ToString());
                }
            }
        }
    }

}
