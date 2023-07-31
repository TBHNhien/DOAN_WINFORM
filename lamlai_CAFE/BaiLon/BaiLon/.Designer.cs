namespace BaiLon
{
    partial class TaiLKhoan
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
            this.vsvdfhv = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.asgsdg = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vsvdfhv
            // 
            this.vsvdfhv.AutoSize = true;
            this.vsvdfhv.Location = new System.Drawing.Point(71, 53);
            this.vsvdfhv.Name = "vsvdfhv";
            this.vsvdfhv.Size = new System.Drawing.Size(38, 13);
            this.vsvdfhv.TabIndex = 0;
            this.vsvdfhv.Text = "Mã Số";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(133, 50);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(100, 20);
            this.txtMaSo.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(133, 100);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 3;
            // 
            // asgsdg
            // 
            this.asgsdg.AutoSize = true;
            this.asgsdg.Location = new System.Drawing.Point(71, 103);
            this.asgsdg.Name = "asgsdg";
            this.asgsdg.Size = new System.Drawing.Size(26, 13);
            this.asgsdg.TabIndex = 2;
            this.asgsdg.Text = "Tên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(133, 155);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 20);
            this.txtMatKhau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức vụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSo,
            this.Ten,
            this.MatKhau,
            this.ChucVu});
            this.dataGridView1.Location = new System.Drawing.Point(335, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 244);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // MaSo
            // 
            this.MaSo.HeaderText = "MaSo";
            this.MaSo.Name = "MaSo";
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.Name = "Ten";
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "NgaySinh";
            this.MatKhau.Name = "MatKhau";
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thêm/Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(198, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xoá";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxChucVu.Location = new System.Drawing.Point(124, 227);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbxChucVu.TabIndex = 11;
            // 
            // TaiLKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxChucVu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.asgsdg);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.vsvdfhv);
            this.Name = "TaiLKhoan";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vsvdfhv;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label asgsdg;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
    }
}

