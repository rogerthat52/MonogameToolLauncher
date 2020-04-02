namespace RPG_Editor
{
    partial class Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTiled = new System.Windows.Forms.Label();
            this.lblInky = new System.Windows.Forms.Label();
            this.lblAseprite = new System.Windows.Forms.Label();
            this.tbTiled = new System.Windows.Forms.TextBox();
            this.tbInky = new System.Windows.Forms.TextBox();
            this.tbAseprite = new System.Windows.Forms.TextBox();
            this.btnTiledBrowse = new System.Windows.Forms.Button();
            this.btnInkyBrowse = new System.Windows.Forms.Button();
            this.btnAsespriteBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(278, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTiled
            // 
            this.lblTiled.AutoSize = true;
            this.lblTiled.Location = new System.Drawing.Point(12, 15);
            this.lblTiled.Name = "lblTiled";
            this.lblTiled.Size = new System.Drawing.Size(30, 13);
            this.lblTiled.TabIndex = 1;
            this.lblTiled.Text = "Tiled";
            // 
            // lblInky
            // 
            this.lblInky.AutoSize = true;
            this.lblInky.Location = new System.Drawing.Point(12, 41);
            this.lblInky.Name = "lblInky";
            this.lblInky.Size = new System.Drawing.Size(27, 13);
            this.lblInky.TabIndex = 2;
            this.lblInky.Text = "Inky";
            // 
            // lblAseprite
            // 
            this.lblAseprite.AutoSize = true;
            this.lblAseprite.Location = new System.Drawing.Point(12, 66);
            this.lblAseprite.Name = "lblAseprite";
            this.lblAseprite.Size = new System.Drawing.Size(45, 13);
            this.lblAseprite.TabIndex = 3;
            this.lblAseprite.Text = "Aseprite";
            // 
            // tbTiled
            // 
            this.tbTiled.Location = new System.Drawing.Point(96, 12);
            this.tbTiled.Name = "tbTiled";
            this.tbTiled.Size = new System.Drawing.Size(204, 20);
            this.tbTiled.TabIndex = 4;
            // 
            // tbInky
            // 
            this.tbInky.Location = new System.Drawing.Point(96, 38);
            this.tbInky.Name = "tbInky";
            this.tbInky.Size = new System.Drawing.Size(204, 20);
            this.tbInky.TabIndex = 5;
            // 
            // tbAseprite
            // 
            this.tbAseprite.Location = new System.Drawing.Point(96, 64);
            this.tbAseprite.Name = "tbAseprite";
            this.tbAseprite.Size = new System.Drawing.Size(204, 20);
            this.tbAseprite.TabIndex = 6;
            // 
            // btnTiledBrowse
            // 
            this.btnTiledBrowse.Location = new System.Drawing.Point(306, 10);
            this.btnTiledBrowse.Name = "btnTiledBrowse";
            this.btnTiledBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnTiledBrowse.TabIndex = 7;
            this.btnTiledBrowse.Text = "Browse";
            this.btnTiledBrowse.UseVisualStyleBackColor = true;
            this.btnTiledBrowse.Click += new System.EventHandler(this.btnTiledBrowse_Click);
            // 
            // btnInkyBrowse
            // 
            this.btnInkyBrowse.Location = new System.Drawing.Point(306, 35);
            this.btnInkyBrowse.Name = "btnInkyBrowse";
            this.btnInkyBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnInkyBrowse.TabIndex = 8;
            this.btnInkyBrowse.Text = "Browse";
            this.btnInkyBrowse.UseVisualStyleBackColor = true;
            this.btnInkyBrowse.Click += new System.EventHandler(this.btnInkyBrowse_Click);
            // 
            // btnAsespriteBrowse
            // 
            this.btnAsespriteBrowse.Location = new System.Drawing.Point(306, 61);
            this.btnAsespriteBrowse.Name = "btnAsespriteBrowse";
            this.btnAsespriteBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnAsespriteBrowse.TabIndex = 9;
            this.btnAsespriteBrowse.Text = "Browse";
            this.btnAsespriteBrowse.UseVisualStyleBackColor = true;
            this.btnAsespriteBrowse.Click += new System.EventHandler(this.btnAsespriteBrowse_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 128);
            this.Controls.Add(this.btnAsespriteBrowse);
            this.Controls.Add(this.btnInkyBrowse);
            this.Controls.Add(this.btnTiledBrowse);
            this.Controls.Add(this.tbAseprite);
            this.Controls.Add(this.tbInky);
            this.Controls.Add(this.tbTiled);
            this.Controls.Add(this.lblAseprite);
            this.Controls.Add(this.lblInky);
            this.Controls.Add(this.lblTiled);
            this.Controls.Add(this.btnSave);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTiled;
        private System.Windows.Forms.Label lblInky;
        private System.Windows.Forms.Label lblAseprite;
        private System.Windows.Forms.TextBox tbTiled;
        private System.Windows.Forms.TextBox tbInky;
        private System.Windows.Forms.TextBox tbAseprite;
        private System.Windows.Forms.Button btnTiledBrowse;
        private System.Windows.Forms.Button btnInkyBrowse;
        private System.Windows.Forms.Button btnAsespriteBrowse;
    }
}