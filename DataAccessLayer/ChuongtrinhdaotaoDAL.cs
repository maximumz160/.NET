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
    public class ChuongtrinhdaotaoDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable loadchuongtrinhdaotao()
        {
            string strchuongtrinhdaotao = "select * from chuongtrinhdaotao";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadchuongtrinhdaotaotheomalop(int malop)
        {
            string strchuongtrinhdaotao = "select * from chuongtrinhdaotao where malop='"+malop+"'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadhocky()
        {
            string strchuongtrinhdaotao = "select distinct hocky from chuongtrinhdaotao";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loaddllmalop()
        {
            string strchuongtrinhdaotao = "select distinct malop from chuongtrinhdaotao";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadnamhoc()
        {
            string strchuongtrinhdaotao = "select distinct namhoc from chuongtrinhdaotao";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadmalop(int hocky ,int namhoc)
        {
            string strchuongtrinhdaotao = "select distinct malop from chuongtrinhdaotao where hocky='"+hocky+"' and namhoc='"+namhoc+"'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadmamh(int malop)
        {
            string strchuongtrinhdaotao = "select distinct mamh from chuongtrinhdaotao where malop='" + malop + "'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable loadmasv(int malop)
        {
            string strchuongtrinhdaotao = "select * from sinhvien where malop='" + malop + "'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        //Dếm số bản ghi
        public int TongBanGhi(chuongtrinhdaotao chuongtrinhdt)
        {
            string sl = "select count(malop) from monhoc where malop='" + chuongtrinhdt.Malop + "'";
            int tbg = trinh.KiemTraMaTrung(sl);
            return tbg;
        }
        //Thêm mon hoc
        public void themctdt(chuongtrinhdaotao ctdt)
        {
            string strthem = "insert into chuongtrinhdaotao values('" + ctdt.Malop + "','" + ctdt.Hocky + "','" + ctdt.Mamh + "','" + ctdt.Namhoc + "','" + ctdt.Magv + "')";
            trinh.ThucThi(strthem);
        }
        //Sửa mon hoc
        public void suactdt(chuongtrinhdaotao ctdt)
        {
            string sua = "update chuongtrinhdaotao set malop='" + ctdt.Malop + "',hocky='" + ctdt.Hocky + "',mamh='" + ctdt.Mamh + "',namhoc='" + ctdt.Namhoc + "',magv='" + ctdt.Magv + "' where malop='" + ctdt.Malop + "' and mamh='" + ctdt.Mamh + "' and magv='" + ctdt.Magv + "'";
            trinh.ThucThi(sua);
        }

        public void xoachuongtrinhdaotao(chuongtrinhdaotao chuongtrinhdaotao)
        {
            string xoa = "delete from chuongtrinhdaotao  where malop='" + chuongtrinhdaotao.Malop+ "' and mamh='"+chuongtrinhdaotao.Mamh+"' and magv='"+chuongtrinhdaotao.Magv+"'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(chuongtrinhdaotao ctdt)
        {
            string dembanghi = "Select count(*) from chuongtrinhdaotao where malop='" + ctdt.Malop + "' and mamh='" + ctdt.Mamh + "' and magv='" + ctdt.Magv + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }

        public DataTable timkiemtheomalop(chuongtrinhdaotao ctdt)
        {
            string strchuongtrinhdaotao = "select * from chuongtrinhdaotao where malop='" + ctdt.Malop + "'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable timkiemtheomamonhoc(chuongtrinhdaotao ctdt)
        {
            string strchuongtrinhdaotao = "select * from chuongtrinhdaotao where mamh='" + ctdt.Mamh + "'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public DataTable timkiemtheomagiangvien(chuongtrinhdaotao ctdt)
        {
            string strchuongtrinhdaotao = "select * from chuongtrinhdaotao where magv='" + ctdt.Magv + "'";
            return trinh.LoadDuLieu(strchuongtrinhdaotao);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
    }
}