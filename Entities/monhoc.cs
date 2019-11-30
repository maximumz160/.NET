using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class monhoc
    {
        private string mamh, tenmh;
        private int stclt, stcth;
        public string Mamh
        {
            get { return mamh; }
            set { mamh = value; }
        }
        public string Tenmh
        {
            get { return tenmh; }
            set { tenmh = value; }
        }
        public int Stclt
        {
            get { return stclt; }
            set { stclt = value; }
        }
        public int Stcth
        {
            get { return stcth; }
            set { stcth = value; }
        }
        public monhoc()
        {
            stclt = stcth = 0;
            mamh = tenmh = "";
        }
        public monhoc(string mamh, string tenmh, int stclt, int stcth)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.stclt = stclt;
            this.stcth = stcth;
        }
    }
}