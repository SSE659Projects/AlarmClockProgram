using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlarmClock
{
    public partial class frmMain : Form
    {

        NotifyIcon icon = new NotifyIcon();

        public bool isSnoozing = false;
        bool canSnooze = false;
        int snoozeTime;

        static public bool AlarmActive = false;
        Timer timer = new Timer();
        OpenFileDialog dlg;
        Sound snd = new Sound();
        bool Playing = false;
        
        Form snoozeForm = new frmSnooze();

        string AlarmTime;

        public frmMain()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += delegate { TimerTick(timer,EventArgs.Empty); };
            timer.Enabled = true;
            icon.Icon = Properties.Resources.Alarm;
            icon.Visible = false;
            icon.ContextMenuStrip = this.contextMenuStrip1;
        }

        public void TimerTick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            
            if (!isSnoozing)
            {
                if (lblTime.Text == AlarmTime && AlarmActive)
                {
                    snd.play();
                    btnSetAlarm.Enabled = true;
                    Playing = true; 
                   
                    if (canSnooze)
                    {
                        doSnooze();
                    }
                }                
            }
            else
            {
                doSnooze();
            }
        }

        private void doSnooze()
        {
            if (!snd.Playing)
                snd.play();

            if (!snoozeForm.Visible)
            {
                if (snoozeForm.ShowDialog(this) == DialogResult.OK)
                {
                    snd.stop();
                    isSnoozing = true;
                    timer.Interval = 1000 * 60 * Int16.Parse(cboSnoozeTime.SelectedItem.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlg = new OpenFileDialog();
            dlg.DefaultExt = ".exe";
            dlg.Filter = "MP3 File|*.mp3|WMA File|*.wma";
            dlg.FilterIndex = 0;
            dlg.Multiselect = false;
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if(dlg.FileName != string.Empty)
                {
                    textBox1.Text = dlg.FileName;
                }
            }
        }

        public void frmMain_Load(object sender, EventArgs e)
        {
            cboHours.SelectedIndex = Properties.Settings.Default.Hour;
            cboMinutes.SelectedIndex = Properties.Settings.Default.Minute;
            cboAmPm.SelectedIndex = Properties.Settings.Default.AMPM;
            chkLoop.Checked = Properties.Settings.Default.Loop;
            textBox1.Text = Properties.Settings.Default.MediaFile;
            txtBoxNote.Text = Properties.Settings.Default.Note;
            cboSnoozeTime.SelectedIndex = Properties.Settings.Default.SnoozeTime;
            chkSnooze.Checked = Properties.Settings.Default.CanSnooze;
            chkMin2Tray.Checked = Properties.Settings.Default.Min2Tray;
            chkActivateStart.Checked = Properties.Settings.Default.ActivateAtStartup;

            if (textBox1.Text == "")
            {
                string absPathContainingHrefs = Directory.GetCurrentDirectory();
                string fullPath = Path.Combine(absPathContainingHrefs, @"..\..\Resources\alarm01.mp3");
                fullPath = Path.GetFullPath(fullPath);  // Will turn the above into a proper abs path
                textBox1.Text = fullPath;
            }

            if (chkActivateStart.Checked)
                btnSetAlarm.PerformClick();
        }

        public void btnSetAlarm_Click(object sender, EventArgs e)
        {
            if (AlarmActive == false)
            {

                if (!textBox1.Text.ToLower().EndsWith(".mp3") & !textBox1.Text.ToLower().EndsWith(".wma"))
                {
                    MessageBox.Show("You must enter the path to a valid mp3 or wma file");
                    return;
                }
            
                AlarmActive = true;
                snd.open(textBox1.Text);
                AlarmTime = cboHours.SelectedItem + ":" + cboMinutes.SelectedItem + " " + cboAmPm.SelectedItem;
                this.Text = "Alarm Clock - Set: " + AlarmTime;
                //btnSetAlarm.Enabled = false;
                btnSetAlarm.Text = "Disable";
            
                Properties.Settings.Default.MediaFile = textBox1.Text;
                Properties.Settings.Default.Note = txtBoxNote.Text;
                Properties.Settings.Default.Hour = cboHours.SelectedIndex;
                Properties.Settings.Default.Minute = cboMinutes.SelectedIndex;
                Properties.Settings.Default.AMPM = cboAmPm.SelectedIndex;
                Properties.Settings.Default.SnoozeTime = cboSnoozeTime.SelectedIndex;
                Properties.Settings.Default.Save();
            }
            else
            {
                AlarmActive = false;
                this.Text = "Alarm";
                btnSetAlarm.Text = "Activate";
            }

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Playing)
            {
                snd.stop();
                snd.close();
            }

            if (snd.isOpen)
                snd.close();
        }

        private void chkLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLoop.Checked)
            {
                snd.Loop = true;
                Properties.Settings.Default.Loop = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                snd.Loop = false;
                Properties.Settings.Default.Loop = false;
                Properties.Settings.Default.Save();
            }
        }

        private void chkSnooze_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSnooze.Checked)
            {
                canSnooze = true;
                snoozeTime = Int16.Parse(cboSnoozeTime.SelectedItem.ToString());
                Properties.Settings.Default.CanSnooze = true;
                Properties.Settings.Default.Save();
            }
            else if (!chkSnooze.Checked)
            {
                canSnooze = false;
                Properties.Settings.Default.CanSnooze = false;
                Properties.Settings.Default.Save();
            }            
        }

        private void chkActivateStart_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkActivateStart.Checked)
            {
                Properties.Settings.Default.ActivateAtStartup = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.ActivateAtStartup = true;
                Properties.Settings.Default.Save();
            }
        }

        private void chkMin2Tray_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMin2Tray.Checked)
            {
                Properties.Settings.Default.Min2Tray = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Min2Tray = false;
                Properties.Settings.Default.Save();
            }
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            if (chkMin2Tray.Checked)
            {
                this.ShowInTaskbar = false;
                icon.Visible = true;
                icon.ShowBalloonTip(2000, "Alarm Clock", "Running...", ToolTipIcon.Info);
            }
            else
            {
                this.ShowInTaskbar = true;
                icon.Visible = false;
            }
        }

        private void ctxExit_Click(object sender, EventArgs e)
        {
            if (snd.Playing)
            {
                snd.stop();
                snd.close();
            }

            if (snd.isOpen)
            {
                snd.close();
            }

            icon.Visible = false;
            Application.Exit();
        }

        private void ctxShowWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icon.Visible = false;
        }      
    }
}
