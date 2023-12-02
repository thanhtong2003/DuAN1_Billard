namespace PRL
{
    partial class f_QLPartner
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
            textBox4 = new TextBox();
            groupBox2 = new GroupBox();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            btnTimKiem = new Button();
            label4 = new Label();
            dgrPartner = new DataGridView();
            groupBox4 = new GroupBox();
            btnXoaForm = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            checkTrangthai = new CheckBox();
            cmbLoaiPartner = new ComboBox();
            txtTenPartner = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            label = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrPartner).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(5, 22);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(459, 111);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(355, 103);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm ";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(82, 77);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(248, 23);
            comboBox3.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 83);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 52;
            label5.Text = "Loại Partner";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(82, 48);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(248, 23);
            comboBox2.TabIndex = 51;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(248, 22);
            btnTimKiem.Margin = new Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(82, 22);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 54);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 50;
            label4.Text = "Trạng thái";
            // 
            // dgrPartner
            // 
            dgrPartner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrPartner.Location = new Point(5, 20);
            dgrPartner.Margin = new Padding(3, 2, 3, 2);
            dgrPartner.Name = "dgrPartner";
            dgrPartner.RowHeadersWidth = 51;
            dgrPartner.RowTemplate.Height = 29;
            dgrPartner.Size = new Size(779, 248);
            dgrPartner.TabIndex = 0;
            dgrPartner.CellClick += dgrPartner_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgrPartner);
            groupBox4.Location = new Point(25, 218);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(789, 260);
            groupBox4.TabIndex = 59;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách Partner";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(268, 20);
            btnXoaForm.Margin = new Padding(3, 2, 3, 2);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(82, 22);
            btnXoaForm.TabIndex = 4;
            btnXoaForm.Text = "Reset";
            btnXoaForm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(93, 20);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(180, 20);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(5, 21);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaForm);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(459, 54);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(355, 52);
            groupBox3.TabIndex = 58;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 17);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 56;
            label2.Text = "QUẢN LÝ PARTNER";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkTrangthai);
            groupBox1.Controls.Add(cmbLoaiPartner);
            groupBox1.Controls.Add(txtTenPartner);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label);
            groupBox1.Location = new Point(25, 54);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(429, 160);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Partner";
            // 
            // checkTrangthai
            // 
            checkTrangthai.AutoSize = true;
            checkTrangthai.Location = new Point(98, 127);
            checkTrangthai.Name = "checkTrangthai";
            checkTrangthai.Size = new Size(81, 19);
            checkTrangthai.TabIndex = 51;
            checkTrangthai.Text = "Đang nghỉ";
            checkTrangthai.UseVisualStyleBackColor = true;
            // 
            // cmbLoaiPartner
            // 
            cmbLoaiPartner.FormattingEnabled = true;
            cmbLoaiPartner.Location = new Point(94, 62);
            cmbLoaiPartner.Margin = new Padding(3, 2, 3, 2);
            cmbLoaiPartner.Name = "cmbLoaiPartner";
            cmbLoaiPartner.Size = new Size(324, 23);
            cmbLoaiPartner.TabIndex = 50;
            // 
            // txtTenPartner
            // 
            txtTenPartner.Location = new Point(94, 22);
            txtTenPartner.Margin = new Padding(3, 2, 3, 2);
            txtTenPartner.Name = "txtTenPartner";
            txtTenPartner.Size = new Size(323, 23);
            txtTenPartner.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 130);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 48;
            label7.Text = "Trạng thái";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 42;
            label1.Text = "Tên Partner";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(94, 93);
            txtDonGia.Margin = new Padding(3, 2, 3, 2);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(323, 23);
            txtDonGia.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 44;
            label3.Text = "Loại Partner";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 98);
            label.Name = "label";
            label.Size = new Size(48, 15);
            label.TabIndex = 46;
            label.Text = "Đơn giá";
            // 
            // f_QLPartner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 495);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "f_QLPartner";
            Text = "f_QLPartner";
            Load += f_QLPartner_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrPartner).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private DataGridView dgrPartner;
        private GroupBox groupBox4;
        private Button btnXoaForm;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtTenPartner;
        private Label label7;
        private Label label1;
        private TextBox txtDonGia;
        private Label label3;
        private Label label;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox cmbLoaiPartner;
        private CheckBox checkTrangthai;
    }
}