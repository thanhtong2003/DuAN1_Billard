using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PRL
{
    public partial class f_QLPartner : Form
    {
        ParterServices _services = new ParterServices();
        int selectID = -1;
        public f_QLPartner()
        {
            InitializeComponent();
            _services = new ParterServices();
        }
        private void LoadData(dynamic data)
        {
            dgrPartner.Rows.Clear();
            dgrPartner.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrPartner.ColumnCount = 6;
            dgrPartner.Columns[0].Name = "stt"; dgrPartner.Columns[0].HeaderText = "Số thứ tự";
            dgrPartner.Columns[1].Name = "TenPatrner"; dgrPartner.Columns[1].HeaderText = "Tên Patrner";
            dgrPartner.Columns[2].Name = "LoaiPartner"; dgrPartner.Columns[2].HeaderText = "Loại Partner";
            dgrPartner.Columns[3].Name = "DonGia"; dgrPartner.Columns[3].HeaderText = "Dơn giá";
            dgrPartner.Columns[4].Name = "TrangThai"; dgrPartner.Columns[4].HeaderText = "Trạng thái";
            dgrPartner.Columns[5].Name = "id";
            dgrPartner.Columns[5].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                dgrPartner.Rows.Add(stt++, item.TenPatrner, item.LoaiPartner, item.DonGia, item.TrangThai, item.Idpartner);
            }
        }

        private void LoadComboLoaiPartner()
        {
            List<string> list = new List<string>
            {
                "Người dạy chơi",
                "Người chơi cùng",

            };
            cmbLoaiPartner.DataSource = list;
            cmbLoaiPartner.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm Partner không?", "Xác nhận thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var themObj = new Partner();
                themObj.TenPatrner = txtTenPartner.Text;
                themObj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                themObj.LoaiPartner = cmbLoaiPartner.SelectedItem?.ToString();
                themObj.TrangThai = checkTrangthai.Checked ? "Đã nghỉ" : "Còn trống";
                bool resurl = _services.Create(themObj);
                if (resurl)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData(_services.GetAll());
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void f_QLPartner_Load(object sender, EventArgs e)
        {
            LoadData(_services.GetAll());
            LoadComboLoaiPartner();
        }

        private void dgrPartner_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrPartner.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrPartner.Rows[index];

                // Lấy dữ liệu từ DataGridView và điền vào các trường
                txtTenPartner.Text = selectedRow.Cells[1].Value.ToString();
                txtDonGia.Text = selectedRow.Cells[3].Value.ToString();

                // Kiểm tra và đặt giá trị của ComboBox
                cmbLoaiPartner.SelectedItem = selectedRow.Cells[2].Value?.ToString();

                // Kiểm tra và đặt giá trị của RadioButton


                // Kiểm tra và đặt giá trị của CheckBox
                checkTrangthai.Checked = selectedRow.Cells[4].Value.ToString() == "Đang nghỉ";
                selectID = Convert.ToInt32(selectedRow.Cells[5].Value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn Sửa Partner không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var SuaObj = new Partner();
                SuaObj.TenPatrner = txtTenPartner.Text;
                SuaObj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                SuaObj.LoaiPartner = cmbLoaiPartner.SelectedItem?.ToString();
                if (checkTrangthai.Checked)
                {
                    SuaObj.TrangThai = "Đang nghỉ";
                }
                bool resurl = _services.Update(selectID, SuaObj);
                if (resurl)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData(_services.GetAll());
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Partner không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool XoaObj = _services.Delete(selectID);
                if (XoaObj)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData(_services.GetAll());
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
