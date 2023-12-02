namespace PRL
{
    partial class f_ChucVu
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
            txtTenChucVu = new TextBox();
            dgrChucVu = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrChucVu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên chức vụ";
            // 
            // txtTenChucVu
            // 
            txtTenChucVu.Location = new Point(116, 23);
            txtTenChucVu.Margin = new Padding(3, 2, 3, 2);
            txtTenChucVu.Name = "txtTenChucVu";
            txtTenChucVu.Size = new Size(330, 23);
            txtTenChucVu.TabIndex = 1;
            // 
            // dgrChucVu
            // 
            dgrChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrChucVu.Location = new Point(21, 62);
            dgrChucVu.Margin = new Padding(3, 2, 3, 2);
            dgrChucVu.Name = "dgrChucVu";
            dgrChucVu.RowHeadersWidth = 51;
            dgrChucVu.RowTemplate.Height = 29;
            dgrChucVu.Size = new Size(424, 141);
            dgrChucVu.TabIndex = 2;
            dgrChucVu.CellClick += dgrChucVu_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(57, 223);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(169, 223);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(285, 223);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // f_ChucVu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 255);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgrChucVu);
            Controls.Add(txtTenChucVu);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "f_ChucVu";
            Text = "f_ChucVu";
            Load += f_ChucVu_Load;
            ((System.ComponentModel.ISupportInitialize)dgrChucVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenChucVu;
        private DataGridView dgrChucVu;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}