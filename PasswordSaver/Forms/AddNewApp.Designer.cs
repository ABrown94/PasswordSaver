namespace PasswordSaver
{
    partial class AddNewApp
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
            this.Enter_New_App = new System.Windows.Forms.Label();
            this.appNameTextbox = new System.Windows.Forms.TextBox();
            this.newUsername = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.submitNewAppButton = new System.Windows.Forms.Button();
            this.goToLookupButton = new System.Windows.Forms.Button();
            this.form2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_New_App
            // 
            this.Enter_New_App.AutoSize = true;
            this.Enter_New_App.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_New_App.Location = new System.Drawing.Point(31, 57);
            this.Enter_New_App.Name = "Enter_New_App";
            this.Enter_New_App.Size = new System.Drawing.Size(108, 16);
            this.Enter_New_App.TabIndex = 3;
            this.Enter_New_App.Text = "Enter App Name:";
            // 
            // appNameTextbox
            // 
            this.appNameTextbox.Location = new System.Drawing.Point(140, 57);
            this.appNameTextbox.Name = "appNameTextbox";
            this.appNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.appNameTextbox.TabIndex = 2;
            // 
            // newUsername
            // 
            this.newUsername.AutoSize = true;
            this.newUsername.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUsername.Location = new System.Drawing.Point(31, 97);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(104, 16);
            this.newUsername.TabIndex = 5;
            this.newUsername.Text = "Enter Username:";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(140, 97);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextbox.TabIndex = 4;
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPassword.Location = new System.Drawing.Point(31, 137);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(101, 16);
            this.newPassword.TabIndex = 7;
            this.newPassword.Text = "Enter Password:";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(140, 137);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextbox.TabIndex = 6;
            // 
            // submitNewAppButton
            // 
            this.submitNewAppButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitNewAppButton.Location = new System.Drawing.Point(159, 174);
            this.submitNewAppButton.Name = "submitNewAppButton";
            this.submitNewAppButton.Size = new System.Drawing.Size(58, 26);
            this.submitNewAppButton.TabIndex = 8;
            this.submitNewAppButton.Text = "Submit";
            this.submitNewAppButton.UseVisualStyleBackColor = true;
            this.submitNewAppButton.Click += new System.EventHandler(this.submitNewAppButton_Click);
            // 
            // goToLookupButton
            // 
            this.goToLookupButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToLookupButton.Location = new System.Drawing.Point(224, 208);
            this.goToLookupButton.Name = "goToLookupButton";
            this.goToLookupButton.Size = new System.Drawing.Size(119, 23);
            this.goToLookupButton.TabIndex = 9;
            this.goToLookupButton.Text = "Look Up Password";
            this.goToLookupButton.UseVisualStyleBackColor = true;
            this.goToLookupButton.Click += new System.EventHandler(this.goToLookupButton_Click);
            // 
            // form2Label
            // 
            this.form2Label.AutoSize = true;
            this.form2Label.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form2Label.Location = new System.Drawing.Point(140, 9);
            this.form2Label.Name = "form2Label";
            this.form2Label.Size = new System.Drawing.Size(100, 16);
            this.form2Label.TabIndex = 10;
            this.form2Label.Text = "Add New App";
            // 
            // AddNewApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 234);
            this.Controls.Add(this.form2Label);
            this.Controls.Add(this.goToLookupButton);
            this.Controls.Add(this.submitNewAppButton);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.newUsername);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.Enter_New_App);
            this.Controls.Add(this.appNameTextbox);
            this.Name = "AddNewApp";
            this.Text = "Add New App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Enter_New_App;
        private System.Windows.Forms.TextBox appNameTextbox;
        private System.Windows.Forms.Label newUsername;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button submitNewAppButton;
        private System.Windows.Forms.Button goToLookupButton;
        private System.Windows.Forms.Label form2Label;
    }
}