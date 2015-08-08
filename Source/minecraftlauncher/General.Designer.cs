namespace minecraftlauncher
{
    partial class General
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.connect = new System.Windows.Forms.Button();
            this.nick_box = new System.Windows.Forms.TextBox();
            this.remember_me = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Button();
            this.download_bar = new System.Windows.Forms.ProgressBar();
            this.password_box = new System.Windows.Forms.TextBox();
            this.site = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.information = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.updatelabel = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.singleplayer = new System.Windows.Forms.Button();
            this.nick = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.PictureBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.icon_box = new System.Windows.Forms.PictureBox();
            this.toplabel = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.connect, "connect");
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Name = "connect";
            this.tooltip.SetToolTip(this.connect, resources.GetString("connect.ToolTip"));
            this.connect.UseVisualStyleBackColor = false;
            this.connect.Click += new System.EventHandler(this.Start_Click);
            // 
            // nick_box
            // 
            resources.ApplyResources(this.nick_box, "nick_box");
            this.nick_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nick_box.Name = "nick_box";
            // 
            // remember_me
            // 
            resources.ApplyResources(this.remember_me, "remember_me");
            this.remember_me.BackColor = System.Drawing.Color.Transparent;
            this.remember_me.ForeColor = System.Drawing.Color.White;
            this.remember_me.Name = "remember_me";
            this.tooltip.SetToolTip(this.remember_me, resources.GetString("remember_me.ToolTip"));
            this.remember_me.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.update, "update");
            this.update.ForeColor = System.Drawing.Color.White;
            this.update.Name = "update";
            this.tooltip.SetToolTip(this.update, resources.GetString("update.ToolTip"));
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.Upd_Click);
            // 
            // download_bar
            // 
            resources.ApplyResources(this.download_bar, "download_bar");
            this.download_bar.Name = "download_bar";
            this.tooltip.SetToolTip(this.download_bar, resources.GetString("download_bar.ToolTip"));
            // 
            // password_box
            // 
            this.password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.password_box, "password_box");
            this.password_box.Name = "password_box";
            this.password_box.UseSystemPasswordChar = true;
            // 
            // site
            // 
            this.site.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.site, "site");
            this.site.ForeColor = System.Drawing.Color.White;
            this.site.Name = "site";
            this.tooltip.SetToolTip(this.site, resources.GetString("site.ToolTip"));
            this.site.UseVisualStyleBackColor = false;
            this.site.Click += new System.EventHandler(this.Site_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.information, "information");
            this.information.ForeColor = System.Drawing.Color.White;
            this.information.Name = "information";
            this.tooltip.SetToolTip(this.information, resources.GetString("information.ToolTip"));
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.About_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.updatelabel);
            this.panel.Controls.Add(this.datelabel);
            this.panel.Controls.Add(this.singleplayer);
            this.panel.Controls.Add(this.nick);
            this.panel.Controls.Add(this.information);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.update);
            this.panel.Controls.Add(this.download_bar);
            this.panel.Controls.Add(this.connect);
            this.panel.Controls.Add(this.site);
            this.panel.Controls.Add(this.remember_me);
            this.panel.Controls.Add(this.nick_box);
            this.panel.Controls.Add(this.password_box);
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // updatelabel
            // 
            resources.ApplyResources(this.updatelabel, "updatelabel");
            this.updatelabel.ForeColor = System.Drawing.Color.White;
            this.updatelabel.Name = "updatelabel";
            // 
            // datelabel
            // 
            resources.ApplyResources(this.datelabel, "datelabel");
            this.datelabel.ForeColor = System.Drawing.Color.White;
            this.datelabel.Name = "datelabel";
            this.tooltip.SetToolTip(this.datelabel, resources.GetString("datelabel.ToolTip"));
            // 
            // singleplayer
            // 
            this.singleplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.singleplayer, "singleplayer");
            this.singleplayer.ForeColor = System.Drawing.Color.White;
            this.singleplayer.Name = "singleplayer";
            this.tooltip.SetToolTip(this.singleplayer, resources.GetString("singleplayer.ToolTip"));
            this.singleplayer.UseVisualStyleBackColor = false;
            this.singleplayer.Click += new System.EventHandler(this.SinglePlayer_Click);
            // 
            // nick
            // 
            this.nick.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.nick, "nick");
            this.nick.Name = "nick";
            this.nick.TabStop = false;
            this.tooltip.SetToolTip(this.nick, resources.GetString("nick.ToolTip"));
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.TabStop = false;
            this.tooltip.SetToolTip(this.password, resources.GetString("password.ToolTip"));
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toppanel.Controls.Add(this.icon_box);
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Controls.Add(this.minimize);
            this.toppanel.Controls.Add(this.exit);
            resources.ApplyResources(this.toppanel, "toppanel");
            this.toppanel.Name = "toppanel";
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            // 
            // icon_box
            // 
            resources.ApplyResources(this.icon_box, "icon_box");
            this.icon_box.Name = "icon_box";
            this.icon_box.TabStop = false;
            this.icon_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.icon_box_MouseDown);
            this.icon_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icon_box_MouseMove);
            // 
            // toplabel
            // 
            resources.ApplyResources(this.toplabel, "toplabel");
            this.toplabel.ForeColor = System.Drawing.Color.White;
            this.toplabel.Name = "toplabel";
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseMove);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.minimize, "minimize");
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Name = "minimize";
            this.tooltip.SetToolTip(this.minimize, resources.GetString("minimize.ToolTip"));
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Name = "exit";
            this.tooltip.SetToolTip(this.exit, resources.GetString("exit.ToolTip"));
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // General
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.generalform;
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.General_FormClosing);
            this.Load += new System.EventHandler(this.General_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button site;
        private System.Windows.Forms.PictureBox nick;
        private System.Windows.Forms.PictureBox password;
        private System.Windows.Forms.ProgressBar download_bar;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox remember_me;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button singleplayer;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label toplabel;
        private System.Windows.Forms.PictureBox icon_box;
        public System.Windows.Forms.TextBox nick_box;
        public System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Label updatelabel;
    }
}

