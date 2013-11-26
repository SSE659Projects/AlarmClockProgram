namespace AlarmClock
{
    partial class frmMain
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboAmPm = new System.Windows.Forms.ComboBox();
            this.cboSnoozeTime = new System.Windows.Forms.ComboBox();
            this.chkSnooze = new System.Windows.Forms.CheckBox();
            this.chkLoop = new System.Windows.Forms.CheckBox();
            this.btnSetAlarm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboMinutes = new System.Windows.Forms.ComboBox();
            this.cboHours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkActivateStart = new System.Windows.Forms.CheckBox();
            this.chkMin2Tray = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxShowWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxNote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.DimGray;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(3, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(486, 116);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            // 
            // cboAmPm
            // 
            this.cboAmPm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAmPm.FormattingEnabled = true;
            this.cboAmPm.ItemHeight = 13;
            this.cboAmPm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cboAmPm.Location = new System.Drawing.Point(122, 155);
            this.cboAmPm.MaxDropDownItems = 2;
            this.cboAmPm.Name = "cboAmPm";
            this.cboAmPm.Size = new System.Drawing.Size(43, 21);
            this.cboAmPm.TabIndex = 4;
            // 
            // cboSnoozeTime
            // 
            this.cboSnoozeTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSnoozeTime.FormattingEnabled = true;
            this.cboSnoozeTime.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cboSnoozeTime.Location = new System.Drawing.Point(313, 155);
            this.cboSnoozeTime.Name = "cboSnoozeTime";
            this.cboSnoozeTime.Size = new System.Drawing.Size(54, 21);
            this.cboSnoozeTime.TabIndex = 15;
            // 
            // chkSnooze
            // 
            this.chkSnooze.AutoSize = true;
            this.chkSnooze.BackColor = System.Drawing.Color.Transparent;
            this.chkSnooze.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkSnooze.Location = new System.Drawing.Point(373, 157);
            this.chkSnooze.Name = "chkSnooze";
            this.chkSnooze.Size = new System.Drawing.Size(98, 17);
            this.chkSnooze.TabIndex = 14;
            this.chkSnooze.Text = "Enable Snooze";
            this.chkSnooze.UseVisualStyleBackColor = false;
            this.chkSnooze.CheckedChanged += new System.EventHandler(this.chkSnooze_CheckedChanged);
            // 
            // chkLoop
            // 
            this.chkLoop.AutoSize = true;
            this.chkLoop.BackColor = System.Drawing.Color.Transparent;
            this.chkLoop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkLoop.Location = new System.Drawing.Point(24, 234);
            this.chkLoop.Name = "chkLoop";
            this.chkLoop.Size = new System.Drawing.Size(79, 17);
            this.chkLoop.TabIndex = 13;
            this.chkLoop.Text = "Loop Alarm";
            this.chkLoop.UseVisualStyleBackColor = false;
            this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
            // 
            // btnSetAlarm
            // 
            this.btnSetAlarm.Location = new System.Drawing.Point(171, 153);
            this.btnSetAlarm.Name = "btnSetAlarm";
            this.btnSetAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnSetAlarm.TabIndex = 12;
            this.btnSetAlarm.Text = "Activate";
            this.btnSetAlarm.UseVisualStyleBackColor = true;
            this.btnSetAlarm.Click += new System.EventHandler(this.btnSetAlarm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Alarm File:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(362, 20);
            this.textBox1.TabIndex = 8;
            // 
            // cboMinutes
            // 
            this.cboMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMinutes.FormattingEnabled = true;
            this.cboMinutes.ItemHeight = 13;
            this.cboMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboMinutes.Location = new System.Drawing.Point(73, 155);
            this.cboMinutes.Name = "cboMinutes";
            this.cboMinutes.Size = new System.Drawing.Size(43, 21);
            this.cboMinutes.TabIndex = 7;
            // 
            // cboHours
            // 
            this.cboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHours.FormattingEnabled = true;
            this.cboHours.ItemHeight = 13;
            this.cboHours.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboHours.Location = new System.Drawing.Point(24, 155);
            this.cboHours.Name = "cboHours";
            this.cboHours.Size = new System.Drawing.Size(43, 21);
            this.cboHours.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Alarm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(310, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Snooze:";
            // 
            // chkActivateStart
            // 
            this.chkActivateStart.AutoSize = true;
            this.chkActivateStart.BackColor = System.Drawing.Color.Transparent;
            this.chkActivateStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkActivateStart.Location = new System.Drawing.Point(127, 234);
            this.chkActivateStart.Name = "chkActivateStart";
            this.chkActivateStart.Size = new System.Drawing.Size(119, 17);
            this.chkActivateStart.TabIndex = 17;
            this.chkActivateStart.Text = "Activate On Startup";
            this.chkActivateStart.UseVisualStyleBackColor = false;
            this.chkActivateStart.CheckedChanged += new System.EventHandler(this.chkActivateStart_CheckedChanged);
            // 
            // chkMin2Tray
            // 
            this.chkMin2Tray.AutoSize = true;
            this.chkMin2Tray.BackColor = System.Drawing.Color.Transparent;
            this.chkMin2Tray.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkMin2Tray.Location = new System.Drawing.Point(267, 234);
            this.chkMin2Tray.Name = "chkMin2Tray";
            this.chkMin2Tray.Size = new System.Drawing.Size(106, 17);
            this.chkMin2Tray.TabIndex = 18;
            this.chkMin2Tray.Text = "Minimize To Tray";
            this.chkMin2Tray.UseVisualStyleBackColor = false;
            this.chkMin2Tray.CheckedChanged += new System.EventHandler(this.chkMin2Tray_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxShowWindow,
            this.toolStripMenuItem1,
            this.ctxExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 54);
            // 
            // ctxShowWindow
            // 
            this.ctxShowWindow.Name = "ctxShowWindow";
            this.ctxShowWindow.Size = new System.Drawing.Size(150, 22);
            this.ctxShowWindow.Text = "Show Window";
            this.ctxShowWindow.Click += new System.EventHandler(this.ctxShowWindow_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(150, 22);
            this.ctxExit.Text = "Exit";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // txtBoxNote
            // 
            this.txtBoxNote.Location = new System.Drawing.Point(63, 132);
            this.txtBoxNote.Name = "txtBoxNote";
            this.txtBoxNote.Size = new System.Drawing.Size(183, 20);
            this.txtBoxNote.TabIndex = 19;
            this.txtBoxNote.Text = "Note";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 263);
            this.Controls.Add(this.txtBoxNote);
            this.Controls.Add(this.chkMin2Tray);
            this.Controls.Add(this.chkActivateStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSnoozeTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.chkSnooze);
            this.Controls.Add(this.chkLoop);
            this.Controls.Add(this.cboAmPm);
            this.Controls.Add(this.btnSetAlarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboHours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboMinutes);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboAmPm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ComboBox cboMinutes;
        public System.Windows.Forms.ComboBox cboHours;
        public System.Windows.Forms.Button btnSetAlarm;
        private System.Windows.Forms.CheckBox chkLoop;
        private System.Windows.Forms.ComboBox cboSnoozeTime;
        private System.Windows.Forms.CheckBox chkSnooze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkActivateStart;
        private System.Windows.Forms.CheckBox chkMin2Tray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxShowWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.TextBox txtBoxNote;


    }
}

