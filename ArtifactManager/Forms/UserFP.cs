using System;
using System.Windows.Forms;
using ArtifactManager.Classes;

namespace ArtifactManager.Forms
{
    public partial class UserFp : Form
    {
        private FrontPage _frontPage;
        private UserProfile _userProfile;
        private Validations _validations;
        private Catalog _catalog;
        public UserFp(FrontPage frontPage)
        {
            _frontPage = frontPage;
            _validations = new Validations();
            _catalog = new Catalog(_frontPage, this);
            _userProfile = new UserProfile(_frontPage, this);
            InitializeComponent();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            _validations.Logout();
            
            Hide();
            _frontPage.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Hide();
            _userProfile.Show();
        }

        private void UserFp_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Hide();
            _frontPage.Close();
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            Hide();
            _catalog.Show();
        }
    }
}