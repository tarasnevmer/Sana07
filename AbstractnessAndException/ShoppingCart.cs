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

        public string DisplayCart()
        {
            string infoAllProducts = "";
            int productNum = 1;
            foreach (var item in items)
            {
                infoAllProducts += $"{productNum}.\n{item.Display()}";
                productNum++;
            }
            return infoAllProducts;
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
