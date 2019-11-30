using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class lophoc
    {
        private string tenlop, magv, chuyennganh, nienkhoa;
        private int malop, siso;
        public string Tenlop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        public string Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public string Chuyennganh
        {
            get { return chuyennganh; }
            set { chuyennganh = value; }
        }
        public string Nienkhoa
        {
            get { return nienkhoa; }
            set { nienkhoa = value; }
        }
        public int Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        public int Siso
        {
            get { return siso; }
            set { siso = value; }
        }
        public lophoc()
        {
            malop = siso = 0;
            tenlop = magv = chuyennganh = nienkhoa = "";
        }
        public lophoc(int malop, string tenlop, string magv, int siso, string chuyennganh, string nienkhoa)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.magv = magv;
            this.siso = siso;
            this.chuyennganh = chuyennganh;
            this.nienkhoa = nienkhoa;
        }
    }
}