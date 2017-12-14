using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;

namespace Shapes.Figures
{
    class Square : Shape
    {
        public Square(double width, double height) : base(width, height)
        {
            Guard.WhenArgument(height, "Height Can't be different than width").IsNotEqual(width).Throw();
            this.Height = this.Width;
        }
        public override double CalculateSurface()
        {
            double surface = 0;
            surface = this.Width * this.Height;
            return surface;
        }
    }
}
