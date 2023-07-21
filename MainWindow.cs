using System.Reflection;
using System.Diagnostics;

using MetroTextures.Metro;

namespace MetroTextures
{
    public partial class MainWindow : Form
    {
        protected string _texturesFolderPath = string.Empty;
        protected string _lastConfigPath = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChooseTextureButton_Click(object sender, EventArgs e) => GetTexturesByFolderDialog();

        public void GetTexturesByFolderDialog()
        {
            using (TextureFolderDialog)
            {
                TextureFolderDialog.ShowDialog();

                if (string.IsNullOrEmpty(TextureFolderDialog.SelectedPath))
                {
                    MessageBox.Show("You Should Select Folder With Textures Files", "You Don't Selected Texture Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                _texturesFolderPath = TextureFolderDialog.SelectedPath;

                UpdateFilesTree(MPaths.GetTexturePaths(_texturesFolderPath));
            }
        }

        public void UpdateFilesTree(List<string> files)
        {
            Tree.Nodes.Clear();

            foreach (string file in files)
            {
                TreeNode? sepPrev = null;

                string fileMetro = file.Substring(file.IndexOf("textures"));
                string[] sepps = fileMetro.Split("\\");

                for (int i = 0; i < sepps.Length; i++)
                {
                    string sep = sepps[i];
                    var nodes = sepPrev == null ? Tree.Nodes : sepPrev.Nodes;

                    if (!nodes.ContainsKey(sep)) sepPrev = nodes.Add(sep, sep);
                    else
                    {
                        sepPrev = nodes[nodes.IndexOfKey(sep)];
                    }
                }
            }
        }

        public GroupBox CreatePropUI(FieldInfo prop, TextureConfigSDK conf)
        {
            var box = new GroupBox();
            box.Text = prop.Name;
            box.Dock = DockStyle.Top;
            box.Padding = new Padding(8);
            box.ForeColor = Color.WhiteSmoke;

            var pan = new Panel();
            pan.Dock = DockStyle.Fill;
            pan.BorderStyle = BorderStyle.None;

            box.Controls.Add(pan);

            var field = new TextBox();
            field.Dock = DockStyle.Fill;
            field.BackColor = Color.Black;
            field.ForeColor = Color.WhiteSmoke;
            field.BorderStyle = BorderStyle.FixedSingle;

            pan.Controls.Add(field);

            if (prop.FieldType == typeof(bool))
            {
                field.Text = ((bool?)prop.GetValue(conf)).ToString();
            }

            if (prop.FieldType == typeof(int))
            {
                field.Text = ((int?)prop.GetValue(conf)).ToString();
            }

            if (prop.FieldType == typeof(float))
            {
                field.Text = ((float?)prop.GetValue(conf)).ToString();
            }

            if (prop.FieldType == typeof(string))
            {
                field.Text = (string?)prop.GetValue(conf);
            }

            if (prop.FieldType == typeof(int[]))
            {
                int[]? arr = (int[]?)prop.GetValue(conf);

                if (arr != null)
                {
                    foreach (int i in arr) field.Text += $"{i}; ";
                }
            }

            if (prop.FieldType == typeof(float[]))
            {
                float[]? arr = (float[]?)prop.GetValue(conf);

                if (arr != null)
                {
                    foreach (float i in arr) field.Text += $"{i}; ";
                }
            }

            box.Height = field.Height * 3;
            field.Text = field.Text?.Trim(' ', '\t', ';');

            return box;
        }

        public void UpdatePropsUIByConfig(TextureConfigSDK config)
        {
            ParamsList.Controls.Clear();

            foreach (FieldInfo field in config.GetType().GetFields()) ParamsList.Controls.Add(CreatePropUI(field, config));
        }

        public TextureConfigSDK? GetConfigFromSelectedNode()
        {
            if (string.IsNullOrEmpty(_texturesFolderPath)) return null;

            if (Tree.SelectedNode == null || !Tree.SelectedNode.Name.Contains(".lua")) return null;

            var luaName = Tree.SelectedNode.FullPath.Replace("textures", "").Trim(' ', '\\');

            _lastConfigPath = $"{_texturesFolderPath}\\{luaName}";

            return MConfig.ReadTextureConfigFromLua(_lastConfigPath);
        }

        public bool SaveConfigFromUI()
        {
            if (string.IsNullOrEmpty(_lastConfigPath)) return false;

            object config = new TextureConfigSDK();

            foreach (Control c in ParamsList.Controls)
            {
                var box = (GroupBox)c;
                var field = config.GetType().GetField(box.Text);
                
                if (field != null)
                {
                    var tb = (TextBox)c.Controls[0].Controls[0];

                    if (field.FieldType == typeof(int)) field.SetValue(config, int.Parse(tb.Text.Trim()));

                    if (field.FieldType == typeof(bool)) field.SetValue(config, bool.Parse(tb.Text.Trim()));

                    if (field.FieldType == typeof(float)) field.SetValue(config, float.Parse(tb.Text.Trim()));

                    if (field.FieldType == typeof(string)) field.SetValue(config, tb.Text.Trim());

                    if (field.FieldType == typeof(int[]))
                    {
                        var sc = tb.Text.Split(";");
                        var arr = new int[sc.Length];

                        for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(sc[i].Trim());

                        field.SetValue(config, arr);
                    }

                    if (field.FieldType == typeof(float[]))
                    {
                        var sc = tb.Text.Split(";");
                        var arr = new float[sc.Length];

                        for (int i = 0; i < arr.Length; i++) arr[i] = float.Parse(sc[i].Trim());

                        field.SetValue(config, arr);
                    }
                }
            }

            return MConfig.WriteLuaConfig(_lastConfigPath, (TextureConfigSDK) config);
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var config = GetConfigFromSelectedNode();

            if (!config.HasValue) return;

            UpdatePropsUIByConfig(config.Value);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var r = SaveConfigFromUI();

            if (r) 
                MessageBox.Show($"Config Finally Created By Path: '{_lastConfigPath}'", "Config Finally Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else 
                MessageBox.Show("Config Doesn't Create...", "Config Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ImportTextureButton_Click(object sender, EventArgs e)
        {
            using (TextureFileDialog)
            {
                var dr = TextureFileDialog.ShowDialog();

                if (dr == DialogResult.OK) _lastConfigPath = TextureFileDialog.FileName;
                else
                {
                    MessageBox.Show("You don't select texture file...", "Texture Select Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            using (TextureFolderDialog)
            {
                var dr = TextureFolderDialog.ShowDialog();

                if (dr == DialogResult.OK) _texturesFolderPath = TextureFolderDialog.SelectedPath;
                else
                {
                    MessageBox.Show("You don't select texture folder for save...", "Texture Folder Select Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            if (DDSUtils.MakeConfigForDDS(_lastConfigPath, _texturesFolderPath))
                MessageBox.Show("Texture File Created By Path", "Good Result!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("NOT Texture File Created By Path", "Bad Result!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}