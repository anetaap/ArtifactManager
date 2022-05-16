using System;
using System.Windows.Forms;

namespace ArtifactManager.Forms
{
    public partial class UserProfile : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private PasswordChange _passwordChange;
        public UserProfile(FrontPage frontPage, UserFp userFp)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            
            _passwordChange = new PasswordChange(this);
            
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _userFp.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            // TODO implement in setting function that delete user from database and all related with it information
            
            Close();
            _userFp.Close();
            _frontPage.Show();
        }

        private void change_passwd_Click(object sender, EventArgs e)
        {
            // TODO implement in setting function that changes the password 
            
            Hide();
            _passwordChange.Show();
        }
    }
}