namespace _2212366_BuiTrungHieu_De3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtTenDocGia = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnXoaTrang = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvQLDG = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(116, 20);
            this.txtMaDocGia.Multiline = true;
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(272, 22);
            this.txtMaDocGia.TabIndex = 4;
            // 
            // txtTenDocGia
            // 
            this.txtTenDocGia.Location = new System.Drawing.Point(116, 58);
            this.txtTenDocGia.Multiline = true;
            this.txtTenDocGia.Name = "txtTenDocGia";
            this.txtTenDocGia.Size = new System.Drawing.Size(272, 22);
            this.txtTenDocGia.TabIndex = 5;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(116, 94);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(272, 20);
            this.mtxtSDT.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(506, 26);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(254, 88);
            this.txtDiaChi.TabIndex = 7;
            // 
            // btnXoaTrang
            // 
            this.btnXoaTrang.Location = new System.Drawing.Point(326, 143);
            this.btnXoaTrang.Name = "btnXoaTrang";
            this.btnXoaTrang.Size = new System.Drawing.Size(103, 23);
            this.btnXoaTrang.TabIndex = 8;
            this.btnXoaTrang.Text = "Xóa trắng";
            this.btnXoaTrang.UseVisualStyleBackColor = true;
            this.btnXoaTrang.Click += new System.EventHandler(this.btnXoaTrang_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(506, 143);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(1, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 261);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách độc giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvQLDG);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 181);
            this.panel1.TabIndex = 1;
            // 
            // lvQLDG
            // 
            this.lvQLDG.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvQLDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQLDG.GridLines = true;
            this.lvQLDG.HideSelection = false;
            this.lvQLDG.Location = new System.Drawing.Point(0, 0);
            this.lvQLDG.Name = "lvQLDG";
            this.lvQLDG.Size = new System.Drawing.Size(800, 181);
            this.lvQLDG.TabIndex = 0;
            this.lvQLDG.UseCompatibleStateImageBehavior = false;
            this.lvQLDG.View = System.Windows.Forms.View.Details;
            this.lvQLDG.SelectedIndexChanged += new System.EventHandler(this.lvQLDG_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã độc giả";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên độc giả";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 160;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdTen);
            this.groupBox2.Controls.Add(this.rdSDT);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(53, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 55);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Location = new System.Drawing.Point(526, 22);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(68, 17);
            this.rdTen.TabIndex = 2;
            this.rdTen.Text = "Theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Checked = true;
            this.rdSDT.Location = new System.Drawing.Point(370, 22);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(75, 17);
            this.rdSDT.TabIndex = 1;
            this.rdSDT.TabStop = true;
            this.rdSDT.Text = "Theo SĐT";
            this.rdSDT.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.Color.LightGray;
            this.txtTimKiem.Location = new System.Drawing.Point(67, 19);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(266, 20);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.Text = "Nhập tên hoặc số điện thoại để tìm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(694, 461);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(107, 23);
            this.btnXuat.TabIndex = 11;
            this.btnXuat.Text = "Xuất File XML";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaTrang);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtTenDocGia);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtTenDocGia;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnXoaTrang;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvQLDG;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

