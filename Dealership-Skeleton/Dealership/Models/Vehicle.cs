using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;

namespace Dealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        private  int wheels;
        private string make;
        private string model;
        private VehicleType type;
        private decimal price;
        private IList<IComment> comments = new List<IComment>();
        protected Vehicle(string make, string model, decimal price)
        {
            Guard.WhenArgument(make, "Make is null").IsNull().Throw();
            Guard.WhenArgument(make.Length, "Make").IsGreaterThan(15).IsLessThan(2).Throw();
            ///make validation
            Guard.WhenArgument(model, "Model is null").IsNull().Throw();
            Guard.WhenArgument(model.Length, "Model").IsGreaterThan(15).IsLessThan(2).Throw();
            //model validation
            Guard.WhenArgument(price, "Price").IsLessThan(0).Throw();
            Guard.WhenArgument(price, "Price").IsGreaterThan(1000000).Throw();


            this.make = make;
            this.model = model;
            this.price = price;
            this.wheels = 0;
            this.type = VehicleType.Car;
        }

        public virtual int Wheels { get { return this.wheels; } set {this.wheels=value; } }

        public VehicleType Type { get { return this.type; } set { this.type = value; } }

        public string Make { get { return this.make; } set { this.make = value; } }

        public string Model { get { return this.model; } set { this.model = value; } }

        public IList<IComment> Comments {get{return this.comments;} set { this.comments = value; } }

        public decimal Price { get {return this.price; }set { this.price = value; } }
        public override string ToString()
        {
            var SB = new StringBuilder();
            SB.AppendLine($"{this.Type}:");
            SB.AppendLine($"Make:{this.Make}");
            SB.AppendLine($"Model:{this.Model}");
            SB.AppendLine($"Wheels:{this.Wheels}");
            SB.AppendLine($"Price:{this.Price}");
            SB.AppendLine(AdditionalInfo());
            if (Comments.Count==0)
            {
                SB.AppendLine("--NO COMMENTS--");
                
            }
            else
            {
                SB.AppendLine("--COMMENTS--");
                foreach (var item in Comments)
                {
                    SB.AppendLine($"----------");
                    SB.AppendLine($"{item.Content}");
                    SB.AppendLine($"User:{item.Author}");
                }
            }
            return SB.ToString().Trim();
        }
        public virtual string AdditionalInfo()
        {
            return $"No additional info";
        }
    }
}
