namespace Meal.Design
{
    partial class ShowProfile
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
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.mobiletextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(559, 262);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(171, 22);
            this.addresstextBox.TabIndex = 28;
            // 
            // mobiletextBox
            // 
            this.mobiletextBox.Location = new System.Drawing.Point(559, 189);
            this.mobiletextBox.Name = "mobiletextBox";
            this.mobiletextBox.Size = new System.Drawing.Size(171, 22);
            this.mobiletextBox.TabIndex = 27;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(181, 268);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(171, 22);
            this.emailtextBox.TabIndex = 26;
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(181, 189);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(171, 22);
            this.usernametextBox.TabIndex = 25;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(452, 260);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(77, 30);
            this.address.TabIndex = 24;
            this.address.Text = "Address";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(390, 187);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(139, 30);
            this.mobile.TabIndex = 23;
            this.mobile.Text = "Mobile Numner";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(100, 268);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(57, 30);
            this.email.TabIndex = 22;
            this.email.Text = "Email";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(62, 185);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(95, 30);
            this.username.TabIndex = 21;
            this.username.Text = "UserName";
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.savebutton.Location = new System.Drawing.Point(226, 367);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(88, 43);
            this.savebutton.TabIndex = 20;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cancelbutton.Location = new System.Drawing.Point(443, 367);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(99, 43);
            this.cancelbutton.TabIndex = 19;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.editbutton.Location = new System.Drawing.Point(12, 103);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(145, 40);
            this.editbutton.TabIndex = 18;
            this.editbutton.Text = "Edit Profile";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Profile Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(164, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 64);
            this.panel1.TabIndex = 15;
            // 
            // ShowProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.mobiletextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.editbutton);
            this.Name = "ShowProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowProfile";
            this.Load += new System.EventHandler(this.ShowProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.TextBox mobiletextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}