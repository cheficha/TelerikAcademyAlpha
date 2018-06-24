using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace SupermarketQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            var names = new StringBuilder();
            var ppl = new BigList<string>();
            var dict = new Dictionary<string,int>();
            string terminationCommand = "End";
            while ((input = Console.ReadLine()) != terminationCommand)
            {
                var parameters = input.Split().ToArray();
                switch (parameters[0])
                {
                    case "Append":
                        Append(parameters[1], ppl,dict,names);
                        break;
                    case "Serve":
                        Serve(int.Parse(parameters[1]), ppl, dict, names);
                        break;
                    case "Find":
                        Find(parameters[1], ppl, dict, names);
                        break;
                    case "Insert":
                        Insert(int.Parse(parameters[1]), parameters[2], ppl, dict, names);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(names.ToString());


        }
        public static void Insert(int pos, string name, BigList<string> names,Dictionary<string,int>dict,StringBuilder result)
        {
            if (pos < 0 || pos > names.Count)
            {
                result.AppendLine("Error");
            }
            else
            {
                names.Insert(pos, name);
                result.AppendLine("OK");
                if (dict.ContainsKey(name))
                {
                    dict[name]++;
                }
                else
                {
                    dict.Add(name,1);
                }
            }
        }
        public static void Find(string name, BigList<string> names, Dictionary<string, int> dict, StringBuilder result)
        {
            if (dict.ContainsKey(name))
            {
                result.AppendLine($"{dict[name]}");
            }
            else
            {
                result.AppendLine("0");
            }
        }
        public static void Append(string name, BigList<string> names, Dictionary<string, int> dict, StringBuilder result)
        {
            names.Add(name);
            if (dict.ContainsKey(name))
            {
                dict[name]++;
            }
            else
            {
                dict.Add(name, 1);
            }
            result.AppendLine("OK");

        }
        public static void Serve(int count, BigList<string> names, Dictionary<string, int> dict, StringBuilder result)
        {
            if (count < 0 || count >= names.Count + 1)
            {
                result.AppendLine("Error");
            }
            else
            {
                var sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    sb.Append($"{names[i]} ");
                    dict[names[i]]--;
                }
                names.RemoveRange(0, count);

                result.AppendLine(sb.ToString().TrimEnd());
            

            }
        }
    }
}