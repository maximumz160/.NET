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
    public class LophocDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable Loadlophoc()
        {
            string strmonhoc = "select * from lophoc";
            return trinh.LoadDuLieu(strmonhoc);
        }
        public DataTable Loadlophoctheomalop(int malop)
        {
            string strmonhoc = "select lophoc.* , giangvien.tengv from lophoc,giangvien where giangvien.magv=lophoc.magv and malop='"+malop+"'";
            return trinh.LoadDuLieu(strmonhoc);
        }
        public DataTable loadddllophoc()
        {
            string strchuongtrinhdaotao = "select distinct malop from lophoc";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        //Dếm số bản ghi
        public int TongBanGhi(lophoc lh)
        {
            string sl = "select count(malop) from monhoc where malop='" + lh.Malop + "'";
            int tbg = trinh.KiemTraMaTrung(sl);
            return tbg;
        }
        //Thêm mon hoc
        public void themlophoc(lophoc lophoc)
        {
            string strthem = "insert into lophoc values('" + lophoc.Malop + "',N'" + trinh.chuanhoaxau(lophoc.Tenlop) + "',N'" +lophoc.Magv + "','" + lophoc.Siso + "',N'" + lophoc.Chuyennganh + "',N'" + lophoc.Nienkhoa + "')";
            trinh.ThucThi(strthem);

        }
        //Sửa mon hoc
        public void Sualophoc(lophoc lophoc)
        {
            string sua = "update lophoc set malop='" + lophoc.Malop + "',tenlop=N'" + trinh.chuanhoaxau(lophoc.Tenlop) + "',magv='" + trinh.chuanhoaxau(lophoc.Magv) + "',siso='" + lophoc.Siso + "',chuyennganh='" + lophoc.Chuyennganh + "',nienkhoa='" + lophoc.Nienkhoa + "' where malop='" + lophoc.Malop + "'";
            trinh.ThucThi(sua);
        }

        public void Xoalophoc(lophoc lophoc)
        {
            string xoa = "delete from lophoc  where malop='" + lophoc.Malop + "'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(string malophoc)
        {
            string dembanghi = "select count(malop) from lophoc where malop='" + malophoc + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }
      
        public DataTable timkiemtheoten(lophoc lophoc)
        {
            string strlophoc= "select * from lophoc where tenlop='" + trinh.chuanhoaxau(lophoc.Tenlop) + "'";
            return trinh.LoadDuLieu(strlophoc);
        }
        public DataTable timkiemtheoma(lophoc lophoc)
        {
            string strlophoc = "select * from lophoc where malop='" + lophoc.Malop + "'";
            return trinh.LoadDuLieu(strlophoc);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
    }
}