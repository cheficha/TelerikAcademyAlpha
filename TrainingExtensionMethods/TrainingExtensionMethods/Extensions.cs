using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExtensionMethods
{
    public static class Extensions
    {
        public static int WordsCount(this string str)
        {
            return str.Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }




    }
}
