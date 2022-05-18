using System;
using System.Windows.Forms;
using ArtifactManager.Classes;

namespace ArtifactManager.Forms
{
    public partial class SignIn : Form
    {
        private FrontPage _frontPage;
        private AdminFp _adminFp;
        private UserFp _userFp;
        private Validations _validations;
        
        private string _username;
        private string _password;
        public SignIn(FrontPage frontPage)
        {
            _frontPage = frontPage;
            _validations = new Validations();
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _frontPage.Show();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            _username = username.Text;
            _password = password.Text;

            if (!_validations.UsernameValidation(_username))
            {
                MessageBox.Show(@"User do not exist, check correctness of your data or register first.");
            }

            if (_validations.PasswordMatchValidation(_password))
            {
                // TODO implement in validations function that checks if user is admin
                // if admin:
                // _adminFp = new AdminFP(_frontPage, _validations);
                // else:
                _userFp = new UserFp(_frontPage, _validations);
                _validations.Login(_username);
            
                Hide();
                _userFp.Show();

                username.Text = "";
                password.Text = "";
            }
            else
            {
                MessageBox.Show(@"Incorrect password.");
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
    }
}