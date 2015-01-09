  //==============================\\
 //==== 2011-2014, GameFuN ========\\
//==================================\\

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Web;
using gfn_mc_launcher.Properties;

namespace gfn_mc_launcher
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            List<string> Servers = new List<string>();
            //int count;
        }

        public void Start_Click(object sender, EventArgs e)
        {
            //string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            //ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw", "-Xms1G -Xmx1G -cp \"" + appData + "\\.minecraft\\bin\\minecraft.jar;" + appData + "\\.minecraft\\bin\\jinput.jar;" + appData + "\\.minecraft\\bin\\lwjgl.jar;" + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\"" + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft" + " " + textBox1.Text);
            //Process.Start(mcStartInfo);
            Listening list = new Listening();   //Переходим в форму выбора сервера
            list.ShowDialog();
            //if(isset($_POST['submit_button_id']))
            //{
                //if($_POST['login_field_id'] == "SomeLogin" && $_POST['password_field_id'] == "SomePassword")
                //{
                //}
                //else
                //{
                //echo "Access Denied";
                //}
            //}
        }

        private void Site_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://gamefuns.ru");
        }

        private void General_Load(object sender, EventArgs e)
        {
            remember_me.Checked = true;
            nick.Text = Properties.Settings.Default.textBox1;
            password.Text = Properties.Settings.Default.textBox2; //Загружаем наши данные
            DateTime date1 = DateTime.Today;
            label2.Text = date1.ToString("dd.MM.yyyy");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Upd_Click(object sender, EventArgs e)
        {
            //progressBar1.Visible = true;
            updatelabel.Visible = true;
            /*label4.Visible = true;
            label3.Text = Upd.EachFileUpdMD5("");
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            timer1.Start();
            Upd.EachFileUpdMD5("");*/
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+5);
            if (progressBar1.Value == 100)
            {
                progressBar1.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                timer1.Stop();
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                Updating upd = new Updating();
                upd.ShowDialog();
            }
        }*/

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (remember_me.Checked == true)
            {
                Properties.Settings.Default.textBox1 = nick.Text;
                Properties.Settings.Default.textBox2 = password.Text;
                Properties.Settings.Default.Save(); //Сохраняем наши данные
            }
            else
            {
                Application.Exit();
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Версия вашей игры ниже или равна 1.5.2?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw", "-Xms1G -Xmx1G -cp \"" + appData + "\\.minecraft\\bin\\minecraft.jar;" + appData + "\\.minecraft\\bin\\jinput.jar;" + appData + "\\.minecraft\\bin\\lwjgl.jar;" + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\"" + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft" + " " + nick.Text);
                Process.Start(mcStartInfo);
                Application.Exit();
            }
            else 
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string Directory = ".minecraft";
                ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw.exe", "-Xincgc -Xms1G -Xmx1G" +
                " -Djava.library.path=\"" +
                appData + "\\" + Directory + "\\versions\\1.7.10\\natives\"" + " -cp \"" +
                appData + "\\" + Directory + "\\libraries\\java3d\\vecmath\\1.3.1\\vecmath-1.3.1.jar;" +
                appData + "\\" + Directory + "\\libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;" +
                appData + "\\" + Directory + "\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\4.5\\jopt-simple-4.5.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" +
                appData + "\\" + Directory + "\\libraries\\io\\netty\\netty-all\\4.0.10.Final\\netty-all-4.0.10.Final.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\google\\guava\\guava\\15.0\\guava-15.0.jar;" +
                appData + "\\" + Directory + "\\libraries\\org\\apache\\commons\\commons-lang3\\3.1\\commons-lang3-3.1.jar;" +
                appData + "\\" + Directory + "\\libraries\\commons-io\\commons-io\\2.4\\commons-io-2.4.jar;" +
                appData + "\\" + Directory + "\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" +
                appData + "\\" + Directory + "\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\google\\code\\gson\\gson\\2.2.4\\gson-2.2.4.jar;" +
                appData + "\\" + Directory + "\\libraries\\com\\mojang\\authlib\\1.3\\authlib-1.3.jar;" +
                appData + "\\" + Directory + "\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.0-beta9\\log4j-api-2.0-beta9.jar;" +
                appData + "\\" + Directory + "\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.0-beta9\\log4j-core-2.0-beta9.jar;" +
                appData + "\\" + Directory + "\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.1-nightly-20131120\\lwjgl-2.9.1-nightly-20131120.jar;" +
                appData + "\\" + Directory + "\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.1-nightly-20131120\\lwjgl_util-2.9.1-nightly-20131120.jar;" +
                appData + "\\" + Directory + " \\libraries\\tv\\twitch\\twitch\\5.12\\twitch-5.12.jar;" +
                appData + "\\" + Directory + "\\versions\\1.7.10\\1.7.10.jar\" " +
                "net.minecraft.client.main.Main " +
                "--username " + nick.Text + " --version 1.7.10 --gameDir " +
                appData + "\\" + Directory + " --assetsDir " +
                appData + "\\" + Directory + "\\assets --assetIndex 1.7.3 --uuid 123 --accessToken  123 --userProperties {} --userType legacy");
                Process.Start(mcStartInfo);
                Application.Exit();
            }
        }

        Point last;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
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
