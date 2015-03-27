namespace NETChrisUsick
{
    partial class frmSalesStaff
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
            this.dgvSalesStaff = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewSalesStaff = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesStaff)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesStaff
            // 
            this.dgvSalesStaff.AllowUserToAddRows = false;
            this.dgvSalesStaff.AllowUserToDeleteRows = false;
            this.dgvSalesStaff.AllowUserToResizeRows = false;
            this.dgvSalesStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesStaff.MultiSelect = false;
            this.dgvSalesStaff.Name = "dgvSalesStaff";
            this.dgvSalesStaff.ReadOnly = true;
            this.dgvSalesStaff.RowHeadersVisible = false;
            this.dgvSalesStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesStaff.ShowCellErrors = false;
            this.dgvSalesStaff.ShowCellToolTips = false;
            this.dgvSalesStaff.ShowEditingIcon = false;
            this.dgvSalesStaff.ShowRowErrors = false;
            this.dgvSalesStaff.Size = new System.Drawing.Size(433, 368);
            this.dgvSalesStaff.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEdit,
            this.mnuRemove});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(118, 48);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(117, 22);
            this.mnuEdit.Text = "Edit";
            // 
            // mnuRemove
            // 
            this.mnuRemove.Name = "mnuRemove";
            this.mnuRemove.Size = new System.Drawing.Size(117, 22);
            this.mnuRemove.Text = "Remove";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(433, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewSalesStaff});
            this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewSalesStaff
            // 
            this.mnuFileNewSalesStaff.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileNewSalesStaff.MergeIndex = 0;
            this.mnuFileNewSalesStaff.Name = "mnuFileNewSalesStaff";
            this.mnuFileNewSalesStaff.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNewSalesStaff.Size = new System.Drawing.Size(206, 22);
            this.mnuFileNewSalesStaff.Text = "&New Sales Staff...";
            // 
            // frmSalesStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 368);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dgvSalesStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesStaff";
            this.ShowIcon = false;
            this.Text = "Sales Staff";
            this.Shown += new System.EventHandler(this.frmSalesStaff_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesStaff)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSalesStaff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuRemove;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewSalesStaff;
    }
}