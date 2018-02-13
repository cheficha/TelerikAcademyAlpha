using Bytes2you.Validation;
using Dealership.Common.Enums;
using Dealership.Contracts;

namespace Dealership.Models
{
    public class Car:Vehicle,ICar,SomeInterface
    {
        private int seats;
        private readonly int wheels;
  
        
        public Car(string make,string model,decimal price,int seats):base(make,model,price)
        {
            Guard.WhenArgument(seats, "seats").IsLessThan(1).IsGreaterThan(10).Throw();
            this.seats = seats;
            this.wheels = 4;
            this.Type = VehicleType.Car;
        }
        
        public int Seats { get {return this.seats; }set {this.seats=value; } }
        public override int Wheels { get { return this.wheels; } }
        public override string AdditionalInfo()
        {
            return $"Seats:{this.Seats}";
        }
    }

  

  
}
