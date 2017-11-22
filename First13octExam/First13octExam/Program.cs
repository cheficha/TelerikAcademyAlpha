using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First13octExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int days= int.Parse(Console.ReadLine());
            DateTime data = new DateTime(year,month,days);
            DateTime FinalDate = data.AddDays(-1);
            string format = "d-MMM-yyyy";
            Console.WriteLine(FinalDate.ToString(format));
        }
    }
}
