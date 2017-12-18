using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWsubstring
{
    public static class NewSubstring
    {
        public static StringBuilder SubBuilder(this StringBuilder str,int index,int length)
        {
            var newSB = new StringBuilder();
           newSB.Append(str.ToString().Substring(index, length));
            return newSB;

        }
    }
}
