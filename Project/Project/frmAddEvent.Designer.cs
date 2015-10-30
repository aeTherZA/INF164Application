﻿namespace Project
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
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.txtBxEventName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
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
            this.monthCalendarAddEvent.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarAddEvent_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentDate);
            this.groupBox1.Controls.Add(this.txtBxEventName);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.btnAddEvent);
            this.groupBox1.Controls.Add(this.lblEventName);
            this.groupBox1.Controls.Add(this.dropDownEvents);
            this.groupBox1.Location = new System.Drawing.Point(44, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.ForeColor = System.Drawing.Color.MintCream;
            this.lblCurrentDate.Location = new System.Drawing.Point(49, 14);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentDate.TabIndex = 5;
            // 
            // txtBxEventName
            // 
            this.txtBxEventName.Location = new System.Drawing.Point(137, 78);
            this.txtBxEventName.Name = "txtBxEventName";
            this.txtBxEventName.Size = new System.Drawing.Size(205, 20);
            this.txtBxEventName.TabIndex = 4;
            this.txtBxEventName.Click += new System.EventHandler(this.txtBxEventName_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.MintCream;
            this.lblSubject.Location = new System.Drawing.Point(49, 81);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(85, 18);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Event name:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(78, 132);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(194, 23);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.ForeColor = System.Drawing.Color.MintCream;
            this.lblEventName.Location = new System.Drawing.Point(6, 37);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(128, 18);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Choose a time slot: ";
            this.lblEventName.Click += new System.EventHandler(this.lblEventName_Click);
            // 
            // dropDownEvents
            // 
            this.dropDownEvents.FormattingEnabled = true;
            this.dropDownEvents.Items.AddRange(new object[] {
            "07:30-08:30",
            "08:30-09:30",
            "09:30-10:30",
            "10:30-11:30",
            "11:30-12:30",
            "12:30-13:30",
            "13:30-14:30",
            "14:30-15:30",
            "15:30-16:30",
            "16:30-17:30",
            "17:30-18:30"});
            this.dropDownEvents.Location = new System.Drawing.Point(137, 37);
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
        private System.Windows.Forms.TextBox txtBxEventName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label lblCurrentDate;
    }
}