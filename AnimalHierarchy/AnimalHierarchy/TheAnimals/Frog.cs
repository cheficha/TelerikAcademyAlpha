using AnimalHierarchy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.TheAnimals
{
    class Frog:Animals
    {
        private string name;
        private int age;
        private SexType sex;
        public Frog(string name, int age, SexType sex):base(name,age,sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public override string ProduceSound()
        {

            return $"Quak Quak";
        }
    }
}
