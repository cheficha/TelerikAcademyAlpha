using Bytes2you.Validation;
using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FurnitureManufacturer.Models
{
    // Finish the class
    public class Company : ICompany
    {
        private readonly string name;
        private readonly string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            Guard.WhenArgument(name, "Name can't be null").IsNull().Throw();
            Guard.WhenArgument(name.Length, "Name is too short or too long").IsLessThan(5).Throw();
            if (!Regex.IsMatch(registrationNumber, "[0-9]{10}"))
            {
                throw new ArgumentException("Registration number is not valid");
            }
            this.name = name;
            this.registrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name => this.name;

        public string RegistrationNumber => this.registrationNumber;

        public ICollection<IFurniture> Furnitures => this.furnitures;

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
            //Console.WriteLine($"Furniture{furniture.Model} added from company {this.Name}");


        }

        public string Catalog()
        {
            this.Furnitures.OrderBy(x=>x.Price).ThenBy(x=>x.Model);
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"{this.Name} - {this.RegistrationNumber} - {this.Furnitures.Count} furnitures");
            foreach (var item in Furnitures)
            {
                strBuilder.AppendLine(item.ToString());
            }
            if (strBuilder.Length==0)
            {
                return $"no furnitures ";
            }
            return strBuilder.ToString().Trim();
        }

        public IFurniture Find(string model)
        {
            var found =
                from s in Furnitures
                where s.Model == model
                select s;
            return found.FirstOrDefault();
            
            
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
            //Console.WriteLine($"Furniture{furniture.Model} removed from company {this.Name}");
        }
    }
}
