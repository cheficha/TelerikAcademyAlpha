using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudentsByName
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Cheficha","Zhekov");
            var student1 = new Student("Zorq", "Asenova");
            var student2 = new Student("Zorq", "Zhekov");
            var student3 = new Student("Anita", "Chickita");
            var student4 = new Student("Stefan", "Zhekov");
            var student5 = new Student("Teodora", "Petrova");
            var students = new Student[] {student,student1,student2,student3,student4,student5 };
            students.Sort();

        }
    }
}
