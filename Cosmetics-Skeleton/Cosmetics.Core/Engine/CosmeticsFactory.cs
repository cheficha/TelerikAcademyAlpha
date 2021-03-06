﻿using Cosmetics.Cart;
using Cosmetics.Common;
using Cosmetics.Products;
using System;


namespace Cosmetics.Core.Engine
{
    public class CosmeticsFactory
    {
        public Category CreateCategory(string name)
        {
            return new Category(name);
        }

        public Product CreateProduct(string name, string brand, decimal price, string gender)
           
        {
            
            Enum.TryParse(gender, out GenderType genderParsed);          
            return new Product(name,brand,price,genderParsed);
            throw new NotImplementedException();
        }

        public ShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
