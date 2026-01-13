using QuanLySinhVien.BLL;
using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien.GUI
{
    public partial class fQuanLyCoVanHocTap : Form
    {
        public fQuanLyCoVanHocTap()
        {
            InitializeComponent();
        }

        private void fQuanLyCoVanHocTap_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvCoVanHocTap.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";
            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();
            try
            {
                if (BLL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Mã giảng viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void dgvCoVanHocTap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvCoVanHocTap.CurrentRow.Cells[0].Value.ToString();
            txbMaCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[1].Value.ToString();
            txbTenCoVan.Text = dgvCoVanHocTap.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvCoVanHocTap.CurrentRow.Cells[3].Value;
            if (dgvCoVanHocTap.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            cmbMaLop.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[6].Value.ToString().Trim();
            cmbMaKhoa.SelectedValue = dgvCoVanHocTap.CurrentRow.Cells[5].Value.ToString().Trim();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maCoVan = txbMaCoVan.Text;
            if (MessageBox.Show($"Bạn có muốn xóa cố vấn {maCoVan}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (BLL_CoVanHocTap.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã giảng viên đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string macovan = txbMaCoVan.Text;
            string tencovan = txbTenCoVan.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = rdNam.Checked ? "Nam" : "Nữ";
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string malop = cmbMaLop.SelectedValue.ToString();


            try
            {
                if (BLL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Mã giảng viên đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
