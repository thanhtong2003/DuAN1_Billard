using BUS.Services;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class f_QLNhanVien : Form
    {
        ChucVuServices _chucVuSer = new ChucVuServices();
        NhanVienServices _nhanVienSer = new NhanVienServices();
        int selectID = -1;
        public f_QLNhanVien()
        {
            InitializeComponent();
            _chucVuSer = new ChucVuServices();
            _nhanVienSer = new NhanVienServices();

        }
        private void LoadData(dynamic data)
        {
            dgrNhanVien.Rows.Clear();
            dgrNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrNhanVien.ColumnCount = 12;
            dgrNhanVien.Columns[0].Name = "stt"; dgrNhanVien.Columns[0].HeaderText = "Số thứ tự";
            dgrNhanVien.Columns[1].Name = "IdchucVu"; dgrNhanVien.Columns[1].HeaderText = "Chức vụ";
            dgrNhanVien.Columns[2].Name = "TenNhanVien"; dgrNhanVien.Columns[2].HeaderText = "Tên nhân viên";
            dgrNhanVien.Columns[3].Name = "DiaChi"; dgrNhanVien.Columns[3].HeaderText = "Địa chỉ";
            dgrNhanVien.Columns[4].Name = "SoDienThoai"; dgrNhanVien.Columns[4].HeaderText = "Số điện thoại";
            dgrNhanVien.Columns[5].Name = "GioiTinh"; dgrNhanVien.Columns[5].HeaderText = "Giới tính";
            dgrNhanVien.Columns[6].Name = "NgaySinh"; dgrNhanVien.Columns[6].HeaderText = "Ngày sinh";
            dgrNhanVien.Columns[7].Name = "TrangThai"; dgrNhanVien.Columns[7].HeaderText = "Trạng thái";
            dgrNhanVien.Columns[8].Name = "TenDangNhap"; dgrNhanVien.Columns[8].HeaderText = "Tên đăng nhập";
            dgrNhanVien.Columns[9].Name = "MatKhau"; dgrNhanVien.Columns[9].HeaderText = "Mật khẩu";
            dgrNhanVien.Columns[10].Name = "Email"; dgrNhanVien.Columns[10].HeaderText = "Email";
            dgrNhanVien.Columns[11].Name = "id";
            dgrNhanVien.Columns[11].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                // Lấy tên chức vụ dựa vào ID chức vụ
                string tenChucVu = _chucVuSer.GetTenChucVu(item.IdchucVu);

                // Thêm dữ liệu vào DataGridView
                dgrNhanVien.Rows.Add(stt++, tenChucVu, item.TenNhanVien, item.DiaChi, item.SoDienThoai, item.GioiTinh, item.NgaySinh, item.TrangThai, item.TenDangNhap, item.MatKhau, item.Email, item.IdnhanVien);
            }
        }


        private void LoadChucVu()
        {
            List<ChucVu> danhSach = _chucVuSer.GetAll();
            cmbChucVu.Items.Clear();

            foreach (var chucVu in danhSach)
            {
                cmbChucVu.Items.Add(chucVu.TenChucVu);
            }

            if (cmbChucVu.Items.Count > 0)
            {
                cmbChucVu.SelectedIndex = 0;
            }
            cmbChucVu.SelectedIndexChanged += cmbChucVu_SelectedIndexChanged;
        }



        private void f_QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData(_nhanVienSer.GetAll());
            LoadChucVu();
            rdNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm nhân viên này không?", "Xác nhận Thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string tenChucVu = cmbChucVu.SelectedItem.ToString();
                var nhanVien = new NhanVien();
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.TenNhanVien = txtTenNhanVien.Text;
                nhanVien.SoDienThoai = txtSDT.Text;
                nhanVien.NgaySinh = dateNgaySinh.Value;
                nhanVien.TenDangNhap = txtTenDangNhap.Text;
                nhanVien.MatKhau = txtMatKhau.Text;
                nhanVien.IdchucVu = _chucVuSer.GetIdByTenChucVu(tenChucVu);
                nhanVien.GioiTinh = rdNam.Checked ? true : false;
                nhanVien.Email = txtEmail.Text;
                nhanVien.TrangThai = checkDaNghi.Checked ? "Đã nghỉ" : "Đang làm";
                bool addNhanVien = _nhanVienSer.Create(nhanVien);
                if (addNhanVien)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData(_nhanVienSer.GetAll());
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }


            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string tenChucVu = cmbChucVu.SelectedItem.ToString();
                var nhanVien = new NhanVien();
                nhanVien.DiaChi = txtDiaChi.Text;
                nhanVien.TenNhanVien = txtTenNhanVien.Text;
                nhanVien.SoDienThoai = txtSDT.Text;
                nhanVien.NgaySinh = dateNgaySinh.Value;
                nhanVien.TenDangNhap = txtTenDangNhap.Text;
                nhanVien.MatKhau = txtMatKhau.Text;
                nhanVien.IdchucVu = _chucVuSer.GetIdByTenChucVu(tenChucVu);
                nhanVien.GioiTinh = rdNam.Checked ? true : false;
                nhanVien.Email = txtEmail.Text;
                nhanVien.TrangThai = checkDaNghi.Checked ? "Đã nghỉ" : "Đang làm";
                bool updateNhanVien = _nhanVienSer.Update(selectID, nhanVien);
                if (updateNhanVien)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData(_nhanVienSer.GetAll());
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool deleteNhanVien = _nhanVienSer.Delete(selectID);
                if (deleteNhanVien)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData(_nhanVienSer.GetAll());
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private void btnThemChucVu_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChucVu.SelectedIndex != -1)
            {
                // Lấy tên chức vụ từ ComboBox
                string tenChucVu = cmbChucVu.SelectedItem.ToString();

                // Lấy ID chức vụ từ tên chức vụ sử dụng phương thức GetIdByTenChucVu
                int idChucVu = _chucVuSer.GetIdByTenChucVu(tenChucVu);

                // Sử dụng idChucVu theo nhu cầu của bạn
                Console.WriteLine("ID chức vụ: " + idChucVu);
            }
        }

        private void dgrNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrNhanVien.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrNhanVien.Rows[index];
                txtTenNhanVien.Text = selectedRow.Cells["TenNhanVien"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = selectedRow.Cells["SoDienThoai"].Value.ToString();
                dateNgaySinh.Value = (DateTime)selectedRow.Cells["NgaySinh"].Value;
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value.ToString();
                txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                rdNam.Checked = selectedRow.Cells["GioiTinh"].Value.ToString() == "True";
                rdNu.Checked = selectedRow.Cells["GioiTinh"].Value.ToString() == "False";
                checkDaNghi.Checked = selectedRow.Cells["TrangThai"].Value.ToString() == "Đã nghỉ";
                cmbChucVu.SelectedItem = selectedRow.Cells["IdchucVu"].Value.ToString();
                selectID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            }
        }

    }
}
