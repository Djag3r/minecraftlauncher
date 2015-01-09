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
using System.Diagnostics;

namespace gfn_mc_launcher
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
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

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OSInfo osinfo = new OSInfo();
            osinfo.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://vk.com/gamefun_vk"); //Открывается страница группы в браузере по умолчанию
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Process.Start(@"http://vk.com/write?email=gamefun.offmail@gmail.com"); //Открывается страница сайта в браузере по умолчанию
            Process.Start(@"mailto:gamefun.offmail@gmail.com"); //Отправка письма на электронную почту через протокол MAILTO:
        }
    }
}