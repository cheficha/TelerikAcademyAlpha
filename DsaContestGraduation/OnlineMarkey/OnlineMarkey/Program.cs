using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace OnlineMarkey
{
    class Program
    {
        static string ProductName;
        static string ProductType;
        static double ProductPrice;
        static Product product;
        static void Main(string[] args)
        {
            var productsWithName = new Dictionary<string, SortedSet<Product>>();
            var productsWithType = new Dictionary<string, SortedSet<Product>>();
            var currentMessage = new StringBuilder();
            var messages = new StringBuilder();
            var biglist = new BigList<Product>();
            string TerminationCommand = "end";
            string commandAsString = null;
            while ((commandAsString = Console.ReadLine()) != TerminationCommand)
            {
                var commandParts = commandAsString.Split(' ').ToArray();
                var command = commandParts[0];
                var filterType = commandParts[2];
                switch (command)
                {
                    case "add":
                        ProductName = commandParts[1];
                        ProductPrice = double.Parse(commandParts[2]);
                        ProductType = commandParts[3];
                        product = new Product(ProductName, ProductPrice, ProductType);
                        AddProduct(product, productsWithName, productsWithType, messages);
                        break;

                    case "filter":
                        switch (filterType)
                        {
                            case "type":
                                var message = FilterByType(commandParts[3], productsWithType, currentMessage, biglist);
                                messages.AppendLine(message);
                                biglist.Clear();
                                currentMessage.Clear();
                                break;
                            case "price":
                                if (commandParts.Length == 7)
                                {
                                    var result = FilterByPriceFromMinToMax((double.Parse(commandParts[4])), (double.Parse(commandParts[6])), productsWithType, currentMessage, biglist);
                                    messages.AppendLine(result);
                                    biglist.Clear();
                                    currentMessage.Clear();
                                }
                                else if (commandParts[3] == "from")
                                {
                                    var result = FilterByPriceFrom((double.Parse(commandParts[4])), productsWithType, currentMessage, biglist);
                                    messages.AppendLine(result);
                                    biglist.Clear();
                                    currentMessage.Clear();
                                }
                                else if (commandParts[3] == "to")
                                {
                                    var result = FilterByPriceTo((double.Parse(commandParts[4])), productsWithType, currentMessage, biglist);
                                    messages.AppendLine(result);
                                    biglist.Clear();
                                    currentMessage.Clear();
                                }
                                break;
                            default:
                                break;
                        }
                        break;


                    default:
                        break;
                }
            }
            Console.WriteLine(messages.ToString());
        }
        public static void AddProduct(Product product, Dictionary<string, SortedSet<Product>> products, Dictionary<string, SortedSet<Product>> products1, StringBuilder builder)
        {


            if (!products.ContainsKey(product.Name))
            {
                var set = new SortedSet<Product>();
                set.Add(product);
                products.Add(product.Name, set);

                builder.AppendLine($"Ok: Product {product.Name} added successfully");
                if (!products1.ContainsKey(product.Type))
                {
                    var collection = new SortedSet<Product>();
                    collection.Add(product);
                    products1.Add(product.Type, collection);
                }
                else
                {
                    products1[product.Type].Add(product);
                }
            }
            else
            {
                builder.AppendLine($"Error: Product {product.Name} already exists");
            }
        }
        public static string FilterByType(string type, Dictionary<string, SortedSet<Product>> products, StringBuilder builder, BigList<Product> list)
        {

            if (!products.ContainsKey(type))
            {
                builder.Append($"Error: Type {type} does not exists");

                return builder.ToString().TrimEnd(' ').TrimEnd(',');

            }
            else
            {
                var thisType = products.Where(x => x.Key == type);
                foreach (var item in thisType)
                {
                    foreach (var product in item.Value)
                    {
                        list.Add(product);
                    }
                }
                list.Sort();
                if (list.Count >= 10)
                {
                    builder.Append("Ok: ");
                    var asd = list.Range(0, 10);
                    foreach (var item in asd)
                    {
                        builder.Append(item.ToString());
                        builder.Append($", ");

                    }
                    builder.Remove(builder.Length - 2, 2);
                }
                else if (list.Count == 0)
                {
                    builder.Append($"Ok: ");



                }

                else
                {

                    builder.Append("Ok: ");

                    foreach (var item in list)
                    {
                        builder.Append(item.ToString());
                        builder.Append($", ");

                    }
                    builder.Remove(builder.Length - 2, 2);
                }


                return builder.ToString().TrimEnd(' ').TrimEnd(',');
            }

        }
        public static string FilterByPriceFromMinToMax(double min, double max, Dictionary<string, SortedSet<Product>> products, StringBuilder builder, BigList<Product> productWithPrice)
        {
            foreach (var item in products.Values)
            {
                foreach (var product in item)
                {
                    if (product.Price >= min && product.Price <= max)
                    {
                        productWithPrice.Add(product);
                    }
                }
            }
            productWithPrice.Sort();
            if (productWithPrice.Count >= 10)
            {
                builder.Append($"Ok: ");
                var target = productWithPrice.Range(0, 10);
                foreach (var item in target)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
            }
            else if (productWithPrice.Count == 9)
            {
                builder.Append($"Ok: ");



            }
            else
            {
                builder.Append($"Ok: ");

                foreach (var item in productWithPrice)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
                builder.Remove(builder.Length - 2, 2);
            }


            return builder.ToString().TrimEnd(' ').TrimEnd(',');
        }
        public static string FilterByPriceFrom(double min, Dictionary<string, SortedSet<Product>> products, StringBuilder builder, BigList<Product> productWithPrice)
        {
            foreach (var item in products.Values)
            {
                foreach (var product in item)
                {
                    if (product.Price >= min)
                    {
                        productWithPrice.Add(product);
                    }
                }
            }
            productWithPrice.Sort();

            if (productWithPrice.Count >= 10)
            {
                builder.Append($"Ok: ");
                var target = productWithPrice.Range(0, 10);
                foreach (var item in target)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
                builder.Remove(builder.Length - 2, 2);

            }
            else if (productWithPrice.Count == 0)
            {
                builder.Append($"Ok: ");



            }
            else
            {
                builder.Append($"Ok: ");

                foreach (var item in productWithPrice)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
                builder.Remove(builder.Length - 2, 2);

            }


            return builder.ToString().TrimEnd(' ').TrimEnd(',');
        }
        public static string FilterByPriceTo(double max, Dictionary<string, SortedSet<Product>> products, StringBuilder builder, BigList<Product> productWithPrice)
        {
            foreach (var item in products.Values)
            {
                foreach (var product in item)
                {
                    if (product.Price <= max)
                    {
                        productWithPrice.Add(product);
                    }
                }
            }
            productWithPrice.Sort();

            if (productWithPrice.Count >= 10)
            {
                builder.Append($"Ok: ");
                var target = productWithPrice.Range(0, 10);
                foreach (var item in target)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
                builder.Remove(builder.Length - 2, 2);

            }
            else if (productWithPrice.Count == 0)
            {
                builder.Append($"Ok: ");



            }
            else
            {
                builder.Append($"Ok: ");

                foreach (var item in productWithPrice)
                {
                    builder.Append(item.ToString());
                    builder.Append($", ");
                }
                builder.Remove(builder.Length - 2, 2);

            }


            return builder.ToString().TrimEnd(' ').TrimEnd(',');
        }
    }
    public struct Product : IComparable<Product>
    {
        private string name;
        private double price;
        private string type;
        public Product(string name, double price, string type)
        {

            this.name = name;
            this.price = price;
            this.type = type;
        }
        public string Name { get { return this.name; } set { value = this.name; } }
        public double Price { get { return this.price; } set { value = this.price; } }
        public string Type { get { return this.type; } set { value = this.type; } }

        public int CompareTo(Product other)
        {
            var result = this.Price.CompareTo(other.Price);
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Type.CompareTo(other.Type);
                }
            }
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.Name}({this.Price})");
            return sb.ToString();
        }
    }
}
