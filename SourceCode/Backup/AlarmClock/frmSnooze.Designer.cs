namespace AlarmClock
{
    partial class frmSnooze
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
            this.btnSnooze = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSnooze
            // 
            this.btnSnooze.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSnooze.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnooze.ForeColor = System.Drawing.Color.Green;
            this.btnSnooze.Location = new System.Drawing.Point(12, 12);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(171, 123);
            this.btnSnooze.TabIndex = 0;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = false;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(189, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 123);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSnooze
            // 
            this.AcceptButton = this.btnSnooze;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(374, 147);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSnooze);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSnooze";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snooze";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Button btnClose;
    }
}