namespace Project
{
    partial class frmRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBxRegisterUser = new System.Windows.Forms.TextBox();
            this.txtBxRegisterPass = new System.Windows.Forms.TextBox();
            this.txtBxRegisterEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpBxRegister = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxRegister.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(18, 59);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(39, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtBxRegisterUser
            // 
            this.txtBxRegisterUser.Location = new System.Drawing.Point(107, 30);
            this.txtBxRegisterUser.Name = "txtBxRegisterUser";
            this.txtBxRegisterUser.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterUser.TabIndex = 3;
            this.txtBxRegisterUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterUser_MouseDown);
            // 
            // txtBxRegisterPass
            // 
            this.txtBxRegisterPass.Location = new System.Drawing.Point(107, 56);
            this.txtBxRegisterPass.Name = "txtBxRegisterPass";
            this.txtBxRegisterPass.PasswordChar = '*';
            this.txtBxRegisterPass.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterPass.TabIndex = 4;
            this.txtBxRegisterPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterPass_MouseDown);
            // 
            // txtBxRegisterEmail
            // 
            this.txtBxRegisterEmail.Location = new System.Drawing.Point(107, 82);
            this.txtBxRegisterEmail.Name = "txtBxRegisterEmail";
            this.txtBxRegisterEmail.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterEmail.TabIndex = 5;
            this.txtBxRegisterEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterEmail_MouseDown);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(161, 208);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpBxRegister
            // 
            this.grpBxRegister.Controls.Add(this.txtBxRegisterEmail);
            this.grpBxRegister.Controls.Add(this.txtBxRegisterPass);
            this.grpBxRegister.Controls.Add(this.txtBxRegisterUser);
            this.grpBxRegister.Controls.Add(this.lblEmail);
            this.grpBxRegister.Controls.Add(this.lblPass);
            this.grpBxRegister.Controls.Add(this.lblUsername);
            this.grpBxRegister.Location = new System.Drawing.Point(54, 82);
            this.grpBxRegister.Name = "grpBxRegister";
            this.grpBxRegister.Size = new System.Drawing.Size(291, 120);
            this.grpBxRegister.TabIndex = 1;
            this.grpBxRegister.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 78);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nice to meet you,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your ticket to managing your studies is  just a few clicks away !";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 245);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBxRegister);
            this.Name = "frmRegister";
            this.Text = "User Registration";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.grpBxRegister.ResumeLayout(false);
            this.grpBxRegister.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBxRegisterUser;
        private System.Windows.Forms.TextBox txtBxRegisterPass;
        private System.Windows.Forms.TextBox txtBxRegisterEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpBxRegister;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}