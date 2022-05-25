using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.History;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class AdminFp : Form
    {
        private FrontPage _frontPage;
        private Validations _validations;
        private UserProfile _userProfile;
        private int _userid;

        private List<User> _users;
        public AdminFp(FrontPage frontPage, Validations validations)
        {
            _frontPage = frontPage;
            _validations = validations;
            _users = MyDbContextFunctions.GetAllUsers();
            InitializeComponent();
            Display();
        }

        private void Display()
        {
            foreach (var user in _users)
            {
                string role = MyDbContextFunctions.GetUserRoleName(user.UserId);
                users.Items.Add($"Username: {user.Username}, Rola: {role}");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (users.SelectedIndex != -1)
            {
                MyDbContextFunctions.ChangeRole(_userid);
                users.Items.Clear();
                Display();
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            int index = users.SelectedIndex;
            string username = _users[index].Username;
            Validations validation = new Validations();
            validation.Login(username);
            _userProfile = new UserProfile(_frontPage, this, validation);
            
            Hide();
            _userProfile.Show();
        }

        private void AdminFp_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            _validations.Logout();
            
            Hide();
            _frontPage.Show();
        }

        private void users_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = users.SelectedIndex;
            if (index != -1)
            {
                var user = _users[index];
                _userid = user.UserId;
            }
        }
    }
}