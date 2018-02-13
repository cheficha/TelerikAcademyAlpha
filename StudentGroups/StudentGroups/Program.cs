using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var marks = new List<double>();
            marks.Add(3.5);
            marks.Add(5.5);
            marks.Add(2.5);
            marks.Add(3.7);
            marks.Add(6.0);
            marks.Add(5.2);
            marks.Add(3.6);

            var student = new Student("Stefan","Zhekov","02/2134",12345,"stefanzhekov95@gmail.com",marks,2);
            var student1 = new Student("Zornitca", "Zhekov", "02/32124",23124, "stefanzhekov95@abv.bg", marks, 2);
            var student2 = new Student("Cheficha", "Petrov", "3512312", 523634, "stefanzhekov295@abv.bg", marks, 3);
            var student3= new Student("Chefak", "Zhekov", "359882911905", 124123, "stefanzhekov95@gmail.com", marks, 1);
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            //students.Group();
            //students.EmailExtract();
            students.SofiaPhones();

        }
    }
}
