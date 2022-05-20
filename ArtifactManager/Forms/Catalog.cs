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
        private List<UserCategory> _userCategories = new List<UserCategory>();
        private List<Element> _elements = new List<Element>();
        private List<int> _categoriesIds = new List<int>();

        public Catalog(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
            InitializeComponent();
        }
        
        private void Catalog_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            
            _categories = MyDbContextFunctions.GetUserCategories(_validations.Username);
            foreach (var cat in _categories)
            {
                category.Items.Add(cat.CategoryName);
                _categoriesIds.Add(cat.UserId);
            }

            List<Element> elements;
            List<UserCategory> userCategories;
            foreach (int id in _categoriesIds)
            {
                elements = MyDbContextFunctions.GetCategoryElements(id);
                userCategories = MyDbContextFunctions.GetUserCategories(id);
                foreach (Element element in elements)
                {
                    _elements.Add(element);
                }

                foreach (var cat in userCategories)
                {
                    mycategory.Items.Add(cat.CategoryName);
                    _userCategories.Add(cat);
                }
            }
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
        
        // TODO edit button
        // TODO add button
        // TODO remove button
        // TODO displaying artifacts 
        // TODO adding/editing forms
    }
}