using QuanLySinhVien.BLL;
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
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }
        private void fSinhVien_Load(object sender, EventArgs e)
        {
            if(HeThong.LOAITAIKHOAN != "Quản trị")
            {
                quảnLýKhoaToolStripMenuItem.Visible = false;
                quảnLýLớpToolStripMenuItem.Visible = false;
                quảnLýTrợGiảngToolStripMenuItem.Visible = false;
                quảnLýMônHọcToolStripMenuItem.Visible = false;
                quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
            }
            else
            {
                quảnLýKhoaToolStripMenuItem.Visible = true;
                quảnLýLớpToolStripMenuItem.Visible = true;
                quảnLýTrợGiảngToolStripMenuItem.Visible = true;
                quảnLýMônHọcToolStripMenuItem.Visible = true;
                quảnLýTàiKhoảnToolStripMenuItem.Visible = true;
            }
            btnLamMoi.PerformClick();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyTaiKhoan f = new fQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void quảnLýKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyKhoa f = new fQuanLyKhoa();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyLop f = new fQuanLyLop();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýTrợGiảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCoVanHocTap f = new fQuanLyCoVanHocTap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyMonHoc f = new fQuanLyMonHoc();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyDiem f = new fQuanLyDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fThongTinChiTiet().ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new fDoiMatKhau().ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = BLL_SinhVien.Instance.DanhSach();
            
            cmbMaCoVan.DataSource = BLL_CoVanHocTap.Instance.DanhSach();
            cmbMaCoVan.DisplayMember = "TenCVHT";
            cmbMaCoVan.ValueMember = "MaCVHT";

            cmbMaKhoa.DataSource = BLL_Khoa.Instance.DanhSach();
            cmbMaKhoa.DisplayMember = "TenKhoa";
            cmbMaKhoa.ValueMember = "MaKhoa";

            cmbMaLop.DataSource = BLL_Lop.Instance.DanhSach();
            cmbMaLop.DisplayMember = "TenLop";
            cmbMaLop.ValueMember = "MaLop";

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txbMaSV.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            txbTenSV.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinh.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[3].Value;
            if (dgvSinhVien.CurrentRow.Cells[4].Value.ToString().Trim() == "Nam")
                rdNam.Checked = true;
            else
                rdNu.Checked = true;
            txbQueQuan.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            dtpkNhapHoc.Value = (DateTime)dgvSinhVien.CurrentRow.Cells[6].Value;
            cmbMaLop.SelectedValue = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
            cmbMaKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[8].Value.ToString();
            cmbMaCoVan.SelectedValue = dgvSinhVien.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text;
            string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();
            try
            {
                if (BLL_SinhVien.Instance.Them(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Tên sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string masv = txbMaSV.Text;
            string tensv = txbTenSV.Text;
            string ngaysinh = dtpkNgaySinh.Value.ToShortDateString();
            string gioitinh = (rdNam.Checked == true) ? "Nam" : "Nữ";
            string quequan = txbQueQuan.Text;
            string ngaynhaphoc = dtpkNhapHoc.Value.ToShortDateString();
            string malop = cmbMaLop.SelectedValue.ToString();
            string makhoa = cmbMaKhoa.SelectedValue.ToString();
            string macovan = cmbMaCoVan.SelectedValue.ToString();
            try
            {
                if (BLL_SinhVien.Instance.Sua(masv, tensv, ngaysinh, gioitinh, quequan, ngaynhaphoc, malop, makhoa, macovan, id) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Tên sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaSV.Text;
            if (MessageBox.Show($"Bạn có muốn xóa sinh viên {maMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    if (BLL_SinhVien.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Xảy ra lỗi khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maLop = cmbMaLop.SelectedValue.ToString();
            string maKhoa = cmbMaKhoa.SelectedValue.ToString();
            string maCVHT = cmbMaCoVan.SelectedValue.ToString();

            dgvSinhVien.DataSource = BLL_SinhVien.Instance.TimKiem(maLop, maKhoa, maCVHT);
        }

    }
}
