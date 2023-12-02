namespace PRL.Views
{
    partial class f_QLBanBi_a
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
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            label6 = new Label();
            txtDonGia = new TextBox();
            label5 = new Label();
            chbSua = new CheckBox();
            rdbVIP = new RadioButton();
            rdbThuong = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTenBan = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dgrBanBi_a = new DataGridView();
            cmbLoaiBan = new ComboBox();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrBanBi_a).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(392, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 31);
            label1.TabIndex = 0;
            label1.Text = "Bàn Bi_a";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(885, 84);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 218);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(80, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(80, 103);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(80, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbLoaiBan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(chbSua);
            groupBox1.Controls.Add(rdbVIP);
            groupBox1.Controls.Add(rdbThuong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenBan);
            groupBox1.Location = new Point(66, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 281);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 167);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 10;
            label6.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(92, 167);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(249, 27);
            txtDonGia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(446, 120);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Trạng thái";
            // 
            // chbSua
            // 
            chbSua.AutoSize = true;
            chbSua.Location = new Point(535, 116);
            chbSua.Name = "chbSua";
            chbSua.Size = new Size(94, 24);
            chbSua.TabIndex = 7;
            chbSua.Text = "Đang sửa";
            chbSua.UseVisualStyleBackColor = true;
            chbSua.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // rdbVIP
            // 
            rdbVIP.AutoSize = true;
            rdbVIP.Location = new Point(198, 114);
            rdbVIP.Name = "rdbVIP";
            rdbVIP.Size = new Size(51, 24);
            rdbVIP.TabIndex = 6;
            rdbVIP.TabStop = true;
            rdbVIP.Text = "VIP";
            rdbVIP.UseVisualStyleBackColor = true;
            // 
            // rdbThuong
            // 
            rdbThuong.AutoSize = true;
            rdbThuong.Location = new Point(95, 114);
            rdbThuong.Name = "rdbThuong";
            rdbThuong.Size = new Size(81, 24);
            rdbThuong.TabIndex = 5;
            rdbThuong.TabStop = true;
            rdbThuong.Text = "Thường";
            rdbThuong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 116);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 4;
            label4.Text = "Cấp bàn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 52);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 2;
            label3.Text = "Loại bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên bàn";
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(95, 49);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(249, 27);
            txtTenBan.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // dgrBanBi_a
            // 
            dgrBanBi_a.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrBanBi_a.Location = new Point(66, 367);
            dgrBanBi_a.Name = "dgrBanBi_a";
            dgrBanBi_a.RowHeadersWidth = 51;
            dgrBanBi_a.RowTemplate.Height = 29;
            dgrBanBi_a.Size = new Size(935, 258);
            dgrBanBi_a.TabIndex = 15;
            dgrBanBi_a.CellClick += dgrBanBi_a_CellClick;
            dgrBanBi_a.CellContentClick += dgrBanBi_a_CellContentClick;
            // 
            // cmbLoaiBan
            // 
            cmbLoaiBan.FormattingEnabled = true;
            cmbLoaiBan.Location = new Point(518, 48);
            cmbLoaiBan.Name = "cmbLoaiBan";
            cmbLoaiBan.Size = new Size(169, 28);
            cmbLoaiBan.TabIndex = 11;
            // 
            // f_QLBanBi_a
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 681);
            Controls.Add(dgrBanBi_a);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Name = "f_QLBanBi_a";
            Text = "f_QLBanBi_a";
            Load += f_QLBanBi_a_Load;
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrBanBi_a).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtTenBan;
        private Label label3;
        private RadioButton rdbVIP;
        private RadioButton rdbThuong;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private CheckBox chbSua;
        private Label label6;
        private TextBox txtDonGia;
        private DataGridView dgrBanBi_a;
        private ComboBox cmbLoaiBan;
    }
}