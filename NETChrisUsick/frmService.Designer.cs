namespace NETChrisUsick
{
    partial class frmService
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.colItemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDgvService = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextClear = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.msServiceMenu = new System.Windows.Forms.MenuStrip();
            this.mnuService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServiceGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.cmsDgvService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.msServiceMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type:";
            // 
            // txtDescription
            // 
            this.errorProvider.SetIconPadding(this.txtDescription, 3);
            this.txtDescription.Location = new System.Drawing.Point(82, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(243, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.control_Validated);
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.errorProvider.SetIconPadding(this.cboType, 3);
            this.cboType.Items.AddRange(new object[] {
            "Labour",
            "Parts",
            "Material"});
            this.cboType.Location = new System.Drawing.Point(83, 57);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 3;
            this.cboType.Validating += new System.ComponentModel.CancelEventHandler(this.cboType_Validating);
            this.cboType.Validated += new System.EventHandler(this.control_Validated);
            // 
            // txtCost
            // 
            this.errorProvider.SetIconPadding(this.txtCost, 3);
            this.txtCost.Location = new System.Drawing.Point(83, 95);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 4;
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCost.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            this.txtCost.Validated += new System.EventHandler(this.control_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(433, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AllowUserToResizeColumns = false;
            this.dgvServices.AllowUserToResizeRows = false;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNumber,
            this.colItemDescription,
            this.colCostType,
            this.colItemCost});
            this.dgvServices.ContextMenuStrip = this.cmsDgvService;
            this.dgvServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServices.Location = new System.Drawing.Point(13, 130);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.ShowEditingIcon = false;
            this.dgvServices.Size = new System.Drawing.Size(495, 192);
            this.dgvServices.TabIndex = 7;
            this.dgvServices.TabStop = false;
            this.dgvServices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvServices_RowsAdded);
            this.dgvServices.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvServices_RowsRemoved);
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // colItemNumber
            // 
            this.colItemNumber.HeaderText = "#";
            this.colItemNumber.Name = "colItemNumber";
            this.colItemNumber.ReadOnly = true;
            this.colItemNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemNumber.Width = 40;
            // 
            // colItemDescription
            // 
            this.colItemDescription.HeaderText = "Description";
            this.colItemDescription.Name = "colItemDescription";
            this.colItemDescription.ReadOnly = true;
            this.colItemDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colItemDescription.Width = 235;
            // 
            // colCostType
            // 
            this.colCostType.HeaderText = "Type";
            this.colCostType.Name = "colCostType";
            this.colCostType.ReadOnly = true;
            this.colCostType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCostType.Width = 120;
            // 
            // colItemCost
            // 
            this.colItemCost.HeaderText = "Cost";
            this.colItemCost.Name = "colItemCost";
            this.colItemCost.ReadOnly = true;
            this.colItemCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmsDgvService
            // 
            this.cmsDgvService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextClear});
            this.cmsDgvService.Name = "cmsDgvService";
            this.cmsDgvService.Size = new System.Drawing.Size(102, 26);
            // 
            // mnuContextClear
            // 
            this.mnuContextClear.Enabled = false;
            this.mnuContextClear.Name = "mnuContextClear";
            this.mnuContextClear.Size = new System.Drawing.Size(101, 22);
            this.mnuContextClear.Text = "Clear";
            this.mnuContextClear.Click += new System.EventHandler(this.mnuContextClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(419, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGST
            // 
            this.lblGST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGST.Location = new System.Drawing.Point(419, 402);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(89, 23);
            this.lblGST.TabIndex = 9;
            this.lblGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "GST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total:";
            // 
            // lblPST
            // 
            this.lblPST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPST.Location = new System.Drawing.Point(419, 370);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(89, 23);
            this.lblPST.TabIndex = 12;
            this.lblPST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(419, 337);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(89, 23);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "PST:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Subtotal:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // msServiceMenu
            // 
            this.msServiceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuService});
            this.msServiceMenu.Location = new System.Drawing.Point(0, 0);
            this.msServiceMenu.Name = "msServiceMenu";
            this.msServiceMenu.Size = new System.Drawing.Size(520, 24);
            this.msServiceMenu.TabIndex = 16;
            this.msServiceMenu.Text = "menuStrip1";
            this.msServiceMenu.Visible = false;
            // 
            // mnuService
            // 
            this.mnuService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuServiceGenerateInvoice});
            this.mnuService.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuService.MergeIndex = 1;
            this.mnuService.Name = "mnuService";
            this.mnuService.Size = new System.Drawing.Size(56, 20);
            this.mnuService.Text = "&Service";
            // 
            // mnuServiceGenerateInvoice
            // 
            this.mnuServiceGenerateInvoice.Enabled = false;
            this.mnuServiceGenerateInvoice.Name = "mnuServiceGenerateInvoice";
            this.mnuServiceGenerateInvoice.Size = new System.Drawing.Size(162, 22);
            this.mnuServiceGenerateInvoice.Text = "Generate &Invoice";
            this.mnuServiceGenerateInvoice.Click += new System.EventHandler(this.mnuServiceGenerateInvoice_Click);
            // 
            // frmService
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msServiceMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msServiceMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmService";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.frmService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.cmsDgvService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.msServiceMenu.ResumeLayout(false);
            this.msServiceMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip msServiceMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuService;
        private System.Windows.Forms.ToolStripMenuItem mnuServiceGenerateInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCost;
        private System.Windows.Forms.ContextMenuStrip cmsDgvService;
        private System.Windows.Forms.ToolStripMenuItem mnuContextClear;
    }
}