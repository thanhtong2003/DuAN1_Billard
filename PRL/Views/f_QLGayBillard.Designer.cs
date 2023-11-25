namespace PRL
{
    partial class f_QLGayBillard
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
            textBox1 = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            txtDiaChi = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnXoaForm = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btnTimKiem = new Button();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 27);
            textBox1.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 174);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 48;
            label7.Text = "Số lượng";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(369, 27);
            txtEmail.TabIndex = 47;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(14, 131);
            label.Name = "label";
            label.Size = new Size(62, 20);
            label.TabIndex = 46;
            label.Text = "Đơn giá";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(108, 77);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(369, 27);
            txtSDT.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 84);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 44;
            label3.Text = "Loại gậy";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(108, 30);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(369, 27);
            txtDiaChi.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 42;
            label1.Text = "Tên gậy";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 213);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin gậy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(401, 24);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 51;
            label2.Text = "QUẢN LÝ GẬY";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaForm);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(508, 73);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(330, 120);
            groupBox3.TabIndex = 53;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(58, 75);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(94, 29);
            btnXoaForm.TabIndex = 4;
            btnXoaForm.Text = "Reset";
            btnXoaForm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(178, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(178, 75);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(58, 27);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 292);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(826, 347);
            groupBox4.TabIndex = 54;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách gậy";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(811, 321);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(508, 199);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(330, 87);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm theo tên gậy";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(227, 29);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 29);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 27);
            textBox4.TabIndex = 0;
            // 
            // f_QLGayBillard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 660);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Name = "f_QLGayBillard";
            Text = "f_QLGayBillard";
            Load += f_QLGayBillard_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label7;
        private TextBox txtEmail;
        private Label label;
        private TextBox txtSDT;
        private Label label3;
        private TextBox txtDiaChi;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox3;
        private Button btnXoaForm;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btnTimKiem;
        private TextBox textBox4;
    }
}