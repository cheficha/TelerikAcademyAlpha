using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training
{
    static class PathStorage
    {
        private static List<Path> PointsFromFile = new List<Path>();
        private static List<Point3D> PointsToFile = new List<Point3D>();

        public static void ReadPaths()
        {
            Path path = new Path();
            using (StreamReader reader = new StreamReader(@"C:\Users\Freeware Sys\Desktop\Points.txt"))
            {
                while (reader.Peek() > -1)
                {
                  int [] XYZ =reader.ReadLine().Split(',').Select(int.Parse).ToArray();
                    Point3D point = new Point3D(XYZ[0],XYZ[1],XYZ[2]);
                    path.AddPoint(point);
                }
                PointsFromFile.Add(path);
            }
        }
        public static void SavePath(Path path)
        {


            using (StreamWriter writer = new StreamWriter(@"C:\Users\Freeware Sys\Desktop\NewPoints.txt"))

                foreach (Point3D item in path.Sequence)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append("point");
                    str.Append(@"(").Append(item.X).Append(',');
                    str.Append(item.Y).Append(',');
                    str.Append(item.Z).Append(")\n");
                    writer.WriteLine(str.ToString());
                }
            

        }
    }
}
