using System;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.Forms
{
    public partial class SignUp : Form
    {
        private FrontPage _frontPage;
        private SignIn _signIn;
        private Validations _validations;

        private string _name;
        private string _lastname;
        private string _username;
        private string _email;
        private string _password;
        private string[] _information;
        public SignUp(FrontPage frontPage, SignIn signIn)
        {
            _frontPage = frontPage;
            _signIn = signIn;

            _validations = new Validations();
            
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _frontPage.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            _name = name_.Text;
            _lastname = lastname_.Text;
            _username = username.Text;
            _email = email.Text;
            _password = password.Text;

            _information = new [] {_name, _lastname, _username, _email, _password};
            
            if (!_validations.CompletenessValidation(_information))
            {
                MessageBox.Show(@"Enter all required information!");
                return;
            }
            
            if (!_validations.EmailValidation(_email))
            {
                MessageBox.Show(@"Email format is incorrect.");
                return;
            }
            if (!_validations.PasswordValidation(_password))
            {
                MessageBox.Show(@"Invalid password.");
                return;
            }
            
            if (_validations.UsernameValidation(_username))
            {
                MessageBox.Show(@"User with that username already exists.");
                return;
            }
            
            _password = _validations.PasswordHash(_password);
            MyDbContextFunctions.AddUser(_username, _name, _lastname, _email, _password);

            Hide();
            _signIn.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _signIn.Close();
            _frontPage.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }
    }
}