using System;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class PasswordChange : Form
    {
        private UserProfile _userProfile;
        public PasswordChange(UserProfile userProfile)
        {
            _userProfile = userProfile;
            InitializeComponent();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void change_passwd_Click(object sender, EventArgs e)
        {   
            // TODO implement in settings function that checks if current password is correct  
            MessageBox.Show(@"Current password is incorrect.");
            // TODO implement in settings function that checks if the password1 is the same as password2
            MessageBox.Show(@"The passwords do not match.");
            // TODO implement in settings function that changes the password in database
            MessageBox.Show(@"The password changed correctly.");
            
            Hide();
            _userProfile.Show();
        }

        private void back__Click(object sender, EventArgs e)
        {
            Hide();
            _userProfile.Show();
        }
    }
}