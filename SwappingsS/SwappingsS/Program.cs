using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingsS
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());///numbers from 1 to length
            string input = Console.ReadLine();///input separators
            string[] arr = input.Split(' ').ToArray();///the separators alone
            var sb = new StringBuilder();
            string line = " ";
            for (int i = 1; i <=length; i++)
            {
                line += i.ToString();
            }
            line=line.Trim();

            for (int i = 0; i < arr.Length; i++)
            {
                var index=line.IndexOf(arr[i]);
                if (index == line.Length - 1)
                {
                    sb.Append($"{line[line.Length-1]}");
                    sb.Append($"{line.Substring(0, line.Length-1)}");
                }
             else   if (index==0)
                {
                    sb.Append($"{line.Substring(1, line.Length - 1)}");
                    sb.Append($"{line[0]}");
                }
                else
                {
                    if (index >= 10)
                    {
                        sb.Append($"{line.Substring(index, line.Length - index - 1)}");
                        sb.Append($"{arr[i]}");
                        sb.Append($"{line.Substring(0, line.Length - (line.Length - index))}");


                    }
                    else
                    {


                        sb.Append($"{line.Substring(index + 1, line.Length - index - 1)}");
                        sb.Append($"{arr[i]}");
                        sb.Append($"{line.Substring(0, line.Length - (line.Length - index))}");
                    }
            }
            line = sb.ToString();
                sb.Clear();
            }
            Console.WriteLine(line);

         
      
    }
}
}
