using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cosmetics.Cart
{
    public class ShoppingCart
    {
        private readonly ICollection<Product> productList;

        public ShoppingCart()
        {
            this.productList = new List<Product>();
           
        }

        public ICollection<Product> ProductList
        {
            get { return this.productList; }
        }

        public void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "Product is Null.").IsNull().Throw();
            this.productList.Add(product);

            //throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            Guard.WhenArgument(product, "Product is Null.").IsNull().Throw();

            this.productList.Remove(product);

            //throw new NotImplementedException();
        }

        public bool ContainsProduct(Product product)
        {
            Guard.WhenArgument(product, "Product is Null.").IsNull().Throw();
            this.productList.Contains(product);
            return this.productList.Contains(product);

            //throw new NotImplementedException();
        }

        public decimal TotalPrice()
        {
            decimal sum=0;
            foreach (Product item in productList)
            {
                sum+=(decimal)item.Price;
            }
            return sum;
        }
    }
}
