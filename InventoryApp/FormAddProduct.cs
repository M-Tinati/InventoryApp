using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class FormAddProduct : Form
    {
        InventoryManager inventory = new InventoryManager();
        public FormAddProduct()
        {
            InitializeComponent();
        }
        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            


        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            Product products = new Product();
            products.name = txtName.Text;
            products.price = Convert.ToInt32(txtPrice.Text);
            products.sell = Convert.ToInt32(txtSell.Text);
            products.stock = Convert.ToInt32(txtStock.Text);
            products.minstock = Convert.ToInt32(txtMinStock.Text);
            inventory.AddProduct(products);
            foreach (Product product in inventory.GetProducts())
            {
                MessageBox.Show(product.name);
            }
        }

        
    }
}
