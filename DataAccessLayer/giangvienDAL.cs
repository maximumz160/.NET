using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PROJECT_3.Entities;
using System.Web.UI.WebControls;

namespace PROJECT_3.DataAccessLayer
{
    public class giangvienDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable Loadgiangvien()
        {
            string strgiangvien = "select * from giangvien";
            return trinh.LoadDuLieu(strgiangvien);
        }
        //Dếm số bản ghi
        public int TongBanGhi(giangvien gv)
        {
            string str = "select count(magv) from giangvien where magv='" + gv.Magv + "'";
            int tbg = trinh.KiemTraMaTrung(str);
            return tbg;
        }
        public int kiemtramatkhau(giangvien gv)
        {
            string str = "select count(*) from giangvien where magv='" + gv.Magv + "'and matkhau='" + gv.Matkhau + "'";
            int tbg = trinh.KiemTraMaTrung(str);
            return tbg;
        }
        //Thêm giang vien
        public void Themgiangvien(giangvien gv)
        {
            string strthem = "insert into giangvien values('" + trinh.chuanhoaxau(gv.Magv) + "',N'" + trinh.chuanhoaxau(gv.Tengv) + "','" + gv.Anh + "','" + gv.Khoa + "','" + gv.Gmail + "','" + gv.Sdt + "','" + gv.Tendangnhap + "','" + gv.Matkhau + "')";
            trinh.ThucThi(strthem);

        }
        //Sửa giang vien
        public void Suagiangvien(giangvien gv)
        {
            string sua = "update giangvien set magv='" + trinh.chuanhoaxau(gv.Magv) + "',tengv=N'" + trinh.chuanhoaxau(gv.Tengv) + "',anh='" + gv.Anh + "',khoa='" + gv.Khoa + "' ,gmail='" + gv.Gmail + "',sdt='" + gv.Sdt + "',tendangnhap='" + gv.Tendangnhap + "',matkhau='" + gv.Matkhau + "'where magv='" + trinh.chuanhoaxau(gv.Magv) + "'";
            trinh.ThucThi(sua);
        }

        public void Xoagiangvien(giangvien gv)
        {
            string xoa = "delete from giangvien  where magv='" + trinh.chuanhoaxau(gv.Magv) + "'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(string magv)
        {
            string dembanghi = "select count(magv) from giangvien where magv='" + magv + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }
       
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }

        public DataTable timkiemtheoten(giangvien gv)
        {
            string strgiangvien = "select * from giangvien where tengv='" + trinh.chuanhoaxau(gv.Tengv) + "'";
            return trinh.LoadDuLieu(strgiangvien);
        }
        public DataTable timkiemtheoma(giangvien gv)
        {
            string strgiangvien = "select * from giangvien where magv='" + trinh.chuanhoaxau(gv.Magv) + "'";
            return trinh.LoadDuLieu(strgiangvien);
        }
        public DataTable timkiemtheokhoa(giangvien gv)
        {
            string strgiangvien = "select * from giangvien where khoa='" + trinh.chuanhoaxau(gv.Khoa) + "'";
            return trinh.LoadDuLieu(strgiangvien);
        }
    }
}