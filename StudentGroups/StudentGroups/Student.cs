using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class Student
    {
        private string firstname;
        private string lastname;
        private string fN;
        private string email;
        private List<double> marks;
        private int groupNumber;
        public Student(string firstname,string lastname,string fN,string email,List<double>marks,int groupNumber)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.FN = fN;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        public string FirstName { get { return this.firstname; } set { this.firstname = value; } }
        public string LastName { get { return this.lastname; } set { this.lastname = value; } }
        public string FN { get { return this.fN; } set { this.fN = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public List<double> Marks{ get { return this.marks; }set {this.marks=value; } }
        public int GroupNumber { get { return this.groupNumber; }set {this.groupNumber=value; } }
        public override string ToString()
        {
            return $" First Name :{this.FirstName}\n\r Second Name:{this.LastName}\r\n FN:{this.FN}\r\n Email:{this.Email} \r\n Group Number:{this.GroupNumber}";
        }

    }
}
