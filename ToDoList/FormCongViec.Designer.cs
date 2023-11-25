namespace ToDoList
{
    partial class FormCongViec
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
			this.pnCongViecMain = new System.Windows.Forms.Panel();
			this.txtTim = new System.Windows.Forms.TextBox();
			this.lbTim = new System.Windows.Forms.Label();
			this.dgvCongViec = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAddCongViec = new System.Windows.Forms.Button();
			this.dptNgayBD = new System.Windows.Forms.DateTimePicker();
			this.lbNgayBD = new System.Windows.Forms.Label();
			this.txtTenCongViec = new System.Windows.Forms.TextBox();
			this.lbTenCongViec = new System.Windows.Forms.Label();
			this.txtIdCongViec = new System.Windows.Forms.TextBox();
			this.lbIdCongViec = new System.Windows.Forms.Label();
			this.pnCongViecMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).BeginInit();
			this.SuspendLayout();
			// 
			// pnCongViecMain
			// 
			this.pnCongViecMain.Controls.Add(this.txtTim);
			this.pnCongViecMain.Controls.Add(this.lbTim);
			this.pnCongViecMain.Controls.Add(this.dgvCongViec);
			this.pnCongViecMain.Controls.Add(this.btnTim);
			this.pnCongViecMain.Controls.Add(this.btnDelete);
			this.pnCongViecMain.Controls.Add(this.btnEdit);
			this.pnCongViecMain.Controls.Add(this.btnAddCongViec);
			this.pnCongViecMain.Controls.Add(this.dptNgayBD);
			this.pnCongViecMain.Controls.Add(this.lbNgayBD);
			this.pnCongViecMain.Controls.Add(this.txtTenCongViec);
			this.pnCongViecMain.Controls.Add(this.lbTenCongViec);
			this.pnCongViecMain.Controls.Add(this.txtIdCongViec);
			this.pnCongViecMain.Controls.Add(this.lbIdCongViec);
			this.pnCongViecMain.Location = new System.Drawing.Point(4, 6);
			this.pnCongViecMain.Name = "pnCongViecMain";
			this.pnCongViecMain.Size = new System.Drawing.Size(989, 569);
			this.pnCongViecMain.TabIndex = 0;
			this.pnCongViecMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnCongViecMain_Paint);
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(165, 236);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(376, 22);
			this.txtTim.TabIndex = 12;
			// 
			// lbTim
			// 
			this.lbTim.AutoSize = true;
			this.lbTim.Location = new System.Drawing.Point(59, 239);
			this.lbTim.Name = "lbTim";
			this.lbTim.Size = new System.Drawing.Size(95, 16);
			this.lbTim.TabIndex = 11;
			this.lbTim.Text = "Tìm Công Việc";
			// 
			// dgvCongViec
			// 
			this.dgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvCongViec.Location = new System.Drawing.Point(56, 345);
			this.dgvCongViec.Name = "dgvCongViec";
			this.dgvCongViec.RowHeadersWidth = 51;
			this.dgvCongViec.RowTemplate.Height = 24;
			this.dgvCongViec.Size = new System.Drawing.Size(848, 204);
			this.dgvCongViec.TabIndex = 10;
			this.dgvCongViec.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongViec_RowEnter);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "Id";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "Tên Công Việc";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Time";
			this.Column3.HeaderText = "Ngày Bắt Đầu";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(590, 214);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(133, 41);
			this.btnTim.TabIndex = 9;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(590, 137);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(133, 41);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(590, 81);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(133, 41);
			this.btnEdit.TabIndex = 7;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnAddCongViec
			// 
			this.btnAddCongViec.Location = new System.Drawing.Point(590, 25);
			this.btnAddCongViec.Name = "btnAddCongViec";
			this.btnAddCongViec.Size = new System.Drawing.Size(133, 41);
			this.btnAddCongViec.TabIndex = 6;
			this.btnAddCongViec.Text = "Thêm";
			this.btnAddCongViec.UseVisualStyleBackColor = true;
			this.btnAddCongViec.Click += new System.EventHandler(this.btnAddCongViec_Click);
			// 
			// dptNgayBD
			// 
			this.dptNgayBD.Location = new System.Drawing.Point(165, 137);
			this.dptNgayBD.Name = "dptNgayBD";
			this.dptNgayBD.Size = new System.Drawing.Size(372, 22);
			this.dptNgayBD.TabIndex = 5;
			// 
			// lbNgayBD
			// 
			this.lbNgayBD.AutoSize = true;
			this.lbNgayBD.Location = new System.Drawing.Point(53, 140);
			this.lbNgayBD.Name = "lbNgayBD";
			this.lbNgayBD.Size = new System.Drawing.Size(90, 16);
			this.lbNgayBD.TabIndex = 4;
			this.lbNgayBD.Text = "Ngày Bắt Đầu";
			// 
			// txtTenCongViec
			// 
			this.txtTenCongViec.Location = new System.Drawing.Point(162, 93);
			this.txtTenCongViec.Name = "txtTenCongViec";
			this.txtTenCongViec.Size = new System.Drawing.Size(376, 22);
			this.txtTenCongViec.TabIndex = 3;
			// 
			// lbTenCongViec
			// 
			this.lbTenCongViec.AutoSize = true;
			this.lbTenCongViec.Location = new System.Drawing.Point(53, 93);
			this.lbTenCongViec.Name = "lbTenCongViec";
			this.lbTenCongViec.Size = new System.Drawing.Size(96, 16);
			this.lbTenCongViec.TabIndex = 2;
			this.lbTenCongViec.Text = "Tên Công Việc";
			// 
			// txtIdCongViec
			// 
			this.txtIdCongViec.Location = new System.Drawing.Point(162, 44);
			this.txtIdCongViec.Name = "txtIdCongViec";
			this.txtIdCongViec.Size = new System.Drawing.Size(376, 22);
			this.txtIdCongViec.TabIndex = 1;
			this.txtIdCongViec.TextChanged += new System.EventHandler(this.txtIdCongViec_TextChanged);
			// 
			// lbIdCongViec
			// 
			this.lbIdCongViec.AutoSize = true;
			this.lbIdCongViec.Location = new System.Drawing.Point(53, 50);
			this.lbIdCongViec.Name = "lbIdCongViec";
			this.lbIdCongViec.Size = new System.Drawing.Size(18, 16);
			this.lbIdCongViec.TabIndex = 0;
			this.lbIdCongViec.Text = "Id";
			// 
			// FormCongViec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(995, 587);
			this.Controls.Add(this.pnCongViecMain);
			this.Name = "FormCongViec";
			this.Text = "FormCongViec";
			this.pnCongViecMain.ResumeLayout(false);
			this.pnCongViecMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCongViec)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCongViecMain;
        private System.Windows.Forms.Label lbTenCongViec;
        private System.Windows.Forms.TextBox txtIdCongViec;
        private System.Windows.Forms.Label lbIdCongViec;
        private System.Windows.Forms.Button btnAddCongViec;
        private System.Windows.Forms.DateTimePicker dptNgayBD;
        private System.Windows.Forms.Label lbNgayBD;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}