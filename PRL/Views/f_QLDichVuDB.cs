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
    public partial class f_QLDichVuDB : Form
    {
        LoaiDVDBServices _loaiService = new LoaiDVDBServices();
        DichVuDBServices _dichVuService = new DichVuDBServices();
        int selectID = -1;
        int selectIDDV = -1;
        public f_QLDichVuDB()
        {
            InitializeComponent();
            _loaiService = new LoaiDVDBServices();
            _dichVuService = new DichVuDBServices();
        }
        private void LoadDataLoaiDichVu(dynamic data)
        {
            dgrLoaiDVDB.Rows.Clear();
            dgrLoaiDVDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrLoaiDVDB.ColumnCount = 4;
            dgrLoaiDVDB.Columns[0].Name = "stt"; dgrLoaiDVDB.Columns[0].HeaderText = "Số thứ tự";
            dgrLoaiDVDB.Columns[1].Name = "TenLoaiDichVuDb"; dgrLoaiDVDB.Columns[1].HeaderText = "Tên Loại dịch vụ";
            dgrLoaiDVDB.Columns[2].Name = "MoTa"; dgrLoaiDVDB.Columns[2].HeaderText = "Mô tả";
            dgrLoaiDVDB.Columns[3].Name = "IdloaiDichVuDb";
            dgrLoaiDVDB.Columns[3].Visible = false;
            int stt = 1;
            foreach (var item in data)
            {
                dgrLoaiDVDB.Rows.Add(stt++, item.TenLoaiDichVuDb, item.MoTa, item.IdloaiDichVuDb);
            }
        }
        private void LoadDataDichVuDB(dynamic data)
        {
            dgrDVDB.Rows.Clear();
            dgrDVDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrDVDB.ColumnCount = 6;
            dgrDVDB.Columns[0].Name = "stt"; dgrDVDB.Columns[0].HeaderText = "Số thứ tự";
            dgrDVDB.Columns[1].Name = "IdloaiDichVu"; dgrDVDB.Columns[1].HeaderText = " Loại dịch vụ";
            dgrDVDB.Columns[2].Name = "TenDichVuDb"; dgrDVDB.Columns[2].HeaderText = "Tên dịch vụ";
            dgrDVDB.Columns[3].Name = "MoTa"; dgrDVDB.Columns[3].HeaderText = "Mô tả";
            dgrDVDB.Columns[4].Name = "DonGia"; dgrDVDB.Columns[4].HeaderText = "Đơn giá";
            dgrDVDB.Columns[5].Name = "IddichVuDb";
            dgrDVDB.Columns[5].Visible = false;
            int stt = 1;
            foreach (var item in data)
            {
                string Tenloai = _loaiService.GetByName(item.IdloaiDichVu);

                dgrDVDB.Rows.Add(stt++, Tenloai, item.TenDichVuDb, item.MoTa, item.DonGia, item.IddichVuDb);
            }
        }
        private void LoadloaiDV()
        {
            List<LoaiDichVuDb> danhSach = _loaiService.GetAll();
            cmbLoaiDVDB.Items.Clear();

            foreach (var item in danhSach)
            {
                cmbLoaiDVDB.Items.Add(item.TenLoaiDichVuDb);
            }

            if (cmbLoaiDVDB.Items.Count > 0)
            {
                cmbLoaiDVDB.SelectedIndex = 0;
            }
            cmbLoaiDVDB.SelectedIndexChanged += cmbLoaiDVDB_SelectedIndexChanged;
        }

        private void f_QLDichVuDB_Load(object sender, EventArgs e)
        {
            LoadDataLoaiDichVu(_loaiService.GetAll());
            LoadDataDichVuDB(_dichVuService.GetAll());
            LoadloaiDV();
            ClearLoai();
            clearDichVu();
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm loại dịch vụ này không?", "Xác nhận thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var obj = new LoaiDichVuDb();
                obj.TenLoaiDichVuDb = txtTenLoaiDVDB.Text;
                obj.MoTa = txtGhiChuLoai.Text;
                bool resurl = _loaiService.Create(obj);
                if (resurl)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataLoaiDichVu(_loaiService.GetAll());
                    ClearLoai();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa loại dịch vụ này không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var obj = new LoaiDichVuDb();
                obj.TenLoaiDichVuDb = txtTenLoaiDVDB.Text;
                obj.MoTa = txtGhiChuLoai.Text;
                bool resurl = _loaiService.Update(selectID, obj);
                if (resurl)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDataLoaiDichVu(_loaiService.GetAll());
                    ClearLoai();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void dgrLoaiDVDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrLoaiDVDB.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrLoaiDVDB.Rows[index];
                txtTenLoaiDVDB.Text = selectedRow.Cells[1].Value.ToString();
                txtGhiChuLoai.Text = selectedRow.Cells[2].Value.ToString();
                selectID = Convert.ToInt32(selectedRow.Cells[3].Value);
            }
        }

        private void dgrLoaiDVDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrLoaiDVDB.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrLoaiDVDB.Rows[index];
                txtTenLoaiDVDB.Text = selectedRow.Cells[1].Value.ToString();
                txtGhiChuLoai.Text = selectedRow.Cells[2].Value.ToString();
            }
        }
        private void ClearLoai()
        {
            txtTenLoaiDVDB.Text = null;
            txtGhiChuLoai.Text = null;
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại dịch vụ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool resurl = _loaiService.Delete(selectID);
                if (resurl)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDataLoaiDichVu(_loaiService.GetAll());
                    ClearLoai();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void cmbLoaiDVDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiDVDB.SelectedIndex != -1)
            {
                string tenLoai = cmbLoaiDVDB.SelectedItem.ToString();
                int idLoai = _loaiService.GetIdByName(tenLoai);

                Console.WriteLine("ID chức vụ: " + idLoai);
            }
        }

        

        private void btnThemDVDB_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm dịch vụ này không?", "Xác nhận Thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string tenLoai = cmbLoaiDVDB.SelectedItem.ToString();
                var obj = new DichVuDb();
                obj.TenDichVuDb = txtTenDVDB.Text;
                obj.IddichVuDb = _loaiService.GetIdByName(tenLoai);
                obj.MoTa = txtGhiChu.Text;
                obj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                bool resurl = _dichVuService.Create(obj);
                if (resurl)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDataDichVuDB(_dichVuService.GetAll());
                    clearDichVu();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void dgrDVDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrDVDB.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrDVDB.Rows[index];
                txtTenDVDB.Text = selectedRow.Cells[2].Value.ToString();
                cmbLoaiDVDB.SelectedItem = selectedRow.Cells[1].Value.ToString();
                txtGhiChu.Text = selectedRow.Cells[3].Value.ToString();
                txtDonGia.Text = selectedRow.Cells[4].Value.ToString();
                selectIDDV = Convert.ToInt32(selectedRow.Cells[5].Value);
            }
        }

        private void btnSuaDVDB_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dịch vụ này không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                string tenLoai = cmbLoaiDVDB.SelectedItem.ToString();
                var obj = new DichVuDb();
                obj.TenDichVuDb = txtTenDVDB.Text;
                obj.IddichVuDb = _loaiService.GetIdByName(tenLoai);
                obj.MoTa = txtGhiChu.Text;
                obj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                bool resurl = _dichVuService.Update(selectIDDV, obj);
                if (resurl)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadDataDichVuDB(_dichVuService.GetAll());
                    clearDichVu();

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoaDVDB_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                
                bool resurl = _dichVuService.Delete(selectIDDV);
                if (resurl)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadDataDichVuDB(_dichVuService.GetAll());
                    clearDichVu();

                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void clearDichVu()
        {
            txtDonGia.Text = null;
            txtGhiChu.Text = null;
            txtTenDVDB.Text = null;
        }
    }
}
