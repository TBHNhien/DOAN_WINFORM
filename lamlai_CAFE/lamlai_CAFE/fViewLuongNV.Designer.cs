namespace Luong_nhan_vien_
{
    partial class fViewLuongNV
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
            this.bangluong = new System.Windows.Forms.DataGridView();
            this.texttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).BeginInit();
            this.SuspendLayout();
            // 
            // bangluong
            // 
            this.bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangluong.Location = new System.Drawing.Point(12, 73);
            this.bangluong.Name = "bangluong";
            this.bangluong.RowHeadersWidth = 51;
            this.bangluong.RowTemplate.Height = 24;
            this.bangluong.Size = new System.Drawing.Size(971, 295);
            this.bangluong.TabIndex = 0;
            // 
            // texttimkiem
            // 
            this.texttimkiem.Location = new System.Drawing.Point(142, 28);
            this.texttimkiem.Name = "texttimkiem";
            this.texttimkiem.Size = new System.Drawing.Size(558, 22);
            this.texttimkiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập mã nhân viên mà bạn muốn tìm vào đây";
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(706, 28);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(88, 39);
            this.buttimkiem.TabIndex = 4;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // fViewLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texttimkiem);
            this.Controls.Add(this.bangluong);
            this.Name = "fViewLuongNV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bangluong;
        private System.Windows.Forms.TextBox texttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttimkiem;
    }
}

