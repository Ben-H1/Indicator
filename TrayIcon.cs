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
    class TrayIcon
    {
        public NotifyIcon icon;
        Icon onIcon;
        Icon offIcon;
        Thread worker;

        public TrayIcon(string offIconPath, string onIconPath)
        {
            icon = new NotifyIcon();
            offIcon = new Icon(offIconPath);
            onIcon = new Icon(onIconPath);
        }
    }
}
