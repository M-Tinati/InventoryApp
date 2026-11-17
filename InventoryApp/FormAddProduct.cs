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
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Product p1 = new Product();
            p1.name = "car";
            p1.price = 100;
            p1.sell = 200;
            p1.stock = 10;
            p1.minstock = 3;

            MessageBox.Show($"Name : {p1.name},Price : {p1.price}, Sell : {p1.sell} , Stock :{p1.stock}, MinStock : {p1.minstock}");
        }
    }
}
