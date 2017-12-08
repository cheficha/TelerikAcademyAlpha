using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Display
    {
        private int ?size;
        private int ?numOfColors;
        public Display(int size)
        {
            this.size = size;        
        }
        public Display(int size,int numOfColors)
            :this(size)
        {
            this.numOfColors = numOfColors;
        }
        public int? Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public int ?NumOfColors
        {
            get
            {
                return numOfColors;
            }
            set
            {
                numOfColors = value;
            }
        }

    }
}
