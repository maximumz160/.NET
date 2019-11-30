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
    public class monhocBLL
    {
        monhocDAL trinh = new monhocDAL();
        public DataTable Loadmonhoc()
        {
            return trinh.Loadmonhoc();
        }
        //Dếm số bản ghi
        public int TongBanGhi(monhoc mh)
        {
            return trinh.TongBanGhi(mh);
        }
        //Thêm mon hoc
        public void Themmonhoc(monhoc mh)
        {
            trinh.Themmonhoc(mh);
        }
        //Sửa mon hoc
        public void Suamonhoc(monhoc mh)
        {
            trinh.Suamonhoc(mh);
        }

        public void Xoamonhoc(monhoc mh)
        {
            trinh.Xoamonhoc(mh);
        }
        public int kiemtramatrung(string mamonhoc)
        {
            return trinh.kiemtramatrung(mamonhoc);
        }
       
        public DataTable timkiemtheoten(monhoc mh)
        {
            return trinh.timkiemtheoten(mh);
        }
        public DataTable timkiemtheoma(monhoc mh)
        {
            return trinh.timkiemtheoma(mh);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public DataTable Loadmonhoctheomalop(int malop)
        {
            return trinh.Loadmonhoctheomalop(malop);
        }
    }
}