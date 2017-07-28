//===== Syntax, 2017 =====\\

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

        public void Multiplayer_Click(object sender, EventArgs e)
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
            nick.Select();
        }

        private void Site_Click(object sender, EventArgs e)
        {
            //Process.Start(@"http://siteisdeveloping.com");
            nick.Select();
        }

        private void General_Load(object sender, EventArgs e)
        {
            remember_me.Checked = true;
            nick_box.Text = Settings.Default.nick;
            password_box.Text = Settings.Default.password; //Загружаем наши данные
            nick.Select();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            nick.Select();
        }

        private void update_Click(object sender, EventArgs e)
        {
            exit.Enabled = false;
            update.Enabled = false;
            download_bar.Visible = true;
            timer.Start();
            download_bar.Refresh();
            nick.Select();
        }

        private void General_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (remember_me.Checked == true)
            {
                Settings.Default.nick = nick_box.Text;
                Settings.Default.password = password_box.Text;
                Settings.Default.Save(); //Сохраняем наши данные
            }
            else Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
            nick.Select();
        }

        #region Запуск одиночной игры
        private void SinglePlayer_Click(object sender, EventArgs e)
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string mcPath = appData + "\\.minecraft";
            string javapath = "C:\\Program Files\\Java";
            string javapath64 = "C:\\Program Files (x86)\\Java";

            if (Environment.Is64BitOperatingSystem == true) javapath = javapath64; 

            if (Directory.Exists(mcPath) && Directory.Exists(javapath))
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
        #endregion

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

        private void icon_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) last = MousePosition;
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
        #endregion

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
