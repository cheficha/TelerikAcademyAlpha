using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Text;
using System;

namespace Cosmetics.Products
{
    public class Shampoo: Product,IShampoo
    {
        private string name;
        private string brand;
        private decimal price;
        private decimal militers;
        private UsageType usage;
        private GenderType gender;
        public Shampoo(string name,string brand,decimal price,GenderType gender,decimal militers,UsageType usage):base(name,brand,price,gender)
        {
         
   
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
            this.militers = militers;
            this.usage = usage;
        }
       
     
        public decimal Militers { get {return this.militers; }set {this.militers=value; } }
        public UsageType Usage { get { return this.usage; }set {this.usage=value; } }
       




    }
}
