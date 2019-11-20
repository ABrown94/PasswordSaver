using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver
{
    public partial class AddNewApp : Form
    {
        Repositories.AddNewAppRepo ar = new Repositories.AddNewAppRepo();
        public AddNewApp()
        {
            InitializeComponent();
        }

        private void submitNewAppButton_Click(object sender, EventArgs e)
        {
            if(appNameTextbox.Text.Length < 1)
            {
                MessageBox.Show("Please enter an app name.");
            }

            if(ar.checkIfUnique(appNameTextbox.Text) == false)
            {
                MessageBox.Show("This app already exists");
            }

            else if (usernameTextbox.Text.Length < 1 || passwordTextbox.Text.Length < 1)
            {
                DialogResult dr = MessageBox.Show("Do you want to leave the username/password field blank?", "Verficiation", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    submitDetails();
                }
            }

            else
            {
                submitDetails();
            }
            
            /*DialogResult result = MessageBox.Show("Please verify that the details are correct:\nApp Name: " + appNameTextbox.Text + "\nUsername: " + usernameTextbox.Text + "\nPassword: " + passwordTextbox.Text, "Verification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                App newApp = new App();
                newApp.AppName = appNameTextbox.Text;
                newApp.Username = usernameTextbox.Text;
                newApp.Password = passwordTextbox.Text;
                ar.AddNewApp(newApp);
                MessageBox.Show("Details successfully submitted.");
            }*/

        }
        private void submitDetails()
        {
            DialogResult result = MessageBox.Show("Please verify that the details are correct:\nApp Name: " + appNameTextbox.Text + "\nUsername: " + usernameTextbox.Text + "\nPassword: " + passwordTextbox.Text, "Verification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                App newApp = new App();
                newApp.AppName = appNameTextbox.Text;
                newApp.Username = usernameTextbox.Text;
                newApp.Password = passwordTextbox.Text;
                ar.AddNewApp(newApp);
                MessageBox.Show("Details successfully submitted.");
            }

        }

        private void goToLookupButton_Click(object sender, EventArgs e)
        {
            PasswordLookup form = new PasswordLookup();
            this.Hide();
            form.Show();
        }
    }
}
