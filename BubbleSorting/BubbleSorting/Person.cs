using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    public class Person : IComparable
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public int CompareTo(Person other)
        {
            return this.Name.CompareTo(other.Name);
            if (this.Name==other.Name)
            {
                return 0;
            }
            if (this.Age<other.Age)
            {

            }

        }
    }
}
