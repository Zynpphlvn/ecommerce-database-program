namespace EcommerceApplication
{
    partial class OrderDetails
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoicedetails = new System.Windows.Forms.Button();
            this.cargodetails = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.invoice_id = new System.Windows.Forms.TextBox();
            this.cargo_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(63, 13);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(180, 35);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 112);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // invoicedetails
            // 
            this.invoicedetails.Location = new System.Drawing.Point(793, 261);
            this.invoicedetails.Name = "invoicedetails";
            this.invoicedetails.Size = new System.Drawing.Size(174, 42);
            this.invoicedetails.TabIndex = 2;
            this.invoicedetails.Text = "Show Invoice Details";
            this.invoicedetails.UseVisualStyleBackColor = true;
            this.invoicedetails.Click += new System.EventHandler(this.invoicedetails_Click);
            // 
            // cargodetails
            // 
            this.cargodetails.Location = new System.Drawing.Point(793, 403);
            this.cargodetails.Name = "cargodetails";
            this.cargodetails.Size = new System.Drawing.Size(174, 42);
            this.cargodetails.TabIndex = 3;
            this.cargodetails.Text = "Show Cargo Details";
            this.cargodetails.UseVisualStyleBackColor = true;
            this.cargodetails.Click += new System.EventHandler(this.cargodetails_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(63, 240);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(667, 112);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(63, 377);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(667, 112);
            this.dataGridView3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "İnvoice id";
            // 
            // invoice_id
            // 
            this.invoice_id.Location = new System.Drawing.Point(890, 124);
            this.invoice_id.Name = "invoice_id";
            this.invoice_id.Size = new System.Drawing.Size(100, 22);
            this.invoice_id.TabIndex = 7;
            // 
            // cargo_id
            // 
            this.cargo_id.Location = new System.Drawing.Point(890, 163);
            this.cargo_id.Name = "cargo_id";
            this.cargo_id.Size = new System.Drawing.Size(100, 22);
            this.cargo_id.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(827, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo id";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(6, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 30;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cargo_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoice_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cargodetails);
            this.Controls.Add(this.invoicedetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderDetails";
            this.Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button invoicedetails;
        private System.Windows.Forms.Button cargodetails;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoice_id;
        private System.Windows.Forms.TextBox cargo_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}