﻿using System;
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
        private List<UserCategory> _userCategories = new List<UserCategory>();
        private List<Element> _elements = new List<Element>();
        private List<int> _categoriesIds = new List<int>();
        private List<Artifact> _artifacts = new List<Artifact>();
        private List<UserArtifactAttribute> _artifactAttributes;

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
                _categoriesIds.Add(cat.CategoryId);
            }

            List<Element> elements;
            List<UserCategory> userCategories;
            userCategories = MyDbContextFunctions.GetUserCategories(_validations.UserId);
            foreach (var cat in userCategories)
            {
                mycategory.Items.Add(cat.CategoryName);
                _userCategories.Add(cat);
            }
            foreach (int id in _categoriesIds)
            {
                elements = MyDbContextFunctions.GetCategoryElements(id);
                foreach (Element element in elements)
                {
                    _elements.Add(element);
                }
            }

            _artifactAttributes = MyDbContextFunctions.GetAllArtifactAttributes();
            List<Artifact> list;
            foreach (UserCategory userCategory in _userCategories)
            {
                list = MyDbContextFunctions.GetCategoryArtifacts(userCategory.CategoryId);
                foreach (Artifact a in list)
                {
                    artifact.Items.Add(a.ArtifactName);
                    _artifacts.Add(a);
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
        
        private void edit_Click(object sender, EventArgs e)
        {
            if (artifact.CheckedItems.Count > 1)
            {
                MessageBox.Show(@"Choose only one artifact to edit.");
                return;
            }
            int index = -1;
            if (artifact.CheckedIndices.Count > 0) { index = artifact.CheckedIndices[0];}
            if (index != -1)
            {
                var artifact1 = _artifacts[index];
                _addEditArtifact = new AddEditArtifact(_frontPage, this, _validations, artifact1);
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
                    indexes.Add(_artifacts[index].ArtifactId);
                }

                foreach (int index in indexes)
                {
                    MyDbContextFunctions.RemoveArtifact(index);
                }
            }
        }

        // private void category_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     if (category.SelectedIndex != -1)
        //     {
        //         artifact.Items.Clear();
        //         int selectedIndex = category.SelectedIndex;
        //         int catId = _categories[selectedIndex].CategoryId;
        //
        //         List<Artifact> list;
        //         list = MyDbContextFunctions.GetCategoryArtifacts(catId);
        //         if (list != null)
        //         {
        //             foreach (Artifact a in list)
        //             {
        //                 artifact.Items.Add(a.ArtifactName);
        //             }
        //         }
        //     }
        // }
        //
        // private void mycategory_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     if (mycategory.SelectedIndex != -1)
        //     {
        //         artifact.Items.Clear();
        //         int selectedIndex = mycategory.SelectedIndex;
        //         int categoryId = _userCategories[selectedIndex].CategoryId;
        //         int userCategoryId = _userCategories[selectedIndex].UserCategoryId;
        //         
        //         List<Artifact> list;
        //         list = MyDbContextFunctions.GetCategoryArtifacts(categoryId);
        //         if (list != null)
        //         {
        //             foreach (Artifact a in list)
        //             {
        //                 if (a.UserCategoryId == userCategoryId)
        //                     artifact.Items.Add(a.ArtifactName);
        //             }
        //         }
        //     }
        // }
    }
}