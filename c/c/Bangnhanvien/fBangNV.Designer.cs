namespace Bangnhanvien
{
    partial class fBangNV
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
            this.bangnhanvien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.texttennv = new System.Windows.Forms.TextBox();
            this.textsdt = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textnamsinh = new System.Windows.Forms.TextBox();
            this.textchucvu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.butthem = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangnhanvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangnhanvien
            // 
            this.bangnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangnhanvien.Location = new System.Drawing.Point(228, 39);
            this.bangnhanvien.Name = "bangnhanvien";
            this.bangnhanvien.RowHeadersWidth = 51;
            this.bangnhanvien.RowTemplate.Height = 24;
            this.bangnhanvien.Size = new System.Drawing.Size(768, 374);
            this.bangnhanvien.TabIndex = 0;
            this.bangnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangnhanvien_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textchucvu);
            this.groupBox1.Controls.Add(this.textnamsinh);
            this.groupBox1.Controls.Add(this.textemail);
            this.groupBox1.Controls.Add(this.textsdt);
            this.groupBox1.Controls.Add(this.texttennv);
            this.groupBox1.Controls.Add(this.textmanv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Năm sinh";
            // 
            // textmanv
            // 
            this.textmanv.Location = new System.Drawing.Point(98, 40);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(103, 22);
            this.textmanv.TabIndex = 6;
            // 
            // texttennv
            // 
            this.texttennv.Location = new System.Drawing.Point(98, 89);
            this.texttennv.Name = "texttennv";
            this.texttennv.Size = new System.Drawing.Size(103, 22);
            this.texttennv.TabIndex = 7;
            // 
            // textsdt
            // 
            this.textsdt.Location = new System.Drawing.Point(100, 130);
            this.textsdt.Name = "textsdt";
            this.textsdt.Size = new System.Drawing.Size(103, 22);
            this.textsdt.TabIndex = 8;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(66, 173);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(137, 22);
            this.textemail.TabIndex = 9;
            // 
            // textnamsinh
            // 
            this.textnamsinh.Location = new System.Drawing.Point(98, 266);
            this.textnamsinh.Name = "textnamsinh";
            this.textnamsinh.Size = new System.Drawing.Size(103, 22);
            this.textnamsinh.TabIndex = 11;
            // 
            // textchucvu
            // 
            this.textchucvu.FormattingEnabled = true;
            this.textchucvu.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.textchucvu.Location = new System.Drawing.Point(66, 222);
            this.textchucvu.Name = "textchucvu";
            this.textchucvu.Size = new System.Drawing.Size(135, 24);
            this.textchucvu.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Chức vụ";
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(7, 383);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(64, 30);
            this.butthem.TabIndex = 2;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(77, 383);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 30);
            this.butsua.TabIndex = 3;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(158, 383);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(64, 30);
            this.butxoa.TabIndex = 4;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bangnhanvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangnhanvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bangnhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textnamsinh;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textsdt;
        private System.Windows.Forms.TextBox texttennv;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.ComboBox textchucvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
    }
}

