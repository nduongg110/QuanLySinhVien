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
    public partial class fQuanLyMonHoc : Form
    {
        public fQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = BLL_MonHoc.Instance.DanhSach();
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvMonHoc.CurrentRow.Cells[0].Value.ToString().Trim();
            txbMaMH.Text = dgvMonHoc.CurrentRow.Cells[1].Value.ToString().Trim();
            txbTenMH.Text = dgvMonHoc.CurrentRow.Cells[2].Value.ToString().Trim();
            numSoTinChi.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[3].Value.ToString());
            numTietLyThuyet.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[4].Value.ToString());
            numTietThucHanh.Value = int.Parse(dgvMonHoc.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMH = txbMaMH.Text;
            string tenMH = txbTenMH.Text;
            int soTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;


            try
            {
                if (BLL_MonHoc.Instance.Them(maMH, tenMH, soTC, LT, TH) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Môn học đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMH.Text;
            string tenMH = txbTenMH.Text;
            int soTC = (int)numSoTinChi.Value;
            int LT = (int)numTietLyThuyet.Value;
            int TH = (int)numTietThucHanh.Value;
            try
            {
                if (BLL_MonHoc.Instance.Sua(maMH, tenMH, soTC, LT, TH, id) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Mã môn học đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string maMH = txbMaMH.Text;
            if (MessageBox.Show($"Bạn có muốn xóa môn học {maMH}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                try
                {
                    if (BLL_MonHoc.Instance.Xoa(id) == true)
                        btnLamMoi.PerformClick();
                }
                catch
                {
                    MessageBox.Show("Mã môn học đang được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void fQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }
    }
}
