using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwords
{
    class Program
    {
        static public int counter = 0;
        static bool isZeroUsed = false;

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string symbols = Console.ReadLine();
            int variation = int.Parse(Console.ReadLine());
            var result = new List<string>();
            Generate(variation, "", symbols, result);

        }

        public static void Generate(int variation, string password, string symbols, List<string> result)
        {


            if (password.Length == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    Generate(variation, i.ToString(), symbols, result);
                }
                isZeroUsed = false;
                return;
            }
            if (password.Length - 1 >= symbols.Length)
            {
                

                counter++;

                if (counter == variation)
                {
                    Console.WriteLine(password);

                    Environment.Exit(0);
                }
                return;
            }
            //=
            if (symbols[password.Length - 1] == '=')
            {
                Generate(variation, password + password[password.Length - 1], symbols, result);
            }
            //<
            else if (symbols[password.Length - 1] == '<')
            {
                if (password[password.Length - 1] == '0')
                {
                    for (char i = '1'; i <= '9'; i++)
                    {
                        Generate(variation, password + i, symbols, result);
                    }
                }
                else
                {
                    for (char i = '1'; i < (char)(password[password.Length - 1]); i++)
                    {
                        Generate(variation, password + i, symbols, result);
                    }
                }

            }

            //>
            else if (symbols[password.Length - 1] == '>' && password[password.Length - 1] != '0')
            {
                if (!isZeroUsed)
                {
                    Generate(variation, password + '0', symbols, result);
                   
                }

                for (char i = (char)(password[password.Length - 1] + 1); i <= '9'; i++)
                {
                    Generate(variation, password + i, symbols, result);
                }

            }

        }
    }
}