using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class Order
    {
        public static void Group(this List<Student> students)
        {
            var ordered =
                from S in students
                where S.GroupNumber == 2
                select S;
            ordered.OrderBy(x => x.FirstName);
            foreach (var item in ordered)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
