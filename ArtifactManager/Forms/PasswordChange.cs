using System;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.Forms
{
    public partial class PasswordChange : Form
    {
        private UserProfile _userProfile;
        private Validations _validations;

        private string _password;
        private string _password1;
        private string _password2;
        private string _newpassword;
        public PasswordChange(UserProfile userProfile, Validations validations)
        {
            _userProfile = userProfile;
            _validations = validations;
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

            if (!_validations.PasswordsMatchValidation(_password1, _password2))
            {
                MessageBox.Show(@"The passwords do not match.");
                return;
            }

            _newpassword = _validations.PasswordHash(_password1);
            _validations.ChangePassword(_newpassword);
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