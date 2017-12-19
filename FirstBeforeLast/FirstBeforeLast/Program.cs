using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Cheficha","Zhekov");
            var student1 = new Student("Asen", "Petrov");
            var student2 = new Student("Zornitca", "Asenova");
            var students = new Student[] { student, student1, student2 };
            students.Students();


        }
    }
}

