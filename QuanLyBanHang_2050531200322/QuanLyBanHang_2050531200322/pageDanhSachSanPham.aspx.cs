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
    public partial class pageDanhSachSanPham : System.Web.UI.Page
    {
        private object tbSanPham;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\QuanLyBanHang_2050531200322\QuanLyBanHang_2050531200322\App_Data\dbQuanLyNhaHang.mdf;Integrated Security=True";
            cn.Open();

            string SQL = "select * from TbMenu";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable TbMenu = new DataTable();
            adp.Fill(TbMenu); // fill truyền dữ liệu vào trong table 

            App_Code.XuLiDuLieu xulydulieu = new App_Code.XuLiDuLieu();
            string madm = Request.QueryString.Get("IDDANHMUC"); // LUU Y TUONG TU CAI CHITIET
            SqlParameter[] pr;
            if (madm != null)
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", madm) };
            else
                pr = new SqlParameter[] { new SqlParameter("@MaDanhMuc", DBNull.Value) };
            DataList1.DataSource = xulydulieu.getTable("psGetSANPHAM", pr);
            //DataList1.DataSource = tbSanPham;
            DataList1.DataBind();
            DataList1.RepeatColumns = 4;
            //cn.Close();


            
            


        }

    }
}