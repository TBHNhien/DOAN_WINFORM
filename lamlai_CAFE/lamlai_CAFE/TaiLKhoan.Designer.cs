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
            this.tThem = new System.Windows.Forms.Button();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView1.Location = new System.Drawing.Point(335, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 244);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tThem
            // 
            this.tThem.Location = new System.Drawing.Point(43, 267);
            this.tThem.Name = "tThem";
            this.tThem.Size = new System.Drawing.Size(75, 23);
            this.tThem.TabIndex = 9;
            this.tThem.Text = "Thêm";
            this.tThem.UseVisualStyleBackColor = true;
            this.tThem.Click += new System.EventHandler(this.button1_Click);
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
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(133, 267);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.button4_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(214, 267);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài Khoản";
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
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.Name = "ChucVu";
            // 
            // TaiLKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.cbxChucVu);
            this.Controls.Add(this.tThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.asgsdg);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.vsvdfhv);
            this.Name = "TaiLKhoan";
            this.Text = "TaiKhoan";
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
        private System.Windows.Forms.Button tThem;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
    }
}

