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
    public class Truck:Vehicle,ITruck
    {
        private int weightCapacity;
        private readonly int wheels;
        private const VehicleType type = VehicleType.Truck;
        public Truck(string make, string model, decimal price, int weightCapacity):base(make,model,price)
        {
            Guard.WhenArgument(weightCapacity, "Weight").IsLessThan(1).IsGreaterThan(100).Throw();
            this.weightCapacity = weightCapacity;
            this.wheels = 8;
            this.Type = VehicleType.Truck;
        }


        public override int Wheels { get { return this.wheels; } }
        public int WeightCapacity { get {return this.weightCapacity; }set {this.weightCapacity=value; } }
        public override string AdditionalInfo()
        {
            return $"Weight:{this.WeightCapacity}";
        }
    }
}
