using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MessagesInBottle
{
    class Program
    {
        static char current;
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();
            string cipher = Console.ReadLine();
            string pattern = @"([A-Z]+)(\d+)";

            SortedDictionary<char, string> letterToCodeMap = new SortedDictionary<char, string>();
            MatchCollection matches = Regex.Matches(cipher, pattern);
            foreach (Match match in matches)
            {
                char letter = match.Groups[1].Value[0];
                string code = match.Groups[2].Value;
                if (!letterToCodeMap.ContainsKey(letter))
                {
                    letterToCodeMap.Add(letter, code);
                }
            }

            StringBuilder messageBuilder = new StringBuilder();
            List<string> originalMessages = new List<string>();
            FindCombos(secretMessage, letterToCodeMap, messageBuilder, originalMessages);

            Console.WriteLine(originalMessages.Count);
            if (originalMessages.Count > 0)
            {
                Console.WriteLine(string.Join("\n", originalMessages));
            }


        }
        public static void FindCombos(string secretMessage, SortedDictionary<char, string>checker,StringBuilder sb ,List<string>list)
        {
            if (secretMessage==string.Empty)
            {
                list.Add(sb.ToString());
                return;

            }
            foreach (var item in checker)
            {
                var key = item.Key;
                var value = item.Value;
                if (secretMessage.StartsWith(value))
                {
                    sb.Append($"{key}");
                    var newSecret = secretMessage.Substring(value.Length);
                    FindCombos(newSecret,checker,sb,list);
                    sb.Remove(sb.Length-1,1);
                }
            }

        }
    }
}
