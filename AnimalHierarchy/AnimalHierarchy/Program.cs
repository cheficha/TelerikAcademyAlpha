using AnimalHierarchy.TheAnimals;
using AnimalHierarchy.TheAnimals.KindsOfCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Sharo",2,Common.SexType.Male);
            Console.WriteLine( dog.Print());
            TomCat tommy = new TomCat("Tommy",1);
            Console.WriteLine(tommy.Print());
            Kitten kitty = new Kitten("Petko",23);
            Console.WriteLine(kitty.Print());
            Console.WriteLine(kitty.ProduceSound());

        }
    }
}
