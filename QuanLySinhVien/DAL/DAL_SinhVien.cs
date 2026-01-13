using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class DAL_SinhVien
    {
        private static DAL_SinhVien instance; // ctr + r + e
        public static DAL_SinhVien Instance
        {
            get { if (instance == null) instance = new DAL_SinhVien(); return instance; }
            private set => instance = value;
        }
        private DAL_SinhVien() { }

        public bool Them(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT)
        {
            string sql = "insert into SinhVien(MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT) values( @MaSV , @TenSV , @NgaySinh , @GioiTinh , @QueQuan , @NgayNhapHoc , @MaLop , @MaKhoa , @MaCVHT )";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT });
        }

        public bool Sua(string MaSV, string TenSV, string NgaySinh, string GioiTinh, string QueQuan, string NgayNhapHoc, string MaLop, string MaKhoa, string MaCVHT, int id)
        {
            string sql = "update SinhVien set MaSV = @MaSV , TenSV = @TenSV , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , QueQuan = @QueQuan , NgayNhapHoc = @NgayNhapHoc , MaLop = @MaLop , MaKhoa = @MaKhoa , MaCVHT = @MaCVHT where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaSV, TenSV, NgaySinh, GioiTinh, QueQuan, NgayNhapHoc, MaLop, MaKhoa, MaCVHT, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from SinhVien where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }
        public DataTable TimKiem(string maLop, string maKhoa, string maCVHT)
        {
            string sql = "SELECT * FROM SinhVien WHERE MaLop = @MaLop AND MaKhoa = @MaKhoa AND MaCVHT = @MaCVHT";
            return KetNoi.Instance.ExcuteQuery(sql, new object[] { maLop, maKhoa, maCVHT });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from SinhVien");
        }

    }
}
