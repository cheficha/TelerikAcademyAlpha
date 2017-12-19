using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeRange
{
    public class Student
    {
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Age.ToString());
            return sb.ToString();

        }
   

    }
}
