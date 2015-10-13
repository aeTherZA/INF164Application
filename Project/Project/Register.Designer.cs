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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxRegister = new System.Windows.Forms.GroupBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtBxRegisterEmail = new System.Windows.Forms.TextBox();
            this.txtBxRegisterPass = new System.Windows.Forms.TextBox();
            this.txtBxRegisterUser = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.grpBxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please provide your details below.";
            // 
            // grpBxRegister
            // 
            this.grpBxRegister.Controls.Add(this.btnRegister);
            this.grpBxRegister.Controls.Add(this.txtBxRegisterEmail);
            this.grpBxRegister.Controls.Add(this.txtBxRegisterPass);
            this.grpBxRegister.Controls.Add(this.txtBxRegisterUser);
            this.grpBxRegister.Controls.Add(this.lblEmail);
            this.grpBxRegister.Controls.Add(this.lblPass);
            this.grpBxRegister.Controls.Add(this.lblUsername);
            this.grpBxRegister.Location = new System.Drawing.Point(12, 63);
            this.grpBxRegister.Name = "grpBxRegister";
            this.grpBxRegister.Size = new System.Drawing.Size(291, 184);
            this.grpBxRegister.TabIndex = 1;
            this.grpBxRegister.TabStop = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(143, 155);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtBxRegisterEmail
            // 
            this.txtBxRegisterEmail.Location = new System.Drawing.Point(107, 115);
            this.txtBxRegisterEmail.Name = "txtBxRegisterEmail";
            this.txtBxRegisterEmail.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterEmail.TabIndex = 5;
            this.txtBxRegisterEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterEmail_MouseDown);
            // 
            // txtBxRegisterPass
            // 
            this.txtBxRegisterPass.Location = new System.Drawing.Point(107, 73);
            this.txtBxRegisterPass.Name = "txtBxRegisterPass";
            this.txtBxRegisterPass.PasswordChar = '*';
            this.txtBxRegisterPass.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterPass.TabIndex = 4;
            this.txtBxRegisterPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterPass_MouseDown);
            // 
            // txtBxRegisterUser
            // 
            this.txtBxRegisterUser.Location = new System.Drawing.Point(107, 30);
            this.txtBxRegisterUser.Name = "txtBxRegisterUser";
            this.txtBxRegisterUser.Size = new System.Drawing.Size(150, 20);
            this.txtBxRegisterUser.TabIndex = 3;
            this.txtBxRegisterUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBxRegisterUser_MouseDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(16, 73);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 30);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 259);
            this.Controls.Add(this.grpBxRegister);
            this.Controls.Add(this.label1);
            this.Name = "frmRegister";
            this.Text = "User Registration";
            this.grpBxRegister.ResumeLayout(false);
            this.grpBxRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxRegister;
        private System.Windows.Forms.TextBox txtBxRegisterEmail;
        private System.Windows.Forms.TextBox txtBxRegisterPass;
        private System.Windows.Forms.TextBox txtBxRegisterUser;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnRegister;
    }
}