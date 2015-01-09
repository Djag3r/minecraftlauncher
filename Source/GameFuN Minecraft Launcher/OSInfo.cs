  //================================================================\\
 //==== Copyright © 2011-2014, GameFuN, All right reserved. =========\\
//====================================================================\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace gfn_mc_launcher
{
    public partial class OSInfo : Form
    {
        public OSInfo()
        {
            InitializeComponent();
        }

        private string GetOSName()
        {
            System.OperatingSystem os = System.Environment.OSVersion;
            string osName = "Unknown";


            switch (os.Platform)
            {
                case System.PlatformID.Win32Windows:
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
                case System.PlatformID.Win32NT:
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
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            label12.Text = ramCounter.NextValue() + " MB";
            label2.Text = GetOSName();
            label11.Text = System.Environment.ProcessorCount.ToString();
            if(System.Environment.ProcessorCount < 2)
            {
                label17.Text = "логическое ядро";
            }
            if(System.Environment.ProcessorCount == 2)
            {
                label17.Text = "логических ядра";
            }
            if (System.Environment.ProcessorCount == 3)
            {
                label17.Text = "логических ядра";
            }
            if (System.Environment.ProcessorCount == 4)
            {
                label17.Text = "логических ядра";
            }
            if(System.Environment.ProcessorCount > 2)
            {
                label17.Text = "логических ядер";
            }

            if (System.Environment.Is64BitOperatingSystem == true)
            {
                label15.Text = "64 bit";
            }
            else
            {
                label15.Text = "32 bit";
            }
            label16.Text = System.Environment.MachineName.ToString();
            //label11.Text = System.Management.Instrumentation.
            double h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            double w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            label18.Text = h+"x"+w;
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
                label19.Text = "Connect";
            } 
            else 
            {
                label19.Text = "Disconnect";
            }

            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point last;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
            if (progressBar1.Value == 1)
            {
                progressBar1.Refresh();
                OSInfo_Load(sender, e);
            }
        }
    }
}