using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class GSM
    {
        private static GSM iPhone4S = new GSM("Iphone4S", "Apple");        
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private BatteryType batteryType;



        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }
        public GSM(string model, string manufacturer, int price)
            : this(model, manufacturer)
        {
            this.price = price;
        }
        public GSM(string model, string manufacturer, int price, string owner)
           : this(model, manufacturer, price)
        {
            this.owner = owner;
        }
        public GSM(string model, string manufacturer, int price, string owner, Battery battery)
          : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
        }
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
          : this(model, manufacturer, price, owner, battery)
        {
            this.display = display;
        }
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display, BatteryType batteryType)
          : this(model, manufacturer, price, owner, battery, display)
        {
            this.batteryType = batteryType;
        }
        public string ModelPhone
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }
        public int? Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }
        }
        public static  GSM Iphone4S { get { return iPhone4S; } }

        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            if (this.model != null)
            {
                SB.Append("The Model:" + this.model + "\n");
            }
            if (this.manufacturer != null)
            {
                SB.Append("The Manufacturer:" + this.manufacturer + "\n");
            }
            if (this.price != null)
            {
                SB.Append("The Price:" + this.price + "\n");
            }
            if (this.owner != null)
            {
                SB.Append("The Owner:" + this.owner + "\n");

            }

            if (this.battery?.Model != null)
            {
                SB.Append("The Battery model:" + this.battery.Model + "\n");
            }
            if (this.battery?.HOURSTALK != null)
            {
                SB.Append("The Battery Hours Of Talk:" + this.battery.HOURSTALK + "\n");
            }
            if (this.battery?.HOURSIDLE != null)
            {
                SB.Append("The Battery Hours Idle:" + this.battery.HOURSIDLE + "\n");
            }
            if (this.display?.Size != null)
            {
                SB.Append("The Display size:" + this.display.Size + "\n");
            }
            if (this.display?.NumOfColors != null)
            {
                SB.Append("The Display Number Of Colors:" + this.display.NumOfColors + "\n");
            }

            return SB.ToString();

        }
    }
}
