using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    static class CalcDistance
    {
        public static int CalcDistanceOfPoints(int x,int y)
        {
            int distance = 0;
            distance = Math.Abs(x - y);
            return distance;
        }
    }
}
