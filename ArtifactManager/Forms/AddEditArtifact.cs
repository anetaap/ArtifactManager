using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ArtifactManager.Classes;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class AddEditArtifact : Form
    {
        private FrontPage _frontPage;
        private Catalog _catalog;
        private Validations _validations;
        private Artifact _artifact;
        private UserCategory _userCategory;
        
        private int _artifactId;
        private int _elementId;
        private int _categoryId;
        private bool _mode;

        private List<UserArtifactAttribute> _artifactAttributes;
        private List<ElementAttribute> _elementAttributes;
        private List<Element> _elements;
        private List<int> _elementIds;
        private Dictionary<int, string> _newAttributes;
        public AddEditArtifact(FrontPage frontPage, Catalog catalog, Validations validations, Artifact artifact)
        {
            _frontPage = frontPage;
            _catalog = catalog;
            _validations = validations;
            _artifact = artifact;
            InitializeComponent();
        }
        public AddEditArtifact(FrontPage frontPage, Catalog catalog, Validations validations, UserCategory userCategory)
        {
            _frontPage = frontPage;
            _catalog = catalog;
            _validations = validations;
            _userCategory = userCategory;
            _elementIds = new List<int>();
            _newAttributes = new Dictionary<int, string>();
            InitializeComponent();
        }
        private void AddEditArtifact_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            _elementAttributes = new List<ElementAttribute>();
            List <ElementAttribute> elementAttributes = MyDbContextFunctions.GetAllElementAttributes();
            

            if (_userCategory != null)
            {
                _mode = true;
                title.Text = @"Add Artifact Attributes";
                save.Text = @"Add Attribute";
                discard.Text = @"Add Artifact";
                _categoryId = _userCategory.CategoryId;
                _elements = MyDbContextFunctions.GetCategoryElements(_categoryId); // all elements
                foreach (var element in _elements)
                {
                    elements.Items.Add(element.ElementName);
                    _elementIds.Add(element.ElementId);
                }
            }
            else
            {
                _mode = false;
                title.Text = @"Edit Artifact Attributes";
                label1.Visible = false;
                elements.Visible = false;
                namelabel.Visible = false;
                name.Visible = false;
                _elementId = _artifact.ElementId;
                _artifactId = _artifact.ArtifactId;
                List<UserArtifactAttribute> artifactAttributes = MyDbContextFunctions.GetAllArtifactAttributes();
                _artifactAttributes = new List<UserArtifactAttribute>();
                foreach (var attribute in elementAttributes)
                {
                    if (attribute.ElementId == _elementId)
                    {
                        _elementAttributes.Add(attribute);
                        attributes.Items.Add(attribute.ElementAttributeName);
                    }
                }
                foreach (var attribute in artifactAttributes)
                {
                    if (attribute.ArtifactId == _artifactId) { _artifactAttributes.Add(attribute); }
                }
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            Hide();
            _catalog.Show();
            Clean();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            _frontPage.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_mode)
            {
                // add 
                string element = elements.Text;
                string attribute = attributes.Text;
                string attributeType = attrType.Text;
                string attributeValue = value.Text;
                string[] informations = {element, attribute, attributeValue};
                if (!_validations.CompletenessValidation(informations))
                    MessageBox.Show(@"Enter all required data!");
                
                if (attributeType == "int")
                {
                    if (!_validations.TypeIntParse(attributeValue))
                    {
                        MessageBox.Show(@"Enter int value!");
                        return;
                    }
                }
                int index = attributes.SelectedIndex;
                int elementAttributeId = _elementAttributes[index].ElementAttributeId;
                _newAttributes[elementAttributeId] = attributeValue;
            }
            else
            {
                // edit 
                string attribute = attributes.Text;
                string attributeType = attrType.Text;
                string attributeValue = value.Text;
                string[] informations = {attribute, attributeValue};
                if (!_validations.CompletenessValidation(informations))
                    MessageBox.Show(@"Enter all required data!");

                if (attributeType == "int")
                {
                    if (!_validations.TypeIntParse(attributeValue))
                    {
                        MessageBox.Show(@"Enter int value!");
                        return;
                    }
                }
                int index = attributes.SelectedIndex;
                int elementAttributeId = _elementAttributes[index].ElementAttributeId;
                int artifactAttributeId = -1;
                foreach (var artifactAttribute in _artifactAttributes)
                {
                    if (artifactAttribute.ElementAttributeId == elementAttributeId)
                        artifactAttributeId = artifactAttribute.UserArtifactAttributeId;
                }
                MyDbContextFunctions.UpdateArtifactAttributes(artifactAttributeId, attributeValue);
            }
        }

        private void attributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attributes.SelectedIndex != -1)
            {
                int index = attributes.SelectedIndex;
                string aType = _elementAttributes[index].ElementAttributeType;
                attrType.Text = aType;
            }
        }

        private void Clean()
        {
            attributes.Text = "";
            attrType.Text = "";
            value.Text = "";
        }

        private void elements_SelectedIndexChanged(object sender, EventArgs e)
        {
            List <ElementAttribute> elementAttributes = MyDbContextFunctions.GetAllElementAttributes();

            int index = elements.SelectedIndex;
            _elementId = _elements[index].ElementId;
            foreach (var attribute in elementAttributes)
            {
                if (attribute.ElementId == _elementId)
                {
                    _elementAttributes.Add(attribute);
                    attributes.Items.Add(attribute.ElementAttributeName);
                }
            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            string artifactName = name.Text;
            if (artifactName == "")
            {
                MessageBox.Show(@"Enter Artifact name!");
                return;
            }
            int artifactId = MyDbContextFunctions.AddArtifact(artifactName, _categoryId, _elementId);
            foreach (KeyValuePair<int,string> newAttribute in _newAttributes)
            {
                int elementAttributeId = newAttribute.Key;
                string value = newAttribute.Value;
                
                MyDbContextFunctions.AddArtifactAttribute(artifactId, elementAttributeId, value);
            }

            MessageBox.Show(@"Category successfully added.");
        }
    }
}