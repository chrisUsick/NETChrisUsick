namespace NETChrisUsick
{
    partial class frmFrame
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
            this.tsMainToolbar = new System.Windows.Forms.ToolStrip();
            this.tsiOpen = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsiOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOpenService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiTile = new System.Windows.Forms.ToolStripButton();
            this.tsiLayer = new System.Windows.Forms.ToolStripButton();
            this.tsiCascade = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiAbout = new System.Windows.Forms.ToolStripButton();
            this.tsiExit = new System.Windows.Forms.ToolStripButton();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenSalesQuote = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpenCarWash = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataSalesStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataVehicleStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainToolbar.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMainToolbar
            // 
            this.tsMainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpen,
            this.toolStripSeparator1,
            this.tsiTile,
            this.tsiLayer,
            this.tsiCascade,
            this.toolStripSeparator2,
            this.tsiAbout,
            this.tsiExit});
            this.tsMainToolbar.Location = new System.Drawing.Point(0, 24);
            this.tsMainToolbar.Name = "tsMainToolbar";
            this.tsMainToolbar.Size = new System.Drawing.Size(284, 25);
            this.tsMainToolbar.TabIndex = 2;
            this.tsMainToolbar.Text = "toolStrip1";
            // 
            // tsiOpen
            // 
            this.tsiOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOpenSalesQuote,
            this.tsiOpenService});
            this.tsiOpen.Image = global::NETChrisUsick.Properties.Resources.open;
            this.tsiOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiOpen.Name = "tsiOpen";
            this.tsiOpen.Size = new System.Drawing.Size(29, 22);
            this.tsiOpen.Text = "Open";
            // 
            // tsiOpenSalesQuote
            // 
            this.tsiOpenSalesQuote.Image = global::NETChrisUsick.Properties.Resources.quote;
            this.tsiOpenSalesQuote.Name = "tsiOpenSalesQuote";
            this.tsiOpenSalesQuote.Size = new System.Drawing.Size(136, 22);
            this.tsiOpenSalesQuote.Text = "Sales Quote";
            this.tsiOpenSalesQuote.Click += new System.EventHandler(this.mnuFileOpenSalesQuote_Click);
            // 
            // tsiOpenService
            // 
            this.tsiOpenService.Image = global::NETChrisUsick.Properties.Resources.service;
            this.tsiOpenService.Name = "tsiOpenService";
            this.tsiOpenService.Size = new System.Drawing.Size(136, 22);
            this.tsiOpenService.Text = "Service";
            this.tsiOpenService.Click += new System.EventHandler(this.mnuFileOpenService_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsiTile
            // 
            this.tsiTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiTile.Image = global::NETChrisUsick.Properties.Resources.tile;
            this.tsiTile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiTile.Name = "tsiTile";
            this.tsiTile.Size = new System.Drawing.Size(23, 22);
            this.tsiTile.Text = "Tile";
            this.tsiTile.Click += new System.EventHandler(this.mnuWindowTile_Click);
            // 
            // tsiLayer
            // 
            this.tsiLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiLayer.Image = global::NETChrisUsick.Properties.Resources.layer;
            this.tsiLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiLayer.Name = "tsiLayer";
            this.tsiLayer.Size = new System.Drawing.Size(23, 22);
            this.tsiLayer.Text = "Layer";
            this.tsiLayer.Click += new System.EventHandler(this.mnuWindowLayer_Click);
            // 
            // tsiCascade
            // 
            this.tsiCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiCascade.Image = global::NETChrisUsick.Properties.Resources.cascade;
            this.tsiCascade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiCascade.Name = "tsiCascade";
            this.tsiCascade.Size = new System.Drawing.Size(23, 22);
            this.tsiCascade.Text = "Cascade";
            this.tsiCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsiAbout
            // 
            this.tsiAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiAbout.Image = global::NETChrisUsick.Properties.Resources.about;
            this.tsiAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiAbout.Name = "tsiAbout";
            this.tsiAbout.Size = new System.Drawing.Size(23, 22);
            this.tsiAbout.Text = "About";
            // 
            // tsiExit
            // 
            this.tsiExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiExit.Image = global::NETChrisUsick.Properties.Resources.exit;
            this.tsiExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiExit.Name = "tsiExit";
            this.tsiExit.Size = new System.Drawing.Size(23, 22);
            this.tsiExit.Text = "Exit";
            this.tsiExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWindow,
            this.mnuData,
            this.mnuHelp});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(284, 24);
            this.msMainMenu.TabIndex = 4;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.toolStripMenuItem1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenSalesQuote,
            this.mnuFileOpenService,
            this.mnuFileOpenCarWash});
            this.mnuFileOpen.Image = global::NETChrisUsick.Properties.Resources.open;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuFileOpen.Text = "&Open";
            // 
            // mnuFileOpenSalesQuote
            // 
            this.mnuFileOpenSalesQuote.Image = global::NETChrisUsick.Properties.Resources.quote;
            this.mnuFileOpenSalesQuote.Name = "mnuFileOpenSalesQuote";
            this.mnuFileOpenSalesQuote.Size = new System.Drawing.Size(136, 22);
            this.mnuFileOpenSalesQuote.Text = "Sales Quote";
            this.mnuFileOpenSalesQuote.Click += new System.EventHandler(this.mnuFileOpenSalesQuote_Click);
            // 
            // mnuFileOpenService
            // 
            this.mnuFileOpenService.Image = global::NETChrisUsick.Properties.Resources.service;
            this.mnuFileOpenService.Name = "mnuFileOpenService";
            this.mnuFileOpenService.Size = new System.Drawing.Size(136, 22);
            this.mnuFileOpenService.Text = "Service";
            this.mnuFileOpenService.Click += new System.EventHandler(this.mnuFileOpenService_Click);
            // 
            // mnuFileOpenCarWash
            // 
            this.mnuFileOpenCarWash.Image = global::NETChrisUsick.Properties.Resources.carwash;
            this.mnuFileOpenCarWash.Name = "mnuFileOpenCarWash";
            this.mnuFileOpenCarWash.Size = new System.Drawing.Size(136, 22);
            this.mnuFileOpenCarWash.Text = "&Car Wash";
            this.mnuFileOpenCarWash.Click += new System.EventHandler(this.mnuFileOpenCarWash_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Image = global::NETChrisUsick.Properties.Resources.exit;
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(103, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowTile,
            this.mnuWindowLayer,
            this.mnuWindowCascade});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "&Window";
            // 
            // mnuWindowTile
            // 
            this.mnuWindowTile.Image = global::NETChrisUsick.Properties.Resources.tile;
            this.mnuWindowTile.Name = "mnuWindowTile";
            this.mnuWindowTile.Size = new System.Drawing.Size(118, 22);
            this.mnuWindowTile.Text = "&Tile";
            this.mnuWindowTile.Click += new System.EventHandler(this.mnuWindowTile_Click);
            // 
            // mnuWindowLayer
            // 
            this.mnuWindowLayer.Image = global::NETChrisUsick.Properties.Resources.layer;
            this.mnuWindowLayer.Name = "mnuWindowLayer";
            this.mnuWindowLayer.Size = new System.Drawing.Size(118, 22);
            this.mnuWindowLayer.Text = "&Layer";
            this.mnuWindowLayer.Click += new System.EventHandler(this.mnuWindowLayer_Click);
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Image = global::NETChrisUsick.Properties.Resources.cascade;
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(118, 22);
            this.mnuWindowCascade.Text = "&Cascade";
            this.mnuWindowCascade.Click += new System.EventHandler(this.mnuWindowCascade_Click);
            // 
            // mnuData
            // 
            this.mnuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDataSalesStaff,
            this.mnuDataVehicleStock});
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(43, 20);
            this.mnuData.Text = "&Data";
            // 
            // mnuDataSalesStaff
            // 
            this.mnuDataSalesStaff.Name = "mnuDataSalesStaff";
            this.mnuDataSalesStaff.Size = new System.Drawing.Size(152, 22);
            this.mnuDataSalesStaff.Text = "&Sales Staff";
            this.mnuDataSalesStaff.Click += new System.EventHandler(this.mnuDataSalesStaff_Click);
            // 
            // mnuDataVehicleStock
            // 
            this.mnuDataVehicleStock.Name = "mnuDataVehicleStock";
            this.mnuDataVehicleStock.Size = new System.Drawing.Size(152, 22);
            this.mnuDataVehicleStock.Text = "&Vehicle Stock";
            this.mnuDataVehicleStock.Click += new System.EventHandler(this.mnuDataVehicleStock_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Image = global::NETChrisUsick.Properties.Resources.about;
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.mnuHelpAbout.Text = "&About";
            // 
            // frmFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tsMainToolbar);
            this.Controls.Add(this.msMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMainMenu;
            this.Name = "frmFrame";
            this.Text = "form 1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFrame_Load);
            this.tsMainToolbar.ResumeLayout(false);
            this.tsMainToolbar.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainToolbar;
        private System.Windows.Forms.ToolStripDropDownButton tsiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsiOpenSalesQuote;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsiTile;
        private System.Windows.Forms.ToolStripButton tsiLayer;
        private System.Windows.Forms.ToolStripButton tsiCascade;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsiAbout;
        private System.Windows.Forms.ToolStripButton tsiExit;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenSalesQuote;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowTile;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowLayer;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenService;
        private System.Windows.Forms.ToolStripMenuItem tsiOpenService;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpenCarWash;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuDataSalesStaff;
        private System.Windows.Forms.ToolStripMenuItem mnuDataVehicleStock;
    }
}

