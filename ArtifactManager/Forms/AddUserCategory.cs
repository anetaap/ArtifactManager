using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class AddUserCategory : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private Validations _validations;

        private int _categoryId;
        private int _categoryAttributeId;
        private string _selectedAttributeName;

        private List<Category> _categories;
        private List<CategoryAttribute> _categoryAttributes;
        private List<CategoryAttribute> _selectedCategoryAttributes;
        private Dictionary<int, string> _newAttributes;
        public AddUserCategory(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
            _categoryAttributes = new List<CategoryAttribute>();
            _newAttributes = new Dictionary<int, string>();
            InitializeComponent();
        }
        
        private void AddUserCategory_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            _categories = MyDbContextFunctions.GetUserCategories(_validations.Username);
            List<CategoryAttribute> categoryAttributes;
            foreach (var category in _categories)
            {
                categoryname.Items.Add(category.CategoryName);
                categoryAttributes = MyDbContextFunctions.GetCategoryAttributes(category.CategoryId);
                foreach (var attribute in categoryAttributes)
                {
                    _categoryAttributes.Add(attribute);
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

        private void add_Click(object sender, EventArgs e)
        {
            string catAttr = categoryattributes.Text;
            string attributeValue = value.Text;
            string attributeType = type.Text;
            string[] informations = {catAttr, attributeType, attributeValue};
            if (!_validations.CompletenessValidation(informations))
            {
                MessageBox.Show(@"Enter all required data!");
                return;
            }
            if (attributeType == "int")
            {
                if (!_validations.TypeIntParse(attributeValue))
                {
                    MessageBox.Show(@"Enter int value!");
                    return;
                }
            }

            string newAttribute = $"{_selectedAttributeName}: {attributeValue}";
            if (!attributeValue.Contains(newAttribute))
            {
                attributes.Items.Add(newAttribute);
                _newAttributes[_categoryAttributeId] = attributeValue;
            }
        }

        private void categoryname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = categoryname.SelectedIndex;
            categoryattributes.Items.Clear();
            if (index != -1)
            {
                _categoryId = _categories[index].CategoryId;
                foreach (var categoryAttribute in _categoryAttributes)
                {
                    if (categoryAttribute.CategoryId == _categoryId) 
                        categoryattributes.Items.Add(categoryAttribute.CategoryAttributeName);
                }
            }
        }

        private void categoryattributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = categoryattributes.SelectedIndex;
            if (index != -1)
            {
                _selectedCategoryAttributes = MyDbContextFunctions.GetCategoryAttributes(_categoryId);
                type.Text = _selectedCategoryAttributes[index].CategoryAttributeType;
                _categoryAttributeId = _selectedCategoryAttributes[index].CategoryAttributeId;
                _selectedAttributeName = _selectedCategoryAttributes[index].CategoryAttributeName;
            }
        }

        private void addcategory_Click(object sender, EventArgs e)
        {
            if (name.Text.Length <= 0)
            {
                MessageBox.Show(@"Enter at least Category name");
                return;
            }
            string userCategoryName = name.Text;

            int userCategoryId = MyDbContextFunctions.AddUserCategory(_categoryId, userCategoryName, 
                _validations.UserId);
            foreach (var newAttribute in _newAttributes)
            {
                string attributeValue = newAttribute.Value;
                int categoryAttributeId = newAttribute.Key;
                MyDbContextFunctions.AddUserCategoryAttribute(categoryAttributeId, userCategoryId, attributeValue);
            }
            _newAttributes.Clear();
        }
    }
}