using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
   public static class Checkerrr
    {
        public static void Check(this Student[] students)
        {
            var AgeChecker =
                      from S in students
                      where S.Age >= 18 && S.Age <= 24
                      select S;
            foreach (var item in AgeChecker)
            {
                Console.WriteLine(item.Print());
            }
        }
    }
}
