using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class sinhvien
    {
        private string tensv, anh, gioitinh, ngaysinh, quequan, gmail;
        private int masv, malop, sdt;
        public string Tensv
        {
            get { return tensv; }
            set { tensv = value; }
        }
        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }
        public int Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public int Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        public int Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public sinhvien()
        {
            masv = malop = sdt = 0;
            tensv = anh = gioitinh = ngaysinh = quequan = gmail = "";
        }
        public sinhvien(int masv, string tensv, string anh, string gioitinh, int malop, string ngaysinh, string quequan, int sdt, string gmail)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.anh = anh;
            this.gioitinh = gioitinh;
            this.masv = malop;
            this.ngaysinh = ngaysinh;
            this.quequan = quequan;
            this.sdt = sdt;
            this.gmail = gmail;
        }
    }
}