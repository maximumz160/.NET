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
    public class SinhvienDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable Loadsinhvien()
        {
            string strsinhvien = "select * from sinhvien";
            return trinh.LoadDuLieu(strsinhvien);
        }
        public DataTable Loadsinhvientheeomalop(int malop)
        {
            string strsinhvien = "select * from sinhvien where malop='"+malop+"'";
            return trinh.LoadDuLieu(strsinhvien);
        }
        //Dếm số bản ghi
        public int TongBanGhi(sinhvien sv)
        {
            string str = "select count(masv) from sinhvien where masv='" + sv.Sdt + "'";
            int tbg = trinh.KiemTraMaTrung(str);
            return tbg;
        }
        //Thêm giang vien
        public void Themsinhvien(sinhvien sv)
        {
            string strthem = "insert into sinhvien values('" + sv.Masv + "',N'" + trinh.chuanhoaxau(sv.Tensv) + "','" + sv.Anh + "',N'" + sv.Gioitinh + "','" + sv.Malop + "','" + sv.Ngaysinh + "','" + trinh.chuanhoaxau(sv.Quequan) + "','" + sv.Sdt + "','" + sv.Gmail + "')";
            trinh.ThucThi(strthem);

        }
        //Sửa giang vien
        public void Suasinhvien(sinhvien sv)
        {
            string sua = "update sinhvien set masv='" + sv.Masv + "',tensv=N'" + trinh.chuanhoaxau(sv.Tensv) + "',anh='" + sv.Anh + "',gioitinh=N'" + sv.Gioitinh + "' ,malop='" + sv.Malop + "',ngaysinh='" + sv.Ngaysinh + "',quequan='" + sv.Quequan + "',sdt='" + sv.Sdt + "' ,gmail='" + sv.Gmail + "' where masv='" + sv.Masv + "'";
            trinh.ThucThi(sua);
        }

        public void Xoasinhvien(sinhvien sv)
        {
            string xoa = "delete from sinhvien  where masv='" + sv.Masv + "'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(int masv)
        {
            string dembanghi = "select count(masv) from sinhvien where masv='" + masv + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }

        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }

        public DataTable timkiemtheoten(sinhvien sv)
        {
            string strsinhvien = "select * from sinhvien where tensv='" + trinh.chuanhoaxau(sv.Tensv) + "'";
            return trinh.LoadDuLieu(strsinhvien);
        }
        public DataTable timkiemtheoma(sinhvien sv)
        {
            string strsinhvien = "select * from sinhvien where masv='" + sv.Masv + "'";
            return trinh.LoadDuLieu(strsinhvien);
        }
        public DataTable timkiemtheolop(sinhvien sv)
        {
            string strsinhvien = "select * from sinhvien where malop='" + sv.Malop + "'";
            return trinh.LoadDuLieu(strsinhvien);
        }
    }
}