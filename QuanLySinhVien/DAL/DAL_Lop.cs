using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAL
{
    public class DAL_Lop
    {
        private static DAL_Lop instance; // ctr + r + e
        public static DAL_Lop Instance
        {
            get { if (instance == null) instance = new DAL_Lop(); return instance; }
            private set => instance = value;
        }

        private DAL_Lop() { }
        public bool Them(string malop, string tenlop, int soluong, string makhoa)
        {
            string sql = "insert into Lop ( MaLop, TenLop, SoLuong, Makhoa) values( @MaLop , @TenLop , @SoLuong , @Makhoa )";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { malop, tenlop, soluong, makhoa });
        }

        public bool Sua(string malop, string tenlop, int soluong, string makhoa, int id)
        {
            string sql = "update Lop set MaLop = @MaLop , TenLop = @TenLop , SoLuong = @SoLuong , Makhoa = @Makhoa where id = @id";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { malop, tenlop, soluong, makhoa, id });
        }

        public bool Xoa(int id)
        {
            string sql = "delete from Lop where id = @id ";
            return KetNoi.Instance.ExcuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExcuteQuery("select * from Lop");
        }
    }
}
