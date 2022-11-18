using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//coded
namespace QuanLyBanHang_2050531200322
{
    public partial class pageGioHang : System.Web.UI.Page
    {
        protected void LoadCart()
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            this.grvCART.DataSource = cart.Listcarts.Values.ToList();
            this.grvCART.DataBind();
            this.grvCART.FooterRow.Cells[0].Text = "Tổng Tiền = ";
            this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadCart();
        }

        protected void btnDELETE_Click1(object sender, EventArgs e)
        {
            App_Code.CART cart = (App_Code.CART)Session["CART"];
            foreach (GridViewRow row in grvCART.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }
            Session["CART"] = cart;
            LoadCart();

        }
    }
}