using System;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class UserProfile : Form
    {
        private string _name;
        private string _lastname;
        private string _username;
        private string _email;
        private string _password;
        private int _mode;

        private FrontPage _frontPage;
        private UserFp _userFp;
        private AdminFp _adminFp;
        private PasswordChange _passwordChange;
        private Validations _validations;

        private string[] _information;
        public UserProfile(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
            // _information = MyDbContextFunctions.GetInformation(_validations.Username);
            _mode = 0;

            InitializeComponent();
            InitWall();
        }
        
        public UserProfile(FrontPage frontPage, AdminFp adminFp, Validations validations)
        {
            _frontPage = frontPage;
            _adminFp = adminFp;
            _validations = validations;
            _mode = 1;
            InitializeComponent();
            InitWall();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void InitWall()
        {
            _information = MyDbContextFunctions.GetInformation(_validations.Username);
            name_.Text = _information[0];
            lastname_.Text = _information[1];
            username.Text = _information[2];
            email.Text = _information[3];

            name_.ReadOnly = true;
            lastname_.ReadOnly = true;
            username.ReadOnly = true;
            email.ReadOnly = true;
            save.Visible = false;
            discard.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (_mode == 0)
            {
                Hide();
                _userFp.Show();
            }
            else if (_mode == 1)
            {
                Hide();
                _adminFp.Show();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            _validations.RemoveUser(_information[2]);
            
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

        private void edit_Click(object sender, EventArgs e)
        {
            name_.ReadOnly = false;
            lastname_.ReadOnly = false;
            email.ReadOnly = false;

            save.Visible = true;
            discard.Visible = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            _name = name_.Text;
            _lastname = lastname_.Text;
            _email = email.Text;
            _password = _validations.Password;
            
            _information = new [] {_name, _lastname, _email};
            
            if (!_validations.CompletenessValidation(_information))
            {
                MessageBox.Show(@"Enter all required information!");
                return;
            }
            
            if (!_validations.EmailChangeValidation(_email))
            {
                MessageBox.Show(@"Email format is incorrect.");
                return;
            }
            
            _validations.ChangeInformation(_name, _lastname, _email);
            InitWall();
        }

        private void discard_Click(object sender, EventArgs e)
        {
            InitWall();
        }
    }
}