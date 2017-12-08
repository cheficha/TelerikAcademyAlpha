using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class GSMtest
    {
        private  GSM[] someGsm;
       
        public GSMtest(GSM[]someGsm)
        {
            this.someGsm = someGsm;
        }
        public GSM [] SomeGsmArr {
            get
            {
                return someGsm;

            }  
            set
            {
                someGsm = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (GSM item in someGsm)
            {
                sb.Append(item.ToString());
            }
            sb.Append(GSM.Iphone4S);
            return sb.ToString();
        }

       



    }
}
