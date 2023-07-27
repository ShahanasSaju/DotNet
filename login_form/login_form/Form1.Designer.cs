namespace login_form
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.alert = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.alert);
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Controls.Add(this.passwordtb);
            this.panel1.Controls.Add(this.usernametb);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Location = new System.Drawing.Point(234, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 188);
            this.panel1.TabIndex = 0;
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Location = new System.Drawing.Point(43, 97);
            this.alert.MinimumSize = new System.Drawing.Size(225, 0);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(225, 16);
            this.alert.TabIndex = 6;
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(70, 157);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 5;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(114, 129);
            this.loginbutton.MinimumSize = new System.Drawing.Size(90, 35);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(90, 35);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.Location = new System.Drawing.Point(155, 70);
            this.passwordtb.MinimumSize = new System.Drawing.Size(11, 4);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '.';
            this.passwordtb.Size = new System.Drawing.Size(112, 24);
            this.passwordtb.TabIndex = 3;
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(155, 39);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(112, 22);
            this.usernametb.TabIndex = 2;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(35, 70);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(75, 16);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(35, 39);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(86, 16);
            this.Username.TabIndex = 0;
            this.Username.Text = "User name ";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Title.Location = new System.Drawing.Point(343, 64);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(102, 28);
            this.Title.TabIndex = 1;
            this.Title.Text = "Login";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label alert;
    }
}

