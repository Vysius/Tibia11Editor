using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SevenZip.Compression.LZMA;

namespace Tibia11Editor
{

    public partial class MainForm : Form
    {

        Loader tibiaLoader;

        public MainForm()
        {
            InitializeComponent();
            
        }


        private void loadFromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String path = String.Empty;
            //Open dialog -> move to form.
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                if (path.EndsWith("\\") == false) path = path + "\\";
            }

            tibiaLoader = new Loader();
            tibiaLoader.load(path);
            updateLabels();
        }

        private void updateLabels() {
            totalElements.Text = tibiaLoader.appearances.CalculateSize().ToString();
            totalEffects.Text = tibiaLoader.appearances.Effect.Count.ToString();
            totalObjects.Text = tibiaLoader.appearances.Object.Count.ToString();
            totalMissiles.Text = tibiaLoader.appearances.Missile.Count.ToString();
            totalOutfits.Text = tibiaLoader.appearances.Outfit.Count.ToString();
            totalSprites.Text = tibiaLoader.sprites.Count.ToString();

        }
    }
}
