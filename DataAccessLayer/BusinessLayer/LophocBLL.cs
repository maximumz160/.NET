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
    public class LophocBLL
    {
        LophocDAL trinh = new LophocDAL();
        public DataTable Loadlophoc()
        {
            return trinh.Loadlophoc();
        }
        //Dếm số bản ghi
        public int TongBanGhi(lophoc lh)
        {
            return trinh.TongBanGhi(lh);
        }
        //Thêm mon hoc
        public void themlophoc(lophoc lophoc)
        {
            trinh.themlophoc(lophoc);
        }
        //Sửa mon hoc
        public void Sualophoc(lophoc lophoc)
        {
            trinh.Sualophoc(lophoc);
        }

        public void Xoalophoc(lophoc lophoc)
        {
            trinh.Xoalophoc(lophoc);
        }
        public int kiemtramatrung(string malophoc)
        {
            return trinh.kiemtramatrung(malophoc);
        }
        
        public DataTable timkiemtheoten(lophoc lophoc)
        {
            return trinh.timkiemtheoten(lophoc);
        }
        public DataTable timkiemtheoma(lophoc lophoc)
        {
            return trinh.timkiemtheoma(lophoc);
        }
        public bool kiemtraso(string a)
        {
            return trinh.kiemtraso(a);
        }
        public DataTable loadddllophoc()
        {
            return trinh.loadddllophoc();
        }
        public DataTable Loadlophoctheomalop(int malop)
        {
            return trinh.Loadlophoctheomalop(malop);
        }
    }
}