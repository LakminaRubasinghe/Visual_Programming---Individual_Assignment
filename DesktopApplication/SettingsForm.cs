using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace DesktopApplication
{
    public partial class SettingsForm : Form
    {

        public int ArraySize;
        public int TimerInterval;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ArraySize = tkSize.Value;
            TimerInterval = (int)numSpeed.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ArraySize = tkSize.Value;
            TimerInterval = (int)numSpeed.Value;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
