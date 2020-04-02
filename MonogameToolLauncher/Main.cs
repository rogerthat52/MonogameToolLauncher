using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Editor
{
    public partial class Main : Form
    {
        public string settingsFile = "settings.json";
        public Dictionary<string, string> exeLocations;

        public Main()
        {
            InitializeComponent();
            
            // attempt to load settings
            LoadFile(settingsFile);

            // if file isn't found or loads incorrectly
            if(exeLocations == null)
            {
                exeLocations = new Dictionary<string, string>();
            }
        }

        // loads settings into memory
        private void LoadFile(string file)
        {
            // if file doesn't exist, create one
            if (File.Exists(file))
            {
                exeLocations = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(file));
            }
        }

        private void LaunchApp(string app)
        {
            if (exeLocations.ContainsKey(app))
            {
                System.Diagnostics.Process.Start(exeLocations[app]);
            }
            else
            {
                MessageBox.Show("Error: Set EXE location under File -> Settings.");
            }
        }

        private void btnLaunchTiled_Click(object sender, EventArgs e)
        {
            LaunchApp("Tiled");
        }

        private void btnLaunchInky_Click(object sender, EventArgs e)
        {
            LaunchApp("Inky");
        }

        private void btnLaunchAseprite_Click(object sender, EventArgs e)
        {
            LaunchApp("Aseprite");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var launchForm = new Settings(this);
            launchForm.Show();
        }
    }
}
