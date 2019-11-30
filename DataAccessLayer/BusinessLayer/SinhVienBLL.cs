using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PROJECT_3.DataAccessLayer;
using System.Data;
using System.Data.SqlClient;
using PROJECT_3.Entities;

namespace PROJECT_3.BusinessLayer
{
    public class SinhVienBLL
    {
        SinhvienDAL trinh = new SinhvienDAL();
        public DataTable Loadsinhvien()
        {
            return trinh.Loadsinhvien();
        }
        //Dếm số bản ghi
        public int TongBanGhi(sinhvien sv)
        {
            return trinh.TongBanGhi(sv);
        }
        //Thêm giang vien
        public void Themsinhvien(sinhvien sv)
        {
            trinh.Themsinhvien(sv);
        }
        //Sửa giang vien
        public void Suasinhvien(sinhvien sv)
        {
            trinh.Suasinhvien(sv);
        }

        public void Xoasinhvien(sinhvien sv)
        {
            trinh.Xoasinhvien(sv);
        }
        public int kiemtramatrung(int masv)
        {
            return trinh.kiemtramatrung(masv);
        }

        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }

        public DataTable timkiemtheoten(sinhvien sv)
        {
            return trinh.timkiemtheoten(sv);
        }
        public DataTable timkiemtheoma(sinhvien sv)
        {
            return trinh.timkiemtheoma(sv);
        }
        public DataTable timkiemtheolop(sinhvien sv)
        {
            return trinh.timkiemtheolop(sv);
        }
        public DataTable Loadsinhvientheeomalop(int malop)
        {
            return trinh.Loadsinhvientheeomalop(malop);
        }
    }
}