using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Training
{
    class Program
    {

        static void Main(string[] args)
        {
            //Point3D point = new Point3D(5, 6, -2);
            //Point3D point2 = new Point3D(5, 6, 2);
            //Point3D point3 = new Point3D(105,23,123214);

            //Console.WriteLine( point.ToString());
            //int distance = CalcDistance.CalcDistanceOfPoints(point.X, point.Y);
            //Console.WriteLine("This is the Distance between point x=({0}) and point y=({1}): {2}",point.X,point.Y,distance);

            //Path path = new Path();
            //path.AddPoint(point);
            //path.AddPoint(point2);
            //path.AddPoint(point3);
            //PathStorage.SavePath(path);
           
            GenericList<int> elements = new GenericList<int>(4);
            elements.AddElement(1);
            elements.AddElement(2);
            elements.AddElement(3);
            elements.AddElement(4);
          
            Console.WriteLine("MIN"+elements.Min());
            Console.WriteLine("MAX" + elements.Max());




            elements.Print();
           

        }
    }
}

