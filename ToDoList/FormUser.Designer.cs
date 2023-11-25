namespace ToDoList
{
    partial class FormUser
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
			this.pnUserMain = new System.Windows.Forms.Panel();
			this.btnMenu = new System.Windows.Forms.Button();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lbEmail = new System.Windows.Forms.Label();
			this.txtPhoneUser = new System.Windows.Forms.TextBox();
			this.lbPhoneUser = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lbNameUser = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lbId = new System.Windows.Forms.Label();
			this.pnUserMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnUserMain
			// 
			this.pnUserMain.Controls.Add(this.btnMenu);
			this.pnUserMain.Controls.Add(this.txtEmail);
			this.pnUserMain.Controls.Add(this.lbEmail);
			this.pnUserMain.Controls.Add(this.txtPhoneUser);
			this.pnUserMain.Controls.Add(this.lbPhoneUser);
			this.pnUserMain.Controls.Add(this.txtUserName);
			this.pnUserMain.Controls.Add(this.lbNameUser);
			this.pnUserMain.Controls.Add(this.txtId);
			this.pnUserMain.Controls.Add(this.lbId);
			this.pnUserMain.Location = new System.Drawing.Point(0, 3);
			this.pnUserMain.Name = "pnUserMain";
			this.pnUserMain.Size = new System.Drawing.Size(761, 393);
			this.pnUserMain.TabIndex = 0;
			this.pnUserMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUserMain_Paint);
			// 
			// btnMenu
			// 
			this.btnMenu.Location = new System.Drawing.Point(164, 309);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(198, 51);
			this.btnMenu.TabIndex = 8;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = true;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(175, 224);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(499, 22);
			this.txtEmail.TabIndex = 7;
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Location = new System.Drawing.Point(69, 230);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(41, 16);
			this.lbEmail.TabIndex = 6;
			this.lbEmail.Text = "Email";
			// 
			// txtPhoneUser
			// 
			this.txtPhoneUser.Location = new System.Drawing.Point(175, 174);
			this.txtPhoneUser.Name = "txtPhoneUser";
			this.txtPhoneUser.Size = new System.Drawing.Size(499, 22);
			this.txtPhoneUser.TabIndex = 5;
			// 
			// lbPhoneUser
			// 
			this.lbPhoneUser.AutoSize = true;
			this.lbPhoneUser.Location = new System.Drawing.Point(66, 180);
			this.lbPhoneUser.Name = "lbPhoneUser";
			this.lbPhoneUser.Size = new System.Drawing.Size(85, 16);
			this.lbPhoneUser.TabIndex = 4;
			this.lbPhoneUser.Text = "Số điện thoại";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(175, 121);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(499, 22);
			this.txtUserName.TabIndex = 3;
			// 
			// lbNameUser
			// 
			this.lbNameUser.AutoSize = true;
			this.lbNameUser.Location = new System.Drawing.Point(66, 121);
			this.lbNameUser.Name = "lbNameUser";
			this.lbNameUser.Size = new System.Drawing.Size(46, 16);
			this.lbNameUser.TabIndex = 2;
			this.lbNameUser.Text = "Họ tên";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(175, 71);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(499, 22);
			this.txtId.TabIndex = 1;
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Location = new System.Drawing.Point(67, 74);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(18, 16);
			this.lbId.TabIndex = 0;
			this.lbId.Text = "Id";
			// 
			// FormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 396);
			this.Controls.Add(this.pnUserMain);
			this.Name = "FormUser";
			this.Text = "FormUser";
			this.pnUserMain.ResumeLayout(false);
			this.pnUserMain.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnUserMain;
        private System.Windows.Forms.TextBox txtPhoneUser;
        private System.Windows.Forms.Label lbPhoneUser;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbNameUser;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
    }
}