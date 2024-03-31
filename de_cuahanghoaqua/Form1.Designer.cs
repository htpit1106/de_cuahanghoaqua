namespace de_cuahanghoaqua
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cb_loaihoaqua = new System.Windows.Forms.ComboBox();
            this.tb_dongia = new System.Windows.Forms.TextBox();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btt_them = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.tb_tienkhach = new System.Windows.Forms.TextBox();
            this.tb_tientralai = new System.Windows.Forms.TextBox();
            this.btt_hoanThanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại hoa quả ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // cb_loaihoaqua
            // 
            this.cb_loaihoaqua.FormattingEnabled = true;
            this.cb_loaihoaqua.Location = new System.Drawing.Point(112, 24);
            this.cb_loaihoaqua.Name = "cb_loaihoaqua";
            this.cb_loaihoaqua.Size = new System.Drawing.Size(149, 21);
            this.cb_loaihoaqua.TabIndex = 3;
            this.cb_loaihoaqua.SelectedValueChanged += new System.EventHandler(this.cb_loaihoaqua_SelectedValueChanged);
            // 
            // tb_dongia
            // 
            this.tb_dongia.Enabled = false;
            this.tb_dongia.Location = new System.Drawing.Point(339, 25);
            this.tb_dongia.Name = "tb_dongia";
            this.tb_dongia.Size = new System.Drawing.Size(140, 20);
            this.tb_dongia.TabIndex = 4;
            // 
            // num_soluong
            // 
            this.num_soluong.Location = new System.Drawing.Point(567, 26);
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(72, 20);
            this.num_soluong.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 224);
            this.dataGridView1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chi tiết đơn hàng";
            // 
            // btt_them
            // 
            this.btt_them.Location = new System.Drawing.Point(221, 66);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(75, 23);
            this.btt_them.TabIndex = 8;
            this.btt_them.Text = "Thêm";
            this.btt_them.UseVisualStyleBackColor = true;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.Location = new System.Drawing.Point(302, 66);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(75, 23);
            this.btt_xoa.TabIndex = 9;
            this.btt_xoa.Text = "Xóa";
            this.btt_xoa.UseVisualStyleBackColor = true;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền phải trả";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số tiền của khách";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số tiền trả lại";
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tongtien.Enabled = false;
            this.tb_tongtien.Location = new System.Drawing.Point(460, 335);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(179, 20);
            this.tb_tongtien.TabIndex = 13;
            // 
            // tb_tienkhach
            // 
            this.tb_tienkhach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tienkhach.Location = new System.Drawing.Point(460, 361);
            this.tb_tienkhach.Name = "tb_tienkhach";
            this.tb_tienkhach.Size = new System.Drawing.Size(179, 20);
            this.tb_tienkhach.TabIndex = 14;
            this.tb_tienkhach.Leave += new System.EventHandler(this.tb_tienkhach_Leave);
            // 
            // tb_tientralai
            // 
            this.tb_tientralai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tientralai.Enabled = false;
            this.tb_tientralai.Location = new System.Drawing.Point(460, 384);
            this.tb_tientralai.Name = "tb_tientralai";
            this.tb_tientralai.Size = new System.Drawing.Size(179, 20);
            this.tb_tientralai.TabIndex = 15;
            // 
            // btt_hoanThanh
            // 
            this.btt_hoanThanh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btt_hoanThanh.Location = new System.Drawing.Point(564, 410);
            this.btt_hoanThanh.Name = "btt_hoanThanh";
            this.btt_hoanThanh.Size = new System.Drawing.Size(75, 23);
            this.btt_hoanThanh.TabIndex = 16;
            this.btt_hoanThanh.Text = "Hoàn Thành";
            this.btt_hoanThanh.UseVisualStyleBackColor = true;
            this.btt_hoanThanh.Click += new System.EventHandler(this.btt_hoanThanh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 452);
            this.Controls.Add(this.btt_hoanThanh);
            this.Controls.Add(this.tb_tientralai);
            this.Controls.Add(this.tb_tienkhach);
            this.Controls.Add(this.tb_tongtien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btt_xoa);
            this.Controls.Add(this.btt_them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.num_soluong);
            this.Controls.Add(this.tb_dongia);
            this.Controls.Add(this.cb_loaihoaqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chương trình quản lý cửa hàng hoa quả của Sv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cb_loaihoaqua;
        private System.Windows.Forms.TextBox tb_dongia;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.TextBox tb_tienkhach;
        private System.Windows.Forms.TextBox tb_tientralai;
        private System.Windows.Forms.Button btt_hoanThanh;
    }
}

