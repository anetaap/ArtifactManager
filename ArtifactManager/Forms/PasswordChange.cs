using System;
using System.Windows.Forms;
using ArtifactManager.Classes;

namespace ArtifactManager.Forms
{
    public partial class PasswordChange : Form
    {
        private UserProfile _userProfile;
        private Validations _validations;

        private String _password;
        private String _password1;
        private String _password2;
        public PasswordChange(UserProfile userProfile)
        {
            _userProfile = userProfile;

            _validations = new Validations();
            InitializeComponent();
        }

        private void PasswordChange_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void change_passwd_Click(object sender, EventArgs e)
        {
            _password = password.Text;
            _password1 = password1.Text;
            _password2 = password2.Text;
            
            if (!_validations.PasswordMatchValidation(_password))
            {
                MessageBox.Show(@"Current password is incorrect.");
                return;
            }

            if (!_validations.PasswordValidation(_password1))
            {
                MessageBox.Show(@"Invalid password form.");
                return;
            }

            if (!_validations.PasswordMatchValidation(_password1, _password2))
            {
                MessageBox.Show(@"The passwords do not match.");
                return;
            }
            
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

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void password1_TextChanged(object sender, EventArgs e)
        {
            password1.UseSystemPasswordChar = true;
        }

        private void password2_TextChanged(object sender, EventArgs e)
        {
            password2.UseSystemPasswordChar = true;
        }
    }
}