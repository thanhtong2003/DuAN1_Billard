﻿namespace PRL.Views
{
    partial class f_QLKhuyenMai
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnXoaForm = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(95, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(612, 19);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 1;
            label1.Text = "Khuyến mại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 91);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 0;
            label2.Text = "Số lượng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(130, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 35);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày tạo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(121, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(548, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 37);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 91);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 6;
            label5.Text = "Tên khuyến mãi";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(130, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 146);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 8;
            label6.Text = "Mức giảm";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(548, 146);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 82);
            textBox3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 149);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 11;
            label7.Text = "Ghi chú";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1157, 301);
            dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoaForm);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(1017, 83);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 248);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnXoaForm
            // 
            btnXoaForm.Location = new Point(80, 172);
            btnXoaForm.Name = "btnXoaForm";
            btnXoaForm.Size = new Size(94, 29);
            btnXoaForm.TabIndex = 4;
            btnXoaForm.Text = "Reset";
            btnXoaForm.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(80, 68);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(80, 119);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(80, 33);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(548, 91);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 12;
            // 
            // f_QLKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 734);
            Controls.Add(groupBox3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "f_QLKhuyenMai";
            Text = "f_QLKhuyenMai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnXoaForm;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TextBox textBox4;
    }
}