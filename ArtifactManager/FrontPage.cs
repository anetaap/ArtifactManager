using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtifactManager
{
    public partial class FrontPage : Form
    {
        private SignIn _signIn;
        private SignUp _signUp;
        public FrontPage()
        {
            _signIn = new SignIn(this);
            _signUp = new SignUp(this, _signIn);
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Hide();
            _signUp.Show();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Hide();
            _signIn.Show();
        }
    }
}