//===== GameFuN, 2011-2015 =====\\

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace minecraftlauncher
{
    public partial class Listening : Form
    {
        public Listening()
        {
            InitializeComponent();
        }

        public void play_Click(object sender, EventArgs e)
        {
            checkbar.Visible = true;
            timer.Start();
            //General gen = new General();
            //string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //Process.Start("javaw", "-Xms1G -Xmx1G -cp \"" + appData + "\\.minecraft\\bin\\minecraft.jar;" + appData + "\\.minecraft\\bin\\jinput.jar;" + appData + "\\.minecraft\\bin\\lwjgl.jar;" + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\"" + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft");
            //Application.Exit();
            MessageBox.Show("Мы работаем над этим!", "Подключение");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            checkbar.Increment(+10);
            if (checkbar.Value == 100)
            {
                checkbar.Visible = false;
                timer.Stop();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
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
