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
    public partial class fQuanLyTaiKhoan : Form
    {
        public fQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0 && matkhau.Length >= 6 && loaiTK.Length > 0)
            {
                try
                {
                    if (BLL_TaiKhoan.Instance.Them(tendangnhap, matkhau, loaiTK) == true)
                        btnLamMoi.PerformClick(); //Bấm Làm mới
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập bị trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được quá ngắn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string tendangnhap = txbTenDangNhap.Text.Trim();
            string matkhau = txbMatKhau.Text.Trim();
            string loaiTK = cmbLoaiTaiKhoan.SelectedItem.ToString();

            if (tendangnhap.Length > 0 && loaiTK.Length > 0)
            {
                try
                {   //không sửa mật khẩu
                    if (matkhau.Length ==0)
                    {
                        if (BLL_TaiKhoan.Instance.KhongSuaMatKhau(tendangnhap, loaiTK, id) == true)
                            btnLamMoi.PerformClick(); //Bấm Làm mới
                    }
                    //sửa mật khẩu
                    else
                    {
                        if (BLL_TaiKhoan.Instance.SuaHet(tendangnhap, matkhau, loaiTK, id) == true)
                            btnLamMoi.PerformClick(); //Bấm Làm mới
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được quá ngắn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString());
            string ten = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa tài  khoản " +ten+ " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if(BLL_TaiKhoan.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick(); //Bấm Làm mới
                }
                catch
                {
                    MessageBox.Show("Phát sinh lỗi khi xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = BLL_TaiKhoan.Instance.DanhSach();
        }

        private void fQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick(); //Bấm Làm mới
            cmbLoaiTaiKhoan.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvTaiKhoan.CurrentRow.Cells[0].Value.ToString().Trim(); 
            txbTenDangNhap.Text = dgvTaiKhoan.CurrentRow.Cells[1].Value.ToString().Trim();
            //txbMatKhau.Text = dgvTaiKhoan.CurrentRow.Cells[2].Value.ToString().Trim();
            cmbLoaiTaiKhoan.SelectedItem = dgvTaiKhoan.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
