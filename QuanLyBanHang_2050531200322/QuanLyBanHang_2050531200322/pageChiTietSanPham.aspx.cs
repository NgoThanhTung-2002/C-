using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang_2050531200322
{
    public partial class pageChiTietSanPham : System.Web.UI.Page
    {
        QuanLyBanHang_2050531200322.App_Code.XuLiDuLieu xulydulieu;
        DataTable TbMenu;
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.XuLiDuLieu xulydulieu = new App_Code.XuLiDuLieu();
            string masanpham = Request.QueryString.Get("IDMON");
            SqlParameter[] pr;
            if (masanpham != null)
                pr = new SqlParameter[] { new SqlParameter("@IDMON", masanpham) };
            else
                pr = new SqlParameter[] { new SqlParameter("@IDMON", DBNull.Value) };
            TbMenu = xulydulieu.getTable("psGetCHITIETSANPHAM", pr);
            Repeater2.DataSource = TbMenu;
            Repeater2.DataBind();



            int soluong = Convert.ToInt32(TbMenu.Rows[0]["SOLUONG"].ToString());
            for (int i = 1; i <= soluong; i++)
            
                this.drlSOLUONG.Items.Add(i.ToString());

        }

        protected void btn_GIOHANG_Click(object sender, EventArgs e)
        {
            Session.Timeout = 2;
            App_Code.CART cart = new App_Code.CART();
            if (TbMenu != null)
            {
                String IDMON = TbMenu.Rows[0]["IDMON"].ToString();
                String TENMON = TbMenu.Rows[0]["TENMON"].ToString();
                double DONGIA = Double.Parse(TbMenu.Rows[0]["DONGIA"].ToString());
                String HINHANH = TbMenu.Rows[0]["HINHANH"].ToString();

                int soluong = Int16.Parse(drlSOLUONG.SelectedItem.Text);
                if (Session["CART"] != null)
                    cart = (App_Code.CART)Session["CART"];
                cart.Add(IDMON, TENMON, DONGIA, soluong, HINHANH);
                Session["CART"] = cart;
                Response.Redirect("pageGioHang.aspx");

                
            }
        }
    }
}