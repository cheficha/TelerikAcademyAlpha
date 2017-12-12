using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    struct Point3D
    {
        private static readonly Point3D point0 = new Point3D(0,0,0);
        public static Point3D Point0 { get { return point0; } }
        private int x;
        private int y;
        private int z;


        public Point3D(int x,int y,int z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("The zero point:"+Point0.X+" "+Point0.Y+" "+Point0.Z+"\n");
            SB.Append("Cordinates for x:"+X+"\n");
            SB.Append("Cordinates for y:"+ Y + "\n");
            SB.Append("Cordinates for z:"+ Z + "\n");

            return SB.ToString();
        }
    }
}
