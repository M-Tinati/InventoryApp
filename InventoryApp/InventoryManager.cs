using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    internal class InventoryManager
    {
        
        
        Product[] products = new Product[3];
        
        public void loop()
        {
            
            for (int i = 0; i < products.Length ; i++)
            {
                Product p1 = new Product();
                p1.name = "";
                p1.price = 100;
                p1.sell = 200;
                p1.stock = 10;
                p1.minstock = 3;
                MessageBox.Show($"Name : {p1.name},Price : {p1.price}, Sell : {p1.sell} , Stock :{p1.stock}, MinStock : {p1.minstock}");
            }
        }
        
    }
    
}
