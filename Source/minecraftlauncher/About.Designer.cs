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
            this.copyright_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.gamefun_box = new System.Windows.Forms.PictureBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.vk = new System.Windows.Forms.Button();
            this.osinfo = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Button();
            this.build = new System.Windows.Forms.Label();
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
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // copyright_label
            // 
            this.copyright_label.AutoSize = true;
            this.copyright_label.BackColor = System.Drawing.Color.Transparent;
            this.copyright_label.ForeColor = System.Drawing.Color.White;
            this.copyright_label.Location = new System.Drawing.Point(7, 70);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(112, 13);
            this.copyright_label.TabIndex = 21;
            this.copyright_label.Text = "2011-2015, GameFuN";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(6, 31);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(127, 13);
            this.name_label.TabIndex = 22;
            this.name_label.Text = "Имя: Minecraft Launcher";
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.BackColor = System.Drawing.Color.Transparent;
            this.version_label.ForeColor = System.Drawing.Color.White;
            this.version_label.Location = new System.Drawing.Point(6, 44);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(47, 13);
            this.version_label.TabIndex = 23;
            this.version_label.Text = "Версия:";
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
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Построение:";
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
            this.vk.UseVisualStyleBackColor = false;
            this.vk.Click += new System.EventHandler(this.button2_Click);
            // 
            // osinfo
            // 
            this.osinfo.BackColor = System.Drawing.Color.Transparent;
            this.osinfo.BackgroundImage = global::minecraftlauncher.Properties.Resources.windows;
            this.osinfo.FlatAppearance.BorderSize = 0;
            this.osinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.osinfo.Location = new System.Drawing.Point(47, 108);
            this.osinfo.Name = "osinfo";
            this.osinfo.Size = new System.Drawing.Size(32, 32);
            this.osinfo.TabIndex = 31;
            this.osinfo.UseVisualStyleBackColor = false;
            this.osinfo.Click += new System.EventHandler(this.button3_Click);
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
            this.email.UseVisualStyleBackColor = false;
            this.email.Click += new System.EventHandler(this.button4_Click);
            // 
            // build
            // 
            this.build.AutoSize = true;
            this.build.BackColor = System.Drawing.Color.Transparent;
            this.build.ForeColor = System.Drawing.Color.White;
            this.build.Location = new System.Drawing.Point(73, 57);
            this.build.Name = "build";
            this.build.Size = new System.Drawing.Size(33, 13);
            this.build.TabIndex = 33;
            this.build.Text = "6D10";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.ForeColor = System.Drawing.Color.White;
            this.version.Location = new System.Drawing.Point(48, 44);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(22, 13);
            this.version.TabIndex = 34;
            this.version.Text = "0.6";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(323, 150);
            this.ControlBox = false;
            this.Controls.Add(this.version);
            this.Controls.Add(this.build);
            this.Controls.Add(this.email);
            this.Controls.Add(this.osinfo);
            this.Controls.Add(this.vk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.gamefun_box);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.copyright_label);
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
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.PictureBox gamefun_box;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button vk;
        private System.Windows.Forms.Button osinfo;
        private System.Windows.Forms.Button email;
        public System.Windows.Forms.Label build;
        private System.Windows.Forms.Label version;
    }
}