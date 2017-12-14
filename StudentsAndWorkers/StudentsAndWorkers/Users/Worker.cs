using StudentsAndWorkers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Users
{
    class Worker: Human,IWorker
    {
        private string firstName;
        private string secondName;
        private float weekSalary;
        private float workHoursPerDay;
        public Worker(string firstName,string secondName,float weekSalary,float workHoursPerDay):base(firstName,secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public float WeekSalary { get {return this.weekSalary; } set { this.weekSalary = value ; } }
        public float WorkHoursPerDay { get { return this.workHoursPerDay; } set { this.workHoursPerDay = value; } }

        public float MoneyPerHour()
        {
            float result = this.WeekSalary/(this.WorkHoursPerDay*7);
            return result;
           
        }
        public override string AdditionalInfo()
        {
            return $"The money earned per Hour are:{this.MoneyPerHour()}lv.";
        }

    }
}
