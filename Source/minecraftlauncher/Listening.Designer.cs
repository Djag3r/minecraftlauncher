namespace minecraftlauncher
{
    partial class Listening
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listening));
            this.serverslist = new System.Windows.Forms.ListBox();
            this.play = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.checkbar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverslist
            // 
            this.serverslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.serverslist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serverslist.ForeColor = System.Drawing.Color.White;
            this.serverslist.FormattingEnabled = true;
            this.serverslist.Items.AddRange(new object[] {
            "Server #1",
            "Server #2",
            ""});
            this.serverslist.Location = new System.Drawing.Point(12, 44);
            this.serverslist.Name = "serverslist";
            this.serverslist.Size = new System.Drawing.Size(273, 260);
            this.serverslist.TabIndex = 0;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(12, 310);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 1;
            this.play.Text = "Играть";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(210, 310);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // checkbar
            // 
            this.checkbar.Location = new System.Drawing.Point(12, 339);
            this.checkbar.Name = "checkbar";
            this.checkbar.Size = new System.Drawing.Size(273, 11);
            this.checkbar.TabIndex = 3;
            this.checkbar.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(300, 23);
            this.toppanel.TabIndex = 4;
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
            this.toplabel.Size = new System.Drawing.Size(108, 16);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "Выбор сервера";
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseMove);
            // 
            // Listening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(300, 356);
            this.ControlBox = false;
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.checkbar);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.play);
            this.Controls.Add(this.serverslist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listening";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сервера";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox serverslist;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ProgressBar checkbar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
    }
}