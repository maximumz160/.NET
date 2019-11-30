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
    public class giangvienBLL
    {
        giangvienDAL trinh = new giangvienDAL();
        //Load lên dg monhoc
        public DataTable Loadgiangvien()
        {
            return trinh.Loadgiangvien();
        }
        //Dếm số bản ghi
        public int TongBanGhi(giangvien gv)
        {
            return TongBanGhi(gv);
        }
        //Thêm giang vien
        public void Themgiangvien(giangvien gv)
        {
            trinh.Themgiangvien(gv);
        }
        //Sửa giang vien
        public void Suagiangvien(giangvien gv)
        {
            trinh.Suagiangvien(gv);
        }

        public void Xoagiangvien(giangvien gv)
        {
            trinh.Xoagiangvien(gv);
        }
        public int kiemtramatrung(string magv)
        {
            return trinh.kiemtramatrung(magv);
        }
        
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public DataTable timkiemtheoten(giangvien giangvien)
        {
            return trinh.timkiemtheoten(giangvien);
        }
        public DataTable timkiemtheoma(giangvien gv)
        {
            return trinh.timkiemtheoma(gv);
        }
        public DataTable timkiemtheokhoa(giangvien gv)
        {
            return trinh.timkiemtheokhoa(gv);
        }
        public int kiemtramatkhau(giangvien gv)
        {
            return trinh.kiemtramatkhau(gv);
        }
    }
}