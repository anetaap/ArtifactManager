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
        private AddEditArtifact _addEditArtifact;
        private List<Category> _categories;
        private List<CategoryAttribute> _categoryAttributes;
        private List<UserCategory> _userCategories = new List<UserCategory>();
        private List<Artifact> _artifacts = new List<Artifact>();
        private List<UserCategoryAttribute> _userCategoryAttributes;
        private List<Artifact> _visibleArtifact;

        private bool _mode;

        public Catalog(FrontPage frontPage, UserFp userFp, Validations validations)
        {
            _frontPage = frontPage;
            _userFp = userFp;
            _validations = validations;
            _mode = true;
            InitializeComponent();
            InitWall();
        }

        public Catalog(FrontPage frontPage)
        {
            _frontPage = frontPage;
            _mode = false;
            
            InitializeComponent();
            InitWall();
        }
        
        private void Catalog_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            Clean();
            if (_mode) { _userFp.Show(); _userFp.InitWall();}
            else { _frontPage.Show();}
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }
        
        private void edit_Click(object sender, EventArgs e)
        {
            if (artifact.CheckedItems.Count > 1)
            {
                MessageBox.Show(@"Choose only one artifact to see details.");
                return;
            }
            int index = -1;
            if (artifact.CheckedIndices.Count > 0) { index = artifact.CheckedIndices[0];}
            if (index != -1)
            {
                var artifact1 = _visibleArtifact[index];
                _addEditArtifact = new AddEditArtifact(_frontPage, this, _validations, artifact1, _mode);
                _addEditArtifact.Show();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (mycategory.SelectedItem is null)
            {
                MessageBox.Show(@"First choose your category to add artifact.");
                return;
            }

            int index = mycategory.SelectedIndex;
            if (index != -1)
            {
                var userCategory = _userCategories[index];
                _addEditArtifact = new AddEditArtifact(_frontPage, this, _validations, userCategory);
                _addEditArtifact.Show();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (artifact.CheckedIndices.Count > 0)
            {
                List<int> indexes = new List<int>();
                foreach (var checkedIndex in artifact.CheckedIndices)
                {
                    string s = checkedIndex.ToString();
                    int index = int.Parse(s);
                    indexes.Add(_visibleArtifact[index].ArtifactId);
                }

                foreach (int index in indexes)
                {
                    MyDbContextFunctions.RemoveArtifact(index);
                }
            }
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (category.SelectedIndex != -1)
            {
                artifact.Items.Clear();
                attributes.Items.Clear();
                _visibleArtifact.Clear();
                
                int selectedIndex = category.SelectedIndex;
                int catId = _categories[selectedIndex].CategoryId;

                List<UserCategory> userCategories = new List<UserCategory>();
                foreach (var userCategory in _userCategories)
                {
                    if(userCategory.CategoryId == catId) userCategories.Add(userCategory);
                }
                
                List<Artifact> list;
                foreach (var userCategory in userCategories)
                {
                    list = MyDbContextFunctions.GetCategoryArtifacts(userCategory.UserCategoryId);
                    if (list != null)
                    {
                        foreach (Artifact a in list)
                        {
                            artifact.Items.Add(a.ArtifactName);
                            _visibleArtifact.Add(a);
                        }
                    }
                }
            }
        }
        
        private void mycategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mycategory.SelectedIndex != -1)
            {
                artifact.Items.Clear();
                _visibleArtifact.Clear();
                attributes.Items.Clear();
                
                int selectedIndex = mycategory.SelectedIndex;
                int categoryId = _userCategories[selectedIndex].CategoryId;
                int userCategoryId = _userCategories[selectedIndex].UserCategoryId;
                _categoryAttributes = MyDbContextFunctions.GetCategoryAttributes(categoryId);
                _userCategoryAttributes = MyDbContextFunctions.GetUserCategoryAttributes(userCategoryId);
                foreach (var attribute in _userCategoryAttributes)
                {
                    int categoryAttributeId = attribute.CategoryAttributeId;
                    foreach (var categoryAttribute in _categoryAttributes)
                    {
                        if (categoryAttribute.CategoryAttributeId == categoryAttributeId)
                        {
                            string inf =
                                $"{categoryAttribute.CategoryAttributeName}: {attribute.CategoryAttributeValue}";
                            attributes.Items.Add(inf);
                        }
                    }
                }
                List<Artifact> list = MyDbContextFunctions.GetCategoryArtifacts(userCategoryId);
                if (list != null)
                {
                    foreach (Artifact a in list)
                    {
                        if (a.UserCategoryId == userCategoryId)
                        {
                            artifact.Items.Add(a.ArtifactName);
                            _visibleArtifact.Add(a);
                        }
                    }
                }
            }
        }

        public void InitWall()
        {
            ClearAll();
            
            if (_mode)
            {
                _categories = MyDbContextFunctions.GetUserCategories(_validations.Username);
                _userCategories = MyDbContextFunctions.GetUserCategories(_validations.UserId);
            }
            else
            {
                _categories = MyDbContextFunctions.GetAllCategories();
                _userCategories = MyDbContextFunctions.GetAllUserCategories();
                remove.Visible = false;
                add.Visible = false;
            }
            
            foreach (var cat in _categories)
            {
                category.Items.Add(cat.CategoryName);
            }
            foreach (var cat in _userCategories)
            {
                mycategory.Items.Add(cat.CategoryName);
            }
            
            foreach (UserCategory userCategory in _userCategories)
            {
                var list = MyDbContextFunctions.GetCategoryArtifacts(userCategory.UserCategoryId);
                foreach (Artifact a in list)
                {
                    artifact.Items.Add(a.ArtifactName);
                    _artifacts.Add(a);
                }
            }

            _visibleArtifact = _artifacts;
        }

        private void Clean()
        {
            attributes.Items.Clear();
            category.Text = "";
            mycategory.Text = "";
        }

        private void ClearAll()
        {
            attributes.Items.Clear();
            category.Items.Clear();
            mycategory.Items.Clear();
            artifact.Items.Clear();
            if (_artifacts != null) _artifacts.Clear();
            if (_userCategories != null) _userCategories.Clear();
        }
    }
}