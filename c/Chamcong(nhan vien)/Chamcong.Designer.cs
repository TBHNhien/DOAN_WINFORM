namespace Chamcong_nhan_vien_
{
    partial class Chamcong
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
            this.bangchamcong = new System.Windows.Forms.DataGridView();
            this.butluu = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textthubay = new System.Windows.Forms.ComboBox();
            this.textthusau = new System.Windows.Forms.ComboBox();
            this.textthunam = new System.Windows.Forms.ComboBox();
            this.textchunhat = new System.Windows.Forms.ComboBox();
            this.textthutu = new System.Windows.Forms.ComboBox();
            this.textthuba = new System.Windows.Forms.ComboBox();
            this.textthuhai = new System.Windows.Forms.ComboBox();
            this.textmanv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bangchamcong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangchamcong
            // 
            this.bangchamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangchamcong.Location = new System.Drawing.Point(356, 12);
            this.bangchamcong.Name = "bangchamcong";
            this.bangchamcong.RowHeadersWidth = 51;
            this.bangchamcong.RowTemplate.Height = 24;
            this.bangchamcong.Size = new System.Drawing.Size(1116, 145);
            this.bangchamcong.TabIndex = 0;
            this.bangchamcong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangchamcong_CellClick);
            // 
            // butluu
            // 
            this.butluu.Location = new System.Drawing.Point(407, 187);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(125, 25);
            this.butluu.TabIndex = 1;
            this.butluu.Text = "Lưu";
            this.butluu.UseVisualStyleBackColor = true;
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // butxoa
            // 
            this.butxoa.Location = new System.Drawing.Point(798, 186);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(154, 26);
            this.butxoa.TabIndex = 2;
            this.butxoa.Text = "Xóa ";
            this.butxoa.UseVisualStyleBackColor = true;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textthubay);
            this.groupBox1.Controls.Add(this.textthusau);
            this.groupBox1.Controls.Add(this.textthunam);
            this.groupBox1.Controls.Add(this.textchunhat);
            this.groupBox1.Controls.Add(this.textthutu);
            this.groupBox1.Controls.Add(this.textthuba);
            this.groupBox1.Controls.Add(this.textthuhai);
            this.groupBox1.Controls.Add(this.textmanv);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 394);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ca làm";
            // 
            // textthubay
            // 
            this.textthubay.FormattingEnabled = true;
            this.textthubay.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthubay.Location = new System.Drawing.Point(98, 283);
            this.textthubay.Name = "textthubay";
            this.textthubay.Size = new System.Drawing.Size(138, 24);
            this.textthubay.TabIndex = 15;
            // 
            // textthusau
            // 
            this.textthusau.FormattingEnabled = true;
            this.textthusau.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthusau.Location = new System.Drawing.Point(97, 244);
            this.textthusau.Name = "textthusau";
            this.textthusau.Size = new System.Drawing.Size(138, 24);
            this.textthusau.TabIndex = 14;
            // 
            // textthunam
            // 
            this.textthunam.FormattingEnabled = true;
            this.textthunam.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthunam.Location = new System.Drawing.Point(97, 199);
            this.textthunam.Name = "textthunam";
            this.textthunam.Size = new System.Drawing.Size(138, 24);
            this.textthunam.TabIndex = 13;
            // 
            // textchunhat
            // 
            this.textchunhat.FormattingEnabled = true;
            this.textchunhat.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textchunhat.Location = new System.Drawing.Point(97, 331);
            this.textchunhat.Name = "textchunhat";
            this.textchunhat.Size = new System.Drawing.Size(138, 24);
            this.textchunhat.TabIndex = 12;
            // 
            // textthutu
            // 
            this.textthutu.FormattingEnabled = true;
            this.textthutu.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthutu.Location = new System.Drawing.Point(98, 160);
            this.textthutu.Name = "textthutu";
            this.textthutu.Size = new System.Drawing.Size(138, 24);
            this.textthutu.TabIndex = 11;
            // 
            // textthuba
            // 
            this.textthuba.FormattingEnabled = true;
            this.textthuba.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthuba.Location = new System.Drawing.Point(97, 121);
            this.textthuba.Name = "textthuba";
            this.textthuba.Size = new System.Drawing.Size(138, 24);
            this.textthuba.TabIndex = 10;
            // 
            // textthuhai
            // 
            this.textthuhai.FormattingEnabled = true;
            this.textthuhai.Items.AddRange(new object[] {
            "1 ca: Ca sang(6h->11h)",
            "1 ca: Ca chieu(11h->17h)",
            "1 ca: Ca toi(17h->22h)",
            "2 ca: Ca sang&chieu(6h->17h)",
            "2 ca: Ca chieu&toi(11h->22h)",
            "2 ca: Ca sang&toi(6h->11h &17h->22h)",
            "3 ca: Ca sang+chieu+toi(6h-22h)"});
            this.textthuhai.Location = new System.Drawing.Point(98, 81);
            this.textthuhai.Name = "textthuhai";
            this.textthuhai.Size = new System.Drawing.Size(138, 24);
            this.textthuhai.TabIndex = 9;
            // 
            // textmanv
            // 
            this.textmanv.Location = new System.Drawing.Point(97, 38);
            this.textmanv.Name = "textmanv";
            this.textmanv.Size = new System.Drawing.Size(139, 22);
            this.textmanv.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chủ nhật";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thứ bảy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thứ sáu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thứ năm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thứ tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thứ ba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thứ hai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // butsua
            // 
            this.butsua.Location = new System.Drawing.Point(593, 187);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(125, 25);
            this.butsua.TabIndex = 4;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = true;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 450);
            this.Controls.Add(this.butsua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butxoa);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.bangchamcong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangchamcong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bangchamcong;
        private System.Windows.Forms.Button butluu;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textthubay;
        private System.Windows.Forms.ComboBox textthusau;
        private System.Windows.Forms.ComboBox textthunam;
        private System.Windows.Forms.ComboBox textchunhat;
        private System.Windows.Forms.ComboBox textthutu;
        private System.Windows.Forms.ComboBox textthuba;
        private System.Windows.Forms.ComboBox textthuhai;
        private System.Windows.Forms.TextBox textmanv;
        private System.Windows.Forms.Button butsua;
    }
}

