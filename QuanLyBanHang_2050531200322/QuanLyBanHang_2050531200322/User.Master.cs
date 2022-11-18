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
    public partial class User : System.Web.UI.MasterPage
    {
        App_Code.XuLiDuLieu xulidulieu;
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataTable tbDanhMuc = new DataTable();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Workspace\QuanLyBanHang_2050531200322\QuanLyBanHang_2050531200322\App_Data\dbQuanLyNhaHang.mdf;Integrated Security=True";
            cn.Open();

            string SQL = "select * from tbDanhMuc";
            SqlDataAdapter adp = new SqlDataAdapter(SQL, cn);
            DataTable tbDanhMuc = new DataTable();
            adp.Fill(tbDanhMuc); // fill truyền dữ liệu vào trong table 
            Repeater1.DataSource = tbDanhMuc;
            Repeater1.DataBind();

            cn.Close();
        }


    }
}