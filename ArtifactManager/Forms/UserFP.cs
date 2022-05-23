using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class UserFp : Form
    {
        private FrontPage _frontPage;
        private UserProfile _userProfile;
        private Validations _validations;
        private Catalog _catalog;
        private AddCategory _addCategory;
        private AddUserCategory _addUserCategory;
        private CreateElement _createElement;
        private List<Artifact> _artifacts;
        public UserFp(FrontPage frontPage, Validations validations)
        {
            _frontPage = frontPage;
            _validations = validations;
            _catalog = new Catalog(_frontPage, this, _validations);
            _userProfile = new UserProfile(_frontPage, this, _validations);
            _addCategory = new AddCategory(_frontPage, this, _validations);
            _addUserCategory = new AddUserCategory(_frontPage, this, _validations);
            _createElement = new CreateElement(_frontPage, this, _validations);
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

        private void create_Click(object sender, EventArgs e)
        {
            Hide();
            _addCategory.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Hide();
            _addUserCategory.Show();
        }

        private void createelement_Click(object sender, EventArgs e)
        {
            Hide();
            _createElement.Show();
        }
    }
}