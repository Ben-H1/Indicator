using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indicator
{
    public partial class InfoForm : Form
    {
        private string versionNumber;

        private string link = "https://www.github.com/Ben-H1";

        public InfoForm(string versionNumber)
        {
            this.versionNumber = versionNumber;

            InitializeComponent();
            setContent();
        }

        private void setContent()
        {
            titleLabel.Text = $"Indicator v{versionNumber} by Ben Hawthorn";

            //this.Text = $"Indicator";
            //descriptionLabel.Text = "";
            //linkLabel.Text = "";
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
