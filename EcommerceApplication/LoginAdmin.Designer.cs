namespace EcommerceApplication
{
    partial class LoginAdmin
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
            this.exitbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.passwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(218, 170);
            this.exitbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 27);
            this.exitbutton.TabIndex = 11;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click_1);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(134, 170);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(56, 27);
            this.loginbutton.TabIndex = 10;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 103);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 9;
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Location = new System.Drawing.Point(131, 103);
            this.passwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(56, 13);
            this.passwd.TabIndex = 8;
            this.passwd.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 61);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 7;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(131, 64);
            this.username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(39, 13);
            this.username.TabIndex = 6;
            this.username.Text = "Admin:";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exit.Location = new System.Drawing.Point(11, 210);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(64, 37);
            this.exit.TabIndex = 30;
            this.exit.Text = "BACK";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 258);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginAdmin";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button exit;
    }
}

