namespace Câu_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiMuon = new System.Windows.Forms.TextBox();
            this.btnTimPhieuMuon = new System.Windows.Forms.Button();
            this.btnChonNguoiMuon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnChonNguoiMuon);
            this.groupBox1.Controls.Add(this.btnTimPhieuMuon);
            this.groupBox1.Controls.Add(this.txtNguoiMuon);
            this.groupBox1.Controls.Add(this.dtpNgayMuon);
            this.groupBox1.Controls.Add(this.txtMaPhieuMuon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(383, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiêu mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Người mượn";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(92, 26);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(161, 20);
            this.txtMaPhieuMuon.TabIndex = 3;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(92, 57);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(161, 20);
            this.dtpNgayMuon.TabIndex = 4;
            // 
            // txtNguoiMuon
            // 
            this.txtNguoiMuon.Location = new System.Drawing.Point(92, 99);
            this.txtNguoiMuon.Name = "txtNguoiMuon";
            this.txtNguoiMuon.Size = new System.Drawing.Size(161, 20);
            this.txtNguoiMuon.TabIndex = 5;
            // 
            // btnTimPhieuMuon
            // 
            this.btnTimPhieuMuon.Location = new System.Drawing.Point(277, 23);
            this.btnTimPhieuMuon.Name = "btnTimPhieuMuon";
            this.btnTimPhieuMuon.Size = new System.Drawing.Size(128, 23);
            this.btnTimPhieuMuon.TabIndex = 6;
            this.btnTimPhieuMuon.Text = "Tìm phiếu mượn";
            this.btnTimPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btnChonNguoiMuon
            // 
            this.btnChonNguoiMuon.Location = new System.Drawing.Point(277, 97);
            this.btnChonNguoiMuon.Name = "btnChonNguoiMuon";
            this.btnChonNguoiMuon.Size = new System.Drawing.Size(128, 23);
            this.btnChonNguoiMuon.TabIndex = 7;
            this.btnChonNguoiMuon.Text = "Chọn người mượn";
            this.btnChonNguoiMuon.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(9, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 265);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sách mượn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(6, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(384, 231);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTimKiem.Location = new System.Drawing.Point(13, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(364, 20);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.Text = "Nhập tên sách để tìm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 361);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 361);
            this.dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(46, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Lưu người mượn";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(277, 400);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Trả sách";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 260;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sách";
            this.Column1.Name = "Column1";
            this.Column1.Width = 310;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnChonNguoiMuon;
        private System.Windows.Forms.Button btnTimPhieuMuon;
        private System.Windows.Forms.TextBox txtNguoiMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

