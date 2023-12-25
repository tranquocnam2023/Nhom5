namespace AgainTodoList_Nam.views
{
    partial class ToDoList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
			this.pnToDoMain = new System.Windows.Forms.Panel();
			this.btnCompleted = new System.Windows.Forms.Button();
			this.btnSaveCV = new System.Windows.Forms.Button();
			this.btnUpdateCV = new System.Windows.Forms.Button();
			this.btnDeleteCV = new System.Windows.Forms.Button();
			this.btnAddCV = new System.Windows.Forms.Button();
			this.dgvToDoList = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNameCV = new System.Windows.Forms.TextBox();
			this.lbNameCV = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.mnuWorkCompleted = new System.Windows.Forms.ToolStripMenuItem();
			this.pnToDoMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvToDoList)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnToDoMain
			// 
			this.pnToDoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnToDoMain.BackgroundImage")));
			this.pnToDoMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pnToDoMain.Controls.Add(this.btnCompleted);
			this.pnToDoMain.Controls.Add(this.btnSaveCV);
			this.pnToDoMain.Controls.Add(this.btnUpdateCV);
			this.pnToDoMain.Controls.Add(this.btnDeleteCV);
			this.pnToDoMain.Controls.Add(this.btnAddCV);
			this.pnToDoMain.Controls.Add(this.dgvToDoList);
			this.pnToDoMain.Controls.Add(this.txtNameCV);
			this.pnToDoMain.Controls.Add(this.lbNameCV);
			this.pnToDoMain.Controls.Add(this.menuStrip1);
			this.pnToDoMain.Location = new System.Drawing.Point(-9, 3);
			this.pnToDoMain.Name = "pnToDoMain";
			this.pnToDoMain.Size = new System.Drawing.Size(996, 624);
			this.pnToDoMain.TabIndex = 1;
			this.pnToDoMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnToDoMain_Paint);
			// 
			// btnCompleted
			// 
			this.btnCompleted.Image = global::AgainTodoList_Nam.Properties.Resources.icons8_check_20;
			this.btnCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompleted.Location = new System.Drawing.Point(314, 477);
			this.btnCompleted.Name = "btnCompleted";
			this.btnCompleted.Size = new System.Drawing.Size(151, 56);
			this.btnCompleted.TabIndex = 15;
			this.btnCompleted.Text = "&Complete";
			this.btnCompleted.UseVisualStyleBackColor = true;
			this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
			// 
			// btnSaveCV
			// 
			this.btnSaveCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveCV.Image = global::AgainTodoList_Nam.Properties.Resources.icons8_save_25;
			this.btnSaveCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveCV.Location = new System.Drawing.Point(694, 472);
			this.btnSaveCV.Name = "btnSaveCV";
			this.btnSaveCV.Size = new System.Drawing.Size(144, 65);
			this.btnSaveCV.TabIndex = 10;
			this.btnSaveCV.Text = "&Save";
			this.btnSaveCV.UseVisualStyleBackColor = true;
			this.btnSaveCV.Click += new System.EventHandler(this.btnSaveCV_Click);
			// 
			// btnUpdateCV
			// 
			this.btnUpdateCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateCV.Image = global::AgainTodoList_Nam.Properties.Resources.icons8_edit_25;
			this.btnUpdateCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdateCV.Location = new System.Drawing.Point(515, 478);
			this.btnUpdateCV.Name = "btnUpdateCV";
			this.btnUpdateCV.Size = new System.Drawing.Size(141, 65);
			this.btnUpdateCV.TabIndex = 9;
			this.btnUpdateCV.Text = "&Update";
			this.btnUpdateCV.UseVisualStyleBackColor = true;
			this.btnUpdateCV.Click += new System.EventHandler(this.btnUpdateCV_Click);
			// 
			// btnDeleteCV
			// 
			this.btnDeleteCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCV.Image = global::AgainTodoList_Nam.Properties.Resources.icons8_delete_25;
			this.btnDeleteCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteCV.Location = new System.Drawing.Point(694, 401);
			this.btnDeleteCV.Name = "btnDeleteCV";
			this.btnDeleteCV.Size = new System.Drawing.Size(144, 65);
			this.btnDeleteCV.TabIndex = 8;
			this.btnDeleteCV.Text = "&Delete";
			this.btnDeleteCV.UseVisualStyleBackColor = true;
			this.btnDeleteCV.Click += new System.EventHandler(this.btnDeleteCV_Click);
			// 
			// btnAddCV
			// 
			this.btnAddCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCV.Image = global::AgainTodoList_Nam.Properties.Resources.icons8_insert_261;
			this.btnAddCV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddCV.Location = new System.Drawing.Point(515, 401);
			this.btnAddCV.Name = "btnAddCV";
			this.btnAddCV.Size = new System.Drawing.Size(141, 65);
			this.btnAddCV.TabIndex = 7;
			this.btnAddCV.Text = "&Insert";
			this.btnAddCV.UseVisualStyleBackColor = true;
			this.btnAddCV.Click += new System.EventHandler(this.btnAddCV_Click);
			// 
			// dgvToDoList
			// 
			this.dgvToDoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvToDoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
			this.dgvToDoList.Location = new System.Drawing.Point(108, 166);
			this.dgvToDoList.Name = "dgvToDoList";
			this.dgvToDoList.RowHeadersWidth = 51;
			this.dgvToDoList.RowTemplate.Height = 24;
			this.dgvToDoList.Size = new System.Drawing.Size(727, 219);
			this.dgvToDoList.TabIndex = 6;
			this.dgvToDoList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToDoList_CellClick);
			this.dgvToDoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToDoList_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Name";
			this.Column1.HeaderText = "Name";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Created";
			this.Column2.HeaderText = "Start Day";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// txtNameCV
			// 
			this.txtNameCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNameCV.Location = new System.Drawing.Point(201, 416);
			this.txtNameCV.Name = "txtNameCV";
			this.txtNameCV.Size = new System.Drawing.Size(264, 30);
			this.txtNameCV.TabIndex = 3;
			// 
			// lbNameCV
			// 
			this.lbNameCV.AutoSize = true;
			this.lbNameCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameCV.Location = new System.Drawing.Point(112, 419);
			this.lbNameCV.Name = "lbNameCV";
			this.lbNameCV.Size = new System.Drawing.Size(64, 25);
			this.lbNameCV.TabIndex = 2;
			this.lbNameCV.Text = "&Name";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWorkCompleted});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(996, 28);
			this.menuStrip1.TabIndex = 16;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mnuWorkCompleted
			// 
			this.mnuWorkCompleted.Name = "mnuWorkCompleted";
			this.mnuWorkCompleted.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuWorkCompleted.Size = new System.Drawing.Size(134, 24);
			this.mnuWorkCompleted.Text = "Completed Tasks";
			this.mnuWorkCompleted.Click += new System.EventHandler(this.mnuWorkCompleted_Click);
			// 
			// ToDoList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(990, 631);
			this.Controls.Add(this.pnToDoMain);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "ToDoList";
			this.Text = "ToDoList";
			this.Load += new System.EventHandler(this.ToDoList_Load);
			this.pnToDoMain.ResumeLayout(false);
			this.pnToDoMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvToDoList)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNameCV;
        private System.Windows.Forms.Label lbNameCV;
        private System.Windows.Forms.Button btnSaveCV;
        private System.Windows.Forms.Button btnUpdateCV;
        private System.Windows.Forms.Button btnDeleteCV;
        private System.Windows.Forms.Button btnAddCV;
        private System.Windows.Forms.DataGridView dgvToDoList;
        private System.Windows.Forms.Panel pnToDoMain;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuWorkCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}