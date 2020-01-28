namespace EcommerceApplication
{
    partial class Admin_Products
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.addFilterButton = new System.Windows.Forms.Button();
            this.bluetoothComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.screenSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.brandComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.serialNumsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(9, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(304, 272);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(121, 23);
            this.resetFilterButton.TabIndex = 56;
            this.resetFilterButton.Text = "Reset Filter";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // addFilterButton
            // 
            this.addFilterButton.Location = new System.Drawing.Point(165, 272);
            this.addFilterButton.Name = "addFilterButton";
            this.addFilterButton.Size = new System.Drawing.Size(121, 23);
            this.addFilterButton.TabIndex = 55;
            this.addFilterButton.Text = "Add Filter";
            this.addFilterButton.UseVisualStyleBackColor = true;
            this.addFilterButton.Click += new System.EventHandler(this.addFilterButton_Click);
            // 
            // bluetoothComboBox
            // 
            this.bluetoothComboBox.FormattingEnabled = true;
            this.bluetoothComboBox.Location = new System.Drawing.Point(304, 226);
            this.bluetoothComboBox.Name = "bluetoothComboBox";
            this.bluetoothComboBox.Size = new System.Drawing.Size(121, 21);
            this.bluetoothComboBox.TabIndex = 54;
            this.bluetoothComboBox.SelectedIndexChanged += new System.EventHandler(this.bluetoothComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Bluetooth:";
            // 
            // screenSizeComboBox
            // 
            this.screenSizeComboBox.FormattingEnabled = true;
            this.screenSizeComboBox.Location = new System.Drawing.Point(165, 226);
            this.screenSizeComboBox.Name = "screenSizeComboBox";
            this.screenSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.screenSizeComboBox.TabIndex = 52;
            this.screenSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.screenSizeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Screen Size:";
            // 
            // priceComboBox
            // 
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Location = new System.Drawing.Point(23, 226);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(121, 21);
            this.priceComboBox.TabIndex = 50;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Price:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(304, 175);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 48;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Color:";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(165, 175);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 46;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Category:";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(9, 6);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(640, 150);
            this.productsDataGridView.TabIndex = 42;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Serial Number:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(23, 175);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 44;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewProductButton.Location = new System.Drawing.Point(458, 175);
            this.addNewProductButton.Margin = new System.Windows.Forms.Padding(2);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(168, 39);
            this.addNewProductButton.TabIndex = 57;
            this.addNewProductButton.Text = "Add New Product";
            this.addNewProductButton.UseVisualStyleBackColor = false;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteButton.Location = new System.Drawing.Point(458, 252);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(168, 42);
            this.deleteButton.TabIndex = 58;
            this.deleteButton.Text = "Delete Product";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // serialNumsTextBox
            // 
            this.serialNumsTextBox.Location = new System.Drawing.Point(537, 227);
            this.serialNumsTextBox.Name = "serialNumsTextBox";
            this.serialNumsTextBox.Size = new System.Drawing.Size(89, 20);
            this.serialNumsTextBox.TabIndex = 59;
            // 
            // Admin_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.serialNumsTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewProductButton);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.addFilterButton);
            this.Controls.Add(this.bluetoothComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.screenSizeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.brandComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Button addFilterButton;
        private System.Windows.Forms.ComboBox bluetoothComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox screenSizeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox priceComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox brandComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox serialNumsTextBox;
    }
}