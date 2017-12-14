using AnimalHierarchy.Common;
using AnimalHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
   abstract class Animals: ISound
    {
        private string name;
        private int age;
        private SexType sex;
      
        protected Animals(string name,int age,SexType sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        protected Animals(string name, int age) {
            this.name = name;
            this.age = age;
            
        }
        public string Name { get {return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public SexType Sex { get { return this.sex; } set { this.sex = value; } }
        public virtual string ProduceSound()
        {
            return $"All animals are different";
        }
        public string Print()
        {

            return $"#Name:{this.Name}\r\n#Age:{this.Age} years old\r\n#Sex:{this.Sex}";
        }
    }
}
