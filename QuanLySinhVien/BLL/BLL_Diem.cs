using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    public class BLL_Diem
    {
        private static BLL_Diem instance; // ctr + r + e
        public static BLL_Diem Instance
        {
            get { if (instance == null) instance = new BLL_Diem(); return instance; }
            private set => instance = value;
        }

        private BLL_Diem() { }

        public DataTable DanhSach()
        {
            return DAL_Diem.Instance.DanhSach();
        }

        public bool Them(string MaSV, string MaMH, int PhanTranTrenLop, int PhanTranThi, float DiemLop, float DiemThi, float DiemTB, string Loai)
        {
            return DAL_Diem.Instance.Them(MaSV, MaMH, PhanTranTrenLop, PhanTranThi, DiemLop, DiemThi, DiemTB, Loai);
        }

        public bool Sua(string MaSV, string MaMH, int PhanTranTrenLop, int PhanTranThi, float DiemLop, float DiemThi, float DiemTB, string Loai, int id)
        {
            return DAL_Diem.Instance.Sua(MaSV, MaMH, PhanTranTrenLop, PhanTranThi, DiemLop, DiemThi, DiemTB, Loai, id);
        }

        public bool Xoa(int id)
        {
            return DAL_Diem.Instance.Xoa(id);
        }
    }
}
