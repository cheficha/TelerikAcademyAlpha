using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStudentsByName
{
    public class Student
    {
        public event EventHandler BuyTicket;

        private string fname;
        private string sname;
        public Student(string fname, string sname)
        {
            this.FirstName = fname;
            this.SecondName = sname;
        }
        public string FirstName { get { return this.fname; } set { this.fname = value; } }
        public string SecondName { get { return this.sname; } set { this.sname = value; } }
        public string Print()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.SecondName);
            return sb.ToString();

        }
        public void OnTicketBuy()
        {
            this.BuyTicket?.Invoke(this, null);
        }


    }
}
