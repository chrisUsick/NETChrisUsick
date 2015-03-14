namespace NETChrisUsick
{
    partial class frmCarWash
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
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.cboFragrance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPst = new System.Windows.Forms.Label();
            this.lblGst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstInterior = new System.Windows.Forms.ListBox();
            this.lstExterior = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.msCarWash = new System.Windows.Forms.MenuStrip();
            this.mnuCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSummary.SuspendLayout();
            this.msCarWash.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Package:";
            // 
            // cboPackage
            // 
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPackage.FormattingEnabled = true;
            this.cboPackage.Location = new System.Drawing.Point(26, 37);
            this.cboPackage.Name = "cboPackage";
            this.cboPackage.Size = new System.Drawing.Size(146, 21);
            this.cboPackage.TabIndex = 0;
            this.cboPackage.SelectedIndexChanged += new System.EventHandler(this.control_Changed);
            // 
            // cboFragrance
            // 
            this.cboFragrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFragrance.FormattingEnabled = true;
            this.cboFragrance.Location = new System.Drawing.Point(209, 37);
            this.cboFragrance.Name = "cboFragrance";
            this.cboFragrance.Size = new System.Drawing.Size(148, 21);
            this.cboFragrance.TabIndex = 1;
            this.cboFragrance.SelectedIndexChanged += new System.EventHandler(this.control_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fragrance:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(272, 268);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPst
            // 
            this.lblPst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPst.Location = new System.Drawing.Point(272, 301);
            this.lblPst.Name = "lblPst";
            this.lblPst.Size = new System.Drawing.Size(100, 23);
            this.lblPst.TabIndex = 6;
            this.lblPst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGst
            // 
            this.lblGst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGst.Location = new System.Drawing.Point(272, 334);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(100, 23);
            this.lblGst.TabIndex = 7;
            this.lblGst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interior:";
            // 
            // lstInterior
            // 
            this.lstInterior.FormattingEnabled = true;
            this.lstInterior.Location = new System.Drawing.Point(10, 50);
            this.lstInterior.Name = "lstInterior";
            this.lstInterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstInterior.Size = new System.Drawing.Size(150, 95);
            this.lstInterior.TabIndex = 1;
            this.lstInterior.TabStop = false;
            // 
            // lstExterior
            // 
            this.lstExterior.FormattingEnabled = true;
            this.lstExterior.Location = new System.Drawing.Point(197, 50);
            this.lstExterior.Name = "lstExterior";
            this.lstExterior.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstExterior.Size = new System.Drawing.Size(148, 95);
            this.lstExterior.TabIndex = 2;
            this.lstExterior.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exterior:";
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.lstExterior);
            this.grpSummary.Controls.Add(this.lstInterior);
            this.grpSummary.Controls.Add(this.label3);
            this.grpSummary.Location = new System.Drawing.Point(12, 92);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(359, 165);
            this.grpSummary.TabIndex = 4;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(272, 367);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PST:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "GST:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total:";
            // 
            // msCarWash
            // 
            this.msCarWash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCarWash});
            this.msCarWash.Location = new System.Drawing.Point(0, 0);
            this.msCarWash.Name = "msCarWash";
            this.msCarWash.Size = new System.Drawing.Size(384, 24);
            this.msCarWash.TabIndex = 13;
            this.msCarWash.Text = "menuStrip1";
            // 
            // mnuCarWash
            // 
            this.mnuCarWash.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateInvoice});
            this.mnuCarWash.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuCarWash.MergeIndex = 1;
            this.mnuCarWash.Name = "mnuCarWash";
            this.mnuCarWash.Size = new System.Drawing.Size(69, 20);
            this.mnuCarWash.Text = "&Car Wash";
            // 
            // mnuGenerateInvoice
            // 
            this.mnuGenerateInvoice.Name = "mnuGenerateInvoice";
            this.mnuGenerateInvoice.Size = new System.Drawing.Size(162, 22);
            this.mnuGenerateInvoice.Text = "Generate &Invoice";
            this.mnuGenerateInvoice.Click += new System.EventHandler(this.mnuGenerateInvoice_Click);
            // 
            // frmCarWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGst);
            this.Controls.Add(this.lblPst);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFragrance);
            this.Controls.Add(this.cboPackage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msCarWash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msCarWash;
            this.MaximizeBox = false;
            this.Name = "frmCarWash";
            this.Text = "Car Wash";
            this.Load += new System.EventHandler(this.frmCarWash_Load);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.msCarWash.ResumeLayout(false);
            this.msCarWash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.ComboBox cboFragrance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPst;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstInterior;
        private System.Windows.Forms.ListBox lstExterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip msCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateInvoice;
    }
}