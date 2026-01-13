using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class DAL_CoVanHocTap
    {
        private static DAL_CoVanHocTap instance; // ctr + r + e
        public static DAL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new DAL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }

        private DAL_CoVanHocTap() { }
        public bool Them(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string MaKhoa, string MaLop)
        {
            string sql = "insert into CoVanHocTap ( MaCVHT, TenCVHT, NgaySinh, GioiTinh, MaKhoa, MaLop) values( @MaCVHT , @TenCVHT , @NgaySinh , @GioiTinh ,  @MaKhoa , @MaLop )";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaKhoa, MaLop });
        }

        public bool Sua(string MaCoVan, string TenCoVan, string NgaySinh, string GioiTinh, string MaKhoa, string MaLop, int id)
        {
            string sql = "update CoVanHocTap set MaCVHT = @MaCVHT , TenCVHT = @TenCVHT , NgaySinh = @NgaySinh , GioiTinh = @GioiTinh , MaKhoa= @MaKhoa , MaLop = @MaLop where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { MaCoVan, TenCoVan, NgaySinh, GioiTinh, MaKhoa, MaLop, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from CoVanHocTap where id = @id ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from CoVanHocTap");
        }
    }
}
