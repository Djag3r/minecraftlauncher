//===== GameFuN, 2011-2015 =====\\

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Management;
using System.Net.NetworkInformation;
using System.Convert;

namespace minecraftlauncher
{
    public partial class OSInfo : Form
    {
        public OSInfo()
        {
            InitializeComponent();
        }

        ManagementObjectSearcher videosearcher =
        new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
        ManagementObjectSearcher processorsearcher =
        new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
        ManagementObjectSearcher memorysearcher =
        new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * From Win32_ComputerSystem");
        ManagementObjectSearcher hddsearcher =
        new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");
        ManagementObjectSearcher mbsearcher =
        new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * From Win32_BaseBoard");

        private string GetOSName()
        {
            OperatingSystem os = Environment.OSVersion;
            string osName = "Unknown";


            switch (os.Platform)
            {
                case PlatformID.Win32Windows:
                    switch (os.Version.Minor)
                    {
                        case 0:
                            osName = "Windows 95";
                            break;
                        case 10:
                            osName = "Windows 98";
                            break;
                        case 90:
                            osName = "Windows ME";
                            break;
                    }
                    break;
                case PlatformID.Win32NT:
                    switch (os.Version.Major)
                    {
                        case 3:
                            osName = "Windws NT 3.51";
                            break;
                        case 4:
                            osName = "Windows NT 4";
                            break;
                        case 5:
                            if (os.Version.Minor == 0)
                                osName = "Windows 2000";
                            else if (os.Version.Minor == 1)
                                osName = "Windows XP";
                            else if (os.Version.Minor == 2)
                                osName = "Windows Server 2003";
                            break;
                        case 6:
                            if (os.Version.Minor == 0)
                                osName = "Windows Vista";
                            else if (os.Version.Minor == 1)
                                osName = "Windows 7";
                            else if (os.Version.Minor == 2)
                                osName = "Windows 8";
                            break;
                        case 7:
                            if (os.Version.Minor == 0)
                                osName = "Windows 8.1";
                            break;

                    }
                    break;
            }

            return osName;
        }

        private void OSInfo_Load(object sender, EventArgs e)
        {
            os.Text = GetOSName();

            if (Environment.Is64BitOperatingSystem == true)
            {
                bit.Text = "64 bit";
            }
            else
            {
                bit.Text = "32 bit";
            }
            pcname.Text = Environment.MachineName.ToString();
            //System.Management.Instrumentation.
            double h = Screen.PrimaryScreen.Bounds.Width;
            double w = Screen.PrimaryScreen.Bounds.Height;
            resolution.Text = h+"x"+w;
            IPStatus status = IPStatus.Unknown;
            try 
            {
                status = new Ping().Send("google.com").Status;
            } 
            catch 
            {
                //lal
            }
 
            if (status == IPStatus.Success) 
            {
                internet.Text = "Connect";
            } 
            else 
            {
                internet.Text = "Disconnect";
            }

            foreach (ManagementObject queryObj in memorysearcher.Get())
            {
                double ramsize = ToDouble(queryObj["TotalPhysicalMemory"]);
                ramsize = Math.Round(ramsize / 1048576);
                ram.Text = ramsize.ToString() + " MB";
            }
            foreach (ManagementObject queryObj in videosearcher.Get())
            { gpu.Text = queryObj["Description"].ToString(); }
            foreach (ManagementObject queryObj in processorsearcher.Get())
            { cpu.Text = queryObj["Name"].ToString(); }
            foreach (ManagementObject queryObj in hddsearcher.Get())
            {
                hdd.Text = queryObj["Model"].ToString();
                hddsize.Text = Math.Round(ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2).ToString() + " GB";
            }
            foreach (ManagementObject queryObj in mbsearcher.Get())
            { mb.Text = queryObj["Manufacturer"].ToString() + ", " + queryObj["Product"].ToString(); }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point last;

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void toppanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }

        private void toplabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void toplabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point cur = MousePosition;
                int dx = cur.X - last.X;
                int dy = cur.Y - last.Y;
                Point loc = new Point(Location.X + dx, Location.Y + dy);
                Location = loc;
                last = cur;
            }
        }
    }
}
