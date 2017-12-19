using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    static class NameSort
    {
        public static void Students(this Student[] students)
        {
            var studentName =
                from S in students
                where S.FirstName[0] < S.SecondName[0]
                select S;
            foreach (var item in studentName)
            {
                Console.WriteLine(item.Print());
            }




        }
    }
}
