  //=============================\\
 //==== 2011-2014, GameFuN=========\\
//=================================\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace gfn_mc_launcher
{
    public partial class Listening : Form
    {
        public Listening()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            General gen = new General();
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Process.Start("javaw", "-Xms1G -Xmx1G -cp \"" + appData + "\\.minecraft\\bin\\minecraft.jar;" + appData + "\\.minecraft\\bin\\jinput.jar;" + appData + "\\.minecraft\\bin\\lwjgl.jar;" + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\"" + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft");
            Application.Exit();
            MessageBox.Show("Мы работаем над этим!", "Подключение");
            //progressBar1.Visible = true;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //progressBar1.Increment(+10);
            //if (progressBar1.Value == 100)
            //{
                //progressBar1.Visible = false;
                //timer1.Stop();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
