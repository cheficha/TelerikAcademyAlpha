using AnimalHierarchy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.TheAnimals
{
   abstract class Cat:Animals
    {
 
        public Cat(string name, int age):base(name,age)
        {
          
            
        }
      
        public override string ProduceSound()
        {

            return $"Myau Myau ";
        }
    }
}
