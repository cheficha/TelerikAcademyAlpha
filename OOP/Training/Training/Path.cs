using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Path
    {
        private List<Point3D> sequence;
        public Path()
        {
            this.sequence = new List<Point3D>();
        }
        public Path(List<Point3D>sequence)
        {
            this.sequence = sequence;
        }
        public List<Point3D> Sequence { get { return this.sequence; }}
        public void AddPoint(Point3D point)
        {
            sequence.Add(point);
        }
     
    }
}
