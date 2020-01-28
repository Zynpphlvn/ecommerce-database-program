namespace EcommerceApplication
{
    partial class UserProducts
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.addOrderBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialNumberTextbox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.updateWarrantiesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(305, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Reset Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bluetoothComboBox
            // 
            this.bluetoothComboBox.FormattingEnabled = true;
            this.bluetoothComboBox.Location = new System.Drawing.Point(305, 225);
            this.bluetoothComboBox.Name = "bluetoothComboBox";
            this.bluetoothComboBox.Size = new System.Drawing.Size(121, 21);
            this.bluetoothComboBox.TabIndex = 36;
            this.bluetoothComboBox.SelectedIndexChanged += new System.EventHandler(this.bluetoothComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bluetooth:";
            // 
            // screenSizeComboBox
            // 
            this.screenSizeComboBox.FormattingEnabled = true;
            this.screenSizeComboBox.Location = new System.Drawing.Point(166, 225);
            this.screenSizeComboBox.Name = "screenSizeComboBox";
            this.screenSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.screenSizeComboBox.TabIndex = 34;
            this.screenSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.screenSizeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Screen Size:";
            // 
            // priceComboBox
            // 
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Location = new System.Drawing.Point(24, 225);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(121, 21);
            this.priceComboBox.TabIndex = 32;
            this.priceComboBox.SelectedIndexChanged += new System.EventHandler(this.priceComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Price:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(305, 174);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 30;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Color:";
            // 
            // brandComboBox
            // 
            this.brandComboBox.FormattingEnabled = true;
            this.brandComboBox.Location = new System.Drawing.Point(166, 174);
            this.brandComboBox.Name = "brandComboBox";
            this.brandComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandComboBox.TabIndex = 28;
            this.brandComboBox.SelectedIndexChanged += new System.EventHandler(this.brandComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Category:";
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Location = new System.Drawing.Point(-1, -2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.Size = new System.Drawing.Size(682, 150);
            this.productsDataGridView.TabIndex = 24;
            this.productsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDataGridView_CellContentClick);
            // 
            // addOrderBasket
            // 
            this.addOrderBasket.Location = new System.Drawing.Point(543, 223);
            this.addOrderBasket.Name = "addOrderBasket";
            this.addOrderBasket.Size = new System.Drawing.Size(116, 23);
            this.addOrderBasket.TabIndex = 23;
            this.addOrderBasket.Text = "Add Order Basket";
            this.addOrderBasket.UseVisualStyleBackColor = true;
            this.addOrderBasket.Click += new System.EventHandler(this.addOrderBasket_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Serial Number:";
            // 
            // serialNumberTextbox
            // 
            this.serialNumberTextbox.Location = new System.Drawing.Point(478, 197);
            this.serialNumberTextbox.Name = "serialNumberTextbox";
            this.serialNumberTextbox.Size = new System.Drawing.Size(181, 20);
            this.serialNumberTextbox.TabIndex = 21;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(24, 174);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 26;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            // 
            // updateWarrantiesButton
            // 
            this.updateWarrantiesButton.Location = new System.Drawing.Point(543, 271);
            this.updateWarrantiesButton.Name = "updateWarrantiesButton";
            this.updateWarrantiesButton.Size = new System.Drawing.Size(116, 23);
            this.updateWarrantiesButton.TabIndex = 39;
            this.updateWarrantiesButton.Text = "Update Warranties";
            this.updateWarrantiesButton.UseVisualStyleBackColor = true;
            this.updateWarrantiesButton.Click += new System.EventHandler(this.updateWarrantiesButton_Click);
            // 
            // UserProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 307);
            this.Controls.Add(this.updateWarrantiesButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.addOrderBasket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialNumberTextbox);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "UserProducts";
            this.Text = "UserProducts";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button addOrderBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialNumberTextbox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button updateWarrantiesButton;
    }
}