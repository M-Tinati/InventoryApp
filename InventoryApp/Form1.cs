namespace InventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct Formadd = new FormAddProduct();
            Formadd.ShowDialog();

        }
    }
}
