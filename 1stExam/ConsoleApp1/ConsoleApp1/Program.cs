using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Battery battery = new Battery();
            //Display display = new Display();
            GSM iphone6s = new GSM("iphone6s","Apple",1000,"Stefan");
            GSM samsungs7 = new GSM("Samsung S7","Samsung",1200,"Ivan",new Battery("12P23SD",7,4.5),new Display(7,10));
            
            GSMtest test = new GSMtest(new GSM[] {iphone6s,samsungs7});
            Console.WriteLine(test);
          
        }
    }
}
