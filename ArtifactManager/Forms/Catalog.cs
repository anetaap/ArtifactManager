using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class Catalog : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private Validations _validations;
        private List<Category> _categories;

        public Catalog(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
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
            _categories = MyDbContextFunctions.GetUserCategories(_validations.Username);
            foreach (var cat in _categories)
            {
                category.Items.Add(cat.CategoryName);
            }
        }
    }
}