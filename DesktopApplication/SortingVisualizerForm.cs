using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class SortingVisualizerForm : Form
    {
        public SortingVisualizerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnOpenSettings_Click(object sender, EventArgs e)
        {
            using (SettingsForm settings = new SettingsForm())
            {
                settings.ShowDialog();
            }
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
