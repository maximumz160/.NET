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
    public class DiemBLL
    {
        DiemDAL trinh = new DiemDAL();
        public DataTable loaddiem()
        {
            return trinh.loaddiem();
        }
        //Dếm số bản ghi
        public int TongBanGhi(diem diem)
        {
            return trinh.TongBanGhi(diem);
        }
        //Thêm mon hoc
        public void themdiem(diem diem)
        {
            trinh.themdiem(diem);
        }
        //Sửa mon hoc
        public void suadiem(diem diem)
        {
            trinh.suadiem(diem);
        }

        public void xoadiem(diem diem)
        {
            trinh.xoadiem(diem);
        }
        public int kiemtramatrung(diem diem)
        {
            return trinh.kiemtramatrung(diem);
        }

        public DataTable timkiemtheomasv(diem diem)
        {
            return trinh.timkiemtheomasv(diem);
        }
        public DataTable timkiemtheomamh(diem diem)
        {
            return trinh.timkiemtheomamh(diem);
        }

        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public DataTable loaddiemtheomamhvamasv(string mamh, int masv)
        {
            return trinh.loaddiemtheomamhvamasv(mamh,masv);
        }
        public bool kiemtramhcoth(string mh)
        {
            return trinh.kiemtramhcoth(mh);
        }
        public DataTable loaddiemtheomasv(int masv)
        {
            return trinh.loaddiemtheomasv(masv);
        }
        public DataTable loaddiemtheomamhvamalop(string mamh, int malop)
        {
            return trinh.loaddiemtheomamhvamalop(mamh,malop);
        }
        public DataTable loaddiemtheohockynamhocmalop(int hocky, int namhoc, int malop)
        {
            return trinh.loaddiemtheohockynamhocmalop(hocky ,namhoc,malop);
        }
        public DataTable loaddiemthilai(int malop, int hocky, int namhoc)
        {
            return trinh.loaddiemthilai(malop,hocky,namhoc);
        }
        public DataTable loaddiemhoclai(int malop, int hocky, int namhoc)
        {
            return trinh.loaddiemhoclai(malop,hocky,namhoc);
        }
        public DataTable loaddiemtbcuasvtheomalophockynamhoc(int malop, int hocky, int namhoc)
        {
            return trinh.loaddiemtbcuasvtheomalophockynamhoc(malop,hocky,namhoc);
        }
    }
}