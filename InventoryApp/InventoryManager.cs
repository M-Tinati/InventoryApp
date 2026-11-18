using System.Collections.Generic;

namespace InventoryApp
{
    public class InventoryManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}