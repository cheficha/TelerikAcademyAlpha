using StudentsAndWorkers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Users
{
    class Student: Human,IStudent
    {
        private string firstName;
        private string secondName;
        private GradeType grade;
        public Student(string firstName,string secondName,GradeType grade):base(firstName, secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.grade = grade;
        }
        public virtual GradeType Grade{ get { return this.grade; } set { this.grade = value; } }
        public override string AdditionalInfo()
        {
            return $"{this.Grade}";
        }

    }
}
