using Shapes.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape : IShape
    {
        private double width;
        private double height;
        protected Shape(double width,double height)
        {
            this.width = width;
            this.height=height;
        }
        public double Width { get {return this.width; } set {this.width=value; } }
        public double Height { get { return this.height; } set { this.height = value; } }
        public virtual  double CalculateSurface()
        { double surface = 0;
            return surface;
        }

    }
}
