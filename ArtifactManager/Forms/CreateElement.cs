using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class CreateElement : Form
    {
        private FrontPage _frontPage;
        private UserFp _userFp;
        private Validations _validations;
        
        private List<Category> _categories;
        private List<string[]> _elementAttributes;

        private string[] _attributesType = {"int", "string"};

        public CreateElement(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;

            InitializeComponent();
        }
        
        private void CreateElement_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            _elementAttributes = new List<string[]>();
            _categories = MyDbContextFunctions.GetUserCategories(_validations.Username);
            foreach (var category1 in _categories)
            {
                category.Items.Add(category1.CategoryName);
            }

            foreach (var s in _attributesType)
            {
                types.Items.Add(s);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _userFp.Show();
            Clean();
        }
        
        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string cat = category.Text;
            if (cat == "")
            {
                MessageBox.Show(@"Choose category!");
                return;
            }
            string type = types.Text;
            string attributName = attributename.Text;
            string[] informations = {type, attributName};
            if (!_validations.CompletenessValidation(informations))
            {
                MessageBox.Show(@"Enter all required information.");
                return;
            }

            string attribute = $"Attribute Name: {attributName}, Type: {type}";
            if (!attributes.Items.Contains(attribute))
            {
                attributes.Items.Add(attribute);
                _elementAttributes.Add(informations);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (attributes.SelectedIndex != -1)
            {
                int index = attributes.SelectedIndex;
                _elementAttributes.RemoveAt(index);
                attributes.Items.RemoveAt(index);
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (elementname.Text == "")
            {
                MessageBox.Show(@"Enter at least Element name and choose Category.");
                return;
            }

            int index = category.SelectedIndex;
            if (index != -1)
            {
                int categoryId = _categories[index].CategoryId;
                string elementName = elementname.Text;
                MyDbContextFunctions.AddElement(elementName, categoryId);
                int elementId = MyDbContextFunctions.GetElementId(elementName, categoryId);
                foreach (var elementAttribute in _elementAttributes)
                {
                    string elementAttributeType = elementAttribute[0];
                    string elementAttributeName = elementAttribute[1];
                    MyDbContextFunctions.AddElementAttribute(elementAttributeName, elementAttributeType, elementId);
                }
            }
            else
            {
                MessageBox.Show(@"Choose category!");
                return;
            }
            MessageBox.Show(@"Element was successfully created.");
            Clean();
        }

        private void Clean()
        {
            category.Text = "";
            elementname.Text = "";
            types.Text = "";
            attributename.Text = "";
            attributes.Items.Clear();
            _elementAttributes.Clear();
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clean();
        }
    }
}