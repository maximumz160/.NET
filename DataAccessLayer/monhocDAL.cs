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
    public class monhocDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable Loadmonhoc()
        {
            string strmonhoc = "select * from monhoc";
            return trinh.LoadDuLieu(strmonhoc);
        }
        public DataTable Loadmonhoctheomalop(int malop)
        {
            string strmonhoc = "select monhoc.*,giangvien.tengv from monhoc,giangvien,chuongtrinhdaotao where giangvien.magv=chuongtrinhdaotao.magv and chuongtrinhdaotao.mamh=monhoc.mamh and chuongtrinhdaotao.malop='"+malop+"'";
            return trinh.LoadDuLieu(strmonhoc);
        }
        //Dếm số bản ghi
        public int TongBanGhi(monhoc mh)
        {
            string sl = "select count(mamon) from monhoc where mamon='" + mh.Mamh + "'";
            int tbg = trinh.KiemTraMaTrung(sl);
            return tbg;
        }
        //Thêm mon hoc
        public void Themmonhoc(monhoc mh)
        {
            string strthem = "insert into monhoc values('" +trinh.chuanhoaxau(mh.Mamh) + "',N'" +trinh.chuanhoaxau(mh.Tenmh) + "','" + mh.Stclt + "','" + mh.Stcth + "')";
            trinh.ThucThi(strthem);

        }
        //Sửa mon hoc
        public void Suamonhoc(monhoc mh)
        {
            string sua = "update monhoc set mamh='"+trinh.chuanhoaxau(mh.Mamh)+"',tenmh=N'" +trinh.chuanhoaxau(mh.Tenmh) + "',sotclt='" + mh.Stclt + "',sotcth='" + mh.Stcth + "' where mamh='" +trinh.chuanhoaxau(mh.Mamh) + "'";
            trinh.ThucThi(sua);
        }

        public void Xoamonhoc(monhoc mh)
        {
            string xoa = "delete from monhoc  where mamh='" +trinh.chuanhoaxau(mh.Mamh) + "'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(string mamonhoc)
        {
            string dembanghi = "select count(mamh) from monhoc where mamh='" + mamonhoc + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }
        
        public DataTable timkiemtheoten(monhoc mh)
        {
            string strmonhoc = "select * from monhoc where tenmh='"+trinh.chuanhoaxau(mh.Tenmh)+"'";
            return trinh.LoadDuLieu(strmonhoc);
        }
        public DataTable timkiemtheoma(monhoc mh)
        {
            string strmonhoc = "select * from monhoc where mamh='" + trinh.chuanhoaxau(mh.Mamh) + "'";
            return trinh.LoadDuLieu(strmonhoc);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
    }
}