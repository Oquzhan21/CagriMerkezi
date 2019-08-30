namespace CagriMerkeziV._1
{
    partial class YazdirSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YazdirSayfasi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çALIŞANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÖRÜŞMEKAYDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gÖREVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yAZDIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çALIŞANToolStripMenuItem,
            this.mÜŞTERİToolStripMenuItem,
            this.gÖRÜŞMEKAYDIToolStripMenuItem,
            this.gÖREVToolStripMenuItem,
            this.yAZDIRToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çALIŞANToolStripMenuItem
            // 
            this.çALIŞANToolStripMenuItem.Name = "çALIŞANToolStripMenuItem";
            this.çALIŞANToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.çALIŞANToolStripMenuItem.Text = "ÇALIŞAN";
            this.çALIŞANToolStripMenuItem.Click += new System.EventHandler(this.çALIŞANToolStripMenuItem_Click);
            // 
            // mÜŞTERİToolStripMenuItem
            // 
            this.mÜŞTERİToolStripMenuItem.Name = "mÜŞTERİToolStripMenuItem";
            this.mÜŞTERİToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.mÜŞTERİToolStripMenuItem.Text = "MÜŞTERİ";
            this.mÜŞTERİToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİToolStripMenuItem_Click);
            // 
            // gÖRÜŞMEKAYDIToolStripMenuItem
            // 
            this.gÖRÜŞMEKAYDIToolStripMenuItem.Name = "gÖRÜŞMEKAYDIToolStripMenuItem";
            this.gÖRÜŞMEKAYDIToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gÖRÜŞMEKAYDIToolStripMenuItem.Text = "GÖRÜŞME KAYDI";
            this.gÖRÜŞMEKAYDIToolStripMenuItem.Click += new System.EventHandler(this.gÖRÜŞMEKAYDIToolStripMenuItem_Click);
            // 
            // gÖREVToolStripMenuItem
            // 
            this.gÖREVToolStripMenuItem.Name = "gÖREVToolStripMenuItem";
            this.gÖREVToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.gÖREVToolStripMenuItem.Text = "GÖREV";
            this.gÖREVToolStripMenuItem.Click += new System.EventHandler(this.gÖREVToolStripMenuItem_Click);
            // 
            // yAZDIRToolStripMenuItem
            // 
            this.yAZDIRToolStripMenuItem.Name = "yAZDIRToolStripMenuItem";
            this.yAZDIRToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.yAZDIRToolStripMenuItem.Text = "YAZDIR";
            this.yAZDIRToolStripMenuItem.Click += new System.EventHandler(this.yAZDIRToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 440);
            this.dataGridView1.TabIndex = 1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // YazdirSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 479);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YazdirSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YazdirSayfasi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çALIŞANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÖRÜŞMEKAYDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gÖREVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem yAZDIRToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}