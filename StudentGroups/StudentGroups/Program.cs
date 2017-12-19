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

            var student = new Student("Stefan","Zhekov","F74278","stefanzhekov95@gmail.com",marks,2);
            var student1 = new Student("Zornitca", "Zhekov", "F74278", "stefanzhekov95@gmail.com", marks, 2);
            var student2 = new Student("Cheficha", "Petrov", "F74218", "stefanzhekov295@gmail.com", marks, 3);
            var student3= new Student("Chefak", "Zhekov", "F74178", "stefanzhekov95@gmail.com", marks, 1);
            students.Add(student);
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            students.Group();

        }
    }
}
