using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHang_2050531200322
{
    public partial class pageQuanLyDanhMuc : System.Web.UI.Page
    {
        App_Code.XuLiDuLieu xulydulieu;

        public void LoadDanhMuc()
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@maDM", DBNull.Value);
            this.grvDANHMUC.DataSource = xulydulieu.getTable("psGetDanhMuc", pr);
            this.grvDANHMUC.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            xulydulieu = new App_Code.XuLiDuLieu();
            LoadDanhMuc();
        }

        protected void btn_luu_Click(object sender, EventArgs e)
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@TENDANHMUC", txtTenDanhMuc.Text);
            int k = xulydulieu.ExeCute("psAddDanhMuc", pr);
            LoadDanhMuc();
        }
    }
}