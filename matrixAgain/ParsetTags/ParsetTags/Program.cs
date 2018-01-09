using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace BraketsChecker
    {
        class Program
        {
            static void Main(string[] args)
            {
            string input = Console.ReadLine();
            string change = "<upcase>(.*?)</upcase>";
            string result = Regex.Replace(input, change,kur =>kur.Groups[1].Value.ToUpper());
            Console.WriteLine(result);
        }
        }
    }




