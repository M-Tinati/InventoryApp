namespace InventoryApp
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPrice = new Label();
            lblName = new Label();
            lblStock = new Label();
            lblSell = new Label();
            lblMinStock = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtSell = new TextBox();
            txtStock = new TextBox();
            txtMinStock = new TextBox();
            btnadd = new Button();
            SuspendLayout();
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(312, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(61, 15);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "قیمت خرید";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(333, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 0;
            lblName.Text = "نام کالا";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(299, 130);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(74, 15);
            lblStock.TabIndex = 0;
            lblStock.Text = "موجودی اولیه";
            // 
            // lblSell
            // 
            lblSell.AutoSize = true;
            lblSell.Location = new Point(305, 88);
            lblSell.Name = "lblSell";
            lblSell.Size = new Size(68, 15);
            lblSell.TabIndex = 0;
            lblSell.Text = "قیمت فروش";
            // 
            // lblMinStock
            // 
            lblMinStock.AutoSize = true;
            lblMinStock.Location = new Point(292, 173);
            lblMinStock.Name = "lblMinStock";
            lblMinStock.Size = new Size(81, 15);
            lblMinStock.TabIndex = 0;
            lblMinStock.Text = "حداقل موجودی";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(118, 23);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(163, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(118, 23);
            txtPrice.TabIndex = 1;
            // 
            // txtSell
            // 
            txtSell.Location = new Point(163, 85);
            txtSell.Name = "txtSell";
            txtSell.Size = new Size(118, 23);
            txtSell.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(163, 127);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(118, 23);
            txtStock.TabIndex = 1;
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(163, 170);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(118, 23);
            txtMinStock.TabIndex = 1;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(20, 198);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(97, 38);
            btnadd.TabIndex = 2;
            btnadd.Text = "ذخیره";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // FormAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 241);
            Controls.Add(btnadd);
            Controls.Add(txtMinStock);
            Controls.Add(txtStock);
            Controls.Add(txtSell);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblSell);
            Controls.Add(lblMinStock);
            Controls.Add(lblStock);
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAddProduct";
            Text = "افزودن کالا";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice;
        private Label lblName;
        private Label lblStock;
        private Label lblSell;
        private Label lblMinStock;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtSell;
        private TextBox txtStock;
        private TextBox txtMinStock;
        private Button btnadd;
    }
}