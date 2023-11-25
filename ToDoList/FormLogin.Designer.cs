namespace ToDoList
{
    partial class FormLogin
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
			this.pnMainLogin = new System.Windows.Forms.Panel();
			this.grbLogin = new System.Windows.Forms.GroupBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPasswordLogin = new System.Windows.Forms.TextBox();
			this.lbPasswordLogin = new System.Windows.Forms.Label();
			this.txtUsernameLogin = new System.Windows.Forms.TextBox();
			this.lbUserLogin = new System.Windows.Forms.Label();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.pnMainLogin.SuspendLayout();
			this.grbLogin.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnMainLogin
			// 
			this.pnMainLogin.Controls.Add(this.grbLogin);
			this.pnMainLogin.Location = new System.Drawing.Point(0, 3);
			this.pnMainLogin.Name = "pnMainLogin";
			this.pnMainLogin.Size = new System.Drawing.Size(947, 536);
			this.pnMainLogin.TabIndex = 0;
			this.pnMainLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMainLogin_Paint);
			// 
			// grbLogin
			// 
			this.grbLogin.Controls.Add(this.btnLogin);
			this.grbLogin.Controls.Add(this.txtPasswordLogin);
			this.grbLogin.Controls.Add(this.lbPasswordLogin);
			this.grbLogin.Controls.Add(this.txtUsernameLogin);
			this.grbLogin.Controls.Add(this.lbUserLogin);
			this.grbLogin.Controls.Add(this.lbWelcome);
			this.grbLogin.Location = new System.Drawing.Point(158, 121);
			this.grbLogin.Name = "grbLogin";
			this.grbLogin.Size = new System.Drawing.Size(562, 291);
			this.grbLogin.TabIndex = 0;
			this.grbLogin.TabStop = false;
			this.grbLogin.Text = "Login";
			this.grbLogin.Enter += new System.EventHandler(this.grbLogin_Enter);
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(71, 207);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(187, 43);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPasswordLogin
			// 
			this.txtPasswordLogin.Location = new System.Drawing.Point(141, 148);
			this.txtPasswordLogin.Name = "txtPasswordLogin";
			this.txtPasswordLogin.PasswordChar = '*';
			this.txtPasswordLogin.Size = new System.Drawing.Size(317, 22);
			this.txtPasswordLogin.TabIndex = 4;
			// 
			// lbPasswordLogin
			// 
			this.lbPasswordLogin.AutoSize = true;
			this.lbPasswordLogin.Location = new System.Drawing.Point(58, 148);
			this.lbPasswordLogin.Name = "lbPasswordLogin";
			this.lbPasswordLogin.Size = new System.Drawing.Size(67, 16);
			this.lbPasswordLogin.TabIndex = 3;
			this.lbPasswordLogin.Text = "Password";
			// 
			// txtUsernameLogin
			// 
			this.txtUsernameLogin.Location = new System.Drawing.Point(141, 103);
			this.txtUsernameLogin.Name = "txtUsernameLogin";
			this.txtUsernameLogin.Size = new System.Drawing.Size(317, 22);
			this.txtUsernameLogin.TabIndex = 2;
			// 
			// lbUserLogin
			// 
			this.lbUserLogin.AutoSize = true;
			this.lbUserLogin.Location = new System.Drawing.Point(56, 103);
			this.lbUserLogin.Name = "lbUserLogin";
			this.lbUserLogin.Size = new System.Drawing.Size(70, 16);
			this.lbUserLogin.TabIndex = 1;
			this.lbUserLogin.Text = "Username";
			// 
			// lbWelcome
			// 
			this.lbWelcome.AutoSize = true;
			this.lbWelcome.Location = new System.Drawing.Point(58, 55);
			this.lbWelcome.Name = "lbWelcome";
			this.lbWelcome.Size = new System.Drawing.Size(178, 16);
			this.lbWelcome.TabIndex = 0;
			this.lbWelcome.Text = "Chào mừng đến với TodoList";
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 540);
			this.Controls.Add(this.pnMainLogin);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.pnMainLogin.ResumeLayout(false);
			this.grbLogin.ResumeLayout(false);
			this.grbLogin.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMainLogin;
        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lbPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Label lbUserLogin;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Button btnLogin;
    }
}

