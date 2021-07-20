using System;
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Management.Instrumentation;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace Indicator
{
    public partial class Program : Form
    {
        static string versionNumber = "2.0";
        static string settingsPath  = "config.cfg";

        static char settingsDelimiter = ':';
        static char settingsComment   = '#';

        static Dictionary<string, string> settings = new Dictionary<string, string>();

        static int maxHdd = 26;

        // Icons
        static IconThread   capsIcon    ;
        static IconThread   numIcon     ;
        static IconThread   scrollIcon  ;
        static IconThread   totalHddIcon;
        static IconThread[] hddIcons = new IconThread[maxHdd];

        // Context menu items
        static MenuItem infoButton    ;
        static MenuItem settingsButton;
        static MenuItem quitButton    ;

        // Forms
        static InfoForm     infoForm    ;
        static SettingsForm settingsForm;

        // Context menu
        static ContextMenu contextMenu;

        private static void Main(string[] args)
        {
            // Enable form styles
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loadSettings();

            // Initiate forms
            infoForm     = new InfoForm(versionNumber);
            settingsForm = new SettingsForm(settings);

            // Initiate icons and context menu items
            initiateIconThreads();
            initiateContextMenu();

            // Run the program
            Application.Run();
        }
        
        private static void loadSettings()
        {
            bool invalid = false;

            // Read settings from file
            try {
                using (StreamReader sr = new StreamReader(settingsPath)) {
                    string line;

                    while ((line = sr.ReadLine()) != null) {
                        if (line != "" && line[0] != settingsComment) {
                            string[] parts = line.Split(settingsDelimiter);

                            string key = parts[0].Trim();
                            string value = parts[1].Trim();

                            if (isValidSetting(key, value)) {
                                settings.Add(key, value);
                            } else {
                                invalid = true;
                            }
                        }
                    }

                    sr.Close();
                }
            } catch (Exception e) {
                settings.Clear();
                loadDefaultSettings();
            }

            if (invalid) {
                settings.Clear();
                loadDefaultSettings();
            }
        }

        private static bool isValidSetting(string key, string value)
        {
            string[] validBooleanKeys = { "displayCapsLock", "displayNumLock", "displayScrollLock", "displayTotalHdd", "useCustomCapsLock", "useCustomNumLock", "useCustomScrollLock", "useCustomTotalHdd" };
            string[] validBooleanValues = { "true", "false" };

            string[] validStringKeys = { "customCapsLockOffPath", "customCapsLockOnPath", "customNumLockOffPath", "customNumLockOnPath", "customScrollLockOffPath", "customScrollLockOnPath", "customTotalHddOffPath", "customTotalHddOnPath" };

            string[] validIntKeys = { "capsLockRefreshTime", "numLockRefreshTime", "scrollLockRefreshTime", "totalHddRefreshTime" };

            if (validBooleanKeys.Contains(key) && validBooleanValues.Contains(value.ToLower())) { return true; }
            if (validStringKeys.Contains(key)) { return true; }
            if (validIntKeys.Contains(key) && Int32.Parse(value) >= 1 && Int32.Parse(value) <= 10000) { return true; }

            return false;
        }

        private static void loadDefaultSettings()
        {
            settings.Add("displayCapsLock"  , "true");
            settings.Add("displayNumLock"   , "true");
            settings.Add("displayScrollLock", "true");
            settings.Add("displayTotalHdd"  , "true");

            settings.Add("useCustomCapsLock"  , "false");
            settings.Add("useCustomNumLock"   , "false");
            settings.Add("useCustomScrollLock", "false");
            settings.Add("useCustomTotalHdd"  , "false");

            settings.Add("customCapsLockOffPath"  , ""); settings.Add("customCapsLockOnPath"  , "");
            settings.Add("customNumLockOffPath"   , ""); settings.Add("customNumLockOnPath"   , "");
            settings.Add("customScrollLockOffPath", ""); settings.Add("customScrollLockOnPath", "");
            settings.Add("customTotalHddOffPath"  , ""); settings.Add("customTotalHddOnPath"  , "");

            settings.Add("capsLockRefreshTime"  , "100");
            settings.Add("numLockRefreshTime"   , "100");
            settings.Add("scrollLockRefreshTime", "100");
            settings.Add("totalHddRefreshTime"  , "100");
        }

        public static void saveSettings(Dictionary<string, string> newSettings)
        {
            settings = newSettings;

            // Update everything
            capsIcon    .setIconVisible(bool.Parse(settings["displayCapsLock"  ]));
            numIcon     .setIconVisible(bool.Parse(settings["displayNumLock"   ]));
            scrollIcon  .setIconVisible(bool.Parse(settings["displayScrollLock"]));
            totalHddIcon.setIconVisible(bool.Parse(settings["displayTotalHdd"  ]));
            
            capsIcon    .setUseCustom(bool.Parse(settings["useCustomCapsLock"  ]));
            numIcon     .setUseCustom(bool.Parse(settings["useCustomNumLock"   ]));
            scrollIcon  .setUseCustom(bool.Parse(settings["useCustomScrollLock"]));
            totalHddIcon.setUseCustom(bool.Parse(settings["useCustomTotalHdd"  ]));
            
            capsIcon    .setCustomOffIcon(settings["customCapsLockOffPath"  ]); capsIcon    .setCustomOnIcon(settings["customCapsLockOnPath"  ]);
            numIcon     .setCustomOffIcon(settings["customNumLockOffPath"   ]); numIcon     .setCustomOnIcon(settings["customNumLockOnPath"   ]);
            scrollIcon  .setCustomOffIcon(settings["customScrollLockOffPath"]); scrollIcon  .setCustomOnIcon(settings["customScrollLockOnPath"]);
            totalHddIcon.setCustomOffIcon(settings["customTotalHddOffPath"  ]); totalHddIcon.setCustomOnIcon(settings["customTotalHddOnPath"  ]);
            
            capsIcon    .setPollTime(Int32.Parse(settings["capsLockRefreshTime"  ]));
            numIcon     .setPollTime(Int32.Parse(settings["numLockRefreshTime"   ]));
            scrollIcon  .setPollTime(Int32.Parse(settings["scrollLockRefreshTime"]));
            totalHddIcon.setPollTime(Int32.Parse(settings["totalHddRefreshTime"  ]));

            // Write settings to file
            using (StreamWriter sw = new StreamWriter(settingsPath)) {
                foreach(KeyValuePair<string, string> item in settings) {
                    sw.WriteLine($"{item.Key.PadRight(23)} {settingsDelimiter} {item.Value}");

                    if (lastInBlock(item.Key)) {
                        sw.WriteLine();
                    }
                }

                sw.Close();
            }
        }

        private static bool lastInBlock(string key)
        {
            string[] last = { "displayTotalHdd", "useCustomTotalHdd", "customTotalHddOnPath"};

            if (last.Contains(key)) {
                return true;
            }

            return false;
        }

        // Initiate icons
        private static void initiateIconThreads()
        {
            //                            visible                                    off icon                         on icon                         use custom                                   custom off path                      custom on path                      poll time                                       type     param
            capsIcon     = new IconThread(bool.Parse(settings["displayCapsLock"  ]), Properties.Resources.Caps_Off  , Properties.Resources.Caps_On  , bool.Parse(settings["useCustomCapsLock"  ]), settings["customCapsLockOffPath"  ], settings["customCapsLockOnPath"  ], Int32.Parse(settings["capsLockRefreshTime"  ]), "lock" , "caps"  );
            numIcon      = new IconThread(bool.Parse(settings["displayNumLock"   ]), Properties.Resources.Num_Off   , Properties.Resources.Num_On   , bool.Parse(settings["useCustomNumLock"   ]), settings["customNumLockOffPath"   ], settings["customNumLockOnPath"   ], Int32.Parse(settings["numLockRefreshTime"   ]), "lock" , "num"   );
            scrollIcon   = new IconThread(bool.Parse(settings["displayScrollLock"]), Properties.Resources.Scroll_Off, Properties.Resources.Scroll_On, bool.Parse(settings["useCustomScrollLock"]), settings["customScrollLockOffPath"], settings["customScrollLockOnPath"], Int32.Parse(settings["scrollLockRefreshTime"]), "lock" , "scroll");
            totalHddIcon = new IconThread(bool.Parse(settings["displayTotalHdd"  ]), Properties.Resources.HDD_Off   , Properties.Resources.HDD_On   , bool.Parse(settings["useCustomTotalHdd"  ]), settings["customTotalHddOffPath"  ], settings["customTotalHddOnPath"  ], Int32.Parse(settings["totalHddRefreshTime"  ]), "drive", "total" );
            
            //for (int i = 0; i < hddIcons.Length; i++) {
            //    hddIcons[i] = new IconThread(false, "images/ico/hddOff2.ico", "images/ico/hddOn2.ico", 100);
            //}
        }

        // Initiate context menu
        private static void initiateContextMenu()
        {
            // Create menu items
            infoButton     = new MenuItem($"Indicator v{versionNumber} by Ben Hawthorn", infoButtonClick    );
            settingsButton = new MenuItem("Settings"                                   , settingsButtonClick);
            quitButton     = new MenuItem("Quit"                                       , quitButtonClick    );

            contextMenu = new ContextMenu();

            // Add menu items to the context menu
            contextMenu.MenuItems.Add(infoButton    );
            contextMenu.MenuItems.Add(settingsButton);
            contextMenu.MenuItems.Add(quitButton    );

            // Add the context menu to the icons
            capsIcon    .addContextMenu(contextMenu);
            numIcon     .addContextMenu(contextMenu);
            scrollIcon  .addContextMenu(contextMenu);
            totalHddIcon.addContextMenu(contextMenu);
            
            //for (int i = 0; i < hddIcons.Length; i++) {
            //    hddIcons[i].addContextMenu(contextMenu);
            //}
        }

        // Context menu item clicks
        private static void infoButtonClick    (object sender, System.EventArgs e) { showInfo();     }
        private static void settingsButtonClick(object sender, System.EventArgs e) { showSettings(); }
        private static void quitButtonClick    (object sender, System.EventArgs e) { quit();         }

        // Show info form
        private static void showInfo()
        {
            infoForm.ShowDialog();
        }

        // Show settings form
        private static void showSettings()
        {
            settingsForm.ShowDialog();
        }

        // Quit the program
        private static void quit()
        {
            // Destroy all icons
            destroyAllIcons();

            // Exit the program
            Environment.Exit(0);
        }

        // Destroy all icons
        private static void destroyAllIcons() {
            capsIcon    .destroyIcon();
            numIcon     .destroyIcon();
            scrollIcon  .destroyIcon();
            totalHddIcon.destroyIcon();

            //for (int i = 0; i < hddIcons.Length; i++) {
            //    hddIcons[i].destroyIcon();
            //}
        }
    }
}
