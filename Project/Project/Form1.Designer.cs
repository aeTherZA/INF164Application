namespace Project
{
    partial class frmLogin
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtBxUser = new System.Windows.Forms.TextBox();
            this.txtBxPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.lnklblSignUp = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpBxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(250, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to <To be named>";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(74, 65);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(147, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Enter your login details below.";
            // 
            // txtBxUser
            // 
            this.txtBxUser.Location = new System.Drawing.Point(37, 35);
            this.txtBxUser.Name = "txtBxUser";
            this.txtBxUser.Size = new System.Drawing.Size(144, 20);
            this.txtBxUser.TabIndex = 2;
            this.txtBxUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxUser_MouseDown);
            // 
            // txtBxPass
            // 
            this.txtBxPass.Location = new System.Drawing.Point(37, 77);
            this.txtBxPass.Name = "txtBxPass";
            this.txtBxPass.PasswordChar = '*';
            this.txtBxPass.Size = new System.Drawing.Size(144, 20);
            this.txtBxPass.TabIndex = 3;
            this.txtBxPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxPass_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUser.Location = new System.Drawing.Point(69, 16);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPass.Location = new System.Drawing.Point(72, 58);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(68, 16);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.Controls.Add(this.lnklblSignUp);
            this.grpBxLogin.Controls.Add(this.label1);
            this.grpBxLogin.Controls.Add(this.btnLogin);
            this.grpBxLogin.Controls.Add(this.lblUser);
            this.grpBxLogin.Controls.Add(this.txtBxPass);
            this.grpBxLogin.Controls.Add(this.lblPass);
            this.grpBxLogin.Controls.Add(this.txtBxUser);
            this.grpBxLogin.Location = new System.Drawing.Point(40, 81);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Size = new System.Drawing.Size(220, 161);
            this.grpBxLogin.TabIndex = 6;
            this.grpBxLogin.TabStop = false;
            // 
            // lnklblSignUp
            // 
            this.lnklblSignUp.ActiveLinkColor = System.Drawing.Color.OrangeRed;
            this.lnklblSignUp.AutoSize = true;
            this.lnklblSignUp.LinkColor = System.Drawing.Color.Teal;
            this.lnklblSignUp.Location = new System.Drawing.Point(99, 139);
            this.lnklblSignUp.Name = "lnklblSignUp";
            this.lnklblSignUp.Size = new System.Drawing.Size(48, 13);
            this.lnklblSignUp.TabIndex = 8;
            this.lnklblSignUp.TabStop = true;
            this.lnklblSignUp.Text = "Sign Up!";
            this.lnklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSignUp_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Not yet a member?";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 274);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWelcome);
            this.Name = "frmLogin";
            this.Text = "Log In Menu";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtBxUser;
        private System.Windows.Forms.TextBox txtBxPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.LinkLabel lnklblSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
    }
}

