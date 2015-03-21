namespace minecraftlauncher
{
    partial class Updating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updating));
            this.infolabel = new System.Windows.Forms.Label();
            this.yes = new System.Windows.Forms.Button();
            this.no = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.toplabel = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.Transparent;
            this.infolabel.ForeColor = System.Drawing.Color.White;
            this.infolabel.Location = new System.Drawing.Point(12, 34);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(214, 26);
            this.infolabel.TabIndex = 0;
            this.infolabel.Text = "Чтобы лаунчер обновился, необходимо \r\nего перезапустить. Сделать это сейчас?";
            // 
            // yes
            // 
            this.yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yes.ForeColor = System.Drawing.Color.White;
            this.yes.Location = new System.Drawing.Point(12, 74);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(75, 23);
            this.yes.TabIndex = 1;
            this.yes.Text = "Да, сейчас";
            this.yes.UseVisualStyleBackColor = false;
            this.yes.Click += new System.EventHandler(this.yes_Click);
            // 
            // no
            // 
            this.no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.no.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no.ForeColor = System.Drawing.Color.White;
            this.no.Location = new System.Drawing.Point(151, 74);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(75, 23);
            this.no.TabIndex = 2;
            this.no.Text = "Нет, позже";
            this.no.UseVisualStyleBackColor = false;
            this.no.Click += new System.EventHandler(this.no_Click);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.toppanel.Controls.Add(this.toplabel);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(239, 21);
            this.toppanel.TabIndex = 3;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            this.toppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseMove);
            // 
            // toplabel
            // 
            this.toplabel.AutoSize = true;
            this.toplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toplabel.ForeColor = System.Drawing.Color.White;
            this.toplabel.Location = new System.Drawing.Point(8, 3);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(79, 15);
            this.toplabel.TabIndex = 0;
            this.toplabel.Text = "Обновление";
            this.toplabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseDown);
            this.toplabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toplabel_MouseMove);
            // 
            // Updating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::minecraftlauncher.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(239, 105);
            this.ControlBox = false;
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.no);
            this.Controls.Add(this.yes);
            this.Controls.Add(this.infolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Updating";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Button yes;
        private System.Windows.Forms.Button no;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label toplabel;
    }
}