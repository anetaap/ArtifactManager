using System;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class UserFp : Form
    {
        private FrontPage _frontPage;
        private UserProfile _userProfile;
        public UserFp(FrontPage frontPage)
        {
            _frontPage = frontPage;
            _userProfile = new UserProfile();
            InitializeComponent();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            // TODO implement logout function 
            
            Hide();
            _frontPage.Show();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            Hide();
            _userProfile.Show();
        }
    }
}