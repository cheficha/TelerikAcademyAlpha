using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIvisibleNubmers
{
   public class Numbers
    {
        private int[] numbers;
        public Numbers(int [] numbers)
        {
            this.AllNumbers = numbers;
        }
        public int [] AllNumbers { get { return this.numbers; } set {this.numbers=value; } }
    }
}
