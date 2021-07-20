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
    class IconThread
    {
        public NotifyIcon trayIcon;

        private Icon offIcon;
        private Icon onIcon;
        private bool useCustom;
        private Icon customOffIcon;
        private Icon customOnIcon;
        private bool invalidOffIcon;
        private bool invalidOnIcon;

        private Thread worker;

        private int pollTime;
        private string type;
        private string param;

        public IconThread(bool visible, Icon off, Icon on, bool useCustom, string customOffPath, string customOnPath, int pollTime, string type, string param)
        {
            // Create the icon, make it visible
            trayIcon = new NotifyIcon();
            trayIcon.Visible = visible;

            // Set the off and on icons
            offIcon = new Icon(off, new Size(16, 16));
            onIcon  = new Icon(on , new Size(16, 16));

            // Set custom icons
            this.useCustom = useCustom;
            setCustomOffIcon(customOffPath);
            setCustomOnIcon (customOnPath );

            // Set the current icon
            if (useCustom) {
                if (!invalidOffIcon) {
                    trayIcon.Icon = customOffIcon;
                }
            } else {
                trayIcon.Icon = offIcon;
            }

            // Set the poll time, type and param
            this.pollTime = pollTime;
            this.type     = type;
            this.param    = param;

            setUpThread();

            // Start the thread if the icon is visible
            if (visible) {
                startThread();
            }
        }

        // Add a context menu to the icon
        public void addContextMenu(ContextMenu contextMenu)
        {
            trayIcon.ContextMenu = contextMenu;
        }

        // Make the icon visible
        public void setIconVisible(bool visible)
        {
            trayIcon.Visible = visible;

            // Start the thread if the icon is visible, abort the thread otherwise
            if (visible) {
                startThread();
            } else {
                suspendThread();
            }
        }

        public void setUseCustom(bool custom)
        {
            useCustom = custom;
        }

        // Set the custom off icon
        public void setCustomOffIcon(string path)
        {
            if (path != "") {
                invalidOffIcon = false;

                try {
                    customOffIcon = new Icon(new Icon(path), new Size(16, 16));
                } catch (Exception e) {
                    invalidOffIcon = true;
                }
            } else {
                invalidOffIcon = true;
            }
        }

        // Set the custom on icon
        public void setCustomOnIcon(string path)
        {
            if (path != "") {
                invalidOnIcon = false;

                try {
                    customOnIcon = new Icon(new Icon(path), new Size(16, 16));
                } catch (Exception e) {
                    invalidOnIcon = true;
                }
            } else {
                invalidOnIcon = true;
            }
        }

        // Set the poll time
        public void setPollTime(int time)
        {
            pollTime = time;
        }

        private void setUpThread()
        {
            switch (type) {
                case "lock":
                    switch (param) {
                        case "caps":
                            startLockThread(Keys.CapsLock);
                            break;
                        case "num":
                            startLockThread(Keys.NumLock);
                            break;
                        case "scroll":
                            startLockThread(Keys.Scroll);
                            break;
                    }
                    break;
                case "drive":
                    switch (param) {
                        case "total":
                            startDriveThread("_Total");
                            break;
                        case "d":
                            startDriveThread("D:");
                            break;
                    }
                    break;
            }
        }

        // Start the thread depending on the type
        private void startThread()
        {
            if (!worker.IsAlive) {
                worker.Start();
            }
        }

        // Start a lock thread
        private void startLockThread(Keys key)
        {
            worker = new Thread(() => lockThread(key));
        }

        // Start a drive thread
        private void startDriveThread(string driveLetter)
        {
            worker = new Thread(() => driveThread(driveLetter));
        }

        // Suspend the thread
        private void suspendThread()
        {
            if (!(worker == null) || worker.IsAlive) {
                try {
                    worker.Suspend();
                } catch (Exception e) {}
            }
        }

        // Destroy the icon
        public void destroyIcon()
        {
            setIconVisible(false);
            trayIcon.Dispose();
        }

        // Lock thread
        public void lockThread(Keys key)
        {
            try {
                while (true) {
                    if (!Control.IsKeyLocked(key)) {
                        if (useCustom) {
                            if (!invalidOffIcon) {
                                trayIcon.Icon = customOffIcon;
                            } else {
                                trayIcon.Icon = offIcon;
                            }
                        } else {
                            trayIcon.Icon = offIcon;
                        }
                    } else {
                        if (useCustom) {
                            if (!invalidOnIcon) {
                                trayIcon.Icon = customOnIcon;
                            } else {
                                trayIcon.Icon = onIcon;
                            }
                        } else {
                            trayIcon.Icon = onIcon;
                        }
                    }

                    Thread.Sleep(pollTime);
                }
            } catch (Exception e) {

            }
        }

        // Drive thread
        public void driveThread(string driveLetter)
        {
            ManagementClass driveDataClass = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk");

            try {
                while (true) {
                    ManagementObjectCollection driveDataClassCollection = driveDataClass.GetInstances();

                    foreach (ManagementObject obj in driveDataClassCollection) {

                        String name = obj["Name"].ToString();
                        //MessageBox.Show(name, "c", MessageBoxButtons.OK);

                        if (name.Contains(driveLetter)) {
                            UInt64 bytesPerSec = Convert.ToUInt64(obj["DiskBytesPersec"]);

                            if (bytesPerSec > 0) {
                                if (useCustom) {
                                    if (!invalidOnIcon) {
                                        trayIcon.Icon = customOnIcon;
                                    } else {
                                        trayIcon.Icon = onIcon;
                                    }
                                } else {
                                    trayIcon.Icon = onIcon;
                                }
                            } else {
                                if (useCustom) {
                                    if (!invalidOffIcon) {
                                        trayIcon.Icon = customOffIcon;
                                    } else {
                                        trayIcon.Icon = offIcon;
                                    }
                                } else {
                                    trayIcon.Icon = offIcon;
                                }
                            }
                        }
                    }

                    Thread.Sleep(pollTime);
                }
            } catch (Exception e) {

            }
        }
    }
}