namespace EcommerceApplication
{
    partial class Main
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
            this.userlogin = new System.Windows.Forms.Button();
            this.adminlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userlogin
            // 
            this.userlogin.Location = new System.Drawing.Point(115, 155);
            this.userlogin.Name = "userlogin";
            this.userlogin.Size = new System.Drawing.Size(248, 125);
            this.userlogin.TabIndex = 0;
            this.userlogin.Text = "Login as Costumer";
            this.userlogin.UseVisualStyleBackColor = true;
            this.userlogin.Click += new System.EventHandler(this.userlogin_Click);
            // 
            // adminlogin
            // 
            this.adminlogin.Location = new System.Drawing.Point(417, 155);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(252, 125);
            this.adminlogin.TabIndex = 1;
            this.adminlogin.Text = "Login as Admin";
            this.adminlogin.UseVisualStyleBackColor = true;
            this.adminlogin.Click += new System.EventHandler(this.adminlogin_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.userlogin);
            this.Name = "Main";
            this.Text = "MAIN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userlogin;
        private System.Windows.Forms.Button adminlogin;
    }
}