namespace Project
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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnklblMainLogout = new System.Windows.Forms.LinkLabel();
            this.lblMainUser = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDatejoined = new System.Windows.Forms.Label();
            this.txtBxChangemail = new System.Windows.Forms.TextBox();
            this.btnChangeMail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnklblMainLogout);
            this.groupBox1.Controls.Add(this.lblMainUser);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lnklblMainLogout
            // 
            this.lnklblMainLogout.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblMainLogout.AutoSize = true;
            this.lnklblMainLogout.LinkColor = System.Drawing.Color.Black;
            this.lnklblMainLogout.Location = new System.Drawing.Point(1177, 19);
            this.lnklblMainLogout.Name = "lnklblMainLogout";
            this.lnklblMainLogout.Size = new System.Drawing.Size(43, 15);
            this.lnklblMainLogout.TabIndex = 1;
            this.lnklblMainLogout.TabStop = true;
            this.lnklblMainLogout.Text = "Logout";
            this.lnklblMainLogout.Click += new System.EventHandler(this.lnklblMainLogout_Click);
            // 
            // lblMainUser
            // 
            this.lblMainUser.AutoSize = true;
            this.lblMainUser.Location = new System.Drawing.Point(6, 19);
            this.lblMainUser.Name = "lblMainUser";
            this.lblMainUser.Size = new System.Drawing.Size(82, 15);
            this.lblMainUser.TabIndex = 0;
            this.lblMainUser.Text = "Welcome Test";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(14, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 483);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(356, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 483);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(117, 185);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChangeMail);
            this.groupBox4.Controls.Add(this.txtBxChangemail);
            this.groupBox4.Controls.Add(this.lblDatejoined);
            this.groupBox4.Controls.Add(this.lblEmail);
            this.groupBox4.Location = new System.Drawing.Point(61, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 218);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Location = new System.Drawing.Point(3, 19);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(174, 196);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email Address";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDatejoined
            // 
            this.lblDatejoined.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDatejoined.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDatejoined.Location = new System.Drawing.Point(25, 52);
            this.lblDatejoined.Name = "lblDatejoined";
            this.lblDatejoined.Size = new System.Drawing.Size(126, 23);
            this.lblDatejoined.TabIndex = 1;
            this.lblDatejoined.Text = "Date Joined";
            this.lblDatejoined.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBxChangemail
            // 
            this.txtBxChangemail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBxChangemail.Location = new System.Drawing.Point(6, 105);
            this.txtBxChangemail.Name = "txtBxChangemail";
            this.txtBxChangemail.Size = new System.Drawing.Size(168, 23);
            this.txtBxChangemail.TabIndex = 2;
            this.txtBxChangemail.Text = "E-mail Address";
            this.txtBxChangemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxChangemail.Click += new System.EventHandler(this.txtBxChangemail_Click);
            // 
            // btnChangeMail
            // 
            this.btnChangeMail.Location = new System.Drawing.Point(28, 157);
            this.btnChangeMail.Name = "btnChangeMail";
            this.btnChangeMail.Size = new System.Drawing.Size(123, 25);
            this.btnChangeMail.TabIndex = 3;
            this.btnChangeMail.Text = "Update E-mail";
            this.btnChangeMail.UseVisualStyleBackColor = true;
            this.btnChangeMail.Click += new System.EventHandler(this.btnChangeMail_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 581);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMainUser;
        private System.Windows.Forms.LinkLabel lnklblMainLogout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChangeMail;
        private System.Windows.Forms.TextBox txtBxChangemail;
        private System.Windows.Forms.Label lblDatejoined;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}