using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Contracts
{
    interface IShape
    {
        double Width { get; set; }
        double Height { get; set; }
        double CalculateSurface();

    }
}
