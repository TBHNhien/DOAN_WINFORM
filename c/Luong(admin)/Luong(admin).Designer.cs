namespace Luong_admin_
{
    partial class Form1
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
            this.lbmanv = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.lbcalam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbphat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.textluongchu = new System.Windows.Forms.TextBox();
            this.textluongso = new System.Windows.Forms.TextBox();
            this.textphat = new System.Windows.Forms.TextBox();
            this.textthoigian = new System.Windows.Forms.TextBox();
            this.textsoca = new System.Windows.Forms.TextBox();
            this.texttennv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butthem = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butsua = new System.Windows.Forms.Button();
            this.butquaylai = new System.Windows.Forms.Button();
            this.butxoahet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangluong
            // 
            this.bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangluong.Location = new System.Drawing.Point(300, 12);
            this.bangluong.Name = "bangluong";
            this.bangluong.RowHeadersWidth = 51;
            this.bangluong.RowTemplate.Height = 24;
            this.bangluong.Size = new System.Drawing.Size(1003, 343);
            this.bangluong.TabIndex = 0;
            this.bangluong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangluong_CellClick);
            this.bangluong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangluong_CellContentClick);
            this.bangluong.SelectionChanged += new System.EventHandler(this.bangluong_SelectionChanged);
            this.bangluong.Click += new System.EventHandler(this.bangluong_Click);
            // 
            // lbmanv
            // 
            this.lbmanv.AutoSize = true;
            this.lbmanv.Location = new System.Drawing.Point(21, 18);
            this.lbmanv.Name = "lbmanv";
            this.lbmanv.Size = new System.Drawing.Size(86, 16);
            this.lbmanv.TabIndex = 1;
            this.lbmanv.Text = "Mã nhân viên";
            this.lbmanv.Click += new System.EventHandler(this.lbmanv_Click);
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Location = new System.Drawing.Point(16, 49);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(91, 16);
            this.lbtennv.TabIndex = 2;
            this.lbtennv.Text = "Tên nhân viên";
            // 
            // lbcalam
            // 
            this.lbcalam.AutoSize = true;
            this.lbcalam.Location = new System.Drawing.Point(17, 84);
            this.lbcalam.Name = "lbcalam";
            this.lbcalam.Size = new System.Drawing.Size(67, 16);
            this.lbcalam.TabIndex = 3;
            this.lbcalam.Text = "Số ca làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng thời gian";
            // 
            // lbphat
            // 
            this.lbphat.AutoSize = true;
            this.lbphat.Location = new System.Drawing.Point(17, 145);
            this.lbphat.Name = "lbphat";
            this.lbphat.Size = new System.Drawing.Size(34, 16);
            this.lbphat.TabIndex = 6;
            this.lbphat.Text = "Phạt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lương số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lương chữ";
            // 
            // textmanv
            // 
            this.textmanv.Location = new System.Drawing.Point(122, 18);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(143, 22);
            this.textmanv.TabIndex = 9;
            // 
            // textluongchu
            // 
            this.textluongchu.Location = new System.Drawing.Point(122, 212);
            this.textluongchu.Name = "textluongchu";
            this.textluongchu.Size = new System.Drawing.Size(143, 22);
            this.textluongchu.TabIndex = 10;
            // 
            // textluongso
            // 
            this.textluongso.Location = new System.Drawing.Point(122, 177);
            this.textluongso.Name = "textluongso";
            this.textluongso.Size = new System.Drawing.Size(143, 22);
            this.textluongso.TabIndex = 11;
            // 
            // textphat
            // 
            this.textphat.Location = new System.Drawing.Point(122, 145);
            this.textphat.Name = "textphat";
            this.textphat.Size = new System.Drawing.Size(143, 22);
            this.textphat.TabIndex = 12;
            // 
            // textthoigian
            // 
            this.textthoigian.Location = new System.Drawing.Point(122, 113);
            this.textthoigian.Name = "textthoigian";
            this.textthoigian.Size = new System.Drawing.Size(143, 22);
            this.textthoigian.TabIndex = 13;
            // 
            // textsoca
            // 
            this.textsoca.Location = new System.Drawing.Point(122, 84);
            this.textsoca.Name = "textsoca";
            this.textsoca.Size = new System.Drawing.Size(143, 22);
            this.textsoca.TabIndex = 14;
            // 
            // texttennv
            // 
            this.texttennv.Location = new System.Drawing.Point(122, 49);
            this.texttennv.Name = "texttennv";
            this.texttennv.Size = new System.Drawing.Size(143, 22);
            this.texttennv.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texttennv);
            this.groupBox1.Controls.Add(this.textsoca);
            this.groupBox1.Controls.Add(this.textthoigian);
            this.groupBox1.Controls.Add(this.textphat);
            this.groupBox1.Controls.Add(this.textluongso);
            this.groupBox1.Controls.Add(this.textluongchu);
            this.groupBox1.Controls.Add(this.textmanv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbphat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbcalam);
            this.groupBox1.Controls.Add(this.lbtennv);
            this.groupBox1.Controls.Add(this.lbmanv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 246);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lương nhân viên";
            // 
            // butthem
            // 
            this.butthem.Location = new System.Drawing.Point(12, 277);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 17;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = true;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(219, 277);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 18;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(112, 277);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 19;
            this.butsua.Text = "Sứa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butquaylai
            // 
            this.butquaylai.Location = new System.Drawing.Point(1228, 386);
            this.butquaylai.Name = "butquaylai";
            this.butquaylai.Size = new System.Drawing.Size(75, 23);
            this.butquaylai.TabIndex = 22;
            this.butquaylai.Text = "Quay lai";
            this.butquaylai.UseVisualStyleBackColor = true;
            // 
            // butxoahet
            // 
            this.butxoahet.Location = new System.Drawing.Point(92, 333);
            this.butxoahet.Name = "butxoahet";
            this.butxoahet.Size = new System.Drawing.Size(118, 22);
            this.butxoahet.TabIndex = 23;
            this.butxoahet.Text = "Xóa hết tất cả";
            this.butxoahet.UseVisualStyleBackColor = true;
            this.butxoahet.Click += new System.EventHandler(this.butxoahet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 481);
            this.Controls.Add(this.butxoahet);
            this.Controls.Add(this.butquaylai);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bangluong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangluong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bangluong;
        private System.Windows.Forms.Label lbmanv;
        private System.Windows.Forms.Label lbtennv;
        private System.Windows.Forms.Label lbcalam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbphat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.TextBox textluongchu;
        private System.Windows.Forms.TextBox textluongso;
        private System.Windows.Forms.TextBox textphat;
        private System.Windows.Forms.TextBox textthoigian;
        private System.Windows.Forms.TextBox textsoca;
        private System.Windows.Forms.TextBox texttennv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butquaylai;
        private System.Windows.Forms.Button butxoahet;
    }
}

