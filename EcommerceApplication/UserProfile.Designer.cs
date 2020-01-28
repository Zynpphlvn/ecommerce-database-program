namespace EcommerceApplication
{
    partial class UserProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderBasketGridView = new System.Windows.Forms.DataGridView();
            this.startShoppingButton = new System.Windows.Forms.Button();
            this.showorders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderBasketGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Write serial number of product that you want to delete.";
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.Location = new System.Drawing.Point(31, 320);
            this.deleteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(205, 22);
            this.deleteTextBox.TabIndex = 12;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.Location = new System.Drawing.Point(246, 320);
            this.deleteProductButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(123, 25);
            this.deleteProductButton.TabIndex = 11;
            this.deleteProductButton.Text = "Delete Product";
            this.deleteProductButton.UseVisualStyleBackColor = true;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "My Order Basket";
            // 
            // orderBasketGridView
            // 
            this.orderBasketGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderBasketGridView.Location = new System.Drawing.Point(396, 80);
            this.orderBasketGridView.Margin = new System.Windows.Forms.Padding(4);
            this.orderBasketGridView.Name = "orderBasketGridView";
            this.orderBasketGridView.RowHeadersWidth = 51;
            this.orderBasketGridView.Size = new System.Drawing.Size(415, 304);
            this.orderBasketGridView.TabIndex = 9;
            this.orderBasketGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderBasketGridView_CellContentClick);
            // 
            // startShoppingButton
            // 
            this.startShoppingButton.Location = new System.Drawing.Point(42, 73);
            this.startShoppingButton.Margin = new System.Windows.Forms.Padding(4);
            this.startShoppingButton.Name = "startShoppingButton";
            this.startShoppingButton.Size = new System.Drawing.Size(194, 72);
            this.startShoppingButton.TabIndex = 8;
            this.startShoppingButton.Text = "Start Shopping";
            this.startShoppingButton.UseVisualStyleBackColor = true;
            this.startShoppingButton.Click += new System.EventHandler(this.startShoppingButton_Click);
            // 
            // showorders
            // 
            this.showorders.Location = new System.Drawing.Point(42, 167);
            this.showorders.Margin = new System.Windows.Forms.Padding(4);
            this.showorders.Name = "showorders";
            this.showorders.Size = new System.Drawing.Size(194, 72);
            this.showorders.TabIndex = 15;
            this.showorders.Text = "Show Orders";
            this.showorders.UseVisualStyleBackColor = true;
            this.showorders.Click += new System.EventHandler(this.showorders_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserProfile
            // 
            this.ClientSize = new System.Drawing.Size(843, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showorders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteTextBox);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderBasketGridView);
            this.Controls.Add(this.startShoppingButton);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.orderBasketGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderBasketGridView;
        private System.Windows.Forms.Button startShoppingButton;
        private System.Windows.Forms.Button showorders;
        private System.Windows.Forms.Button button1;
    }
}