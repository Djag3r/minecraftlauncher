namespace minecraftlauncher
{
    partial class OSInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSInfo));
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.os = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.os_label = new System.Windows.Forms.Label();
            this.osinfo_groupbox = new System.Windows.Forms.GroupBox();
            this.mb = new System.Windows.Forms.Label();
            this.hddsize = new System.Windows.Forms.Label();
            this.hddsize_label = new System.Windows.Forms.Label();
            this.hdd = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.internet = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.internet_label = new System.Windows.Forms.Label();
            this.resolution_label = new System.Windows.Forms.Label();
            this.hdd_label = new System.Windows.Forms.Label();
            this.mb_label = new System.Windows.Forms.Label();
            this.gpu_label = new System.Windows.Forms.Label();
            this.ram_label = new System.Windows.Forms.Label();
            this.cpu_label = new System.Windows.Forms.Label();
            this.bit_label = new System.Windows.Forms.Label();
            this.pcname_label = new System.Windows.Forms.Label();
            this.bit = new System.Windows.Forms.Label();
            this.pcname = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.osinfo_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(300, 23);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.toplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toplabel.ForeColor = System.Drawing.Color.White;
            this.toplabel.Location = new System.Drawing.Point(12, 3);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(161, 16);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "Информация о системе";
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // os
            // 
            this.os.AutoSize = true;
            this.os.BackColor = System.Drawing.Color.Transparent;
            this.os.ForeColor = System.Drawing.Color.White;
            this.os.Location = new System.Drawing.Point(73, 39);
            this.os.Name = "os";
            this.os.Size = new System.Drawing.Size(0, 13);
            this.os.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.Location = new System.Drawing.Point(12, 313);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(276, 28);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // os_label
            // 
            this.os_label.AutoSize = true;
            this.os_label.BackColor = System.Drawing.Color.Transparent;
            this.os_label.ForeColor = System.Drawing.Color.White;
            this.os_label.Location = new System.Drawing.Point(12, 39);
            this.os_label.Name = "os_label";
            this.os_label.Size = new System.Drawing.Size(55, 13);
            this.os_label.TabIndex = 3;
            this.os_label.Text = "Ваша ОС:";
            // 
            // osinfo_groupbox
            // 
            this.osinfo_groupbox.BackColor = System.Drawing.Color.Transparent;
            this.osinfo_groupbox.Controls.Add(this.mb);
            this.osinfo_groupbox.Controls.Add(this.hddsize);
            this.osinfo_groupbox.Controls.Add(this.hddsize_label);
            this.osinfo_groupbox.Controls.Add(this.hdd);
            this.osinfo_groupbox.Controls.Add(this.cpu);
            this.osinfo_groupbox.Controls.Add(this.internet);
            this.osinfo_groupbox.Controls.Add(this.resolution);
            this.osinfo_groupbox.Controls.Add(this.ram);
            this.osinfo_groupbox.Controls.Add(this.gpu);
            this.osinfo_groupbox.Controls.Add(this.internet_label);
            this.osinfo_groupbox.Controls.Add(this.resolution_label);
            this.osinfo_groupbox.Controls.Add(this.hdd_label);
            this.osinfo_groupbox.Controls.Add(this.mb_label);
            this.osinfo_groupbox.Controls.Add(this.gpu_label);
            this.osinfo_groupbox.Controls.Add(this.ram_label);
            this.osinfo_groupbox.Controls.Add(this.cpu_label);
            this.osinfo_groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.osinfo_groupbox.ForeColor = System.Drawing.Color.White;
            this.osinfo_groupbox.Location = new System.Drawing.Point(12, 94);
            this.osinfo_groupbox.Name = "osinfo_groupbox";
            this.osinfo_groupbox.Size = new System.Drawing.Size(276, 205);
            this.osinfo_groupbox.TabIndex = 4;
            this.osinfo_groupbox.TabStop = false;
            this.osinfo_groupbox.Text = "Системная конфигурация";
            // 
            // mb
            // 
            this.mb.AutoSize = true;
            this.mb.Location = new System.Drawing.Point(32, 79);
            this.mb.Name = "mb";
            this.mb.Size = new System.Drawing.Size(0, 13);
            this.mb.TabIndex = 15;
            // 
            // hddsize
            // 
            this.hddsize.AutoSize = true;
            this.hddsize.Location = new System.Drawing.Point(57, 105);
            this.hddsize.Name = "hddsize";
            this.hddsize.Size = new System.Drawing.Size(0, 13);
            this.hddsize.TabIndex = 14;
            // 
            // hddsize_label
            // 
            this.hddsize_label.AutoSize = true;
            this.hddsize_label.Location = new System.Drawing.Point(6, 105);
            this.hddsize_label.Name = "hddsize_label";
            this.hddsize_label.Size = new System.Drawing.Size(45, 13);
            this.hddsize_label.TabIndex = 13;
            this.hddsize_label.Text = "Объем:";
            // 
            // hdd
            // 
            this.hdd.AutoSize = true;
            this.hdd.Location = new System.Drawing.Point(35, 92);
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(0, 13);
            this.hdd.TabIndex = 12;
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(31, 40);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(0, 13);
            this.cpu.TabIndex = 11;
            // 
            // internet
            // 
            this.internet.AutoSize = true;
            this.internet.Location = new System.Drawing.Point(153, 155);
            this.internet.Name = "internet";
            this.internet.Size = new System.Drawing.Size(0, 13);
            this.internet.TabIndex = 10;
            // 
            // resolution
            // 
            this.resolution.AutoSize = true;
            this.resolution.Location = new System.Drawing.Point(109, 142);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(0, 13);
            this.resolution.TabIndex = 9;
            // 
            // ram
            // 
            this.ram.AutoSize = true;
            this.ram.Location = new System.Drawing.Point(40, 53);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(0, 13);
            this.ram.TabIndex = 8;
            // 
            // gpu
            // 
            this.gpu.AutoSize = true;
            this.gpu.Location = new System.Drawing.Point(29, 66);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(0, 13);
            this.gpu.TabIndex = 7;
            // 
            // internet_label
            // 
            this.internet_label.AutoSize = true;
            this.internet_label.Location = new System.Drawing.Point(6, 155);
            this.internet_label.Name = "internet_label";
            this.internet_label.Size = new System.Drawing.Size(141, 13);
            this.internet_label.TabIndex = 6;
            this.internet_label.Text = "Состояние сети Интернет:";
            // 
            // resolution_label
            // 
            this.resolution_label.AutoSize = true;
            this.resolution_label.Location = new System.Drawing.Point(6, 142);
            this.resolution_label.Name = "resolution_label";
            this.resolution_label.Size = new System.Drawing.Size(97, 13);
            this.resolution_label.TabIndex = 5;
            this.resolution_label.Text = "Разрешение LCD:";
            // 
            // hdd_label
            // 
            this.hdd_label.AutoSize = true;
            this.hdd_label.Location = new System.Drawing.Point(6, 92);
            this.hdd_label.Name = "hdd_label";
            this.hdd_label.Size = new System.Drawing.Size(30, 13);
            this.hdd_label.TabIndex = 4;
            this.hdd_label.Text = "ЖД:";
            // 
            // mb_label
            // 
            this.mb_label.AutoSize = true;
            this.mb_label.Location = new System.Drawing.Point(6, 79);
            this.mb_label.Name = "mb_label";
            this.mb_label.Size = new System.Drawing.Size(27, 13);
            this.mb_label.TabIndex = 3;
            this.mb_label.Text = "МП:";
            // 
            // gpu_label
            // 
            this.gpu_label.AutoSize = true;
            this.gpu_label.Location = new System.Drawing.Point(6, 66);
            this.gpu_label.Name = "gpu_label";
            this.gpu_label.Size = new System.Drawing.Size(24, 13);
            this.gpu_label.TabIndex = 2;
            this.gpu_label.Text = "ГП:";
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.Location = new System.Drawing.Point(6, 53);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(33, 13);
            this.ram_label.TabIndex = 1;
            this.ram_label.Text = "ОЗУ:";
            // 
            // cpu_label
            // 
            this.cpu_label.AutoSize = true;
            this.cpu_label.Location = new System.Drawing.Point(6, 40);
            this.cpu_label.Name = "cpu_label";
            this.cpu_label.Size = new System.Drawing.Size(26, 13);
            this.cpu_label.TabIndex = 0;
            this.cpu_label.Text = "ЦП:";
            // 
            // bit_label
            // 
            this.bit_label.AutoSize = true;
            this.bit_label.BackColor = System.Drawing.Color.Transparent;
            this.bit_label.ForeColor = System.Drawing.Color.White;
            this.bit_label.Location = new System.Drawing.Point(12, 52);
            this.bit_label.Name = "bit_label";
            this.bit_label.Size = new System.Drawing.Size(76, 13);
            this.bit_label.TabIndex = 5;
            this.bit_label.Text = "Разрядность:";
            // 
            // pcname_label
            // 
            this.pcname_label.AutoSize = true;
            this.pcname_label.BackColor = System.Drawing.Color.Transparent;
            this.pcname_label.ForeColor = System.Drawing.Color.White;
            this.pcname_label.Location = new System.Drawing.Point(12, 65);
            this.pcname_label.Name = "pcname_label";
            this.pcname_label.Size = new System.Drawing.Size(98, 13);
            this.pcname_label.TabIndex = 6;
            this.pcname_label.Text = "Имя компьютера:";
            // 
            // bit
            // 
            this.bit.AutoSize = true;
            this.bit.BackColor = System.Drawing.Color.Transparent;
            this.bit.ForeColor = System.Drawing.Color.White;
            this.bit.Location = new System.Drawing.Point(94, 52);
            this.bit.Name = "bit";
            this.bit.Size = new System.Drawing.Size(0, 13);
            this.bit.TabIndex = 7;
            // 
            // pcname
            // 
            this.pcname.AutoSize = true;
            this.pcname.BackColor = System.Drawing.Color.Transparent;
            this.pcname.ForeColor = System.Drawing.Color.White;
            this.pcname.Location = new System.Drawing.Point(116, 65);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(0, 13);
            this.pcname.TabIndex = 8;
            // 
            // OSInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(300, 356);
            this.ControlBox = false;
            this.Controls.Add(this.pcname);
            this.Controls.Add(this.bit);
            this.Controls.Add(this.pcname_label);
            this.Controls.Add(this.bit_label);
            this.Controls.Add(this.osinfo_groupbox);
            this.Controls.Add(this.os_label);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.os);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSInfo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о системе";
            this.Load += new System.EventHandler(this.OSInfo_Load);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.osinfo_groupbox.ResumeLayout(false);
            this.osinfo_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
        private System.Windows.Forms.Label os;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label os_label;
        private System.Windows.Forms.GroupBox osinfo_groupbox;
        private System.Windows.Forms.Label internet_label;
        private System.Windows.Forms.Label resolution_label;
        private System.Windows.Forms.Label hdd_label;
        private System.Windows.Forms.Label mb_label;
        private System.Windows.Forms.Label gpu_label;
        private System.Windows.Forms.Label ram_label;
        private System.Windows.Forms.Label cpu_label;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label gpu;
        private System.Windows.Forms.Label bit_label;
        private System.Windows.Forms.Label pcname_label;
        private System.Windows.Forms.Label bit;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.Label internet;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label hdd;
        private System.Windows.Forms.Label hddsize;
        private System.Windows.Forms.Label hddsize_label;
        private System.Windows.Forms.Label mb;
    }
}