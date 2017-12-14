using Shapes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] square = new Square[3];
            Square square1 = new Square(3,3);
            Square square2 = new Square(4, 4);
            Square square3 = new Square(5 ,5);
            square[0] = square1;
            square[1] = square2;
            square[2] = square3;
            foreach (var item in square)
            {
                Console.WriteLine(item.CalculateSurface());
            }
            Triangle[] triangle = new Triangle[3];
            Triangle triangle1 = new Triangle(3, 4);
            Triangle triangle2 = new Triangle(5, 5);
            Triangle triangle3 = new Triangle(6, 4);
            triangle[0] = triangle1;
            triangle[1] = triangle2;
            triangle[2] = triangle3;
            foreach (var item in triangle)
            {
                Console.WriteLine(item.CalculateSurface());
            }





        }
    }
}
