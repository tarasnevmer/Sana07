using System;
using AbstractnessAndException.Products;

namespace AbstractnessAndException
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart() 
        {
            items = new List<Product>();
        }
    
        public void AddToCard(Product product)
        {
            items.Add(product);
        }

        public void DisplayCart()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Display());
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in items) 
            {
                total += item.Price * item.Count;
            }
            return total;
        }

    }
}
