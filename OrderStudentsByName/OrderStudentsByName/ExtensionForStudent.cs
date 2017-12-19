using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderStudentsByName
{
    public static class ExtensionForStudent
    {
        public static void Sort(this Student[]students)
        {
            
            var sorted = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.SecondName);
            foreach (var item in sorted)
            {
                Console.WriteLine(item.Print());
            }



        }
    }
}
