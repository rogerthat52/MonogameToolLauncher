namespace RPG_Editor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTiledLaunch = new System.Windows.Forms.Button();
            this.btnInkyLaunch = new System.Windows.Forms.Button();
            this.btnAsepriteLaunch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(139, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // btnTiledLaunch
            // 
            this.btnTiledLaunch.Location = new System.Drawing.Point(12, 27);
            this.btnTiledLaunch.Name = "btnTiledLaunch";
            this.btnTiledLaunch.Size = new System.Drawing.Size(115, 23);
            this.btnTiledLaunch.TabIndex = 1;
            this.btnTiledLaunch.Text = "Launch Tiled";
            this.btnTiledLaunch.UseVisualStyleBackColor = true;
            this.btnTiledLaunch.Click += new System.EventHandler(this.btnLaunchTiled_Click);
            // 
            // btnInkyLaunch
            // 
            this.btnInkyLaunch.Location = new System.Drawing.Point(12, 56);
            this.btnInkyLaunch.Name = "btnInkyLaunch";
            this.btnInkyLaunch.Size = new System.Drawing.Size(115, 23);
            this.btnInkyLaunch.TabIndex = 2;
            this.btnInkyLaunch.Text = "Launch Inky";
            this.btnInkyLaunch.UseVisualStyleBackColor = true;
            this.btnInkyLaunch.Click += new System.EventHandler(this.btnLaunchInky_Click);
            // 
            // btnAsepriteLaunch
            // 
            this.btnAsepriteLaunch.Location = new System.Drawing.Point(12, 85);
            this.btnAsepriteLaunch.Name = "btnAsepriteLaunch";
            this.btnAsepriteLaunch.Size = new System.Drawing.Size(115, 23);
            this.btnAsepriteLaunch.TabIndex = 3;
            this.btnAsepriteLaunch.Text = "Launch Aseprite";
            this.btnAsepriteLaunch.UseVisualStyleBackColor = true;
            this.btnAsepriteLaunch.Click += new System.EventHandler(this.btnLaunchAseprite_Click);
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(139, 121);
            this.Controls.Add(this.btnAsepriteLaunch);
            this.Controls.Add(this.btnInkyLaunch);
            this.Controls.Add(this.btnTiledLaunch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLauncher";
            this.Text = "Editor Launcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnTiledLaunch;
        private System.Windows.Forms.Button btnInkyLaunch;
        private System.Windows.Forms.Button btnAsepriteLaunch;
    }
}

