namespace minecraftlauncher
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.ok = new System.Windows.Forms.Button();
            this.copyleftlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            this.gamefun_box = new System.Windows.Forms.PictureBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.buildlabel = new System.Windows.Forms.Label();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.build = new System.Windows.Forms.Label();
            this.vk = new System.Windows.Forms.Button();
            this.windows = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamefun_box)).BeginInit();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(229, 117);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(79, 23);
            this.ok.TabIndex = 20;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // copyleftlabel
            // 
            this.copyleftlabel.AutoSize = true;
            this.copyleftlabel.BackColor = System.Drawing.Color.Transparent;
            this.copyleftlabel.ForeColor = System.Drawing.Color.White;
            this.copyleftlabel.Location = new System.Drawing.Point(7, 70);
            this.copyleftlabel.Name = "copyleftlabel";
            this.copyleftlabel.Size = new System.Drawing.Size(112, 13);
            this.copyleftlabel.TabIndex = 21;
            this.copyleftlabel.Text = "2011-2015, GameFuN";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.Transparent;
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(6, 31);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(127, 13);
            this.namelabel.TabIndex = 22;
            this.namelabel.Text = "Имя: Minecraft Launcher";
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.BackColor = System.Drawing.Color.Transparent;
            this.versionlabel.ForeColor = System.Drawing.Color.White;
            this.versionlabel.Location = new System.Drawing.Point(6, 44);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(47, 13);
            this.versionlabel.TabIndex = 23;
            this.versionlabel.Text = "Версия:";
            // 
            // gamefun_box
            // 
            this.gamefun_box.BackColor = System.Drawing.Color.Transparent;
            this.gamefun_box.Image = global::minecraftlauncher.Properties.Resources.gamefun;
            this.gamefun_box.Location = new System.Drawing.Point(229, 31);
            this.gamefun_box.Name = "gamefun_box";
            this.gamefun_box.Size = new System.Drawing.Size(79, 80);
            this.gamefun_box.TabIndex = 24;
            this.gamefun_box.TabStop = false;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(323, 18);
            this.toppanel.TabIndex = 25;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.toplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toplabel.ForeColor = System.Drawing.Color.White;
            this.toplabel.Location = new System.Drawing.Point(7, 0);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(84, 15);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "О программе";
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseMove);
            // 
            // buildlabel
            // 
            this.buildlabel.AutoSize = true;
            this.buildlabel.BackColor = System.Drawing.Color.Transparent;
            this.buildlabel.ForeColor = System.Drawing.Color.White;
            this.buildlabel.Location = new System.Drawing.Point(7, 57);
            this.buildlabel.Name = "buildlabel";
            this.buildlabel.Size = new System.Drawing.Size(71, 13);
            this.buildlabel.TabIndex = 26;
            this.buildlabel.Text = "Построение:";
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.BackColor = System.Drawing.Color.Transparent;
            this.build.ForeColor = System.Drawing.Color.White;
            this.build.Location = new System.Drawing.Point(74, 57);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(33, 13);
            this.build.TabIndex = 34;
            this.build.Text = "6D20";
            this.tooltip.SetToolTip(this.build, "Номер построения (только в DEBUG-релизах)");
            // 
            // vk
            // 
            this.vk.BackColor = System.Drawing.Color.Transparent;
            this.vk.BackgroundImage = global::minecraftlauncher.Properties.Resources.vk;
            this.vk.FlatAppearance.BorderSize = 0;
            this.vk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vk.Location = new System.Drawing.Point(9, 108);
            this.vk.Name = "vk";
            this.vk.Size = new System.Drawing.Size(32, 32);
            this.vk.TabIndex = 30;
            this.tooltip.SetToolTip(this.vk, "Открыть группу ВК");
            this.vk.UseVisualStyleBackColor = false;
            this.vk.Click += new System.EventHandler(this.vk_Click);
            // 
            // windows
            // 
            this.windows.BackColor = System.Drawing.Color.Transparent;
            this.windows.BackgroundImage = global::minecraftlauncher.Properties.Resources.windows;
            this.windows.FlatAppearance.BorderSize = 0;
            this.windows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windows.Location = new System.Drawing.Point(47, 108);
            this.windows.Name = "windows";
            this.windows.Size = new System.Drawing.Size(32, 32);
            this.windows.TabIndex = 31;
            this.tooltip.SetToolTip(this.windows, "Просмотрите информацию о вашей системе, нажав на этот значок");
            this.windows.UseVisualStyleBackColor = false;
            this.windows.Click += new System.EventHandler(this.windows_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.BackgroundImage = global::minecraftlauncher.Properties.Resources.e_mail;
            this.email.FlatAppearance.BorderSize = 0;
            this.email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email.Location = new System.Drawing.Point(85, 108);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 32);
            this.email.TabIndex = 32;
            this.tooltip.SetToolTip(this.email, "Отправить e-mail тех. поддержке");
            this.email.UseVisualStyleBackColor = false;
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(49, 44);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(22, 13);
            this.version.TabIndex = 33;
            this.version.Text = "0.6";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(323, 150);
            this.ControlBox = false;
            this.Controls.Add(this.build);
            this.Controls.Add(this.version);
            this.Controls.Add(this.email);
            this.Controls.Add(this.windows);
            this.Controls.Add(this.vk);
            this.Controls.Add(this.buildlabel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.gamefun_box);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.copyleftlabel);
            this.Controls.Add(this.ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.gamefun_box)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label copyleftlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label versionlabel;
        private System.Windows.Forms.PictureBox gamefun_box;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
        public System.Windows.Forms.Label buildlabel;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Button vk;
        private System.Windows.Forms.Button windows;
        private System.Windows.Forms.Button email;
        private System.Windows.Forms.Label version;
        public System.Windows.Forms.Label build;
    }
}