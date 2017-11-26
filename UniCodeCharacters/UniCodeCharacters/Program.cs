using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniCodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char [] symbols = text.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
               string  symbol = " ";
                symbol = "\\u" + ((int)symbols[i]).ToString("X").PadLeft(4, '0');               
                Console.Write(symbol);
            }
            
            
        }
    }
}
