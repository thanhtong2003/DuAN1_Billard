using BUS.IServices;
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

namespace PRL.Views
{
    public partial class f_QLMemberShip : Form
    {
        MemberServices _services = new MemberServices();
        int selectedID = -1;
        public f_QLMemberShip()
        {
            InitializeComponent();
            _services = new MemberServices();
        }

        private void f_QLMemberShip_Load(object sender, EventArgs e)
        {

        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            var obj = new MemBerShip();
            obj.NgayGiaNhap = dateGiaNhap.Value;
            obj.NgayHetHan = dateHan.Value;
            obj.PhanTramGiam = Convert.ToDouble(txtPhanTramGiam.Text);
            obj.LoaiTheThanhVien = txtTenMember.Text;

            bool themObj = _services.Create(obj);
            if (themObj)
            {
                MessageBox.Show("Thêm thành công");
                LoadData(_services.GetAll());

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void LoadData(dynamic data)
        {
            dgrMember.Rows.Clear();
            dgrMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrMember.ColumnCount = 6;
            dgrMember.Columns[0].Name = "stt"; dgrMember.Columns[0].HeaderText = "Số thứ tự";
            dgrMember.Columns[1].Name = "NgayGiaNhap"; dgrMember.Columns[1].HeaderText = "Ngày Gia nhập";
            dgrMember.Columns[2].Name = "Ngayhethan"; dgrMember.Columns[2].HeaderText = "Ngày hết hạn";
            dgrMember.Columns[3].Name = "TenTheThanhVien"; dgrMember.Columns[3].HeaderText = "Tên Membership";
            dgrMember.Columns[4].Name = "PhantramGIam"; dgrMember.Columns[4].HeaderText = "Phần trăm giảm";
            dgrMember.Columns[5].Name = "id";
            dgrMember.Columns[5].Visible = false;
            int stt = 1;
            foreach (var item in data)
            {
                dgrMember.Rows.Add(stt++, item.NgayGiaNhap, item.NgayHetHan, item.LoaiTheThanhVien, item.PhanTramGiam, item.IdmemBerShip);
            }

        }
        private void dgrMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectMember = dgrMember.Rows[index];
            txtTenMember.Text = selectMember.Cells[3].Value.ToString();
            txtPhanTramGiam.Text = selectMember.Cells[4].Value.ToString();
            dateGiaNhap.Value = (DateTime)selectMember.Cells[1].Value;
            dateHan.Value = (DateTime)selectMember.Cells[2].Value;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData(_services.GetAll());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var obj = new MemBerShip();
            obj.NgayGiaNhap = dateGiaNhap.Value;
            obj.NgayHetHan = dateHan.Value;
            obj.PhanTramGiam = Convert.ToDouble(txtPhanTramGiam.Text);
            obj.LoaiTheThanhVien = txtTenMember.Text;

            bool themObj = _services.Update(selectedID, obj);
            if (themObj)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_services.GetAll());

            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dgrMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selectMember = dgrMember.Rows[index];
            txtTenMember.Text = selectMember.Cells[3].Value.ToString();
            txtPhanTramGiam.Text = selectMember.Cells[4].Value.ToString();
            dateGiaNhap.Value = (DateTime)selectMember.Cells[1].Value;
            dateHan.Value = (DateTime)selectMember.Cells[2].Value;
            selectedID = Convert.ToInt32(selectMember.Cells[5].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool Obj = _services.Delete(selectedID);
            if (Obj)
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


