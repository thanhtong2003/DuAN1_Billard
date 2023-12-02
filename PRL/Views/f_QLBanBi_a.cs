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
    public partial class f_QLBanBi_a : Form
    {
        BanBi_AServices _services = new BanBi_AServices();
        int selectID = 1;
        public f_QLBanBi_a()
        {
            InitializeComponent();
            _services = new BanBi_AServices();
        }

        private void LoadData(dynamic data)
        {
            dgrBanBi_a.Rows.Clear();
            dgrBanBi_a.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgrBanBi_a.ColumnCount = 7;
            dgrBanBi_a.Columns[0].Name = "stt"; dgrBanBi_a.Columns[0].HeaderText = "Số thứ tự";
            dgrBanBi_a.Columns[1].Name = "TenBan"; dgrBanBi_a.Columns[1].HeaderText = "Tên bàn";
            dgrBanBi_a.Columns[2].Name = "LoaiBan"; dgrBanBi_a.Columns[2].HeaderText = "Loại bàn";
            dgrBanBi_a.Columns[3].Name = "CapBan"; dgrBanBi_a.Columns[3].HeaderText = "Cấp Bàn";
            dgrBanBi_a.Columns[4].Name = "TrangThai"; dgrBanBi_a.Columns[4].HeaderText = "Trạng thái";
            dgrBanBi_a.Columns[5].Name = "DonGia"; dgrBanBi_a.Columns[5].HeaderText = "Đơn giá";
            dgrBanBi_a.Columns[6].Name = "id";
            dgrBanBi_a.Columns[6].Visible = false;

            int stt = 1;
            foreach (var item in data)
            {
                dgrBanBi_a.Rows.Add(stt++, item.TenBanBiA, item.LoaiBanBiA.ToString(), item.CapBanBiA, item.TrangThai, item.DonGia, item.IdbanBiA);
            }
        }
        private void LoadCombo()
        {
            List<string> list = new List<string>
            {
                "Pool",
                "Carom ",
                "Snooker",
            };
            cmbLoaiBan.DataSource = list;
            cmbLoaiBan.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var ThemData = new BanBium();
            ThemData.TenBanBiA = txtTenBan.Text;
            ThemData.DonGia = decimal.Parse(txtDonGia.Text);
            ThemData.LoaiBanBiA = cmbLoaiBan.SelectedItem?.ToString();

            ThemData.CapBanBiA = rdbThuong.Checked ? "Thường" : "VIP";

            ThemData.TrangThai = chbSua.Checked ? "Đang sửa" : "";

            bool addObj = _services.Create(ThemData);

            if (addObj)
            {
                MessageBox.Show("Thêm thành công");
                LoadData(_services.GetAll());
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgrBanBi_a_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void f_QLBanBi_a_Load(object sender, EventArgs e)
        {
            LoadData(_services.GetAll());
            LoadCombo();
        }

        private void dgrBanBi_a_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgrBanBi_a.Rows.Count)
            {
                int index = e.RowIndex;
                var selectedRow = dgrBanBi_a.Rows[index];

                //Lấy dữ liệu từ DataGridView và điền vào các trường
                txtTenBan.Text = selectedRow.Cells["TenBan"].Value.ToString();
                txtDonGia.Text = selectedRow.Cells["DonGia"].Value.ToString();

                //Kiểm tra và đặt giá trị của ComboBox
                cmbLoaiBan.SelectedItem = selectedRow.Cells["LoaiBan"].Value?.ToString();

                //Kiểm tra và đặt giá trị của RadioButton
                rdbThuong.Checked = selectedRow.Cells["CapBan"].Value.ToString() == "Thường";
                rdbVIP.Checked = selectedRow.Cells["CapBan"].Value.ToString() == "VIP";

                //Kiểm tra và đặt giá trị của CheckBox
                chbSua.Checked = selectedRow.Cells["TrangThai"].Value.ToString() == "Đang sửa";
                selectID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var SuaData = new BanBium();
            SuaData.TenBanBiA = txtTenBan.Text;
            SuaData.DonGia = decimal.Parse(txtDonGia.Text);
            SuaData.LoaiBanBiA = cmbLoaiBan.SelectedItem?.ToString();

            SuaData.CapBanBiA = rdbThuong.Checked ? "Thường" : "VIP";

            SuaData.TrangThai = chbSua.Checked ? "Đang sửa" : "";

            bool updateObj = _services.Update(selectID, SuaData);

            if (updateObj)
            {
                MessageBox.Show("Sửa thành công");
                LoadData(_services.GetAll());
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bool XoaObj = _services.Delete(selectID);
            if (XoaObj)
            {
                MessageBox.Show("Xóa thành công");
                LoadData(_services.GetAll());

            }
            else
            {
                MessageBox.Show("xóa thất bại");
            }
        }
    }
}
