namespace PRL.Views
{
    partial class f_QLDichVuDB
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
            groupBox1 = new GroupBox();
            txtGhiChu = new TextBox();
            label5 = new Label();
            txtDonGia = new TextBox();
            label4 = new Label();
            txtTenDVDB = new TextBox();
            label3 = new Label();
            cmbLoaiDVDB = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgrDVDB = new DataGridView();
            groupBox3 = new GroupBox();
            btnXoaDVDB = new Button();
            btnSuaDVDB = new Button();
            btnThemDVDB = new Button();
            groupBox4 = new GroupBox();
            txtGhiChuLoai = new TextBox();
            label7 = new Label();
            txtTenLoaiDVDB = new TextBox();
            label6 = new Label();
            groupBox5 = new GroupBox();
            dgrLoaiDVDB = new DataGridView();
            groupBox6 = new GroupBox();
            btnXoaLoai = new Button();
            btnSuaLoai = new Button();
            btnThemLoai = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrDVDB).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrLoaiDVDB).BeginInit();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenDVDB);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbLoaiDVDB);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(658, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dịch vụ đặc biệt";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(426, 38);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(213, 99);
            txtGhiChu.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 41);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Ghi chú";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(129, 163);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(206, 27);
            txtDonGia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 163);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Đơn giá";
            // 
            // txtTenDVDB
            // 
            txtTenDVDB.Location = new Point(129, 99);
            txtTenDVDB.Name = "txtTenDVDB";
            txtTenDVDB.Size = new Size(206, 27);
            txtTenDVDB.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 99);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên dịch vụ Đb\r\n";
            // 
            // cmbLoaiDVDB
            // 
            cmbLoaiDVDB.FormattingEnabled = true;
            cmbLoaiDVDB.Location = new Point(129, 38);
            cmbLoaiDVDB.Name = "cmbLoaiDVDB";
            cmbLoaiDVDB.Size = new Size(206, 28);
            cmbLoaiDVDB.TabIndex = 1;
            cmbLoaiDVDB.SelectedIndexChanged += cmbLoaiDVDB_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 46);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 0;
            label2.Text = "Loại dịch vụ ĐB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(614, 24);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 1;
            label1.Text = "Quản lý dịch vụ đặc biệt";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgrDVDB);
            groupBox2.Location = new Point(12, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(927, 322);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách";
            // 
            // dgrDVDB
            // 
            dgrDVDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrDVDB.Location = new Point(11, 26);
            dgrDVDB.Name = "dgrDVDB";
            dgrDVDB.RowHeadersWidth = 51;
            dgrDVDB.RowTemplate.Height = 29;
            dgrDVDB.Size = new Size(892, 296);
            dgrDVDB.TabIndex = 0;
            dgrDVDB.CellClick += dgrDVDB_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaDVDB);
            groupBox3.Controls.Add(btnSuaDVDB);
            groupBox3.Controls.Add(btnThemDVDB);
            groupBox3.Location = new Point(689, 57);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 276);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // btnXoaDVDB
            // 
            btnXoaDVDB.Location = new Point(78, 190);
            btnXoaDVDB.Name = "btnXoaDVDB";
            btnXoaDVDB.Size = new Size(94, 29);
            btnXoaDVDB.TabIndex = 3;
            btnXoaDVDB.Text = "Xóa";
            btnXoaDVDB.UseVisualStyleBackColor = true;
            btnXoaDVDB.Click += btnXoaDVDB_Click;
            // 
            // btnSuaDVDB
            // 
            btnSuaDVDB.Location = new Point(78, 126);
            btnSuaDVDB.Name = "btnSuaDVDB";
            btnSuaDVDB.Size = new Size(94, 29);
            btnSuaDVDB.TabIndex = 1;
            btnSuaDVDB.Text = "Sửa";
            btnSuaDVDB.UseVisualStyleBackColor = true;
            btnSuaDVDB.Click += btnSuaDVDB_Click;
            // 
            // btnThemDVDB
            // 
            btnThemDVDB.Location = new Point(78, 58);
            btnThemDVDB.Name = "btnThemDVDB";
            btnThemDVDB.Size = new Size(94, 29);
            btnThemDVDB.TabIndex = 0;
            btnThemDVDB.Text = "Thêm";
            btnThemDVDB.UseVisualStyleBackColor = true;
            btnThemDVDB.Click += btnThemDVDB_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtGhiChuLoai);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(txtTenLoaiDVDB);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(976, 57);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(379, 276);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Loại dịch vụ ĐB";
            // 
            // txtGhiChuLoai
            // 
            txtGhiChuLoai.Location = new Point(160, 87);
            txtGhiChuLoai.Multiline = true;
            txtGhiChuLoai.Name = "txtGhiChuLoai";
            txtGhiChuLoai.Size = new Size(206, 75);
            txtGhiChuLoai.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 84);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Ghi chú";
            // 
            // txtTenLoaiDVDB
            // 
            txtTenLoaiDVDB.Location = new Point(160, 34);
            txtTenLoaiDVDB.Name = "txtTenLoaiDVDB";
            txtTenLoaiDVDB.Size = new Size(206, 27);
            txtTenLoaiDVDB.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 37);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 4;
            label6.Text = "Tên Loại dịch vụ Đb\r\n";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dgrLoaiDVDB);
            groupBox5.Location = new Point(976, 351);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(524, 322);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            // 
            // dgrLoaiDVDB
            // 
            dgrLoaiDVDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrLoaiDVDB.Location = new Point(13, 15);
            dgrLoaiDVDB.Name = "dgrLoaiDVDB";
            dgrLoaiDVDB.RowHeadersWidth = 51;
            dgrLoaiDVDB.RowTemplate.Height = 29;
            dgrLoaiDVDB.Size = new Size(499, 301);
            dgrLoaiDVDB.TabIndex = 0;
            dgrLoaiDVDB.CellClick += dgrLoaiDVDB_CellClick;
            dgrLoaiDVDB.CellContentClick += dgrLoaiDVDB_CellContentClick;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnXoaLoai);
            groupBox6.Controls.Add(btnSuaLoai);
            groupBox6.Controls.Add(btnThemLoai);
            groupBox6.Location = new Point(1368, 57);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(139, 276);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Loại dịch vụ ĐB";
            // 
            // btnXoaLoai
            // 
            btnXoaLoai.Location = new Point(27, 189);
            btnXoaLoai.Name = "btnXoaLoai";
            btnXoaLoai.Size = new Size(94, 29);
            btnXoaLoai.TabIndex = 3;
            btnXoaLoai.Text = "Xóa";
            btnXoaLoai.UseVisualStyleBackColor = true;
            btnXoaLoai.Click += btnXoaLoai_Click;
            // 
            // btnSuaLoai
            // 
            btnSuaLoai.Location = new Point(27, 125);
            btnSuaLoai.Name = "btnSuaLoai";
            btnSuaLoai.Size = new Size(94, 29);
            btnSuaLoai.TabIndex = 1;
            btnSuaLoai.Text = "Sửa";
            btnSuaLoai.UseVisualStyleBackColor = true;
            btnSuaLoai.Click += btnSuaLoai_Click;
            // 
            // btnThemLoai
            // 
            btnThemLoai.Location = new Point(27, 57);
            btnThemLoai.Name = "btnThemLoai";
            btnThemLoai.Size = new Size(94, 29);
            btnThemLoai.TabIndex = 0;
            btnThemLoai.Text = "Thêm";
            btnThemLoai.UseVisualStyleBackColor = true;
            btnThemLoai.Click += btnThemLoai_Click;
            // 
            // f_QLDichVuDB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 685);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "f_QLDichVuDB";
            Text = "f_QLDichVuDB";
            Load += f_QLDichVuDB_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrDVDB).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrLoaiDVDB).EndInit();
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private ComboBox cmbLoaiDVDB;
        private TextBox txtTenDVDB;
        private Label label3;
        private TextBox txtGhiChu;
        private Label label5;
        private TextBox txtDonGia;
        private Label label4;
        private GroupBox groupBox2;
        private DataGridView dgrDVDB;
        private GroupBox groupBox3;
        private Button btnXoaDVDB;
        private Button btnSuaDVDB;
        private Button btnThemDVDB;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private DataGridView dgrLoaiDVDB;
        private TextBox txtGhiChuLoai;
        private Label label7;
        private TextBox txtTenLoaiDVDB;
        private Label label6;
        private GroupBox groupBox6;
        private Button btnXoaLoai;
        private Button btnSuaLoai;
        private Button btnThemLoai;
    }
}