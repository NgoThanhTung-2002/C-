using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHang_2050531200322.App_Code.PD
{
    public class pd_QUANLYDANHMUC
    {
        App_Code.XuLiDuLieu xulydulieu;
        public pd_QUANLYDANHMUC()
        {
            xulydulieu = new App_Code.XuLiDuLieu();
        }


        public DataTable BangDanhMuc()
        {
            DataTable tb;
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@maDM", DBNull.Value);
            tb = xulydulieu.getTable("psGetDanhMuc", pr);
            return tb;
        }


        public int themmoiDanhMuc(String tendanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@TENDANHMUC", tendanhmuc);
            int k = xulydulieu.ExeCute("psAddDanhMuc", pr);
            return k;
        }

        public int XoaDanhMuc(String madanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@MADANHMUC", madanhmuc);
            int k = xulydulieu.ExeCute("psDELETEDanhmuc", pr);
            return k;
        }

        public int SuaDanhMuc(String madanhmuc, String tendanhmuc)
        {
            SqlParameter[] pr = new SqlParameter[2];
            pr[0] = new SqlParameter("@MADANHMUC", madanhmuc);
            pr[1] = new SqlParameter("@TENDANHMUC", tendanhmuc);
            int k = xulydulieu.ExeCute("psUPDATEDanhMuc", pr);
            return k;
        }
    }
}