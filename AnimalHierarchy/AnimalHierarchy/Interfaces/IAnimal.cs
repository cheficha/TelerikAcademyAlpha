using AnimalHierarchy.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy.Interfaces
{
    interface IAnimal
    {
       string Name { get; set; }
        int Age { get; set; }
        SexType Sex { get; set; }

    }
}
