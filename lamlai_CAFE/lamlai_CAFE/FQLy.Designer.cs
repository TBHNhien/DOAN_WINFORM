namespace lamlai_CAFE
{
    partial class FQLy
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
            this.btnacc = new System.Windows.Forms.Button();
            this.btnqliNV = new System.Windows.Forms.Button();
            this.btnluong = new System.Windows.Forms.Button();
            this.btnloinhuan = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.btnCaLam = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnacc
            // 
            this.btnacc.Location = new System.Drawing.Point(28, 64);
            this.btnacc.Name = "btnacc";
            this.btnacc.Size = new System.Drawing.Size(112, 67);
            this.btnacc.TabIndex = 0;
            this.btnacc.Text = "quản lí tài khoản";
            this.btnacc.UseVisualStyleBackColor = true;
            this.btnacc.Click += new System.EventHandler(this.btnacc_Click);
            // 
            // btnqliNV
            // 
            this.btnqliNV.Location = new System.Drawing.Point(238, 64);
            this.btnqliNV.Name = "btnqliNV";
            this.btnqliNV.Size = new System.Drawing.Size(112, 67);
            this.btnqliNV.TabIndex = 1;
            this.btnqliNV.Text = "quản lí nhân viên ";
            this.btnqliNV.UseVisualStyleBackColor = true;
            this.btnqliNV.Click += new System.EventHandler(this.btnqliNV_Click);
            // 
            // btnluong
            // 
            this.btnluong.Location = new System.Drawing.Point(422, 64);
            this.btnluong.Name = "btnluong";
            this.btnluong.Size = new System.Drawing.Size(112, 67);
            this.btnluong.TabIndex = 2;
            this.btnluong.Text = "quản lí lương";
            this.btnluong.UseVisualStyleBackColor = true;
            this.btnluong.Click += new System.EventHandler(this.btnluong_Click);
            // 
            // btnloinhuan
            // 
            this.btnloinhuan.Location = new System.Drawing.Point(238, 339);
            this.btnloinhuan.Name = "btnloinhuan";
            this.btnloinhuan.Size = new System.Drawing.Size(112, 67);
            this.btnloinhuan.TabIndex = 3;
            this.btnloinhuan.Text = "Tổng kết lợi nhuận";
            this.btnloinhuan.UseVisualStyleBackColor = true;
            this.btnloinhuan.Click += new System.EventHandler(this.btnloinhuan_Click);
            // 
            // btnKho
            // 
            this.btnKho.Location = new System.Drawing.Point(28, 204);
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(112, 67);
            this.btnKho.TabIndex = 4;
            this.btnKho.Text = "Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnCaLam
            // 
            this.btnCaLam.Location = new System.Drawing.Point(28, 339);
            this.btnCaLam.Name = "btnCaLam";
            this.btnCaLam.Size = new System.Drawing.Size(112, 67);
            this.btnCaLam.TabIndex = 5;
            this.btnCaLam.Text = "quản lí ca làm ";
            this.btnCaLam.UseVisualStyleBackColor = true;
            this.btnCaLam.Click += new System.EventHandler(this.btnCaLam_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(422, 204);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(112, 67);
            this.btnThongke.TabIndex = 6;
            this.btnThongke.Text = "thống kê dữ liệu";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btncafe
            // 
            this.btncafe.BackColor = System.Drawing.SystemColors.Highlight;
            this.btncafe.Location = new System.Drawing.Point(238, 204);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(112, 67);
            this.btncafe.TabIndex = 7;
            this.btncafe.Text = "Quán Cơm";
            this.btncafe.UseVisualStyleBackColor = false;
            this.btncafe.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(422, 339);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(112, 67);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "thoát ";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FQLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 467);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncafe);
            this.Controls.Add(this.btnThongke);
            this.Controls.Add(this.btnCaLam);
            this.Controls.Add(this.btnKho);
            this.Controls.Add(this.btnloinhuan);
            this.Controls.Add(this.btnluong);
            this.Controls.Add(this.btnqliNV);
            this.Controls.Add(this.btnacc);
            this.Name = "FQLy";
            this.Text = "FQLy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnacc;
        private System.Windows.Forms.Button btnqliNV;
        private System.Windows.Forms.Button btnluong;
        private System.Windows.Forms.Button btnloinhuan;
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Button btnCaLam;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Button btnexit;
    }
}