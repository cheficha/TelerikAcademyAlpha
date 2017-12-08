using Bytes2you.Validation;
using Cosmetics.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmetics
{
    public class Category
    {
        private readonly string name;
        private readonly List<Product> products;

        public Category(string name)
        {
            Guard.WhenArgument(name, "Name").IsNull().Throw();
            Guard.WhenArgument(name.Length, "Name Length").IsLessThan(3).IsGreaterThan(10).Throw();


            this.products = new List<Product>();
            this.name = name;
        }

        public List<Product> Products
        {
         
            get
            {
                return this.products;
               // throw new NotImplementedException();
            }
        }

        public string Name => name;

        public virtual void AddProduct(Product product)
        {
            Guard.WhenArgument(product, "Product is null!").IsNull().Throw();
            this.products.Add(product);
           // throw new NotImplementedException();

        }

        public virtual void RemoveProduct(Product product)
        {

            if (!this.products.Any(x=>x.Name==product.Name))
            {
                throw new ArgumentNullException();
            }
                this.products.Remove(product);
           

        }
       
        public string Print()
        {
            var strBuilder = new StringBuilder();
            var productsSorted = this.products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price);
            strBuilder.Append(string.Format(" #Category:{0}\n",this.name));
            if (Products.Count==0)
            {
                strBuilder.Append(" #No products in this category!");
            }
            foreach (var product in productsSorted)
            {
               
                strBuilder.AppendLine(product.Print());
                
            }
            
            return strBuilder.ToString();
        }

    }
}
