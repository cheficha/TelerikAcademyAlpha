using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class Student
    {
        private string firstName;
        private string secondName;
        public Student(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string SecondName { get { return this.secondName; } set { this.secondName = value; } }
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.SecondName);
            return sb.ToString();

        }


    }
}
