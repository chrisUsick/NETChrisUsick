﻿namespace NETChrisUsick
{
    partial class frmReport
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
            this.crvVehiclesSold = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvVehiclesSold
            // 
            this.crvVehiclesSold.ActiveViewIndex = -1;
            this.crvVehiclesSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvVehiclesSold.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvVehiclesSold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvVehiclesSold.Location = new System.Drawing.Point(0, 0);
            this.crvVehiclesSold.Name = "crvVehiclesSold";
            this.crvVehiclesSold.Size = new System.Drawing.Size(653, 313);
            this.crvVehiclesSold.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 313);
            this.Controls.Add(this.crvVehiclesSold);
            this.Name = "frmReport";
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvVehiclesSold;
    }
}