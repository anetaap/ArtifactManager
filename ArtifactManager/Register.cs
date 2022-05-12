using System;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class SignUp : Form
    {
        private FrontPage _frontPage;
        private SignIn _signIn;

        private String _name;
        private String _lastname;
        private String _username;
        private String _email;
        private String _password;
        public SignUp(FrontPage frontPage, SignIn signIn)
        {
            _frontPage = frontPage;
            _signIn = signIn;
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
            
            // TODO implement in settings function that checks if email form is correct, else:

            MessageBox.Show(@"Email format is incorrect.");
            
            // TODO implement in settings function that checks if all values were given, else:

            MessageBox.Show(@"Enter all required information!");
            
            // TODO implement in settings function that add new user to database
            
            Hide();
            _signIn.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _signIn.Close();
            _frontPage.Close();
        }
    }
}