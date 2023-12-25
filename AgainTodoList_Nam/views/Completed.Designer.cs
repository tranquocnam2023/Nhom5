namespace AgainTodoList_Nam.views
{
    partial class lvCompleted
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
			this.lstViewComplete = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.pnUnfinishedIcon = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// lstViewComplete
			// 
			this.lstViewComplete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstViewComplete.FullRowSelect = true;
			this.lstViewComplete.GridLines = true;
			this.lstViewComplete.HideSelection = false;
			this.lstViewComplete.Location = new System.Drawing.Point(12, 65);
			this.lstViewComplete.Name = "lstViewComplete";
			this.lstViewComplete.Size = new System.Drawing.Size(837, 459);
			this.lstViewComplete.TabIndex = 0;
			this.lstViewComplete.UseCompatibleStateImageBehavior = false;
			this.lstViewComplete.View = System.Windows.Forms.View.Details;
			this.lstViewComplete.SelectedIndexChanged += new System.EventHandler(this.lstViewComplete_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Start Day";
			this.columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "End Day";
			this.columnHeader3.Width = 200;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(267, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 29);
			this.label1.TabIndex = 3;
			this.label1.Text = "List Of Completed Tasks";
			// 
			// pnUnfinishedIcon
			// 
			this.pnUnfinishedIcon.BackgroundImage = global::AgainTodoList_Nam.Properties.Resources.icons8_check_20;
			this.pnUnfinishedIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pnUnfinishedIcon.Location = new System.Drawing.Point(173, 13);
			this.pnUnfinishedIcon.Name = "pnUnfinishedIcon";
			this.pnUnfinishedIcon.Size = new System.Drawing.Size(41, 29);
			this.pnUnfinishedIcon.TabIndex = 4;
			this.pnUnfinishedIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUnfinishedIcon_Paint);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::AgainTodoList_Nam.Properties.Resources.icons8_check_20;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Location = new System.Drawing.Point(591, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(41, 29);
			this.panel1.TabIndex = 5;
			// 
			// lvCompleted
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 536);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnUnfinishedIcon);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstViewComplete);
			this.Name = "lvCompleted";
			this.Text = "Completed";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.lvCompleted_FormClosing);
			this.Load += new System.EventHandler(this.Completed_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewComplete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnUnfinishedIcon;
        private System.Windows.Forms.Panel panel1;
    }
}