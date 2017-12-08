using Bytes2you.Validation;
using Cosmetics.Common;
using System;

namespace Cosmetics.Products
{
    public class Product
    {
        private readonly decimal price;
        private readonly string name;
        private readonly string brand;
        private readonly GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            Guard.WhenArgument(name, "name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "name length").IsLessThan(3).IsGreaterThan(10).Throw();
            Guard.WhenArgument(price, "The price").IsLessThan(0).Throw();
            Guard.WhenArgument(brand, "name").IsNull().Throw();
            Guard.WhenArgument(brand.Length, "name length").IsLessThan(2).IsGreaterThan(10).Throw();

            this.price = price;
            this.name = name;
            this.brand = brand;
            this.gender = gender;

        }
        public object Price { get {return this.price; } }
        public object Name { get { return this.name; } }
        public object Brand { get { return this.brand; } }
        public object Gender { get { return this.gender; } }


        public string Print()
        {
            return ($" #{this.Name} {this.Brand}\r\n #Price: ${this.Price}\r\n #Gender: {this.Gender}\r\n ===");
        }
    }
}
