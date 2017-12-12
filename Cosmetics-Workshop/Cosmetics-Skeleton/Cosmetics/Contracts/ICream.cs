using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmetics.Common;

namespace Cosmetics.Contracts
{
    interface ICream : IProduct
    {
       ScentType Scent { get; set; }
    }
}
