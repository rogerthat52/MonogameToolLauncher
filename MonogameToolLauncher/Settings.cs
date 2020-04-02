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
    public partial class Settings : Form
    {
        Main mainForm;

        public Settings(Main main)
        {
            InitializeComponent();
            mainForm = main;
            PopulateFields();
        }

        private void PopulateFields()
        {
            tbTiled.Text = getLocation("Tiled");
            tbInky.Text = getLocation("Inky");
            tbAseprite.Text = getLocation("Aseprite");
        }

        private string getLocation(string app)
        {
            if (mainForm.exeLocations.ContainsKey(app))
            {
                mainForm.exeLocations.TryGetValue(app, out string value);
                return value;
            } else
            {
                return "";
            }
        }

        private void btnTiledBrowse_Click(object sender, EventArgs e)
        {
            tbTiled.Text = Browse("Tiled");
        }

        private void btnInkyBrowse_Click(object sender, EventArgs e)
        {
            tbInky.Text = Browse("Inky");
        }

        private void btnAsespriteBrowse_Click(object sender, EventArgs e)
        {
            tbAseprite.Text = Browse("Aseprite");
        }

        private string Browse(string app)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            dialog.Title = "Select " + app + " Executable";
            dialog.DefaultExt = "exe";
            return dialog.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            mainForm.exeLocations = new Dictionary<string, string>()
            {
                ["Tiled"] = tbTiled.Text,
                ["Inky"] = tbInky.Text,
                ["Aseprite"] = tbAseprite.Text
            };
            File.WriteAllText(mainForm.settingsFile, JsonConvert.SerializeObject(mainForm.exeLocations));
            this.Close();
        }
    }
}
