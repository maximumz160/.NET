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
    public class ChuongtrinhdaotaoBLL
    {
        ChuongtrinhdaotaoDAL trinh = new ChuongtrinhdaotaoDAL();
        public DataTable loadchuongtrinhdaotao()
        {
            return trinh.loadchuongtrinhdaotao();
        }
        //Dếm số bản ghi
        public int TongBanGhi(chuongtrinhdaotao chuongtrinhdt)
        {
            return TongBanGhi(chuongtrinhdt);
        }
        //Thêm mon hoc
        public void themctdt(chuongtrinhdaotao ctdt)
        {
            trinh.themctdt(ctdt);
        }
        //Sửa mon hoc
        public void suactdt(chuongtrinhdaotao ctdt)
        {
            trinh.suactdt(ctdt);
        }

        public void xoachuongtrinhdaotao(chuongtrinhdaotao chuongtrinhdaotao)
        {
            trinh.xoachuongtrinhdaotao(chuongtrinhdaotao);
        }
        public int kiemtramatrung(chuongtrinhdaotao ctdt)
        {
            return trinh.kiemtramatrung(ctdt);
        }

        public DataTable timkiemtheomalop(chuongtrinhdaotao ctdt)
        {
            return trinh.timkiemtheomalop(ctdt);
        }
        public DataTable timkiemtheomamonhoc(chuongtrinhdaotao ctdt)
        {
            return trinh.timkiemtheomamonhoc(ctdt);
        }
        public DataTable timkiemtheomagiangvien(chuongtrinhdaotao ctdt)
        {
            return trinh.timkiemtheomagiangvien(ctdt);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public DataTable loadhocky()
        {
            return trinh.loadhocky();
        }
        public DataTable loadnamhoc()
        {
            return trinh.loadnamhoc();
        }
        public DataTable loadmamh(int malop)
        {
            return trinh.loadmamh(malop);
        }
        public DataTable loadmalop(int hocky ,int namhoc)
        {
            return trinh.loadmalop(hocky,namhoc);
        }
        public DataTable loadmasv(int malop)
        {
            return trinh.loadmasv(malop);
        }
        public DataTable loadchuongtrinhdaotaotheomalop(int malop)
        {
            return trinh.loadchuongtrinhdaotaotheomalop(malop);
        }
        public DataTable loaddllmalop()
        {
            return trinh.loaddllmalop();
        }
    }
}