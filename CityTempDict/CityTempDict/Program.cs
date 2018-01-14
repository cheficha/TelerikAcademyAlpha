using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTempDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var varna = new City("Varna", "Bulgaria", 300000, 25);
            var sofia = new City("Sofia", "Bulgaria", 2000000, 21);
            var plovdiv = new City("Plovdiv", "Bulgaria",200000, 20);
            var london = new City("London", "UK", 4000000, 12);


            var dict = new Dictionary<string,City>();

            dict.Add("Varna",varna);
            dict.Add("Sofia", sofia);
            dict.Add("Plovdiv", plovdiv);
            dict.Add("London", london);
            dict["Varna"].UpgradePopulation(dict["Varna"], 9000);
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.ToString());
            }
        }
    

    }
    
}
