using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractnessAndException.Products
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public Product(string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public abstract string Display();
    }
}
