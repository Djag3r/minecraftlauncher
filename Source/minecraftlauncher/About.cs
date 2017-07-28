//===== Syntax, 2017 =====\\

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace minecraftlauncher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        { this.Close(); }

        #region Перемещение мышью
        Point last;

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) last = MousePosition;
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
            if (e.Button == MouseButtons.Left) last = MousePosition;
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
        #endregion

        private void vk_Click(object sender, EventArgs e)
        { Process.Start(@"http://vk.com/syntaxproject"); }

        private void windows_Click(object sender, EventArgs e)
        {
            OSInfo osinfo = new OSInfo();
            osinfo.ShowDialog();
        }

        private void email_Click(object sender, EventArgs e)
        { Process.Start(@"mailto:syntax.offmail@gmail.com"); /*Отправка письма на электронную почту через протокол MAILTO:*/ }

        private void About_Load(object sender, EventArgs e)
        {
            version.Text = "0.8";
            build.Text = "8D08";
            logo.Select();
        }
    }
}
