//===== GameFuN, 2011-2015 =====\\

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using minecraftlauncher.Properties;

namespace minecraftlauncher
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
            //Process.Start(@"http://siteisdeveloping.com");
        }

        private void General_Load(object sender, EventArgs e)
        {
            remember_me.Checked = true;
            nick_box.Text = Settings.Default.nick;
            password_box.Text = Settings.Default.password; //Загружаем наши данные
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void update_Click(object sender, EventArgs e)
        {
            exit.Enabled = false;
            update.Enabled = false;
            download_bar.Visible = true;
            timer.Start();
            download_bar.Refresh();
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (remember_me.Checked == true)
            {
                Settings.Default.nick = nick_box.Text;
                Settings.Default.password = password_box.Text;
                Settings.Default.Save(); //Сохраняем наши данные
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
                string mcPath = appData + "\\.minecraft";

                if (Directory.Exists(mcPath))
                {
                    ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw", "-Xms1G -Xmx1G -cp \""
                   + appData + "\\.minecraft\\bin\\minecraft.jar;"
                   + appData + "\\.minecraft\\bin\\jinput.jar;"
                   + appData + "\\.minecraft\\bin\\lwjgl.jar;"
                   + appData + "\\.minecraft\\bin\\lwjgl_util.jar \" -Djava.library.path=\""
                   + appData + "\\.minecraft\\bin\\natives\" net.minecraft.client.Minecraft"
                   + " "
                   + Settings.Default.nick);
                    Process.Start(mcStartInfo);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Minecraft Launcher не обнаружил или не смог запустить Minecraft! Пожалуйста, установите игру или проверьте ее наличие. " +
                    "Также, если вы используете х64-битную систему, убедитесь, что у вас установлены как х64-bit, так и х32-bit версии Java. " +
                    "В скором времени программа сама будет предлагать скачать и установить игру в таких ситуациях.", "Не удалось запустить Minecraft!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Скачивание с FTP: сервера настроенной версии Minecraft 1.5.2 от GameFuN             
                }
            }

            if (dr == DialogResult.No)
            {
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string mcPath = appData + "\\.minecraft";

                if (Directory.Exists(mcPath))
                {
                    ProcessStartInfo mcStartInfo = new ProcessStartInfo("javaw.exe", "-Xincgc -Xms1G -Xmx1G" +
                    " -Djava.library.path=\"" +
                    appData + "\\.minecraft\\versions\\1.7.10\\natives\"" + " -cp \"" +
                    appData + "\\.minecraft\\libraries\\java3d\\vecmath\\1.3.1\\vecmath-1.3.1.jar;" +
                    appData + "\\.minecraft\\libraries\\net\\sf\\trove4j\\trove4j\\3.0.3\\trove4j-3.0.3.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\ibm\\icu\\icu4j-core-mojang\\51.2\\icu4j-core-mojang-51.2.jar;" +
                    appData + "\\.minecraft\\libraries\\net\\sf\\jopt-simple\\jopt-simple\\4.5\\jopt-simple-4.5.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\paulscode\\codecjorbis\\20101023\\codecjorbis-20101023.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\paulscode\\codecwav\\20101023\\codecwav-20101023.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\paulscode\\libraryjavasound\\20101123\\libraryjavasound-20101123.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\paulscode\\librarylwjglopenal\\20100824\\librarylwjglopenal-20100824.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\paulscode\\soundsystem\\20120107\\soundsystem-20120107.jar;" +
                    appData + "\\.minecraft\\libraries\\io\\netty\\netty-all\\4.0.10.Final\\netty-all-4.0.10.Final.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\google\\guava\\guava\\15.0\\guava-15.0.jar;" +
                    appData + "\\.minecraft\\libraries\\org\\apache\\commons\\commons-lang3\\3.1\\commons-lang3-3.1.jar;" +
                    appData + "\\.minecraft\\libraries\\commons-io\\commons-io\\2.4\\commons-io-2.4.jar;" +
                    appData + "\\.minecraft\\libraries\\net\\java\\jinput\\jinput\\2.0.5\\jinput-2.0.5.jar;" +
                    appData + "\\.minecraft\\libraries\\net\\java\\jutils\\jutils\\1.0.0\\jutils-1.0.0.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\google\\code\\gson\\gson\\2.2.4\\gson-2.2.4.jar;" +
                    appData + "\\.minecraft\\libraries\\com\\mojang\\authlib\\1.3\\authlib-1.3.jar;" +
                    appData + "\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-api\\2.0-beta9\\log4j-api-2.0-beta9.jar;" +
                    appData + "\\.minecraft\\libraries\\org\\apache\\logging\\log4j\\log4j-core\\2.0-beta9\\log4j-core-2.0-beta9.jar;" +
                    appData + "\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl\\2.9.1-nightly-20131120\\lwjgl-2.9.1-nightly-20131120.jar;" +
                    appData + "\\.minecraft\\libraries\\org\\lwjgl\\lwjgl\\lwjgl_util\\2.9.1-nightly-20131120\\lwjgl_util-2.9.1-nightly-20131120.jar;" +
                    appData + "\\.minecraft\\libraries\\tv\\twitch\\twitch\\5.12\\twitch-5.12.jar;" +
                    appData + "\\.minecraft\\versions\\1.7.10\\1.7.10.jar\" " +
                    "net.minecraft.client.main.Main " +
                    "--username " + Settings.Default.nick + " --version 1.7.10 --gameDir " +
                    appData + "\\.minecraft --assetsDir " +
                    appData + "\\.minecraft\\assets --assetIndex 1.7.3 --uuid 123 --accessToken  123 --userProperties {} --userType legacy");
                    Process.Start(mcStartInfo);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Minecraft Launcher не обнаружил или не смог запустить Minecraft! Пожалуйста, установите игру или проверьте ее наличие. " +
                    "Также, если вы используете х64-битную систему, убедитесь, что у вас установлены как х64-bit, так и х32-bit версии Java. " +
                    "В скором времени программа сама будет предлагать скачать и установить игру в таких ситуациях.", "Не удалось запустить Minecraft!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Скачивание с FTP: сервера настроенной версии Minecraft выше, чем 1.5.2 от GameFuN
                }
            }
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

        private void icon_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                last = MousePosition;
            }
        }

        private void icon_box_MouseMove(object sender, MouseEventArgs e)
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

        private void timer_Tick(object sender, EventArgs e)
        {
            download_bar.Increment(+1);
            if (download_bar.Value == 100)
            {
                exit.Enabled = true;
                update.Enabled = true;
                updatelabel.Visible = true;
                timer.Stop();
                //Updating upd = new Updating();
                //upd.ShowDialog();
            }
        }
    }
}
