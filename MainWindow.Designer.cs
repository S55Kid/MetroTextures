namespace MetroTextures
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Docker = new System.Windows.Forms.Panel();
            this.PreviewDock = new System.Windows.Forms.Panel();
            this.ButtonsContainer = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ConfigBox = new System.Windows.Forms.GroupBox();
            this.ParamsList = new System.Windows.Forms.Panel();
            this.TreeDock = new System.Windows.Forms.Panel();
            this.ButtonsDock = new System.Windows.Forms.Panel();
            this.ImportTextureButton = new System.Windows.Forms.Button();
            this.ChooseTextureButton = new System.Windows.Forms.Button();
            this.Tree = new System.Windows.Forms.TreeView();
            this.TextureFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TextureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Docker.SuspendLayout();
            this.PreviewDock.SuspendLayout();
            this.ButtonsContainer.SuspendLayout();
            this.ConfigBox.SuspendLayout();
            this.TreeDock.SuspendLayout();
            this.ButtonsDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Docker
            // 
            this.Docker.Controls.Add(this.PreviewDock);
            this.Docker.Controls.Add(this.TreeDock);
            this.Docker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Docker.Location = new System.Drawing.Point(0, 0);
            this.Docker.Name = "Docker";
            this.Docker.Size = new System.Drawing.Size(784, 561);
            this.Docker.TabIndex = 0;
            // 
            // PreviewDock
            // 
            this.PreviewDock.Controls.Add(this.ButtonsContainer);
            this.PreviewDock.Controls.Add(this.ConfigBox);
            this.PreviewDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewDock.Location = new System.Drawing.Point(342, 0);
            this.PreviewDock.Name = "PreviewDock";
            this.PreviewDock.Padding = new System.Windows.Forms.Padding(16);
            this.PreviewDock.Size = new System.Drawing.Size(442, 561);
            this.PreviewDock.TabIndex = 1;
            // 
            // ButtonsContainer
            // 
            this.ButtonsContainer.Controls.Add(this.SaveButton);
            this.ButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsContainer.Location = new System.Drawing.Point(16, 491);
            this.ButtonsContainer.Name = "ButtonsContainer";
            this.ButtonsContainer.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.ButtonsContainer.Size = new System.Drawing.Size(410, 54);
            this.ButtonsContainer.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(0, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(410, 38);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save Config";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ConfigBox
            // 
            this.ConfigBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ConfigBox.Controls.Add(this.ParamsList);
            this.ConfigBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfigBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfigBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ConfigBox.Location = new System.Drawing.Point(16, 16);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Padding = new System.Windows.Forms.Padding(16);
            this.ConfigBox.Size = new System.Drawing.Size(410, 469);
            this.ConfigBox.TabIndex = 0;
            this.ConfigBox.TabStop = false;
            this.ConfigBox.Text = "Parameters";
            // 
            // ParamsList
            // 
            this.ParamsList.AutoScroll = true;
            this.ParamsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamsList.Location = new System.Drawing.Point(16, 34);
            this.ParamsList.Name = "ParamsList";
            this.ParamsList.Padding = new System.Windows.Forms.Padding(8);
            this.ParamsList.Size = new System.Drawing.Size(378, 419);
            this.ParamsList.TabIndex = 0;
            // 
            // TreeDock
            // 
            this.TreeDock.Controls.Add(this.ButtonsDock);
            this.TreeDock.Controls.Add(this.Tree);
            this.TreeDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeDock.Location = new System.Drawing.Point(0, 0);
            this.TreeDock.Name = "TreeDock";
            this.TreeDock.Padding = new System.Windows.Forms.Padding(16);
            this.TreeDock.Size = new System.Drawing.Size(342, 561);
            this.TreeDock.TabIndex = 0;
            // 
            // ButtonsDock
            // 
            this.ButtonsDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ButtonsDock.Controls.Add(this.ImportTextureButton);
            this.ButtonsDock.Controls.Add(this.ChooseTextureButton);
            this.ButtonsDock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsDock.Location = new System.Drawing.Point(16, 417);
            this.ButtonsDock.Name = "ButtonsDock";
            this.ButtonsDock.Padding = new System.Windows.Forms.Padding(16);
            this.ButtonsDock.Size = new System.Drawing.Size(310, 128);
            this.ButtonsDock.TabIndex = 1;
            // 
            // ImportTextureButton
            // 
            this.ImportTextureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ImportTextureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportTextureButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ImportTextureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportTextureButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ImportTextureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ImportTextureButton.Location = new System.Drawing.Point(16, 74);
            this.ImportTextureButton.Name = "ImportTextureButton";
            this.ImportTextureButton.Size = new System.Drawing.Size(278, 38);
            this.ImportTextureButton.TabIndex = 1;
            this.ImportTextureButton.Text = "Import Texture";
            this.ImportTextureButton.UseVisualStyleBackColor = false;
            this.ImportTextureButton.Click += new System.EventHandler(this.ImportTextureButton_Click);
            // 
            // ChooseTextureButton
            // 
            this.ChooseTextureButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ChooseTextureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseTextureButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChooseTextureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTextureButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseTextureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ChooseTextureButton.Location = new System.Drawing.Point(16, 16);
            this.ChooseTextureButton.Name = "ChooseTextureButton";
            this.ChooseTextureButton.Size = new System.Drawing.Size(278, 38);
            this.ChooseTextureButton.TabIndex = 0;
            this.ChooseTextureButton.Text = "Choose Textures Folder";
            this.ChooseTextureButton.UseVisualStyleBackColor = false;
            this.ChooseTextureButton.Click += new System.EventHandler(this.ChooseTextureButton_Click);
            // 
            // Tree
            // 
            this.Tree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Tree.Location = new System.Drawing.Point(16, 16);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(310, 529);
            this.Tree.TabIndex = 0;
            this.Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tree_AfterSelect);
            // 
            // TextureFolderDialog
            // 
            this.TextureFolderDialog.Description = "Choose Texture Folder";
            this.TextureFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.TextureFolderDialog.UseDescriptionForTitle = true;
            // 
            // TextureFileDialog
            // 
            this.TextureFileDialog.FileName = "Texture File";
            this.TextureFileDialog.Filter = "DDS Image|*.dds";
            this.TextureFileDialog.Title = "Select Texture File";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Docker);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metro SDK | Textures Editor";
            this.Docker.ResumeLayout(false);
            this.PreviewDock.ResumeLayout(false);
            this.ButtonsContainer.ResumeLayout(false);
            this.ConfigBox.ResumeLayout(false);
            this.TreeDock.ResumeLayout(false);
            this.ButtonsDock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Docker;
        private Panel TreeDock;
        private Panel PreviewDock;
        private TreeView Tree;
        private FolderBrowserDialog TextureFolderDialog;
        private Panel ButtonsDock;
        private Button ImportTextureButton;
        private Button ChooseTextureButton;
        private GroupBox ConfigBox;
        private Panel ParamsList;
        private Panel ButtonsContainer;
        private Button SaveButton;
        private OpenFileDialog TextureFileDialog;
    }
}