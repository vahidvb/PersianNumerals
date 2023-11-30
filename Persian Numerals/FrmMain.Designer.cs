namespace Persian_Numerals
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblStatus = new System.Windows.Forms.Label();
            this.radAlways = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.radDisable = new System.Windows.Forms.RadioButton();
            this.chkGeneral = new System.Windows.Forms.CheckBox();
            this.chkNumLock = new System.Windows.Forms.CheckBox();
            this.radCtrlShift = new System.Windows.Forms.RadioButton();
            this.radScrollLock = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.chkStartup = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radOperationLang = new System.Windows.Forms.RadioButton();
            this.lnkGit = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(83, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "⚫ ";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblStatus.TextChanged += new System.EventHandler(this.label1_TextChanged);
            this.lblStatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // radAlways
            // 
            this.radAlways.AutoSize = true;
            this.radAlways.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radAlways.Location = new System.Drawing.Point(9, 134);
            this.radAlways.Name = "radAlways";
            this.radAlways.Size = new System.Drawing.Size(190, 17);
            this.radAlways.TabIndex = 1;
            this.radAlways.Text = "Numbers should always be Persian";
            this.radAlways.UseVisualStyleBackColor = true;
            this.radAlways.CheckedChanged += new System.EventHandler(this.radAlways_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 70);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem2.Text = "Setting";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem4.Text = "Visit My Github Profile";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "Exit Application";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // radDisable
            // 
            this.radDisable.AutoSize = true;
            this.radDisable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radDisable.Location = new System.Drawing.Point(9, 111);
            this.radDisable.Name = "radDisable";
            this.radDisable.Size = new System.Drawing.Size(113, 17);
            this.radDisable.TabIndex = 5;
            this.radDisable.Text = "Disable application";
            this.radDisable.UseVisualStyleBackColor = true;
            this.radDisable.CheckedChanged += new System.EventHandler(this.radDisable_CheckedChanged);
            // 
            // chkGeneral
            // 
            this.chkGeneral.AutoSize = true;
            this.chkGeneral.Checked = true;
            this.chkGeneral.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGeneral.Location = new System.Drawing.Point(9, 249);
            this.chkGeneral.Name = "chkGeneral";
            this.chkGeneral.Size = new System.Drawing.Size(201, 17);
            this.chkGeneral.TabIndex = 5;
            this.chkGeneral.Text = "Change main keyboard Numbers key";
            this.chkGeneral.UseVisualStyleBackColor = true;
            this.chkGeneral.CheckedChanged += new System.EventHandler(this.chkGeneral_CheckedChanged);
            // 
            // chkNumLock
            // 
            this.chkNumLock.AutoSize = true;
            this.chkNumLock.Checked = true;
            this.chkNumLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumLock.Location = new System.Drawing.Point(9, 226);
            this.chkNumLock.Name = "chkNumLock";
            this.chkNumLock.Size = new System.Drawing.Size(172, 17);
            this.chkNumLock.TabIndex = 4;
            this.chkNumLock.Text = "Change NumLock numbers key";
            this.chkNumLock.UseVisualStyleBackColor = true;
            this.chkNumLock.CheckedChanged += new System.EventHandler(this.chkNumLock_CheckedChanged);
            // 
            // radCtrlShift
            // 
            this.radCtrlShift.AutoSize = true;
            this.radCtrlShift.Checked = true;
            this.radCtrlShift.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radCtrlShift.Location = new System.Drawing.Point(9, 180);
            this.radCtrlShift.Name = "radCtrlShift";
            this.radCtrlShift.Size = new System.Drawing.Size(229, 17);
            this.radCtrlShift.TabIndex = 3;
            this.radCtrlShift.TabStop = true;
            this.radCtrlShift.Text = "Activate application with the Control+Shift";
            this.radCtrlShift.UseVisualStyleBackColor = true;
            this.radCtrlShift.CheckedChanged += new System.EventHandler(this.radCtrlShift_CheckedChanged);
            // 
            // radScrollLock
            // 
            this.radScrollLock.AutoSize = true;
            this.radScrollLock.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radScrollLock.Location = new System.Drawing.Point(9, 157);
            this.radScrollLock.Name = "radScrollLock";
            this.radScrollLock.Size = new System.Drawing.Size(233, 17);
            this.radScrollLock.TabIndex = 2;
            this.radScrollLock.Text = "Activate application with the Scroll Lock key";
            this.radScrollLock.UseVisualStyleBackColor = true;
            this.radScrollLock.CheckedChanged += new System.EventHandler(this.radScrollLock_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(-2, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 3);
            this.label3.TabIndex = 7;
            // 
            // chkStartup
            // 
            this.chkStartup.AutoSize = true;
            this.chkStartup.Checked = true;
            this.chkStartup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStartup.Location = new System.Drawing.Point(9, 272);
            this.chkStartup.Name = "chkStartup";
            this.chkStartup.Size = new System.Drawing.Size(145, 17);
            this.chkStartup.TabIndex = 10;
            this.chkStartup.Text = "Start at windows startup";
            this.chkStartup.UseVisualStyleBackColor = true;
            this.chkStartup.CheckedChanged += new System.EventHandler(this.chkStartup_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(-2, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 3);
            this.label5.TabIndex = 12;
            // 
            // radOperationLang
            // 
            this.radOperationLang.AutoSize = true;
            this.radOperationLang.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radOperationLang.Location = new System.Drawing.Point(9, 203);
            this.radOperationLang.Name = "radOperationLang";
            this.radOperationLang.Size = new System.Drawing.Size(245, 17);
            this.radOperationLang.TabIndex = 14;
            this.radOperationLang.Text = "Activate based on operating system language";
            this.radOperationLang.UseVisualStyleBackColor = true;
            this.radOperationLang.CheckedChanged += new System.EventHandler(this.radOperationLang_CheckedChanged);
            // 
            // lnkGit
            // 
            this.lnkGit.BackColor = System.Drawing.SystemColors.Control;
            this.lnkGit.Location = new System.Drawing.Point(87, 308);
            this.lnkGit.Name = "lnkGit";
            this.lnkGit.Size = new System.Drawing.Size(123, 19);
            this.lnkGit.TabIndex = 16;
            this.lnkGit.TabStop = true;
            this.lnkGit.Text = "Visit My Github Profile";
            this.lnkGit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkGit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGit_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Persian_Numerals.Properties.Resources.Banner_jpg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 104);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersion
            // 
            this.lblVersion.BackColor = System.Drawing.Color.White;
            this.lblVersion.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(151, 83);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 12);
            this.lblVersion.TabIndex = 19;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(94, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkGit);
            this.Controls.Add(this.radOperationLang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkStartup);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radDisable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkGeneral);
            this.Controls.Add(this.chkNumLock);
            this.Controls.Add(this.radCtrlShift);
            this.Controls.Add(this.radAlways);
            this.Controls.Add(this.radScrollLock);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persian Numerals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton radAlways;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.RadioButton radScrollLock;
        private System.Windows.Forms.RadioButton radCtrlShift;
        private System.Windows.Forms.CheckBox chkGeneral;
        private System.Windows.Forms.CheckBox chkNumLock;
        private System.Windows.Forms.RadioButton radDisable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkStartup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radOperationLang;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnkGit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnExit;
    }
}

