using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            var byName = new SortedSet<Product>();
            var byType = new Dictionary<string, OrderedSet<Product>>();
            var result = new StringBuilder();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandParams = command.Split();
                switch (commandParams[0])
                {
                    case "add":
                        var product = new Product(commandParams[1], double.Parse(commandParams[2]), commandParams[3]);
                        AddProduct(byName, byType, result, product);
                        break;

                    case "filter":
                      
                        if (commandParams[2]=="type")
                        {
                            FilterByType(byType, result, commandParams[3]);
                        }
                        else if (commandParams.Length > 6)
                        {
                            FIlterByPriceFromMinToMax(byName, result, double.Parse(commandParams[4]), double.Parse(commandParams[6]));
                            result.Remove(result.Length - 1, 1);
                            result.AppendLine();
                        }
                        else if (commandParams.Length==5 && commandParams[3]=="from")
                        {
                            FIlterByPriceFromMin(byName, result, double.Parse(commandParams[4]));
                            result.Remove(result.Length - 1, 1);

                            result.AppendLine();

                        }
                        else if (commandParams.Length == 5 && commandParams[3] == "to")
                        {
                            FIlterByPriceToMax(byName, result, double.Parse(commandParams[4]));
                            result.Remove(result.Length - 1, 1);

                            result.AppendLine();

                        }


                        break;

                }
            }
            Console.WriteLine(result.ToString().TrimEnd().TrimEnd(','));
        }
        public static void AddProduct(SortedSet<Product> byName, Dictionary<string, OrderedSet<Product>> byType, StringBuilder result, Product product)
        {
            if (byName.Contains(product))
            {
                result.AppendLine($"Error: Product Milk already exists");
            }
            else
            {
                byName.Add(product);
                result.AppendLine($"Ok: Product {product.Name} added successfully");
            }
            if (!byType.ContainsKey(product.Type))
            {
                var sorted = new OrderedSet<Product>();
                sorted.Add(product);
                byType.Add(product.Type, sorted);
            }
            else
            {
                byType[product.Type].Add(product);
            }

        }
        public static void FilterByType(Dictionary<string, OrderedSet<Product>> byType, StringBuilder result, string type)
        {
            if (byType.ContainsKey(type))
            {
                result.AppendLine(string.Format("Ok: {0}", string.Join(", ", byType[type].Take(10))));

            }
            else
            {
                result.AppendLine($"Error: Type {type} does not exists");
            }
        }
        public static void FIlterByPriceFromMinToMax(SortedSet<Product> byName, StringBuilder result, double min, double max)
        {
            int counter = 0;
            result.Append($"Ok: ");
            foreach (var item in byName)
            {
                if (item.Price >= min && item.Price <= max)
                {
                  
                        result.Append(item.ToString() + ",");

            
                    counter++;
                }
                if (counter == 10)
                {
                    break;
                }

            }

        }
        public static void FIlterByPriceFromMin(SortedSet<Product> byName, StringBuilder result, double min)
        {
            int counter = 0;
            result.Append($"Ok: ");
            foreach (var item in byName)
            {
                if (item.Price >= min)
                {
                  
                        result.Append(item.ToString() + ",");

               
                    counter++;
                }
                if (counter == 10)
                {
                  
                    break;
                }

            }

        }
        public static void FIlterByPriceToMax(SortedSet<Product> byName, StringBuilder result, double max)
        {
            int counter = 0;
            result.Append($"Ok: ");
            foreach (var item in byName)
            {
                if (item.Price<=max)
                {
                 
                        result.Append(item.ToString() + ",");

                
                    counter++;
                }
                if (counter == 10)
                {
                    
                    break;
                }

            }

        }
        public class Product : IComparable<Product>
        {
            public Product(string name, double price, string type)
            {
                Name = name;
                Price = price;
                Type = type;
            }
            public string Name { get; set; }
            public double Price { get; set; }
            public string Type { get; set; }

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
}
