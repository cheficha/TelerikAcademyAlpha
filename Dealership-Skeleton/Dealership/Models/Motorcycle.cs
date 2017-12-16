using Bytes2you.Validation;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Motorcycle:Vehicle,IMotorcycle
    {

        private string category;
        private readonly int wheels;
        private const VehicleType type = VehicleType.Motorcycle;
        public Motorcycle(string make, string model, decimal price, string category):base(make,model,price)
        {
            Guard.WhenArgument(category, "Category").IsNull().Throw();
            Guard.WhenArgument(category.Length, "Category").IsLessThan(3).IsGreaterThan(10).Throw();
            this.category = category;
            this.wheels = 2;
            this.Type = VehicleType.Motorcycle;
        }


        public override int Wheels { get { return this.wheels; } }

        public string Category { get {return this.category; }set { this.category = value; } }
        public override string AdditionalInfo()
        {
            return $"Category:{this.Category}";
        }
    }
}

