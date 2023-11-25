namespace PRL.Views
{
    partial class f_QLMemberShip
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
            groupBox3 = new GroupBox();
            btnLoadData = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            txtPhanTramGiam = new TextBox();
            label4 = new Label();
            txtTenMember = new TextBox();
            label3 = new Label();
            dateHan = new DateTimePicker();
            label2 = new Label();
            dateGiaNhap = new DateTimePicker();
            label1 = new Label();
            label5 = new Label();
            dgrMember = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrMember).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLoadData);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Location = new Point(977, 72);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(251, 218);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(80, 151);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(94, 29);
            btnLoadData.TabIndex = 4;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
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
            groupBox1.Controls.Add(txtPhanTramGiam);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTenMember);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateHan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dateGiaNhap);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(59, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 218);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // txtPhanTramGiam
            // 
            txtPhanTramGiam.Location = new Point(564, 132);
            txtPhanTramGiam.Name = "txtPhanTramGiam";
            txtPhanTramGiam.Size = new Size(250, 27);
            txtPhanTramGiam.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 139);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 6;
            label4.Text = "Phần trăm giảm";
            // 
            // txtTenMember
            // 
            txtTenMember.Location = new Point(150, 135);
            txtTenMember.Name = "txtTenMember";
            txtTenMember.Size = new Size(250, 27);
            txtTenMember.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 142);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Cấp VIP";
            // 
            // dateHan
            // 
            dateHan.Location = new Point(564, 55);
            dateHan.Name = "dateHan";
            dateHan.Size = new Size(250, 27);
            dateHan.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 60);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày hết hạn";
            // 
            // dateGiaNhap
            // 
            dateGiaNhap.Location = new Point(150, 56);
            dateGiaNhap.Name = "dateGiaNhap";
            dateGiaNhap.Size = new Size(250, 27);
            dateGiaNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày gia nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(486, 9);
            label5.Name = "label5";
            label5.Size = new Size(153, 31);
            label5.TabIndex = 14;
            label5.Text = "MemBerShip";
            // 
            // dgrMember
            // 
            dgrMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrMember.Location = new Point(196, 331);
            dgrMember.Name = "dgrMember";
            dgrMember.RowHeadersWidth = 51;
            dgrMember.RowTemplate.Height = 29;
            dgrMember.Size = new Size(934, 268);
            dgrMember.TabIndex = 15;
            dgrMember.CellClick += dgrMember_CellClick;
            dgrMember.CellContentClick += dgrMember_CellContentClick;
            // 
            // f_QLMemberShip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 648);
            Controls.Add(dgrMember);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "f_QLMemberShip";
            Text = "f_QLMemberShip";
            Load += f_QLMemberShip_Load;
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btnLoadData;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox1;
        private TextBox txtPhanTramGiam;
        private Label label4;
        private TextBox txtTenMember;
        private Label label3;
        private DateTimePicker dateHan;
        private Label label2;
        private DateTimePicker dateGiaNhap;
        private Label label1;
        private Label label5;
        private DataGridView dgrMember;
    }
}