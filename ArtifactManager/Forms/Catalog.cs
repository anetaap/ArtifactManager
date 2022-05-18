using System;
using System.Windows.Forms;

namespace ArtifactManager.Forms
{
    public partial class Catalog : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        
        public Catalog(FrontPage frontPage, UserFp userFp)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _userFp.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}