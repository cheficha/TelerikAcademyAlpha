using Bytes2you.Validation;
using Cosmetics.Common;
using Cosmetics.Contracts;
using System.Collections;
using System.Collections.Generic;

namespace Cosmetics.Products
{
    public class Toothpaste: Product,IToothpaste
    {
        private string name;
        private string brand;
        private decimal price;
        private string ingredients;
        GenderType gender;
        public Toothpaste (string name, string brand, decimal price, GenderType gender, string ingredients):base(name, brand, price, gender)
        {
            
          
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.gender = gender;
            this.ingredients = ingredients;
           
        }
      
        public string Ingredients { get {return this.ingredients; } set {
                Guard.WhenArgument(ingredients, "No Ingredients").IsNull().Throw();
                this.ingredients = value;
                ;
            } }
        
    }
}