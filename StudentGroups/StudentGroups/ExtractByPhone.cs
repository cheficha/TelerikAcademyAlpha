using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class ExtractByPhone
    {
        public static void SofiaPhones(this List<Student> students)
        {
            
            var phones =
                from S in students
                where S.FN[0] == '0' && S.FN[1]=='2'
                select S;
            foreach (var item in phones)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
