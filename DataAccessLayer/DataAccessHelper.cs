using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PROJECT_3.DataAccessLayer
{
    public class DataAccessHelper
    {
        string strKetnoi = @"Data Source=(local);Initial Catalog=QLDSinhVien;Integrated Security=True";
        SqlDataAdapter sqlAdap;//(cau lenh ,chuoi ket noi);//cau noi giua nguon du lieu va cac bang datatable 
        DataTable dt;//chua du lieu thong qua phuong thuc fill cua dataadapter
        SqlConnection sqlcon;//(truyen vao chuoi ket noi)
        SqlCommand sqlcom;//(cau lenh sql ,sqlcon)
        /// <summary>
        /// phương thức mở kết nối đến CSDL
        /// </summary>
 
        public void KetNoi()
        {
            sqlcon = new SqlConnection(strKetnoi);
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
       /// <summary>
       /// phương thức ngắt kết nối đến CSDL
       /// </summary>
        public void NgatKetNoi()
        {
            sqlcon.Close();
        }
        /// <summary>
        /// Phương thức kiểm tra mã trùng
        /// </summary>
        /// <param name="chuoi">truyền vào chuỗi để tương tác với csdl</param>
        /// <returns>trả về số bản ghi</returns>
        public int KiemTraMaTrung(string chuoi)
        {
            int sbg = 0;
            KetNoi();
            sqlcom = new SqlCommand(chuoi, sqlcon);
            sbg = (int)sqlcom.ExecuteScalar();
            NgatKetNoi();
            return sbg;
        }
        /// <summary>
        /// phương thức thực hiện thêm sửa xóa dữ liệu trong CSDL
        /// </summary>
        /// <param name="caulenh">truyền vào câu lệnh truy vấn SQL</param>
        public void ThucThi(string caulenh)
        {
            KetNoi();
            sqlcom = new SqlCommand(caulenh, sqlcon);
            sqlcom.ExecuteNonQuery();
            NgatKetNoi();
        }
        //Lay du lieu vao 1 datatable 
        /// <summary>
        /// Lấy dữ liệu vào một datatable
        /// </summary>
        /// <param name="caulenhtruyvan">truyền vào câu lệnh truy vấn SQL</param>
        /// <returns>trả về đối tượng một bảng dữ liệu</returns>
        public DataTable LoadDuLieu(string caulenhtruyvan)
        {
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(caulenhtruyvan, strKetnoi);
            sqlAdap.Fill(dt);
            return dt;
        }
        /// <summary>
        /// phương thức chuẩn hóa xâu đầu vào
        /// </summary>
        /// <param name="xau"></param>
        /// <returns></returns>
        public string chuanhoaxau(string xau)
        {
            string s = "";
            do
            {
                xau = xau.Replace("  ", " ");
            } while (xau.IndexOf("  ") != -1);
            xau = xau.Trim();
            string[] mang = xau.Split(' ');
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] = mang[i].Substring(0, 1).ToUpper() + mang[i].Substring(1).ToLower();
                s = s + " " + mang[i];
            }
            return s.Trim();
        }
        /// <summary>
        /// phương thức kiểm tra ký tự có phải là số hay không
        /// </summary>
        /// <param name="a"> truyền vào ký tự</param>
        /// <returns></returns>
        public bool kiemtraso1(string a)
        {
            a = a.Trim();
            bool kt = false;
            for (int i = 0; i <= 9; i++)
            {
                if (a == i.ToString())
                {
                    kt = true;
                }
            }
            return kt;
        }
        /// <summary>
        /// phương thức kiểm tra chuỗi đầu vào có phải là số không
        /// </summary>
        /// <param name="a"> truyền vào một chuỗi</param>
        /// <returns></returns>
        public bool kiemtraso(string a)
        {
            bool kt=true;
            
            do
            {
                a = a.Replace(" ", "");
            } while (a.IndexOf(" ") != -1);
            for (int i = 0; i < a.Length; i++)
            {
                if (kiemtraso1(a.Substring(i,1))==false)
                    kt = false;
            }
            return kt;
        }
    }
}