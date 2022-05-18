using System;
using System.Windows.Forms;
using ArtifactManager.Classes;

namespace ArtifactManager.Forms
{
    public partial class UserProfile : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private PasswordChange _passwordChange;
        private Validations _validations;
        public UserProfile(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;

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
            // TODO implement in MyDbContextFunctions function that delete user from database and all related with it information
            
            Close();
            _userFp.Close();
            _frontPage.Show();
        }

        private void change_passwd_Click(object sender, EventArgs e)
        {
            _passwordChange = new PasswordChange(this, _validations);
            
            Hide();
            _passwordChange.Show();
        }
    }
}