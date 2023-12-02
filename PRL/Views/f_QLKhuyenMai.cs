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

namespace PRL.Views
{
    public partial class f_QLKhuyenMai : Form
    {
        KhuyenMaiServices _services = new KhuyenMaiServices();
        int selectID = -1;
        public f_QLKhuyenMai()
        {
            InitializeComponent();
            _services = new KhuyenMaiServices();
        }


        private void LoadData(dynamic data)
        {
            dgrKhuyenMai.Rows.Clear();
            dgrKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrKhuyenMai.ColumnCount = 9;
            dgrKhuyenMai.Columns[0].Name = "stt"; dgrKhuyenMai.Columns[0].HeaderText = "Số thứ tự";
            dgrKhuyenMai.Columns[1].Name = "NgayTao"; dgrKhuyenMai.Columns[1].HeaderText = "Ngày tạo";
            dgrKhuyenMai.Columns[2].Name = "NgayHetHan"; dgrKhuyenMai.Columns[2].HeaderText = "Ngày hết hạn";
            dgrKhuyenMai.Columns[3].Name = "TenKhuyenMai"; dgrKhuyenMai.Columns[3].HeaderText = "Tên khuyến mãi";
            dgrKhuyenMai.Columns[4].Name = "MucGiam"; dgrKhuyenMai.Columns[4].HeaderText = "Mức giảm";
            dgrKhuyenMai.Columns[5].Name = "TrangThai"; dgrKhuyenMai.Columns[5].HeaderText = "Trạng thái";
            dgrKhuyenMai.Columns[6].Name = "SoLuong"; dgrKhuyenMai.Columns[6].HeaderText = "Số lượng";
            dgrKhuyenMai.Columns[7].Name = "GhiChu"; dgrKhuyenMai.Columns[7].HeaderText = "Ghi chú";
            dgrKhuyenMai.Columns[8].Name = "IdkhuyenMai";
            dgrKhuyenMai.Columns[8].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                // Thêm dữ liệu vào DataGridView
                dgrKhuyenMai.Rows.Add(stt++, item.NgayTao, item.NgayHetHan, item.TenKhuyenMai, item.MucGiam, item.TrangThai, item.SoLuong, item.GhiChu, item.IdkhuyenMai);
            }
        }
        private void f_QLKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData(_services.GetAll());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm khuyến mãi này không?", "Xác nhận Thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var obj = new KhuyenMai();
                obj.TenKhuyenMai = txtTenKhuyenMai.Text;
                obj.GhiChu = txtGhiChu.Text;
                obj.MucGiam = Convert.ToDouble(txtMucGiam.Text);
                obj.NgayTao = dateNgayTao.Value;
                obj.NgayHetHan = dateNgayHetHan.Value;
                obj.SoLuong = Convert.ToInt32(txtSoluong.Text);
                obj.TrangThai = "đang hoạt động";
                bool resurl = _services.Create(obj);
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

        private void dgrKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrKhuyenMai.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrKhuyenMai.Rows[index];
                dateNgayTao.Value = (DateTime)selectedRow.Cells[1].Value;
                dateNgayHetHan.Value = (DateTime)selectedRow.Cells[2].Value;
                txtTenKhuyenMai.Text = selectedRow.Cells[3].Value.ToString();
                txtMucGiam.Text = selectedRow.Cells[4].Value.ToString();
                txtSoluong.Text = selectedRow.Cells[6].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells[7].Value.ToString();
                selectID = Convert.ToInt32(selectedRow.Cells[8].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khuyến mãi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool resurl = _services.Delete(selectID);
                if (resurl)
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa khuyến mãi này không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var obj = new KhuyenMai();
                obj.TenKhuyenMai = txtTenKhuyenMai.Text;
                obj.GhiChu = txtGhiChu.Text;
                obj.MucGiam = Convert.ToDouble(txtMucGiam.Text);
                obj.NgayTao = dateNgayTao.Value;
                obj.NgayHetHan = dateNgayHetHan.Value;
                obj.SoLuong = Convert.ToInt32(txtSoluong.Text);
                obj.TrangThai = "đang hoạt động";
                bool resurl = _services.Update(selectID, obj);
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
    }
}
