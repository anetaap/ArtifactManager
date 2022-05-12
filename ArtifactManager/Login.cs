using System;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class SignIn : Form
    {
        private FrontPage _frontPage;
        private AdminFp _adminFp;
        private UserFp _userFp;
        
        private String _username;
        private String _password;
        public SignIn(FrontPage frontPage)
        {
            _frontPage = frontPage;
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
            
            // TODO implement in settings function validating if user exists

            MessageBox.Show(@"User do not exist, check correctness of your data or register first.");
            
            // TODO implement in settings function that checks if user is admin
            // if admin:
            // _adminFp = new AdminFP();
            // else:
            _userFp = new UserFp(_frontPage);
            
            Hide();
            _userFp.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }
    }
}