using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string upCase = "<upcase>";
            string upCaseEnd = "</upcase>";
            
            int start = text.IndexOf(upCase);
            int stop = text.IndexOf(upCaseEnd);
            
            

            while (start  != -1 && stop != -1)
            {
                string change = text.Substring(start + 8, stop-(start+8)).ToUpper();
                text = text.Replace(text.Substring(start, (stop+9)-start), change);
                start = text.IndexOf(upCase);
                stop = text.IndexOf(upCaseEnd);
            }
            Console.WriteLine(text);
           
        }
    }
}
