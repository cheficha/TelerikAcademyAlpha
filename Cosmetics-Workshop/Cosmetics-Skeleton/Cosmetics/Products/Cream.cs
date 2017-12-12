using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;


namespace Cosmetics.Products
{
    public class Cream: Product,ICream
    {
        private string name;
        private string brand;
        private decimal price;
        private ScentType scent;
       private GenderType gender;
        public Cream(string name, string brand, decimal price, GenderType gender, ScentType scent) : base( name, brand, price,  gender)
        {


            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
            this.scent = scent;

        }
      
        public ScentType Scent
        {
            get { return this.scent; }
            set
            {
               
                this.scent = value;
                ;
            }
        }
       
    }
}

