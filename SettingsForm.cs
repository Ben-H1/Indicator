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
    public partial class SettingsForm : Form
    {
        public SettingsForm(Dictionary<string, string> settings)
        {
            InitializeComponent();

            loadSettings(settings);
        }

        private void loadSettings(Dictionary<string, string> settings)
        {
            capsLockIndicatorCheckBox  .Checked = bool.Parse(settings["displayCapsLock"  ]);
            numLockIndicatorCheckBox   .Checked = bool.Parse(settings["displayNumLock"   ]);
            scrollLockIndicatorCheckBox.Checked = bool.Parse(settings["displayScrollLock"]);
            totalHddIndicatorCheckBox  .Checked = bool.Parse(settings["displayTotalHdd"  ]);
            
            customCapsLockIconsCheckBox  .Checked = bool.Parse(settings["useCustomCapsLock"  ]); setCustomCapsLockIconsEnabled();
            customNumLockIconsCheckBox   .Checked = bool.Parse(settings["useCustomNumLock"   ]); setCustomNumLockIconsEnabled();
            customScrollLockIconsCheckBox.Checked = bool.Parse(settings["useCustomScrollLock"]); setCustomScrollLockIconsEnabled();
            customTotalHddIconsCheckBox  .Checked = bool.Parse(settings["useCustomTotalHdd"  ]); setCustomTotalHddIconsEnabled();
            
            customCapsLockOffIconPathBox  .Text = settings["customCapsLockOffPath"  ]; customCapsLockOnIconPathBox  .Text = settings["customCapsLockOnPath"  ];
            customNumLockOffIconPathBox   .Text = settings["customNumLockOffPath"   ]; customNumLockOnIconPathBox   .Text = settings["customNumLockOnPath"   ];
            customScrollLockOffIconPathBox.Text = settings["customScrollLockOffPath"]; customScrollLockOnIconPathBox.Text = settings["customScrollLockOnPath"];
            customTotalHddOffIconPathBox  .Text = settings["customTotalHddOffPath"  ]; customTotalHddOnIconPathBox  .Text = settings["customTotalHddOnPath"  ];

            capsLockRefreshTimeUpDown  .Value = limitToRange(Int32.Parse(settings["capsLockRefreshTime"  ]), (int) capsLockRefreshTimeUpDown  .Minimum, (int) capsLockRefreshTimeUpDown.Maximum  );
            numLockRefreshTimeUpDown   .Value = limitToRange(Int32.Parse(settings["numLockRefreshTime"   ]), (int) numLockRefreshTimeUpDown   .Minimum, (int) numLockRefreshTimeUpDown.Maximum   );
            scrollLockRefreshTimeUpDown.Value = limitToRange(Int32.Parse(settings["scrollLockRefreshTime"]), (int) scrollLockRefreshTimeUpDown.Minimum, (int) scrollLockRefreshTimeUpDown.Maximum);
            totalHddRefreshTimeUpDown  .Value = limitToRange(Int32.Parse(settings["totalHddRefreshTime"  ]), (int) totalHddRefreshTimeUpDown  .Minimum, (int) totalHddRefreshTimeUpDown.Maximum  );
        }

        private int limitToRange(int value, int min, int max)
        {
            if (value >= min) {
                if (value <= max) {
                    return value;
                }
                return max;
            }
            return min;
        }

        private void okButton_Click    (object sender, EventArgs e) { applySettings(); closeForm(); }
        private void cancelButton_Click(object sender, EventArgs e) {                  closeForm(); }
        private void applyButton_Click (object sender, EventArgs e) { applySettings();              }

        private void closeForm() { this.Close(); }

        private void applySettings()
        {
            Dictionary<string, string> newSettings = new Dictionary<string, string>();

            newSettings.Add("displayCapsLock"  , capsLockIndicatorCheckBox  .Checked.ToString());
            newSettings.Add("displayNumLock"   , numLockIndicatorCheckBox   .Checked.ToString());
            newSettings.Add("displayScrollLock", scrollLockIndicatorCheckBox.Checked.ToString());
            newSettings.Add("displayTotalHdd"  , totalHddIndicatorCheckBox  .Checked.ToString());

            newSettings.Add("useCustomCapsLock"  , customCapsLockIconsCheckBox  .Checked.ToString());
            newSettings.Add("useCustomNumLock"   , customNumLockIconsCheckBox   .Checked.ToString());
            newSettings.Add("useCustomScrollLock", customScrollLockIconsCheckBox.Checked.ToString());
            newSettings.Add("useCustomTotalHdd"  , customTotalHddIconsCheckBox  .Checked.ToString());

            newSettings.Add("customCapsLockOffPath"  , customCapsLockOffIconPathBox  .Text); newSettings.Add("customCapsLockOnPath"  , customCapsLockOnIconPathBox  .Text);
            newSettings.Add("customNumLockOffPath"   , customNumLockOffIconPathBox   .Text); newSettings.Add("customNumLockOnPath"   , customNumLockOnIconPathBox   .Text);
            newSettings.Add("customScrollLockOffPath", customScrollLockOffIconPathBox.Text); newSettings.Add("customScrollLockOnPath", customScrollLockOnIconPathBox.Text);
            newSettings.Add("customTotalHddOffPath"  , customTotalHddOffIconPathBox  .Text); newSettings.Add("customTotalHddOnPath"  , customTotalHddOnIconPathBox  .Text);

            newSettings.Add("capsLockRefreshTime"  , capsLockRefreshTimeUpDown  .Value.ToString());
            newSettings.Add("numLockRefreshTime"   , numLockRefreshTimeUpDown   .Value.ToString());
            newSettings.Add("scrollLockRefreshTime", scrollLockRefreshTimeUpDown.Value.ToString());
            newSettings.Add("totalHddRefreshTime"  , totalHddRefreshTimeUpDown  .Value.ToString());

            Program.saveSettings(newSettings);
        }

        #region Custom Caps Lock

        private void customCapsLockIconsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setCustomCapsLockIconsEnabled();
        }

        private void setCustomCapsLockIconsEnabled()
        {
            if (customCapsLockIconsCheckBox.Checked) {
                customCapsLockIconsPanel.Enabled = true;
            } else {
                customCapsLockIconsPanel.Enabled = false;
            }
        }

        private void customCapsLockOnIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void customCapsLockOffIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Custom Num Lock

        private void customNumLockIconsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setCustomNumLockIconsEnabled();
        }

        private void setCustomNumLockIconsEnabled()
        {
            if (customNumLockIconsCheckBox.Checked) {
                customNumLockIconsPanel.Enabled = true;
            } else {
                customNumLockIconsPanel.Enabled = false;
            }
        }

        private void customNumLockOnIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void customNumLockOffIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Custom Scroll Lock

        private void customScrollLockIconsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setCustomScrollLockIconsEnabled();
        }

        private void setCustomScrollLockIconsEnabled()
        {
            if (customScrollLockIconsCheckBox.Checked) {
                customScrollLockIconsPanel.Enabled = true;
            } else {
                customScrollLockIconsPanel.Enabled = false;
            }
        }

        private void customScrollLockOnIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void customScrollLockOffIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Custom Total HDD

        private void customTotalHddIconsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            setCustomTotalHddIconsEnabled();
        }

        private void setCustomTotalHddIconsEnabled()
        {
            if (customTotalHddIconsCheckBox.Checked) {
                customTotalHddIconsPanel.Enabled = true;
            } else {
                customTotalHddIconsPanel.Enabled = false;
            }
        }

        private void customTotalHddOnIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        private void customTotalHddOffIconBrowseButton_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
