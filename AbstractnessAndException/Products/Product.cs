using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractnessAndException.Products
{
    public abstract class Product
    {
        private string name = "Назва";
        private decimal price;
        private int count;

        public string Name {
            get { return name; } 
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Назва не може бути порожньою або містити лише пробіли!");
                }
                name = value;
            }
        
        }
        public decimal Price {
            get { return price; }
            set {
                if (value < 0)
                    throw new ArgumentException("Ціна не може бути від'ємною!");
                price = value;
            } 
        }
        public int Count {
            get {return count; }
            set {
                if (value < 0)
                    throw new ArgumentException("Кількість не може бути від'ємною!");
                count = value;
            } 
        }

        public Product(string name, decimal price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public abstract string Display();
    }
}
