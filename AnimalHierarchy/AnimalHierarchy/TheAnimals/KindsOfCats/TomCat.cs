using AnimalHierarchy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.TheAnimals.KindsOfCats
{
    class TomCat:Cat
    {      
        public TomCat(string name, int age):base(name,age)
        {

            this.Sex = SexType.Male;

        }

    }
}
