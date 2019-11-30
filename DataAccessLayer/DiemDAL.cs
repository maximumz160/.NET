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
    public class DiemDAL
    {
        DataAccessHelper trinh = new DataAccessHelper();
        //Load lên dg monhoc
        public DataTable loaddiem()
        {
            string strdiem = "select * from diem";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemtbcuasvtheomalophockynamhoc(int malop, int hocky, int namhoc)
        {
            string strdiem = "select diem.masv,sinhvien.tensv, tong=(sum(diem.diemtb*(monhoc.sotclt+monhoc.sotcth))/SUM(monhoc.sotclt+monhoc.sotcth)) from diem ,monhoc ,chuongtrinhdaotao ,sinhvien ,lophoc  where diem.mamh=monhoc.mamh and diem.masv=sinhvien.masv  and lophoc.malop=sinhvien.malop and chuongtrinhdaotao.malop=lophoc.malop and chuongtrinhdaotao.namhoc='" + namhoc + "' and chuongtrinhdaotao.hocky='" + hocky + "' and chuongtrinhdaotao.malop='" + malop + "' group by  diem.masv,sinhvien.tensv order by tong desc";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemthilai(int malop,int hocky,int namhoc)
        {
            string strdiem = "select diem.masv,sinhvien.tensv,lophoc.tenlop,monhoc.mamh,monhoc.tenmh,diem.diemghp from diem,sinhvien,monhoc,lophoc,chuongtrinhdaotao where diem.masv=sinhvien.masv and diem.mamh=monhoc.mamh and sinhvien.malop=lophoc.malop and chuongtrinhdaotao.malop=lophoc.malop and (diem.diemghp<4) and lophoc.malop='" + malop + "' and chuongtrinhdaotao.hocky='" + hocky + "' and chuongtrinhdaotao.namhoc='"+namhoc+"' ";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemhoclai(int malop, int hocky, int namhoc)
        {
            string strdiem = "select diem.masv,sinhvien.tensv,lophoc.tenlop,monhoc.mamh,monhoc.tenmh,diem.diemghplan2,diem.diemkthp from diem,sinhvien,monhoc,lophoc,chuongtrinhdaotao where diem.masv=sinhvien.masv and diem.mamh=monhoc.mamh and sinhvien.malop=lophoc.malop and chuongtrinhdaotao.malop=lophoc.malop and ((diem.diemghplan2<4) or (diem.diemkthp<5))   and lophoc.malop='" + malop + "' and chuongtrinhdaotao.hocky='" + hocky + "' and chuongtrinhdaotao.namhoc='" + namhoc + "' ";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemtheomasv(int masv)
        {
            string strdiem = "select diem.*, monhoc.tenmh from diem,monhoc where diem.mamh=monhoc.mamh and masv='"+masv+"'";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemtheohockynamhocmalop(int hocky,int namhoc,int malop)
        {
            string strdiem = "select diem.*, monhoc.tenmh,sinhvien.tensv from diem,monhoc,sinhvien,chuongtrinhdaotao where diem.mamh=monhoc.mamh and monhoc.mamh=chuongtrinhdaotao.mamh and diem.masv=sinhvien.masv and chuongtrinhdaotao.malop='" + malop + "'and chuongtrinhdaotao.hocky='" + hocky + "' and chuongtrinhdaotao.namhoc='"+namhoc+"'";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemtheomamhvamasv(string mamh,int masv)
        {
            string strdiem = "select * from diem where mamh='"+mamh+"' and masv='"+masv+"'";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable loaddiemtheomamhvamalop(string mamh, int malop)
        {
            string strdiem = "select diem.*,sinhvien.tensv,monhoc.tenmh from diem,lophoc,sinhvien,monhoc where  diem.mamh='"+mamh+"' and lophoc.malop='"+malop+"' and sinhvien.malop=lophoc.malop and diem.masv=sinhvien.masv and diem.masv=sinhvien.masv and diem.mamh=monhoc.mamh";
            return trinh.LoadDuLieu(strdiem);
        }
        //Dếm số bản ghi
        public int TongBanGhi(diem diem)
        {
            string strdiem = "select count(*) from diem where masv='" + diem.Masv + "' and mamh='" + diem.Mamh + "' and diemlan='" + diem.Diemlan + "'";
            int tbg = trinh.KiemTraMaTrung(strdiem);
            return tbg;
        }
        //Thêm mon hoc
        public void themdiem(diem diem)
        {
            string strthem = "insert into diem values('" + diem.Masv + "','" + diem.Mamh + "','" + diem.Diemghp + "','" + diem.Diembtc + "','" + diem.Diemth + "','" + diem.Diemkthp + "','" + diem.Diemtb + "','" + diem.Diemghplan2 + "','" + diem.Diemlan + "')";
            trinh.ThucThi(strthem);
        }
        //Sửa mon hoc
        public void suadiem(diem diem)
        {
            string sua = "update diem set  diemlan='" + diem.Diemlan + "', masv='" + diem.Masv + "',mamh='" + diem.Mamh + "',diemghp='" + diem.Diemghp + "',diembtc='" + diem.Diembtc + "',diemth='" + diem.Diemth + "',diemkthp='" + diem.Diemkthp + "',diemtb='" + diem.Diemtb + "' where masv='" + diem.Masv + "' and mamh='" + diem.Mamh + "' and diemlan='" + diem.Diemlan + "'";
            trinh.ThucThi(sua);
        }

        public void xoadiem(diem diem)
        {
            string xoa = "delete from diem  where masv='" + diem.Masv + "' and mamh='" + diem.Mamh + "' and diemlan='" + diem.Diemlan + "'";
            trinh.ThucThi(xoa);
        }
        public int kiemtramatrung(diem diem)
        {
            string dembanghi = "Select count(*) from diem where masv='" + diem.Masv + "' and mamh='" + diem.Mamh + "' and diemlan='" + diem.Diemlan + "'";
            return trinh.KiemTraMaTrung(dembanghi);
        }

        public DataTable timkiemtheomasv(diem diem)
        {
            string strdiem = "select * from diem where masv='" + diem.Masv + "'";
            return trinh.LoadDuLieu(strdiem);
        }
        public DataTable timkiemtheomamh(diem diem)
        {
            string strdiem = "select * from diem where mamh='" + diem.Mamh + "'";
            return trinh.LoadDuLieu(strdiem);
        }
        
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public bool kiemtramhcoth(string mh)
        {
            bool ok = true;
            string strSelect = "select count(mamh) from monhoc where mamh='" + mh + "'and sotcth='0'";
            if (trinh.KiemTraMaTrung(strSelect) == 0)
            {
                ok = false;
            }
            return ok;
        }
    }
}