using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Contracts
{
    interface IWorker:IHuman
    {
         float WeekSalary { get; set; }
        float WorkHoursPerDay { get; set; }
        float MoneyPerHour();

    }
}
