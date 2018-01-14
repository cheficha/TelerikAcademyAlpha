using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CityTempDict
{
    public class City
    {
        private string name;
        private int temp;
        private BigInteger population;
        private string country;
        public City(string name, string country, BigInteger population, int temp)
        {
            this.Name = name;
            this.Country = country;
            this.Population = population;
            this.Temp = temp;

        }
        public string Name { get { return this.name; } private set { this.name = value; } }
        public string Country { get { return this.country; } private set { this.country = value; } }
        public BigInteger Population { get { return this.population; } set { this.population = value; } }
        public int Temp { get { return this.temp; } private set { this.temp = value; } }

        public  void UpgradePopulation(City city,BigInteger upgrade)
        {
            city.Population += upgrade;
            
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            sb.AppendLine($"Country: {this.Country}");
            sb.AppendLine($"Population: {this.Population}");
            sb.AppendLine($"Temperature: {this.Temp}");
            return sb.ToString().Trim();

        }
        public override bool Equals(object obj)
        {
            var newCity = obj as City;
            if (this.Equals(newCity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }


    }
}
