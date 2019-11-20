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
    public partial class PasswordLookup : Form
    {
        Repositories.PasswordLookupRepo pr = new Repositories.PasswordLookupRepo();
        Repositories.AddNewAppRepo ar = new Repositories.AddNewAppRepo();

        public PasswordLookup()
        {
            InitializeComponent();
            editAppPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var info = pr.GetAppInfo(searchTextbox.Text);
            if (info != null)
            {
                AppNameLabel.Text = info.AppName;
                uName.Text = info.Username;
                pWord.Text = info.Password;
            }
        }

        private void goToAddNewAppButton_Click(object sender, EventArgs e)
        {
            AddNewApp newApp = new AddNewApp();
            this.Hide();
            newApp.Show();
        }

        private void editAppButton_Click(object sender, EventArgs e)
        {
            if(searchTextbox.Text.Length > 0)
            {
                editAppPanel.Show();
                var info = pr.GetAppInfo(searchTextbox.Text);
                newUsernameTxtbox.Text = info.Username;
                newPasswordTxtbox.Text = info.Password;
            }
            else
            {
                MessageBox.Show("Please enter an app to edit");
            }                     
        }

        private void exitEditPanel_Click(object sender, EventArgs e)
        {
            newUsernameTxtbox.Clear();
            newPasswordTxtbox.Clear();
            editAppPanel.Hide();
        }

        private void submitChangesButton_Click(object sender, EventArgs e)
        {
            if (newUsernameTxtbox.Text.Length > 0 && newPasswordTxtbox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Please verify that the details are correct:\nUsername: " + newUsernameTxtbox.Text + "\nPassword: " + newPasswordTxtbox.Text, "Verification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ar.EditApp(searchTextbox.Text, newUsernameTxtbox.Text, newPasswordTxtbox.Text);
                    MessageBox.Show("Details updated submitted.");
                }
                newUsernameTxtbox.Clear();
                newPasswordTxtbox.Clear();
                editAppPanel.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a username/password");
            }          
        }

        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            if (searchTextbox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + searchTextbox.Text + "?", "Verification", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ar.DeleteApp(searchTextbox.Text);
                    MessageBox.Show("App deleted successfully");
                }
            }
            else
            {
                MessageBox.Show("Please enter an app to delete");
            }


        }
    }
}