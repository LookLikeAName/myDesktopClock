namespace desktopClock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.repositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AM = new System.Windows.Forms.PictureBox();
            this.PM = new System.Windows.Forms.PictureBox();
            this.bk = new System.Windows.Forms.PictureBox();
            this.num0 = new System.Windows.Forms.PictureBox();
            this.num1 = new System.Windows.Forms.PictureBox();
            this.num2 = new System.Windows.Forms.PictureBox();
            this.num3 = new System.Windows.Forms.PictureBox();
            this.num4 = new System.Windows.Forms.PictureBox();
            this.num5 = new System.Windows.Forms.PictureBox();
            this.num6 = new System.Windows.Forms.PictureBox();
            this.num7 = new System.Windows.Forms.PictureBox();
            this.num8 = new System.Windows.Forms.PictureBox();
            this.num9 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num9)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositionToolStripMenuItem,
            this.endToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // repositionToolStripMenuItem
            // 
            this.repositionToolStripMenuItem.Name = "repositionToolStripMenuItem";
            this.repositionToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.repositionToolStripMenuItem.Text = "Reposition";
            this.repositionToolStripMenuItem.Click += new System.EventHandler(this.repositionToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DesktopClock";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // AM
            // 
            this.AM.Image = ((System.Drawing.Image)(resources.GetObject("AM.Image")));
            this.AM.Location = new System.Drawing.Point(291, 314);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(73, 52);
            this.AM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AM.TabIndex = 4;
            this.AM.TabStop = false;
            this.AM.Visible = false;
            this.AM.Click += new System.EventHandler(this.AM_Click);
            // 
            // PM
            // 
            this.PM.Image = ((System.Drawing.Image)(resources.GetObject("PM.Image")));
            this.PM.Location = new System.Drawing.Point(392, 314);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(73, 52);
            this.PM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PM.TabIndex = 5;
            this.PM.TabStop = false;
            this.PM.Visible = false;
            // 
            // bk
            // 
            this.bk.Image = ((System.Drawing.Image)(resources.GetObject("bk.Image")));
            this.bk.Location = new System.Drawing.Point(-4, 388);
            this.bk.Name = "bk";
            this.bk.Size = new System.Drawing.Size(514, 165);
            this.bk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bk.TabIndex = 6;
            this.bk.TabStop = false;
            this.bk.Visible = false;
            // 
            // num0
            // 
            this.num0.Image = ((System.Drawing.Image)(resources.GetObject("num0.Image")));
            this.num0.Location = new System.Drawing.Point(24, 188);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(34, 50);
            this.num0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num0.TabIndex = 7;
            this.num0.TabStop = false;
            this.num0.Visible = false;
            // 
            // num1
            // 
            this.num1.Image = ((System.Drawing.Image)(resources.GetObject("num1.Image")));
            this.num1.Location = new System.Drawing.Point(127, 188);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(34, 50);
            this.num1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num1.TabIndex = 8;
            this.num1.TabStop = false;
            this.num1.Visible = false;
            // 
            // num2
            // 
            this.num2.Image = ((System.Drawing.Image)(resources.GetObject("num2.Image")));
            this.num2.Location = new System.Drawing.Point(220, 188);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(34, 50);
            this.num2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num2.TabIndex = 9;
            this.num2.TabStop = false;
            this.num2.Visible = false;
            // 
            // num3
            // 
            this.num3.Image = ((System.Drawing.Image)(resources.GetObject("num3.Image")));
            this.num3.Location = new System.Drawing.Point(315, 188);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(34, 50);
            this.num3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num3.TabIndex = 10;
            this.num3.TabStop = false;
            this.num3.Visible = false;
            // 
            // num4
            // 
            this.num4.Image = ((System.Drawing.Image)(resources.GetObject("num4.Image")));
            this.num4.Location = new System.Drawing.Point(409, 188);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(34, 50);
            this.num4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num4.TabIndex = 11;
            this.num4.TabStop = false;
            this.num4.Visible = false;
            // 
            // num5
            // 
            this.num5.Image = ((System.Drawing.Image)(resources.GetObject("num5.Image")));
            this.num5.Location = new System.Drawing.Point(24, 259);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(34, 50);
            this.num5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num5.TabIndex = 12;
            this.num5.TabStop = false;
            this.num5.Visible = false;
            // 
            // num6
            // 
            this.num6.Image = ((System.Drawing.Image)(resources.GetObject("num6.Image")));
            this.num6.Location = new System.Drawing.Point(127, 259);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(34, 50);
            this.num6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num6.TabIndex = 13;
            this.num6.TabStop = false;
            this.num6.Visible = false;
            // 
            // num7
            // 
            this.num7.Image = ((System.Drawing.Image)(resources.GetObject("num7.Image")));
            this.num7.Location = new System.Drawing.Point(222, 256);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(34, 50);
            this.num7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num7.TabIndex = 14;
            this.num7.TabStop = false;
            this.num7.Visible = false;
            // 
            // num8
            // 
            this.num8.Image = ((System.Drawing.Image)(resources.GetObject("num8.Image")));
            this.num8.Location = new System.Drawing.Point(315, 256);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(34, 50);
            this.num8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num8.TabIndex = 15;
            this.num8.TabStop = false;
            this.num8.Visible = false;
            // 
            // num9
            // 
            this.num9.Image = ((System.Drawing.Image)(resources.GetObject("num9.Image")));
            this.num9.Location = new System.Drawing.Point(409, 256);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(34, 50);
            this.num9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.num9.TabIndex = 16;
            this.num9.TabStop = false;
            this.num9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(517, 565);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.bk);
            this.Controls.Add(this.PM);
            this.Controls.Add(this.AM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositionToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AM;
        private System.Windows.Forms.PictureBox PM;
        private System.Windows.Forms.PictureBox bk;
        private System.Windows.Forms.PictureBox num0;
        private System.Windows.Forms.PictureBox num1;
        private System.Windows.Forms.PictureBox num2;
        private System.Windows.Forms.PictureBox num3;
        private System.Windows.Forms.PictureBox num4;
        private System.Windows.Forms.PictureBox num5;
        private System.Windows.Forms.PictureBox num6;
        private System.Windows.Forms.PictureBox num7;
        private System.Windows.Forms.PictureBox num8;
        private System.Windows.Forms.PictureBox num9;
    }
}

