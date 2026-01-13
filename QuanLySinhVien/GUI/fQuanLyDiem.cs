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
    public partial class fQuanLyDiem : Form
    {
        public fQuanLyDiem()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvDiem.DataSource = BLL_Diem.Instance.DanhSach();
            cmbMaSV.DataSource = BLL_SinhVien.Instance.DanhSach();
            cmbMaSV.DisplayMember = "TenSV";
            cmbMaSV.ValueMember = "MaSV";
            cmbMaMH.DataSource = BLL_MonHoc.Instance.DanhSach();
            cmbMaMH.DisplayMember = "TenMH";
            cmbMaMH.ValueMember = "MaMH";
            dgvDiem.Columns["Column8"].DefaultCellStyle.Format = "N2";


        }

        private void fQuanLyDiem_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string masv = cmbMaSV.SelectedValue.ToString();
            string mamh = cmbMaMH.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phantramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            if ((phantramlop + phantramthi != 100) || diemlop < 0 || diemlop > 10 || diemthi < 0 || diemthi > 10)
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float diemtb = (phantramlop * diemlop + phantramthi * diemthi) / 100f;
            diemtb = (float)Math.Round(diemtb, 2);
            string loai;
            if (diemtb >= 9) loai = "A";
            else if (diemtb >= 7) loai = "B";
            else if (diemtb >= 5) loai = "C";
            else if (diemtb >= 3) loai = "D";
            else loai = "F";
            try
            {
                if (BLL_Diem.Instance.Them(masv, mamh, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Các giá trị nhập vào bị trùng nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            string masv = cmbMaSV.SelectedValue.ToString();
            string mamh = cmbMaMH.SelectedValue.ToString();
            int phantramlop = (int)numPhanTramLop.Value;
            int phantramthi = (int)numPhanTramThi.Value;
            float diemlop = float.Parse(txbDiemLop.Text);
            float diemthi = float.Parse(txbDiemThi.Text);
            if ((phantramlop + phantramthi != 100) || diemlop < 0 || diemlop > 10 || diemthi < 0 || diemthi > 10)
            {
                MessageBox.Show("Giá trị nhập vào không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float diemtb = (phantramlop * diemlop + phantramthi * diemthi) / 100f;
            diemtb = (float)Math.Round(diemtb, 2);
            string loai;
            if (diemtb >= 9) loai = "A";
            else if (diemtb >= 7) loai = "B";
            else if (diemtb >= 5) loai = "C";
            else if (diemtb >= 3) loai = "D";
            else loai = "F";
            try
            {
                if (BLL_Diem.Instance.Sua(masv, mamh, phantramlop, phantramthi, diemlop, diemthi, diemtb, loai, id) == true)
                    btnLamMoi.PerformClick();
            }
            catch
            {
                MessageBox.Show("Sửa điểm không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbID.Text);
            if (MessageBox.Show($"Bạn có muốn xóa điểm có ID: {id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BLL_Diem.Instance.Xoa(id) == true)
                    btnLamMoi.PerformClick();
            }
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbID.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            cmbMaSV.SelectedValue = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            cmbMaMH.SelectedValue = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            numPhanTramLop.Value = int.Parse(dgvDiem.CurrentRow.Cells[3].Value.ToString());
            numPhanTramThi.Value = int.Parse(dgvDiem.CurrentRow.Cells[4].Value.ToString());
            txbDiemLop.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();
            txbDiemThi.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
