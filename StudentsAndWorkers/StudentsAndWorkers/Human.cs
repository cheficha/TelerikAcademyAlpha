using StudentsAndWorkers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
   public abstract class Human: IHuman
    {
        private string firstName;
        private string secondName;
        protected  Human(string fname,string sname)
        {
            this.firstName = fname;
            this.secondName = sname;
        
        }
        public string FirstName { get {return this.firstName; } set {this.firstName=value; } }
        public string SecondName { get { return this.secondName; } set { this.secondName = value; } }
        public virtual string Print()
        {
            return $"{this.FirstName},{this.SecondName},{this.AdditionalInfo()}";
        }
        public virtual string AdditionalInfo() {

            return $"No additional info";
        }



    }
}
