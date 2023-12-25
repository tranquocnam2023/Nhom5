namespace AgainTodoList_Nam.views
{
    partial class Login
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.timeWelCome = new System.Windows.Forms.Timer(this.components);
			this.pnLogin = new System.Windows.Forms.Panel();
			this.lbWelcome = new System.Windows.Forms.Label();
			this.picLoginUser = new System.Windows.Forms.PictureBox();
			this.cmbEmail = new System.Windows.Forms.ComboBox();
			this.btnSignUp = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPasswordLogin = new System.Windows.Forms.TextBox();
			this.lbPasswordLogin = new System.Windows.Forms.Label();
			this.lbEmailLogin = new System.Windows.Forms.Label();
			this.pnLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoginUser)).BeginInit();
			this.SuspendLayout();
			// 
			// timeWelCome
			// 
			this.timeWelCome.Tick += new System.EventHandler(this.timeWelCome_Tick);
			// 
			// pnLogin
			// 
			this.pnLogin.BackgroundImage = global::AgainTodoList_Nam.Properties.Resources.logintodolist;
			this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnLogin.Controls.Add(this.lbWelcome);
			this.pnLogin.Controls.Add(this.picLoginUser);
			this.pnLogin.Controls.Add(this.cmbEmail);
			this.pnLogin.Controls.Add(this.btnSignUp);
			this.pnLogin.Controls.Add(this.btnLogin);
			this.pnLogin.Controls.Add(this.txtPasswordLogin);
			this.pnLogin.Controls.Add(this.lbPasswordLogin);
			this.pnLogin.Controls.Add(this.lbEmailLogin);
			this.pnLogin.Location = new System.Drawing.Point(0, 5);
			this.pnLogin.Name = "pnLogin";
			this.pnLogin.Size = new System.Drawing.Size(831, 538);
			this.pnLogin.TabIndex = 0;
			// 
			// lbWelcome
			// 
			this.lbWelcome.AutoSize = true;
			this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWelcome.ForeColor = System.Drawing.Color.Black;
			this.lbWelcome.Location = new System.Drawing.Point(251, 34);
			this.lbWelcome.Name = "lbWelcome";
			this.lbWelcome.Size = new System.Drawing.Size(345, 36);
			this.lbWelcome.TabIndex = 14;
			this.lbWelcome.Text = "Welcome To Do List App";
			// 
			// picLoginUser
			// 
			this.picLoginUser.Image = global::AgainTodoList_Nam.Properties.Resources.userLoginImg;
			this.picLoginUser.Location = new System.Drawing.Point(484, 162);
			this.picLoginUser.Name = "picLoginUser";
			this.picLoginUser.Size = new System.Drawing.Size(300, 268);
			this.picLoginUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picLoginUser.TabIndex = 13;
			this.picLoginUser.TabStop = false;
			// 
			// cmbEmail
			// 
			this.cmbEmail.BackColor = System.Drawing.Color.White;
			this.cmbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbEmail.FormattingEnabled = true;
			this.cmbEmail.Location = new System.Drawing.Point(68, 203);
			this.cmbEmail.Name = "cmbEmail";
			this.cmbEmail.Size = new System.Drawing.Size(346, 33);
			this.cmbEmail.TabIndex = 12;
			this.cmbEmail.SelectedIndexChanged += new System.EventHandler(this.cmbEmail_SelectedIndexChanged);
			// 
			// btnSignUp
			// 
			this.btnSignUp.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSignUp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
			this.btnSignUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSignUp.Location = new System.Drawing.Point(257, 390);
			this.btnSignUp.Name = "btnSignUp";
			this.btnSignUp.Size = new System.Drawing.Size(157, 58);
			this.btnSignUp.TabIndex = 11;
			this.btnSignUp.Text = "Sign Up";
			this.btnSignUp.UseVisualStyleBackColor = false;
			this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.SystemColors.MenuBar;
			this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
			this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogin.Location = new System.Drawing.Point(55, 390);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(155, 58);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
			// 
			// txtPasswordLogin
			// 
			this.txtPasswordLogin.BackColor = System.Drawing.Color.White;
			this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasswordLogin.Location = new System.Drawing.Point(66, 320);
			this.txtPasswordLogin.Name = "txtPasswordLogin";
			this.txtPasswordLogin.Size = new System.Drawing.Size(349, 30);
			this.txtPasswordLogin.TabIndex = 9;
			this.txtPasswordLogin.TextChanged += new System.EventHandler(this.txtPasswordLogin_TextChanged);
			// 
			// lbPasswordLogin
			// 
			this.lbPasswordLogin.AutoSize = true;
			this.lbPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPasswordLogin.Location = new System.Drawing.Point(60, 264);
			this.lbPasswordLogin.Name = "lbPasswordLogin";
			this.lbPasswordLogin.Size = new System.Drawing.Size(146, 32);
			this.lbPasswordLogin.TabIndex = 8;
			this.lbPasswordLogin.Text = "Password";
			// 
			// lbEmailLogin
			// 
			this.lbEmailLogin.AutoSize = true;
			this.lbEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEmailLogin.Location = new System.Drawing.Point(60, 160);
			this.lbEmailLogin.Name = "lbEmailLogin";
			this.lbEmailLogin.Size = new System.Drawing.Size(91, 32);
			this.lbEmailLogin.TabIndex = 7;
			this.lbEmailLogin.Text = "Email";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 550);
			this.Controls.Add(this.pnLogin);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.pnLogin.ResumeLayout(false);
			this.pnLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLoginUser)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.ComboBox cmbEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label lbPasswordLogin;
        private System.Windows.Forms.Label lbEmailLogin;
        private System.Windows.Forms.PictureBox picLoginUser;
        private System.Windows.Forms.Timer timeWelCome;
        private System.Windows.Forms.Label lbWelcome;
    }
}