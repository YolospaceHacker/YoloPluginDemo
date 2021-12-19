using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YoloPluginDemo
{
    public partial class YoloFormDemo : YoloPlugins.YoloFormBase
    {
        public YoloFormDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbLogs.Text = "Hello \n";
            rtbLogs.Text = GetMainForm().ConfigGetEntry("YoloSpaceHacker", "profile", "not found");
        }
    }
}
