namespace Project
{
    partial class frmAddEvent
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
            this.monthCalendarAddEvent = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.dropDownEvents = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarAddEvent
            // 
            this.monthCalendarAddEvent.Location = new System.Drawing.Point(453, 41);
            this.monthCalendarAddEvent.Name = "monthCalendarAddEvent";
            this.monthCalendarAddEvent.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEventName);
            this.groupBox1.Controls.Add(this.dropDownEvents);
            this.groupBox1.Location = new System.Drawing.Point(44, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.MintCream;
            this.lblEventName.Location = new System.Drawing.Point(6, 22);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(128, 18);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Choose a time slot: ";
            this.lblEventName.Click += new System.EventHandler(this.lblEventName_Click);
            // 
            // dropDownEvents
            // 
            this.dropDownEvents.FormattingEnabled = true;
            this.dropDownEvents.Location = new System.Drawing.Point(137, 22);
            this.dropDownEvents.Name = "dropDownEvents";
            this.dropDownEvents.Size = new System.Drawing.Size(206, 21);
            this.dropDownEvents.TabIndex = 0;
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(696, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendarAddEvent);
            this.Name = "frmAddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarAddEvent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.ComboBox dropDownEvents;
    }
}