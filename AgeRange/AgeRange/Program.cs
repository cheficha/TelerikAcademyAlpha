using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Stefan", 22);
            var student1 = new Student("Cheficha", 10);
            var student2 = new Student("Gosho", 17);
            var student3 = new Student("Chefaka", 23);
            var student4 = new Student("Pesho", 18);
            var students = new Student[] { student, student1, student2, student3, student4 };
            students.Check();
            

        }
       
    }
}
