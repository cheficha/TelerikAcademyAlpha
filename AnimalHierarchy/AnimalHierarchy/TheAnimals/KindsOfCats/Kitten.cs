using AnimalHierarchy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.TheAnimals.KindsOfCats
{
    class Kitten:Cat
    {
        public Kitten(string name, int age):base(name,age)
        {

            this.Sex = SexType.Female;

        } 
    }
}
