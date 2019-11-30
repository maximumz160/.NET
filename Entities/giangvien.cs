using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class giangvien
    {
        private string magv, tengv, anh, khoa, gmail, tendangnhap, matkhau;
        private int sdt;

        public string Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public string Tengv
        {
            get { return tengv; }
            set { tengv = value; }
        }
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        public string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }
        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }
        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public giangvien(string magv, string tengv, string anh, string khoa, string gmail, int sdt, string tendn, string matkhau)
        {
            this.magv = magv;
            this.tengv = tengv;
            this.anh = anh;
            this.khoa = khoa;
            this.gmail = gmail;
            this.sdt = sdt;
            this.tendangnhap = tendn;
            this.matkhau = matkhau;
        }
        public giangvien()
        {
            magv = tengv = anh = khoa = gmail = tendangnhap = matkhau = "";
            sdt = 0;
        }
    }
}