using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWsubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var sb = new StringBuilder();
            sb.Append("Az");
            sb.Append("sum");
            sb.Append("mnogo");
            sb.Append("gotin");
            sb.Append("ve");
            sb.Append("brat");
            Console.WriteLine( sb.SubBuilder(0,8));

        }
    }
}
