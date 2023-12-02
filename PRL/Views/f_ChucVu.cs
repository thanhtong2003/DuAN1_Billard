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

namespace PRL
{
    public partial class f_ChucVu : Form
    {
        ChucVuServices _services = new ChucVuServices();
        int selectID = -1;
        public f_ChucVu()
        {
            InitializeComponent();
            _services = new ChucVuServices();
        }

        private void LoadData(dynamic data)
        {
            dgrChucVu.Rows.Clear();
            dgrChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrChucVu.ColumnCount = 3;
            dgrChucVu.Columns[0].Name = "stt"; dgrChucVu.Columns[0].HeaderText = "Số thứ tự";
            dgrChucVu.Columns[1].Name = "TenChucVu"; dgrChucVu.Columns[1].HeaderText = "Tên Chức vụ";
            dgrChucVu.Columns[2].Name = "id";
            dgrChucVu.Columns[2].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                dgrChucVu.Rows.Add(stt++, item.TenChucVu, item.IdchucVu);
            }
        }

        private void f_ChucVu_Load(object sender, EventArgs e)
        {
            LoadData(_services.GetAll());
            Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var themChucVu = new ChucVu();
            themChucVu.TenChucVu = txtTenChucVu.Text;
            bool resurl = _services.Create(themChucVu);
            if (resurl)
            {
                MessageBox.Show("Thêm thành công");
                LoadData(_services.GetAll());
                Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var SuaChucVu = new ChucVu();
            SuaChucVu.TenChucVu = txtTenChucVu.Text;
            bool resurl = _services.Update(selectID, SuaChucVu);
            if (resurl)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_services.GetAll());
                Clear();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dgrChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrChucVu.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrChucVu.Rows[index];
                txtTenChucVu.Text = selectedRow.Cells[1].Value.ToString();
                selectID = Convert.ToInt32(selectedRow.Cells[2].Value);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool resurl = _services.Delete(selectID);
            if (resurl)
            {
                MessageBox.Show("Xóa thành công");
                LoadData(_services.GetAll());
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        public void Clear()
        {
            txtTenChucVu.Text = null;
        }
    }
}
