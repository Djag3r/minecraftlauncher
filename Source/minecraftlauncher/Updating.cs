//===== Syntax, 2017 =====\\

using System;
using System.Drawing;
using System.Windows.Forms;

namespace minecraftlauncher
{
    public partial class Updating : Form
    {
        public Updating()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        { Application.Restart(); }

        private void no_Click(object sender, EventArgs e)
        { this.Close(); }

        #region Перемещение мышью
        Point last;

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
        #endregion
    }
}
