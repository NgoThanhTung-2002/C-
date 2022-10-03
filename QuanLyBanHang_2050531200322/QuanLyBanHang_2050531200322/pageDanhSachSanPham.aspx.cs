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
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\C_Sharp\QuanLyBanHang_2050531200322\QuanLyBanHang_2050531200322\App_Data\dbQuanLyBanHang.mdf;Integrated Security=True";
            cn.Open();

            string SQL = "select * from tbSanPham";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbSanPham = new DataTable();
            adp.Fill(tbSanPham); // fill truyền dữ liệu vào trong table 
            DataList1.DataSource = tbSanPham;
            DataList1.DataBind();
            DataList1.RepeatColumns = 4;

            cn.Close();

        }
    }
}