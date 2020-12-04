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
        static string versionNumber = "1.01";
        static string settingsPath = "config.txt";

        static bool capsOn;
        static bool numOn;
        static bool scrollOn;
        static bool hddOn;
        static int waitTime;

        static NotifyIcon capsIcon;
        static NotifyIcon numIcon;
        static NotifyIcon scrollIcon;
        static NotifyIcon hddIcon;

        static Icon capsOffIcon;
        static Icon capsOnIcon;
        static Icon numOffIcon;
        static Icon numOnIcon;
        static Icon scrollOffIcon;
        static Icon scrollOnIcon;
        static Icon hddOffIcon;
        static Icon hddOnIcon;

        static MenuItem infoButton;
        static MenuItem capsCheckbox;
        static MenuItem numCheckbox;
        static MenuItem scrollCheckbox;
        static MenuItem hddCheckbox;
        static MenuItem quitButton;

        static Thread capsWorker;
        static Thread numWorker;
        static Thread scrollWorker;
        static Thread hddWorker;

        private static void Main(string[] args)
        {
            getSettings();

            //Create tray icons
            capsIcon   = new NotifyIcon();
            numIcon    = new NotifyIcon();
            scrollIcon = new NotifyIcon();
            hddIcon    = new NotifyIcon();

            //Get icon images
            capsOffIcon   = new Icon("images/ico/capsOff.ico");
            capsOnIcon    = new Icon("images/ico/capsOn.ico");
            numOffIcon    = new Icon("images/ico/numOff.ico");
            numOnIcon     = new Icon("images/ico/numOn.ico");
            scrollOffIcon = new Icon("images/ico/scrollOff2.ico");
            scrollOnIcon  = new Icon("images/ico/scrollOn2.ico");
            hddOffIcon    = new Icon("images/ico/hddOff2.ico");
            hddOnIcon     = new Icon("images/ico/hddOn2.ico");

            //Set icon images
            capsIcon.Icon   = capsOffIcon;
            numIcon.Icon    = numOffIcon;
            scrollIcon.Icon = scrollOffIcon;
            hddIcon.Icon    = hddOffIcon;

            //Create menu items
            infoButton     = new MenuItem("Indicator v" + versionNumber + " by Ben Hawthorn", infoButton_Click);
            capsCheckbox   = new MenuItem("Caps lock indicator",            capsCheckbox_Click);   capsCheckbox.Checked   = capsOn;
            numCheckbox    = new MenuItem("Num lock indicator",             numCheckbox_Click);    numCheckbox.Checked    = numOn;
            scrollCheckbox = new MenuItem("Scroll lock indicator",          scrollCheckbox_Click); scrollCheckbox.Checked = scrollOn;
            hddCheckbox    = new MenuItem("Hard drive activity indicator",  hddCheckbox_Click);    hddCheckbox.Checked    = hddOn;
            quitButton     = new MenuItem("Quit",                           quitButton_Click);

            //Add menu items to context menu
            ContextMenu contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(infoButton);
            contextMenu.MenuItems.Add(capsCheckbox);
            contextMenu.MenuItems.Add(numCheckbox);
            contextMenu.MenuItems.Add(scrollCheckbox);
            contextMenu.MenuItems.Add(hddCheckbox);
            contextMenu.MenuItems.Add(quitButton);

            //Add context menu to all icons
            capsIcon.ContextMenu   = contextMenu;
            numIcon.ContextMenu    = contextMenu;
            scrollIcon.ContextMenu = contextMenu;
            hddIcon.ContextMenu    = contextMenu;
            
            //Make icons visible based on settings
            capsIcon.Visible   = capsOn;
            numIcon.Visible    = numOn;
            scrollIcon.Visible = scrollOn;
            hddIcon.Visible    = hddOn;

            //Create threads
            capsWorker   = new Thread(() => LockThread(Keys.CapsLock, capsIcon, capsOffIcon, capsOnIcon));
            numWorker    = new Thread(() => LockThread(Keys.NumLock, numIcon, numOffIcon, numOnIcon));
            scrollWorker = new Thread(() => LockThread(Keys.Scroll, scrollIcon, scrollOffIcon, scrollOnIcon));
            hddWorker    = new Thread(() => DriveThread(hddIcon, hddOffIcon, hddOnIcon));

            //Start threads based on settings
            if (capsOn) {
                capsWorker.Start();
            } if (numOn) {
                numWorker.Start();
            } if (scrollOn) {
                scrollWorker.Start();
            } if (hddOn) {
                hddWorker.Start();
            }
            
            //Run the application
            Application.Run();
        }

        private static void getSettings()
        {
            //If settings file doesn't exist, create it
            if (!File.Exists(settingsPath)) {
                using (StreamWriter sw = File.CreateText(settingsPath)) {
                    sw.WriteLine("1");
                    sw.WriteLine("1");
                    sw.WriteLine("1");
                    sw.WriteLine("1");
                    sw.WriteLine("100");
                }
            }

            int[] settings = new int[5];

            using (StreamReader sr = File.OpenText(settingsPath)) {
                string line = "";
                int i = 0;
                while ((line = sr.ReadLine()) != null) {
                    settings[i] = Int32.Parse(line);
                    i++;
                }
            }

            capsOn   = Convert.ToBoolean(settings[0]);
            numOn    = Convert.ToBoolean(settings[1]);
            scrollOn = Convert.ToBoolean(settings[2]);
            hddOn    = Convert.ToBoolean(settings[3]);
            waitTime = settings[4];
        }

        private static void setSettings()
        {
            using (StreamWriter sw = File.CreateText(settingsPath)) {
                sw.WriteLine(capsCheckbox.Checked ? "1" : "0");
                sw.WriteLine(numCheckbox.Checked ? "1" : "0");
                sw.WriteLine(scrollCheckbox.Checked ? "1" : "0");
                sw.WriteLine(hddCheckbox.Checked ? "1" : "0");
                sw.WriteLine(waitTime);
            }
        }

        private static void infoButton_Click(object sender, System.EventArgs e)
        {
            //Show a message box
            MessageBox.Show("Indicator v" + versionNumber + " by Ben Hawthorn" + "\n\n" + "http://www.github.com/Ben-H1", "Indicator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void quitButton_Click(object sender, System.EventArgs e)
        {
            quit();
        }

        private static void quit()
        {
            //Abort any alive threads
            if (capsWorker.IsAlive) {
                capsWorker.Abort();
            } if (numWorker.IsAlive) {
                numWorker.Abort();
            } if (scrollWorker.IsAlive) {
                scrollWorker.Abort();
            } if (hddWorker.IsAlive) {
                hddWorker.Abort();
            }

            //Make all icons invisible
            capsIcon.Visible   = false;
            numIcon.Visible    = false;
            scrollIcon.Visible = false;
            hddIcon.Visible    = false;

            //Dispose of all icons
            capsIcon.Dispose();
            numIcon.Dispose();
            scrollIcon.Dispose();
            hddIcon.Dispose();

            //Exit the application
            Environment.Exit(0);
        }

        private static void doClick(MenuItem menuItem, NotifyIcon icon, Thread worker, string thread)
        {
            if (menuItem.Checked) { //If the item is checked
                menuItem.Checked = false; //Make it not checked
                icon.Visible = false; //Make the icon invisible
                worker.Abort(); //Abort the thread
                checkAll();
                setSettings();
            } else { //If not checked
                menuItem.Checked = true; //Make it checked
                icon.Visible = true; //Make the icon visible
                startThread(thread); //Start the thread
                setSettings();
            }
        }

        private static void checkAll()
        {
            if (!capsCheckbox.Checked && !numCheckbox.Checked && !scrollCheckbox.Checked && !hddCheckbox.Checked) { //If all menu items are not checked
                quit();
            }
        }

        private static void capsCheckbox_Click(object sender, System.EventArgs e)
        {
            doClick(capsCheckbox, capsIcon, capsWorker, "caps");
        }

        private static void numCheckbox_Click(object sender, System.EventArgs e)
        {
            doClick(numCheckbox, numIcon, numWorker, "num");
        }

        private static void scrollCheckbox_Click(object sender, System.EventArgs e)
        {
            doClick(scrollCheckbox, scrollIcon, scrollWorker, "scroll");
        }

        private static void hddCheckbox_Click(object sender, System.EventArgs e)
        {
            doClick(hddCheckbox, hddIcon, hddWorker, "hdd");
        }

        private static void startThread(string thread)
        {
            //Check which thread to start and start it
            switch (thread) {
                case "caps":
                    capsWorker = new Thread(() => LockThread(Keys.CapsLock, capsIcon, capsOffIcon, capsOnIcon));
                    capsWorker.Start();
                    break;

                case "num":
                    numWorker = new Thread(() => LockThread(Keys.NumLock, numIcon, numOffIcon, numOnIcon));
                    numWorker.Start();
                    break;

                case "scroll":
                    scrollWorker = new Thread(() => LockThread(Keys.Scroll, scrollIcon, scrollOffIcon, scrollOnIcon));
                    scrollWorker.Start();
                    break;

                case "hdd":
                    hddWorker = new Thread(() => DriveThread(hddIcon, hddOffIcon, hddOnIcon));
                    hddWorker.Start();
                    break;
            }
        }

        private static void updateSetting(string key, string value)
        {
            ConfigurationManager.AppSettings.Add(key, value); //Change the value of the key in the config file
        }

        private static void LockThread(Keys key, NotifyIcon icon, Icon offIcon, Icon onIcon)
        {
            try {
                while (true) {
                    //Change the icon based on the lock state
                    if (!Control.IsKeyLocked(key)) {
                        icon.Icon = offIcon;
                    } else {
                        icon.Icon = onIcon;
                    }

                    Thread.Sleep(waitTime); //Wait
                }
            } catch (ThreadAbortException tbe) {

            }
        }

        private static void DriveThread(NotifyIcon icon, Icon offIcon, Icon onIcon)
        {
            ManagementClass driveDataClass = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk");

            try {
                while (true) {
                    //Change the icon based on the hard drive activity
                    ManagementObjectCollection driveDataClassCollection = driveDataClass.GetInstances();
                    foreach (ManagementObject obj in driveDataClassCollection) {
                        if (obj["Name"].ToString() == "_Total") {
                            if (Convert.ToUInt64(obj["DiskBytesPersec"]) > 0) {
                                icon.Icon = onIcon;
                            } else {
                                icon.Icon = offIcon;
                            }
                        }
                    }

                    Thread.Sleep(waitTime); //Wait
                }
            } catch (ThreadAbortException tbe) {

            }
        }
    }
}
