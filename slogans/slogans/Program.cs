using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slogans
{
    class Program
    {
        public static bool isValid;
        static void Main(string[] args)
        {
            var allowed = new List<string>();
            var sb = new StringBuilder();
            var list = new List<string>();
            var num = int.Parse(Console.ReadLine());
            var counter = 0;
            while (counter != num)
            {
                counter++;
                var allowedWords = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var suggestion = Console.ReadLine();


                isValid = false;
                    UsedWords(suggestion, allowedWords, sb, list);
                    sb.Clear();
                    allowedWords.Clear();

                if (!isValid)
                {
                    Console.WriteLine("NOT VALID");
                }
                
            }

        }
        public static void UsedWords(string slogan, List<string> allowedWords, StringBuilder result, List<string> list)
        {
            var sloganNew = slogan;


            if (sloganNew.Length == 0)
            {
                list.Add(result.ToString());
                return;
            }


            for (int i = 0; i < allowedWords.Count; i++)
            {
                var element = allowedWords[i];
                if (sloganNew.Length >= element.Length)
                {
                    var part = sloganNew.Substring(0, element.Length);
                    if (part == element)
                    {
                        result.Append($"{element} ");

                        sloganNew = slogan.Substring(part.Length);
                        UsedWords(sloganNew, allowedWords, result, list);
                        if (list.Count == 1)
                        {
                            Console.WriteLine(result.ToString().TrimEnd());
                            isValid = true;
                            list.Clear();
                            break;
                        }
                        else
                        {
                            return;
                        }
                    } 
                }


            }




        }
    }
}
