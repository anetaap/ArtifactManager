using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ArtifactManager.DataBase.Context;
using ArtifactManager.DataBase.Model;

namespace ArtifactManager.Forms
{
    public partial class FrontPage : Form
    {
        private SignIn _signIn;
        private SignUp _signUp;
        private Catalog _catalog;

        private List<Artifact> _artifacts;
        private Dictionary<string, string> _characters;
        public FrontPage()
        {
            InitializeComponent();
            InitWall();
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Hide();
            _signUp = new SignUp(this, _signIn);
            _signUp.Show();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            Hide();
            _signIn = new SignIn(this);
            _signIn.Show();
        }

        private void counter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (counter.SelectedIndex != -1)
            {
                int index = counter.SelectedIndex;
                int n = int.Parse(counter.Items[index].ToString());
                lastest.Items.Clear();
                if (_artifacts.Count < n) {n = _artifacts.Count;}
                for(int i = 0; i < n; i++)
                {
                    lastest.Items.Add(_artifacts[i].ArtifactName);
                }
            }
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            Hide();
            _catalog = new Catalog(this);
            // _catalog.InitWall();
            _catalog.Show();
        }

        public void InitWall()
        {
            if (_artifacts != null) _artifacts.Clear();
            if (_characters != null) _characters.Clear();
            lastest.Items.Clear();
            top.Items.Clear();

            _characters = MyDbContextFunctions.GetAllCharacters();
            var ordered = _characters.
                OrderByDescending(x => int.Parse(x.Value)).ToDictionary(x => x.Key, 
                    x => int.Parse(x.Value));
            _artifacts = MyDbContextFunctions.GetAllArtifactsDesc();

            int[] nums = {1, 5, 10, 15};
            foreach (int num in nums)
            {
                counter.Items.Add(num);
            }
            int a = 0;
            if (ordered.Count < 5) {a = ordered.Count;}
            else { a = 5; }

            foreach (var character in ordered)
            {
                if (a == 0 ) break;
                string inf = $"Character name: {character.Key}, power value: {character.Value}";
                top.Items.Add(inf);
                a--;
            }

            int n = 0;
            if (_artifacts.Count < 5) {n = _artifacts.Count;}
            else { n = 5; }
            for(int i = 0; i < n; i++)
            {
                lastest.Items.Add(_artifacts[i].ArtifactName);
            }
        }
    }
}