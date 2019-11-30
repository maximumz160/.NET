using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_3.Entities
{
    public class diem
    {
        private string mamh;
        private int masv,diemlan;
        private float diemghp, diembtc, diemth, diemkthp, diemtb,diemghplan2;
        public int Masv
        {
            get { return masv; }
            set{masv=value;}
        }
        public float Diemghplan2
        {
            get { return diemghplan2; }
            set { diemghplan2 = value; }
        }
        public int Diemlan
        {
            get { return diemlan; }
            set{diemlan=value;}
        }
        public string Mamh
        {
            get { return mamh; }
            set { mamh = value; }
        }
        public float Diemghp
        {
            get { return diemghp; }
            set { diemghp = value; }
        }
        public float Diembtc
        {
            get { return diembtc; }
            set { diembtc = value; }
        }
        public float Diemth
        {
            get { return diemth; }
            set { diemth = value; }
        }
        public float Diemkthp
        {
            get { return diemkthp; }
            set { diemkthp = value; }
        }
        public float Diemtb
        {
            get { return diemtb; }
            set { diemtb = value; }
        }
        public diem(int diemlan,int masv, string mamh,float diemghp, float diembtc,float diemth,float diemkthp,float diemtb)
        {
            this.diemlan = diemlan;
            this.masv = masv;
            this.mamh = mamh;
            this.diemghp = diemghp;
            this.diembtc = diembtc;
            this.diemth = diemth;
            this.diemkthp = diemkthp;
            this.diemtb = diemtb;
        }
        public diem()
        {
            diemlan = masv = 0;
            mamh = "";
            diemghp = diembtc = diemth = diemkthp = diemtb =diemghplan2= 0;
        }
    }
}