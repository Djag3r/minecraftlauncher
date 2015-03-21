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
            this.oslabel = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.mb = new System.Windows.Forms.Label();
            this.hddsize = new System.Windows.Forms.Label();
            this.hddsizelabel = new System.Windows.Forms.Label();
            this.hdd = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.internet = new System.Windows.Forms.Label();
            this.resolution = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.Label();
            this.gpu = new System.Windows.Forms.Label();
            this.internetlabel = new System.Windows.Forms.Label();
            this.resolutionlabel = new System.Windows.Forms.Label();
            this.hddlabel = new System.Windows.Forms.Label();
            this.mblabel = new System.Windows.Forms.Label();
            this.gpulabel = new System.Windows.Forms.Label();
            this.ramlabel = new System.Windows.Forms.Label();
            this.cpulabel = new System.Windows.Forms.Label();
            this.bitlabel = new System.Windows.Forms.Label();
            this.pcnamelabel = new System.Windows.Forms.Label();
            this.bit = new System.Windows.Forms.Label();
            this.pcname = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.groupbox.SuspendLayout();
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
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
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
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseMove);
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
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // oslabel
            // 
            this.oslabel.AutoSize = true;
            this.oslabel.BackColor = System.Drawing.Color.Transparent;
            this.oslabel.ForeColor = System.Drawing.Color.White;
            this.oslabel.Location = new System.Drawing.Point(12, 39);
            this.oslabel.Name = "oslabel";
            this.oslabel.Size = new System.Drawing.Size(55, 13);
            this.oslabel.TabIndex = 3;
            this.oslabel.Text = "Ваша ОС:";
            // 
            // groupbox
            // 
            this.groupbox.BackColor = System.Drawing.Color.Transparent;
            this.groupbox.Controls.Add(this.mb);
            this.groupbox.Controls.Add(this.hddsize);
            this.groupbox.Controls.Add(this.hddsizelabel);
            this.groupbox.Controls.Add(this.hdd);
            this.groupbox.Controls.Add(this.cpu);
            this.groupbox.Controls.Add(this.internet);
            this.groupbox.Controls.Add(this.resolution);
            this.groupbox.Controls.Add(this.ram);
            this.groupbox.Controls.Add(this.gpu);
            this.groupbox.Controls.Add(this.internetlabel);
            this.groupbox.Controls.Add(this.resolutionlabel);
            this.groupbox.Controls.Add(this.hddlabel);
            this.groupbox.Controls.Add(this.mblabel);
            this.groupbox.Controls.Add(this.gpulabel);
            this.groupbox.Controls.Add(this.ramlabel);
            this.groupbox.Controls.Add(this.cpulabel);
            this.groupbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox.ForeColor = System.Drawing.Color.White;
            this.groupbox.Location = new System.Drawing.Point(12, 94);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(276, 205);
            this.groupbox.TabIndex = 4;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Системная конфигурация";
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
            // hddsizelabel
            // 
            this.hddsizelabel.AutoSize = true;
            this.hddsizelabel.Location = new System.Drawing.Point(6, 105);
            this.hddsizelabel.Name = "hddsizelabel";
            this.hddsizelabel.Size = new System.Drawing.Size(45, 13);
            this.hddsizelabel.TabIndex = 13;
            this.hddsizelabel.Text = "Объем:";
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
            // internetlabel
            // 
            this.internetlabel.AutoSize = true;
            this.internetlabel.Location = new System.Drawing.Point(6, 155);
            this.internetlabel.Name = "internetlabel";
            this.internetlabel.Size = new System.Drawing.Size(141, 13);
            this.internetlabel.TabIndex = 6;
            this.internetlabel.Text = "Состояние сети Интернет:";
            // 
            // resolutionlabel
            // 
            this.resolutionlabel.AutoSize = true;
            this.resolutionlabel.Location = new System.Drawing.Point(6, 142);
            this.resolutionlabel.Name = "resolutionlabel";
            this.resolutionlabel.Size = new System.Drawing.Size(97, 13);
            this.resolutionlabel.TabIndex = 5;
            this.resolutionlabel.Text = "Разрешение LCD:";
            // 
            // hddlabel
            // 
            this.hddlabel.AutoSize = true;
            this.hddlabel.Location = new System.Drawing.Point(6, 92);
            this.hddlabel.Name = "hddlabel";
            this.hddlabel.Size = new System.Drawing.Size(30, 13);
            this.hddlabel.TabIndex = 4;
            this.hddlabel.Text = "ЖД:";
            // 
            // mblabel
            // 
            this.mblabel.AutoSize = true;
            this.mblabel.Location = new System.Drawing.Point(6, 79);
            this.mblabel.Name = "mblabel";
            this.mblabel.Size = new System.Drawing.Size(27, 13);
            this.mblabel.TabIndex = 3;
            this.mblabel.Text = "МП:";
            // 
            // gpulabel
            // 
            this.gpulabel.AutoSize = true;
            this.gpulabel.Location = new System.Drawing.Point(6, 66);
            this.gpulabel.Name = "gpulabel";
            this.gpulabel.Size = new System.Drawing.Size(24, 13);
            this.gpulabel.TabIndex = 2;
            this.gpulabel.Text = "ГП:";
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.Location = new System.Drawing.Point(6, 53);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Size = new System.Drawing.Size(33, 13);
            this.ramlabel.TabIndex = 1;
            this.ramlabel.Text = "ОЗУ:";
            // 
            // cpulabel
            // 
            this.cpulabel.AutoSize = true;
            this.cpulabel.Location = new System.Drawing.Point(6, 40);
            this.cpulabel.Name = "cpulabel";
            this.cpulabel.Size = new System.Drawing.Size(26, 13);
            this.cpulabel.TabIndex = 0;
            this.cpulabel.Text = "ЦП:";
            // 
            // bitlabel
            // 
            this.bitlabel.AutoSize = true;
            this.bitlabel.BackColor = System.Drawing.Color.Transparent;
            this.bitlabel.ForeColor = System.Drawing.Color.White;
            this.bitlabel.Location = new System.Drawing.Point(12, 52);
            this.bitlabel.Name = "bitlabel";
            this.bitlabel.Size = new System.Drawing.Size(76, 13);
            this.bitlabel.TabIndex = 5;
            this.bitlabel.Text = "Разрядность:";
            // 
            // pcnamelabel
            // 
            this.pcnamelabel.AutoSize = true;
            this.pcnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.pcnamelabel.ForeColor = System.Drawing.Color.White;
            this.pcnamelabel.Location = new System.Drawing.Point(12, 65);
            this.pcnamelabel.Name = "pcnamelabel";
            this.pcnamelabel.Size = new System.Drawing.Size(98, 13);
            this.pcnamelabel.TabIndex = 6;
            this.pcnamelabel.Text = "Имя компьютера:";
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
            this.Controls.Add(this.pcnamelabel);
            this.Controls.Add(this.bitlabel);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.oslabel);
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
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
        private System.Windows.Forms.Label os;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label oslabel;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label internetlabel;
        private System.Windows.Forms.Label resolutionlabel;
        private System.Windows.Forms.Label hddlabel;
        private System.Windows.Forms.Label mblabel;
        private System.Windows.Forms.Label gpulabel;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.Label cpulabel;
        private System.Windows.Forms.Label ram;
        private System.Windows.Forms.Label gpu;
        private System.Windows.Forms.Label bitlabel;
        private System.Windows.Forms.Label pcnamelabel;
        private System.Windows.Forms.Label bit;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.Label resolution;
        private System.Windows.Forms.Label internet;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label hdd;
        private System.Windows.Forms.Label hddsize;
        private System.Windows.Forms.Label hddsizelabel;
        private System.Windows.Forms.Label mb;
    }
}