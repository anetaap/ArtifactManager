using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class FrontPage : Form
    {
        private SignIn _signIn;
        private SignUp _signUp;
        private Catalog _catalog;

        private List<Artifact> _artifacts;
        public FrontPage()
        {
            _signIn = new SignIn(this);
            _signUp = new SignUp(this, _signIn);
            _catalog = new Catalog(this);
            InitializeComponent();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            _artifacts = MyDbContextFunctions.GetAllArtifactsDesc();

            int[] nums = {1, 5, 10, 15};
            foreach (int num in nums)
            {
                counter.Items.Add(num);
            }

            int n = 0;
            if (_artifacts.Count < 5) {n = _artifacts.Count;}
            else { n = 5; }
            for(int i = 0; i < n; i++)
            {
                lastest.Items.Add(_artifacts[i].ArtifactName);
            }
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

        private void counter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (counter.SelectedIndex != -1)
            {
                int index = counter.SelectedIndex;
                int n = int.Parse(counter.Items[index].ToString());
                lastest.Items.Clear();
                if (_artifacts.Count < n) {n = _artifacts.Count;}
                for(int i = 0; i < n; i++)
                {
                    lastest.Items.Add(_artifacts[i].ArtifactName);
                }
            }
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            Hide();
            _catalog.Show();
        }
    }
}