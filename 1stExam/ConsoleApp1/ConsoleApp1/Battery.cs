using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Battery
    {
        private string model;
        private double ?hoursIdle;
        private double ?hoursTalk;
       
        public Battery(string model)
        {
            this.model = model;
        }
        public Battery(string model,double hoursIdle)
            :this(model)
        {
            this.hoursIdle = hoursIdle;
        }
        public Battery(string model, double hoursIdle,double hoursTalk)
            : this(model,hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }
        public string Model {
            get {
                return model ;
            }
            set {
                model = value;
            }
        }
        public double ?HOURSIDLE
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                hoursIdle = value;
            }
        }
        public double ?HOURSTALK
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                hoursTalk = value;
            }
        }

    }
}
