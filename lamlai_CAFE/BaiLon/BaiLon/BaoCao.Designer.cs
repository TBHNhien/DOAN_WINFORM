namespace BaiLon
{
    partial class BaoCao
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.báoCáoLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoLợiNhuậnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(331, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoLuongToolStripMenuItem,
            this.báoCáoLợiNhuậnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoLuongToolStripMenuItem
            // 
            this.báoCáoLuongToolStripMenuItem.Name = "báoCáoLuongToolStripMenuItem";
            this.báoCáoLuongToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.báoCáoLuongToolStripMenuItem.Text = "Báo cáo Luong";
            this.báoCáoLuongToolStripMenuItem.Click += new System.EventHandler(this.báoCáoLuongToolStripMenuItem_Click);
            // 
            // báoCáoLợiNhuậnToolStripMenuItem
            // 
            this.báoCáoLợiNhuậnToolStripMenuItem.Name = "báoCáoLợiNhuậnToolStripMenuItem";
            this.báoCáoLợiNhuậnToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.báoCáoLợiNhuậnToolStripMenuItem.Text = "Báo cáo Lợi Nhuận";
            this.báoCáoLợiNhuậnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoLợiNhuậnToolStripMenuItem_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 339);
            this.reportViewer1.TabIndex = 2;
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaoCao";
            this.Text = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoLợiNhuậnToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}