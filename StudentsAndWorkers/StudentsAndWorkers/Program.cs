using StudentsAndWorkers.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> Students = new List<Student>(10);
            List<Worker> Workers = new List<Worker>(10);
            Student pesho = new Student("Pesho","Peshev",GradeType.A);
            Student georgi = new Student("Georgi", "Georgiev", GradeType.B);
            Student chefo = new Student("Chefo", "Cheficha", GradeType.A);
            Student chefak = new Student("Chefak", "Zhekov", GradeType.A);
            Student stefan = new Student("Stefan", "Zhekov", GradeType.C);
            Student ivo = new Student("Ivo", "Zhekov", GradeType.A);
            Student polena = new Student("Polena", "Zhekova", GradeType.A);
            Student ivan = new Student("Ivan", "Ivanov", GradeType.F);
            Student toma = new Student("Toma", "Tomov", GradeType.D);
            Student maimuna = new Student("Monkey", "Coder", GradeType.D);
            Students.Add(pesho);
            Students.Add(georgi);
            Students.Add(chefo);
            Students.Add(chefak);
            Students.Add(stefan);
            Students.Add(ivo);
            Students.Add(polena);
            Students.Add(ivan);
            Students.Add(toma);
            Students.Add(maimuna);
            Worker goshoBaby = new Worker("Gosho", "Baby", 1000, 5);
            Workers.Add(goshoBaby);
            foreach (var item in Workers)
            {
                Console.WriteLine( item.Print());
            }



        }
    }
}
