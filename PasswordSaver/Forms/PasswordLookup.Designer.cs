namespace PasswordSaver
{
    partial class PasswordLookup
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
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.EnterAppNameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.pWord = new System.Windows.Forms.Label();
            this.goToAddNewAppButton = new System.Windows.Forms.Button();
            this.form1Label = new System.Windows.Forms.Label();
            this.deleteAppButton = new System.Windows.Forms.Button();
            this.editAppButton = new System.Windows.Forms.Button();
            this.editAppPanel = new System.Windows.Forms.Panel();
            this.submitChangesButton = new System.Windows.Forms.Button();
            this.newUsernameTxtbox = new System.Windows.Forms.TextBox();
            this.newPasswordTxtbox = new System.Windows.Forms.TextBox();
            this.editUsernameLabel = new System.Windows.Forms.Label();
            this.editPasswordLabel = new System.Windows.Forms.Label();
            this.exitEditPanel = new System.Windows.Forms.Button();
            this.editAppPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextbox.Location = new System.Drawing.Point(140, 55);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchTextbox.TabIndex = 0;
            // 
            // EnterAppNameLabel
            // 
            this.EnterAppNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterAppNameLabel.AutoSize = true;
            this.EnterAppNameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAppNameLabel.Location = new System.Drawing.Point(27, 56);
            this.EnterAppNameLabel.Name = "EnterAppNameLabel";
            this.EnterAppNameLabel.Size = new System.Drawing.Size(108, 16);
            this.EnterAppNameLabel.TabIndex = 1;
            this.EnterAppNameLabel.Text = "Enter App Name:";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(246, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(42, 24);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Go";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(77, 143);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Username:";
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.ForeColor = System.Drawing.SystemColors.Desktop;
            this.uName.Location = new System.Drawing.Point(153, 146);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(16, 13);
            this.uName.TabIndex = 6;
            this.uName.Text = "...";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(77, 165);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Password:";
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.AutoSize = true;
            this.AppNameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppNameLabel.Location = new System.Drawing.Point(132, 119);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(70, 16);
            this.AppNameLabel.TabIndex = 9;
            this.AppNameLabel.Text = "App Name";
            // 
            // pWord
            // 
            this.pWord.AutoSize = true;
            this.pWord.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pWord.Location = new System.Drawing.Point(153, 168);
            this.pWord.Name = "pWord";
            this.pWord.Size = new System.Drawing.Size(16, 13);
            this.pWord.TabIndex = 10;
            this.pWord.Text = "...";
            // 
            // goToAddNewAppButton
            // 
            this.goToAddNewAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goToAddNewAppButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToAddNewAppButton.Location = new System.Drawing.Point(9, 229);
            this.goToAddNewAppButton.Name = "goToAddNewAppButton";
            this.goToAddNewAppButton.Size = new System.Drawing.Size(95, 27);
            this.goToAddNewAppButton.TabIndex = 11;
            this.goToAddNewAppButton.Text = "Add New App";
            this.goToAddNewAppButton.UseVisualStyleBackColor = true;
            this.goToAddNewAppButton.Click += new System.EventHandler(this.goToAddNewAppButton_Click);
            // 
            // form1Label
            // 
            this.form1Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form1Label.AutoSize = true;
            this.form1Label.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Label.Location = new System.Drawing.Point(116, 19);
            this.form1Label.Name = "form1Label";
            this.form1Label.Size = new System.Drawing.Size(124, 16);
            this.form1Label.TabIndex = 12;
            this.form1Label.Text = "Password Lookup";
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteAppButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppButton.Location = new System.Drawing.Point(238, 229);
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.Size = new System.Drawing.Size(95, 27);
            this.deleteAppButton.TabIndex = 13;
            this.deleteAppButton.Text = "Delete App";
            this.deleteAppButton.UseVisualStyleBackColor = true;
            this.deleteAppButton.Click += new System.EventHandler(this.deleteAppButton_Click);
            // 
            // editAppButton
            // 
            this.editAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAppButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppButton.Location = new System.Drawing.Point(119, 229);
            this.editAppButton.Name = "editAppButton";
            this.editAppButton.Size = new System.Drawing.Size(95, 27);
            this.editAppButton.TabIndex = 14;
            this.editAppButton.Text = "Edit App";
            this.editAppButton.UseVisualStyleBackColor = true;
            this.editAppButton.Click += new System.EventHandler(this.editAppButton_Click);
            // 
            // editAppPanel
            // 
            this.editAppPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAppPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editAppPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editAppPanel.Controls.Add(this.exitEditPanel);
            this.editAppPanel.Controls.Add(this.submitChangesButton);
            this.editAppPanel.Controls.Add(this.newUsernameTxtbox);
            this.editAppPanel.Controls.Add(this.newPasswordTxtbox);
            this.editAppPanel.Controls.Add(this.editUsernameLabel);
            this.editAppPanel.Controls.Add(this.editPasswordLabel);
            this.editAppPanel.Location = new System.Drawing.Point(51, 91);
            this.editAppPanel.Name = "editAppPanel";
            this.editAppPanel.Size = new System.Drawing.Size(236, 121);
            this.editAppPanel.TabIndex = 15;
            // 
            // submitChangesButton
            // 
            this.submitChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitChangesButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitChangesButton.Location = new System.Drawing.Point(97, 92);
            this.submitChangesButton.Name = "submitChangesButton";
            this.submitChangesButton.Size = new System.Drawing.Size(53, 24);
            this.submitChangesButton.TabIndex = 27;
            this.submitChangesButton.Text = "Submit";
            this.submitChangesButton.UseVisualStyleBackColor = true;
            this.submitChangesButton.Click += new System.EventHandler(this.submitChangesButton_Click);
            // 
            // newUsernameTxtbox
            // 
            this.newUsernameTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUsernameTxtbox.Location = new System.Drawing.Point(128, 31);
            this.newUsernameTxtbox.Name = "newUsernameTxtbox";
            this.newUsernameTxtbox.Size = new System.Drawing.Size(98, 20);
            this.newUsernameTxtbox.TabIndex = 24;
            // 
            // newPasswordTxtbox
            // 
            this.newPasswordTxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordTxtbox.Location = new System.Drawing.Point(128, 64);
            this.newPasswordTxtbox.Name = "newPasswordTxtbox";
            this.newPasswordTxtbox.Size = new System.Drawing.Size(98, 20);
            this.newPasswordTxtbox.TabIndex = 23;
            // 
            // editUsernameLabel
            // 
            this.editUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editUsernameLabel.AutoSize = true;
            this.editUsernameLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUsernameLabel.Location = new System.Drawing.Point(3, 35);
            this.editUsernameLabel.Name = "editUsernameLabel";
            this.editUsernameLabel.Size = new System.Drawing.Size(116, 16);
            this.editUsernameLabel.TabIndex = 22;
            this.editUsernameLabel.Text = "Update Username:";
            // 
            // editPasswordLabel
            // 
            this.editPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPasswordLabel.AutoSize = true;
            this.editPasswordLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPasswordLabel.Location = new System.Drawing.Point(2, 64);
            this.editPasswordLabel.Name = "editPasswordLabel";
            this.editPasswordLabel.Size = new System.Drawing.Size(113, 16);
            this.editPasswordLabel.TabIndex = 21;
            this.editPasswordLabel.Text = "Update Password:";
            // 
            // exitEditPanel
            // 
            this.exitEditPanel.BackColor = System.Drawing.Color.Red;
            this.exitEditPanel.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitEditPanel.Location = new System.Drawing.Point(210, 0);
            this.exitEditPanel.Name = "exitEditPanel";
            this.exitEditPanel.Size = new System.Drawing.Size(26, 23);
            this.exitEditPanel.TabIndex = 28;
            this.exitEditPanel.Text = "X";
            this.exitEditPanel.UseVisualStyleBackColor = false;
            this.exitEditPanel.Click += new System.EventHandler(this.exitEditPanel_Click);
            // 
            // PasswordLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(345, 258);
            this.Controls.Add(this.editAppPanel);
            this.Controls.Add(this.editAppButton);
            this.Controls.Add(this.deleteAppButton);
            this.Controls.Add(this.form1Label);
            this.Controls.Add(this.goToAddNewAppButton);
            this.Controls.Add(this.pWord);
            this.Controls.Add(this.AppNameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.EnterAppNameLabel);
            this.Controls.Add(this.searchTextbox);
            this.Name = "PasswordLookup";
            this.Text = "Password Lookup";
            this.editAppPanel.ResumeLayout(false);
            this.editAppPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.Label EnterAppNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label pWord;
        private System.Windows.Forms.Button goToAddNewAppButton;
        private System.Windows.Forms.Label form1Label;
        private System.Windows.Forms.Button deleteAppButton;
        private System.Windows.Forms.Button editAppButton;
        private System.Windows.Forms.Panel editAppPanel;
        private System.Windows.Forms.TextBox newUsernameTxtbox;
        private System.Windows.Forms.TextBox newPasswordTxtbox;
        private System.Windows.Forms.Label editUsernameLabel;
        private System.Windows.Forms.Label editPasswordLabel;
        private System.Windows.Forms.Button submitChangesButton;
        private System.Windows.Forms.Button exitEditPanel;
    }
}

