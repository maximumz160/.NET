using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class chuongtrinhdaotao
    {
        private string mamh, magv;
        private int malop, hocky, namhoc;
        public string Mamh
        {
            get { return mamh; }
            set { mamh = value; }
        }
        public string Magv
        {
            get { return magv; }
            set { magv = value; }
        }
        public int Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        public int Hocky
        {
            get { return hocky; }
            set { hocky = value; }
        }
        public int Namhoc
        {
            get { return namhoc; }
            set { namhoc = value; }
        }
        public chuongtrinhdaotao()
        {
            mamh = magv = "";
            malop = hocky = namhoc = 0;
        }
        public chuongtrinhdaotao(int malop, int hocky, string mamh, int namhoc, string magv)
        {
            this.malop = malop;
            this.hocky = hocky;
            this.mamh = mamh;
            this.namhoc = namhoc;
            this.magv = magv;
        }
    }
}