using QuanLySinhVien.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.BLL
{
    public class BLL_CoVanHocTap
    {
        private static BLL_CoVanHocTap instance; // ctr + r + e
        public static BLL_CoVanHocTap Instance
        {
            get { if (instance == null) instance = new BLL_CoVanHocTap(); return instance; }
            private set => instance = value;
        }

        private BLL_CoVanHocTap() { }

        public DataTable DanhSach()
        {
            return DAL_CoVanHocTap.Instance.DanhSach();
        }

        public bool Them(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop)
        {
            return DAL_CoVanHocTap.Instance.Them(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop);
        }

        public bool Sua(string macovan, string tencovan, string ngaysinh, string gioitinh, string makhoa, string malop, int id)
        {
            return DAL_CoVanHocTap.Instance.Sua(macovan, tencovan, ngaysinh, gioitinh, makhoa, malop, id);
        }

        public bool Xoa(int id)
        {
            return DAL_CoVanHocTap.Instance.Xoa(id);
        }
    }
}
