﻿namespace NETChrisUsick
{
    partial class frmQuote
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
            this.txtTradeIn = new System.Windows.Forms.TextBox();
            this.grpAccessories = new System.Windows.Forms.GroupBox();
            this.chkNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeather = new System.Windows.Forms.CheckBox();
            this.chkStereo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFinish = new System.Windows.Forms.GroupBox();
            this.radCustomDetail = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.lnkReset = new System.Windows.Forms.LinkLabel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTradeIn = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTaxLabel = new System.Windows.Forms.Label();
            this.lblSaleTax = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.msSalesQuote = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileAcceptQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFinance = new System.Windows.Forms.GroupBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hsbInterestRate = new System.Windows.Forms.HScrollBar();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hsbNoYears = new System.Windows.Forms.HScrollBar();
            this.lblNoYears = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboVehicleStock = new System.Windows.Forms.ComboBox();
            this.grpAccessories.SuspendLayout();
            this.grpFinish.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.msSalesQuote.SuspendLayout();
            this.grpFinance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle\'s S&tock #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "T&rade-in Allowance:";
            // 
            // txtTradeIn
            // 
            this.errorProvider.SetIconPadding(this.txtTradeIn, 3);
            this.txtTradeIn.Location = new System.Drawing.Point(133, 57);
            this.txtTradeIn.Name = "txtTradeIn";
            this.txtTradeIn.Size = new System.Drawing.Size(113, 20);
            this.txtTradeIn.TabIndex = 3;
            this.txtTradeIn.Text = "0";
            this.txtTradeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTradeIn.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            this.txtTradeIn.VisibleChanged += new System.EventHandler(this.control_Validated);
            this.txtTradeIn.Enter += new System.EventHandler(this.textbox_Enter);
            this.txtTradeIn.Validating += new System.ComponentModel.CancelEventHandler(this.textboxIsNumeric_Validating);
            this.txtTradeIn.Validated += new System.EventHandler(this.control_Validated);
            // 
            // grpAccessories
            // 
            this.grpAccessories.Controls.Add(this.chkNavigation);
            this.grpAccessories.Controls.Add(this.chkLeather);
            this.grpAccessories.Controls.Add(this.chkStereo);
            this.grpAccessories.Location = new System.Drawing.Point(28, 97);
            this.grpAccessories.Name = "grpAccessories";
            this.grpAccessories.Size = new System.Drawing.Size(218, 130);
            this.grpAccessories.TabIndex = 4;
            this.grpAccessories.TabStop = false;
            this.grpAccessories.Text = "Accessories";
            // 
            // chkNavigation
            // 
            this.chkNavigation.AutoSize = true;
            this.chkNavigation.Location = new System.Drawing.Point(17, 97);
            this.chkNavigation.Name = "chkNavigation";
            this.chkNavigation.Size = new System.Drawing.Size(125, 17);
            this.chkNavigation.TabIndex = 2;
            this.chkNavigation.Text = "Computer &Navigation";
            this.chkNavigation.UseVisualStyleBackColor = true;
            this.chkNavigation.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // chkLeather
            // 
            this.chkLeather.AutoSize = true;
            this.chkLeather.Location = new System.Drawing.Point(17, 64);
            this.chkLeather.Name = "chkLeather";
            this.chkLeather.Size = new System.Drawing.Size(97, 17);
            this.chkLeather.TabIndex = 1;
            this.chkLeather.Text = "Leather &Interior";
            this.chkLeather.UseVisualStyleBackColor = true;
            this.chkLeather.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // chkStereo
            // 
            this.chkStereo.AutoSize = true;
            this.chkStereo.Location = new System.Drawing.Point(17, 30);
            this.chkStereo.Name = "chkStereo";
            this.chkStereo.Size = new System.Drawing.Size(94, 17);
            this.chkStereo.TabIndex = 0;
            this.chkStereo.Text = "S&tereo System";
            this.chkStereo.UseVisualStyleBackColor = true;
            this.chkStereo.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(279, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(4, 423);
            this.label3.TabIndex = 5;
            // 
            // grpFinish
            // 
            this.grpFinish.Controls.Add(this.radCustomDetail);
            this.grpFinish.Controls.Add(this.radPearlized);
            this.grpFinish.Controls.Add(this.radStandard);
            this.grpFinish.Location = new System.Drawing.Point(28, 243);
            this.grpFinish.Name = "grpFinish";
            this.grpFinish.Size = new System.Drawing.Size(218, 129);
            this.grpFinish.TabIndex = 5;
            this.grpFinish.TabStop = false;
            this.grpFinish.Text = "Exterior Finish";
            // 
            // radCustomDetail
            // 
            this.radCustomDetail.AutoSize = true;
            this.radCustomDetail.Location = new System.Drawing.Point(7, 97);
            this.radCustomDetail.Name = "radCustomDetail";
            this.radCustomDetail.Size = new System.Drawing.Size(104, 17);
            this.radCustomDetail.TabIndex = 2;
            this.radCustomDetail.Text = "Custom &Detailing";
            this.radCustomDetail.UseVisualStyleBackColor = true;
            this.radCustomDetail.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(7, 64);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(68, 17);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.Text = "Pearli&zed";
            this.radPearlized.UseVisualStyleBackColor = true;
            this.radPearlized.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(7, 30);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(68, 17);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "&Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            this.radStandard.Click += new System.EventHandler(this.chkOrRadio_Click);
            // 
            // lnkReset
            // 
            this.lnkReset.AutoSize = true;
            this.lnkReset.Location = new System.Drawing.Point(25, 413);
            this.lnkReset.Name = "lnkReset";
            this.lnkReset.Size = new System.Drawing.Size(61, 13);
            this.lnkReset.TabIndex = 7;
            this.lnkReset.TabStop = true;
            this.lnkReset.Text = "Reset Form";
            this.lnkReset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReset_LinkClicked);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 404);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnCalculate.Size = new System.Drawing.Size(113, 31);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate Quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.label10);
            this.grpSummary.Controls.Add(this.lblAmountDue);
            this.grpSummary.Controls.Add(this.label9);
            this.grpSummary.Controls.Add(this.lblTradeIn);
            this.grpSummary.Controls.Add(this.label6);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.lblSalesTaxLabel);
            this.grpSummary.Controls.Add(this.lblSaleTax);
            this.grpSummary.Controls.Add(this.label7);
            this.grpSummary.Controls.Add(this.lblSubtotal);
            this.grpSummary.Controls.Add(this.label5);
            this.grpSummary.Controls.Add(this.lblOptions);
            this.grpSummary.Controls.Add(this.label4);
            this.grpSummary.Controls.Add(this.lblSalePrice);
            this.grpSummary.Controls.Add(this.msSalesQuote);
            this.grpSummary.Location = new System.Drawing.Point(297, 12);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(313, 285);
            this.grpSummary.TabIndex = 9;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Amount Due: ";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.Location = new System.Drawing.Point(184, 235);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(100, 20);
            this.lblAmountDue.TabIndex = 12;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Trade-in Allowance: ";
            // 
            // lblTradeIn
            // 
            this.lblTradeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeIn.Location = new System.Drawing.Point(184, 200);
            this.lblTradeIn.Name = "lblTradeIn";
            this.lblTradeIn.Size = new System.Drawing.Size(100, 20);
            this.lblTradeIn.TabIndex = 10;
            this.lblTradeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(184, 165);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxLabel
            // 
            this.lblSalesTaxLabel.AutoSize = true;
            this.lblSalesTaxLabel.Location = new System.Drawing.Point(89, 135);
            this.lblSalesTaxLabel.Name = "lblSalesTaxLabel";
            this.lblSalesTaxLabel.Size = new System.Drawing.Size(60, 13);
            this.lblSalesTaxLabel.TabIndex = 7;
            this.lblSalesTaxLabel.Text = "Sales Tax: ";
            // 
            // lblSaleTax
            // 
            this.lblSaleTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaleTax.Location = new System.Drawing.Point(184, 131);
            this.lblSaleTax.Name = "lblSaleTax";
            this.lblSaleTax.Size = new System.Drawing.Size(100, 20);
            this.lblSaleTax.TabIndex = 6;
            this.lblSaleTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Subtotal: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(184, 96);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 20);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Options: ";
            // 
            // lblOptions
            // 
            this.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptions.Location = new System.Drawing.Point(184, 61);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(100, 20);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vehicle\'s Sale Price: ";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalePrice.Location = new System.Drawing.Point(184, 26);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(100, 20);
            this.lblSalePrice.TabIndex = 0;
            this.lblSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msSalesQuote
            // 
            this.msSalesQuote.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.msSalesQuote.Location = new System.Drawing.Point(3, 16);
            this.msSalesQuote.Name = "msSalesQuote";
            this.msSalesQuote.Size = new System.Drawing.Size(307, 24);
            this.msSalesQuote.TabIndex = 14;
            this.msSalesQuote.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileAcceptQuote});
            this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileAcceptQuote
            // 
            this.mnuFileAcceptQuote.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuFileAcceptQuote.MergeIndex = 1;
            this.mnuFileAcceptQuote.Name = "mnuFileAcceptQuote";
            this.mnuFileAcceptQuote.Size = new System.Drawing.Size(147, 22);
            this.mnuFileAcceptQuote.Text = "Accept Quote";
            // 
            // grpFinance
            // 
            this.grpFinance.Controls.Add(this.lblInterestRate);
            this.grpFinance.Controls.Add(this.label13);
            this.grpFinance.Controls.Add(this.hsbInterestRate);
            this.grpFinance.Controls.Add(this.lblMonthlyPayment);
            this.grpFinance.Controls.Add(this.label12);
            this.grpFinance.Controls.Add(this.hsbNoYears);
            this.grpFinance.Controls.Add(this.lblNoYears);
            this.grpFinance.Controls.Add(this.label11);
            this.grpFinance.Enabled = false;
            this.grpFinance.Location = new System.Drawing.Point(298, 314);
            this.grpFinance.Name = "grpFinance";
            this.grpFinance.Size = new System.Drawing.Size(313, 121);
            this.grpFinance.TabIndex = 8;
            this.grpFinance.TabStop = false;
            this.grpFinance.Text = "Finance";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.Location = new System.Drawing.Point(126, 53);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(63, 20);
            this.lblInterestRate.TabIndex = 7;
            this.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Monthly Payment";
            // 
            // hsbInterestRate
            // 
            this.hsbInterestRate.LargeChange = 25;
            this.hsbInterestRate.Location = new System.Drawing.Point(124, 87);
            this.hsbInterestRate.Maximum = 2524;
            this.hsbInterestRate.Name = "hsbInterestRate";
            this.hsbInterestRate.Size = new System.Drawing.Size(65, 17);
            this.hsbInterestRate.TabIndex = 1;
            this.hsbInterestRate.Value = 500;
            this.hsbInterestRate.ValueChanged += new System.EventHandler(this.hsbInterestRate_ValueChanged);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(207, 53);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(88, 20);
            this.lblMonthlyPayment.TabIndex = 4;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Interest Rate";
            // 
            // hsbNoYears
            // 
            this.hsbNoYears.LargeChange = 3;
            this.hsbNoYears.Location = new System.Drawing.Point(19, 87);
            this.hsbNoYears.Maximum = 12;
            this.hsbNoYears.Minimum = 1;
            this.hsbNoYears.Name = "hsbNoYears";
            this.hsbNoYears.Size = new System.Drawing.Size(63, 17);
            this.hsbNoYears.TabIndex = 0;
            this.hsbNoYears.Value = 3;
            this.hsbNoYears.ValueChanged += new System.EventHandler(this.hsbNoYears_ValueChanged);
            // 
            // lblNoYears
            // 
            this.lblNoYears.Location = new System.Drawing.Point(19, 53);
            this.lblNoYears.Name = "lblNoYears";
            this.lblNoYears.Size = new System.Drawing.Size(63, 20);
            this.lblNoYears.TabIndex = 1;
            this.lblNoYears.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "No. of Years";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // cboVehicleStock
            // 
            this.cboVehicleStock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleStock.FormattingEnabled = true;
            this.cboVehicleStock.Location = new System.Drawing.Point(133, 20);
            this.cboVehicleStock.Name = "cboVehicleStock";
            this.cboVehicleStock.Size = new System.Drawing.Size(113, 21);
            this.cboVehicleStock.TabIndex = 10;
            // 
            // frmQuote
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(636, 460);
            this.Controls.Add(this.cboVehicleStock);
            this.Controls.Add(this.grpFinance);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lnkReset);
            this.Controls.Add(this.grpFinish);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpAccessories);
            this.Controls.Add(this.txtTradeIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msSalesQuote;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuote";
            this.Text = " Sales Quote";
            this.Load += new System.EventHandler(this.frmQuote_Load);
            this.Shown += new System.EventHandler(this.frmQuote_Shown);
            this.grpAccessories.ResumeLayout(false);
            this.grpAccessories.PerformLayout();
            this.grpFinish.ResumeLayout(false);
            this.grpFinish.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.msSalesQuote.ResumeLayout(false);
            this.msSalesQuote.PerformLayout();
            this.grpFinance.ResumeLayout(false);
            this.grpFinance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeIn;
        private System.Windows.Forms.GroupBox grpAccessories;
        private System.Windows.Forms.CheckBox chkNavigation;
        private System.Windows.Forms.CheckBox chkLeather;
        private System.Windows.Forms.CheckBox chkStereo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFinish;
        private System.Windows.Forms.RadioButton radCustomDetail;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.LinkLabel lnkReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTradeIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTaxLabel;
        private System.Windows.Forms.Label lblSaleTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.GroupBox grpFinance;
        private System.Windows.Forms.HScrollBar hsbNoYears;
        private System.Windows.Forms.Label lblNoYears;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.HScrollBar hsbInterestRate;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cboVehicleStock;
        private System.Windows.Forms.MenuStrip msSalesQuote;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileAcceptQuote;

    }
}