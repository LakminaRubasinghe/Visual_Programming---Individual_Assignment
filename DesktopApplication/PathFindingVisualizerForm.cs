using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class PathfindingVisualizerForm : Form
    {
        public PathfindingVisualizerForm()
        {
            InitializeComponent();
        }

        private void PathfindingVisualizerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenSettings_Click_1(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                settings.ShowDialog();
            }
        }
    }
}
