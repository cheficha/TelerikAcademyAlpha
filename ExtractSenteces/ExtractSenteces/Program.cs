using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSenteces
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string [] sentences = text.Split('.');
            StringBuilder str = new StringBuilder();
            List<char> symbols = new List<char>();
            
            for (int j = 0; j <text.Length; j++)
            {
                if (!Char.IsLetter(text[j]))
                {
                    symbols.Add(text[j]);
                }
            }
           char [] symbolS = symbols.ToArray();

            for (int i = 0; i < sentences.Length; i++)
            {
               string [] words = sentences[i].Split(symbolS).ToArray();
                for (int j = 0; j < words.Length; j++)
                {
                    if (word.Equals(words[j]))
                    {
                        str.Append(sentences[i].Trim()+". ");
                        
                        
                    }
                }

            }
            Console.Write(str.ToString().TrimEnd());
        }
    }
}
