using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver.Forms
{
    public partial class EditApp : Form
    {
        Repositories.PasswordLookupRepo pr = new Repositories.PasswordLookupRepo();
        Repositories.AddNewAppRepo ar = new Repositories.AddNewAppRepo();

        public EditApp()
        {
            InitializeComponent();
            
        }

        private void searchAppToEditBtn_Click(object sender, EventArgs e)
        {
            var info = pr.GetAppInfo(appToEditTextbox.Text);
            if (info != null)
            {
                curUsernameLabel.Text = info.Username;
                curPasswordLabel.Text = info.Password;
            }
        }

        private void submitChangesBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please verify that the details are correct:\nUsername: " + newUsernameTextbox.Text + "\nPassword: " + newPasswordTextbox.Text, "Verification", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                ar.EditApp(appToEditTextbox.Text, newUsernameTextbox.Text, newPasswordTextbox.Text);
                MessageBox.Show("Details updated submitted.");
            }
        }
    }
}
