﻿using Cosmetics.Contracts;
using System.Collections.Generic;

namespace Cosmetics.Contracts
{
    public interface IShoppingCart
    {
        // Which methods should be here?
        // Write them
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        bool ContainsProduct(IProduct product);
        decimal TotalPrice();



    }
}