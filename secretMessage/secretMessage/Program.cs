using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace secretMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
     
            Console.WriteLine(input);
            char[] symbols = input.ToCharArray();
            var num = "";
            var listOfNum = new Stack<int>();
            var stack = new Stack<char>();
            num = NumsInString(symbols, num, listOfNum);
            for (int i = symbols.Length - 1; i >= 0; i--)
            {
                if (symbols[i]=='}')
                {
                    stack.Push()
                }
            }

        }

        private static string NumsInString(char[] symbols, string num, Stack<int> listOfNum)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (char.IsDigit(symbols[i]))
                {
                    while (char.IsDigit(symbols[i]) && i + 1 < symbols.Length)
                    {
                        num += symbols[i];
                        i++;
                    }
                    listOfNum.Push(int.Parse(num));
                    num = "";
                    i--;
                }
            }

            return num;
        }
    }

}
