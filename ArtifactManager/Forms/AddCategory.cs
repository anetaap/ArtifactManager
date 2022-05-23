using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;

namespace ArtifactManager.Forms
{
    public partial class AddCategory : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private Validations _validations;
        private string[] _attributesType = {"int", "string"};
        private List<string[]> _categoryAttributes;

        public AddCategory(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            _categoryAttributes = new List<string[]>();
            foreach (string s in _attributesType)
            {
                types.Items.Add(s);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _userFp.Show();
            categoryname.Text = "";
            types.Text = "";
            attributename.Text = "";
            attributes.Items.Clear();
            _categoryAttributes.Clear();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string categoryName = categoryname.Text;
            string attributeName = attributename.Text;
            string attributeType = types.Text;

            string[] informations = {attributeName, attributeType, categoryName, _validations.UserId.ToString()};
            if (!_validations.CompletenessValidation(informations))
            {
                MessageBox.Show(@"Enter all required information.");
                return;   
            }

            string attribute = $"Category name: {categoryName}, Attribute name: {attributeName}, Attribute Type: " +
                               $"{attributeType}.";
            if (!attributes.Items.Contains(attribute))
            {
                attributes.Items.Add(attribute);
                _categoryAttributes.Add(informations);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (attributes.SelectedIndex != -1)
            {
                int index = attributes.SelectedIndex;
            
                attributes.Items.RemoveAt(index);
                _categoryAttributes.RemoveAt(index);
            }
        }
        
        private void create_Click(object sender, EventArgs e)
        {
            if (categoryname.Text.Length <= 0)
            {
                MessageBox.Show(@"Enter at least Category name");
                return;
            }
            string categoryName = categoryname.Text;
            
            MyDbContextFunctions.AddCategory(categoryName, _validations.UserId);
              
            foreach (string[] categoryAttribute in _categoryAttributes)
            {
                MyDbContextFunctions.AddCategoryAttribute(categoryAttribute);
            }
            MessageBox.Show(@"Category was successfully created.");
            categoryname.Text = "";
            types.Text = "";
            attributename.Text = "";
            attributes.Items.Clear();
            _categoryAttributes.Clear();
        }
    }
}