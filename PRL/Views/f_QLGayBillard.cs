using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace PRL
{


    public partial class f_QLGayBillard : Form
    {
        GayBi_aService _services = new GayBi_aService();
        int selectID = -1;
        public f_QLGayBillard()
        {
            InitializeComponent();
            _services = new GayBi_aService();
        }
        private void LoadData(dynamic data)
        {
            dgrGayBi_a.Rows.Clear();
            dgrGayBi_a.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrGayBi_a.ColumnCount = 7;
            dgrGayBi_a.Columns[0].Name = "stt"; dgrGayBi_a.Columns[0].HeaderText = "Số thứ tự";
            dgrGayBi_a.Columns[1].Name = "TenGayBiA"; dgrGayBi_a.Columns[1].HeaderText = "Tên Gậy Bi_a";
            dgrGayBi_a.Columns[2].Name = "LoaiGayBiA"; dgrGayBi_a.Columns[2].HeaderText = "Loại Gậy Bi_a";
            dgrGayBi_a.Columns[3].Name = "DonGia"; dgrGayBi_a.Columns[3].HeaderText = "Đơn giá";
            dgrGayBi_a.Columns[4].Name = "TrangThai"; dgrGayBi_a.Columns[4].HeaderText = "Trạng thái";
            dgrGayBi_a.Columns[5].Name = "SoLuong"; dgrGayBi_a.Columns[5].HeaderText = "Số lượng";
            dgrGayBi_a.Columns[6].Name = "id";
            dgrGayBi_a.Columns[6].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                // Thêm dữ liệu vào DataGridView
                dgrGayBi_a.Rows.Add(stt++, item.TenGayBiA, item.LoaiGayBiA, item.DonGia, item.TrangThai, item.SoLuong, item.IdgayBiA);
            }
        }
        private void f_QLGayBillard_Load(object sender, EventArgs e)
        {
            ClearData();
            LoadData(_services.GetAll());
        }

        private void dgrGayBi_a_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrGayBi_a.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrGayBi_a.Rows[index];
                txtTenGay.Text = selectedRow.Cells[1].Value.ToString();
                txtLoaiGay.Text = selectedRow.Cells[2].Value.ToString();
                txtDonGia.Text = selectedRow.Cells[3].Value.ToString();
                checkHetGay.Checked = selectedRow.Cells[4].Value.ToString() == "Hết gậy";
                txtSoLuong.Text = selectedRow.Cells[5].Value.ToString();
                selectID = Convert.ToInt32(selectedRow.Cells[6].Value);

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thêm gậy này không?", "Xác nhận Thêm", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var themObj = new GayBium();
                themObj.TenGayBiA = txtTenGay.Text;
                themObj.LoaiGayBiA = txtLoaiGay.Text;
                themObj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                themObj.TrangThai = checkHetGay.Checked ? "Hết gậy" : "Còn gậy";
                themObj.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                bool resurl = _services.Create(themObj);
                if (resurl)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData(_services.GetAll());
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }

        }
        private void ClearData()
        {
            txtDonGia.Text = null;
            txtTenGay.Text = null;
            txtLoaiGay.Text = null;
            txtDonGia.Text = null;
            txtSoLuong.Text = null;
            checkHetGay.Checked = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn sửa gậy này không?", "Xác nhận sửa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var Obj = new GayBium();
                Obj.TenGayBiA = txtTenGay.Text;
                Obj.LoaiGayBiA = txtLoaiGay.Text;
                Obj.DonGia = Convert.ToDecimal(txtDonGia.Text);
                Obj.TrangThai = checkHetGay.Checked ? "Hết gậy" : "Còn gậy";
                Obj.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                bool resurl = _services.Update(selectID, Obj);
                if (resurl)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData(_services.GetAll());
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa gậy này không?", "Xác nhận xóa", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool resurl = _services.Delete(selectID);
                if (resurl)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData(_services.GetAll());
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
