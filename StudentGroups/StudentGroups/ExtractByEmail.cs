using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class ExtractByEmail
    {
        public static void EmailExtract(this List<Student> students)
        {
            var extracted =
                from S in students
                where S.Email.Contains("abv.bg")
                select S;
            foreach (var item in extracted)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
