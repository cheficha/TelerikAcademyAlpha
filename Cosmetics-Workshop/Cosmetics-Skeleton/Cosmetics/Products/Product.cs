using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Products
{
    public abstract class Product : IProduct
    {
        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }
        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;
        public virtual string Name { get { return this.name; } set { if (value == null) { throw new ArgumentNullException(); } else if (value.Length < 3 || value.Length > 10) { throw new ArgumentOutOfRangeException(); } this.name = value; } }
        public virtual string Brand { get { return this.brand; } set { if (value == null) { throw new ArgumentNullException(); } else if (value.Length < 2 || value.Length > 10) { throw new ArgumentOutOfRangeException(); } this.brand = value; } }
        public decimal Price { get { return this.price; } set { if (value < 0) { throw new ArgumentOutOfRangeException(); } this.price = value; } }
        public GenderType Gender { get { return this.gender; } set { this.gender = value; } }
        public virtual string Print()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("#{0} {1}\n", this.Name, this.Brand))
                .Append(string.Format(" #Price: ${0}\n", this.Price))
                .Append(string.Format(" #Gender: {0}\n", this.Gender));
            return result.ToString();
        }
    }
}
