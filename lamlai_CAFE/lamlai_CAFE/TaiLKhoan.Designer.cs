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
            this.tThem = new System.Windows.Forms.Button();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vsvdfhv
            // 
            this.vsvdfhv.AutoSize = true;
            this.vsvdfhv.Location = new System.Drawing.Point(95, 65);
            this.vsvdfhv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vsvdfhv.Name = "vsvdfhv";
            this.vsvdfhv.Size = new System.Drawing.Size(46, 16);
            this.vsvdfhv.TabIndex = 0;
            this.vsvdfhv.Text = "Mã Số";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Location = new System.Drawing.Point(177, 62);
            this.txtMaSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(132, 22);
            this.txtMaSo.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(177, 123);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(132, 22);
            this.txtTen.TabIndex = 3;
            // 
            // asgsdg
            // 
            this.asgsdg.AutoSize = true;
            this.asgsdg.Location = new System.Drawing.Point(95, 127);
            this.asgsdg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.asgsdg.Name = "asgsdg";
            this.asgsdg.Size = new System.Drawing.Size(31, 16);
            this.asgsdg.TabIndex = 2;
            this.asgsdg.Text = "Tên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(177, 191);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(132, 22);
            this.txtMatKhau.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
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
            this.dataGridView1.Location = new System.Drawing.Point(447, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(568, 300);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaSo
            // 
            this.MaSo.HeaderText = "MaSo";
            this.MaSo.MinimumWidth = 6;
            this.MaSo.Name = "MaSo";
            this.MaSo.Width = 125;
            // 
            // Ten
            // 
            this.Ten.HeaderText = "Ten";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // tThem
            // 
            this.tThem.Location = new System.Drawing.Point(57, 329);
            this.tThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tThem.Name = "tThem";
            this.tThem.Size = new System.Drawing.Size(100, 28);
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
            this.cbxChucVu.Location = new System.Drawing.Point(165, 279);
            this.cbxChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(160, 24);
            this.cbxChucVu.TabIndex = 11;
            this.cbxChucVu.SelectedIndexChanged += new System.EventHandler(this.cbxChucVu_SelectedIndexChanged);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(177, 329);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(100, 28);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.button4_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(285, 329);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tài Khoản";
            // 
            // TaiLKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 430);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

