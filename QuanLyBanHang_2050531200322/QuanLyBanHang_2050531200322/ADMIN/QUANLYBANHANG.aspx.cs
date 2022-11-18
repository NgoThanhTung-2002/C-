using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHang_2050531200322.ADMIN
{
    public partial class QUANLYBANHANG : System.Web.UI.Page
    {
        App_Code.XuLiDuLieu xulydulieu;

        App_Code.BL.bl_QUANLYDANHMUC blquanlydanhmuc;

        public void LoadDANHMUC()
        {
            SqlParameter[] pr = new SqlParameter[1];
            pr[0] = new SqlParameter("@maDM", DBNull.Value);
            this.grvDANHMUC.DataSource = xulydulieu.getTable("psGetDanhMuc", pr);
            this.grvDANHMUC.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //xulydulieu = new App_Code.XuLiDuLieu();
            //LoadDANHMUC();
            blquanlydanhmuc = new App_Code.BL.bl_QUANLYDANHMUC(this);
            blquanlydanhmuc.hienthi();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //SqlParameter[] pr = new SqlParameter[1];
            //pr[0] = new SqlParameter("@TENDANHMUC", txtTenDanhMuc.Text);
            //int k = xulydulieu.ExeCute("psAddDanhMuc", pr);
            //LoadDANHMUC();
            blquanlydanhmuc.ThemMoi();
            blquanlydanhmuc.hienthi();
        }

        protected void grvDANHMUC_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grvDANHMUC.PageIndex = e.NewPageIndex;
            //LoadDANHMUC();
            blquanlydanhmuc.hienthi();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            //SqlParameter[] pr = new SqlParameter[2];
            //pr[0] = new SqlParameter("@MADANHMUC", txtMaDanhMuc.Text);
            //pr[1] = new SqlParameter("@TENDANHMUC", txtTenDanhMuc.Text);
            //int k = xulydulieu.ExeCute("psUPDATEDanhMuc", pr);
            //LoadDANHMUC();
            blquanlydanhmuc.Capnhat();
            blquanlydanhmuc.hienthi();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            //SqlParameter[] pr = new SqlParameter[1];
            //String madanhmuc = txtMaDanhMuc.Text;
            //pr[0] = new SqlParameter("@MADANHMUC", madanhmuc);
            //int k = xulydulieu.ExeCute("psDELETEDanhmuc", pr);
            //LoadDANHMUC();

            blquanlydanhmuc.Xoa();
            blquanlydanhmuc.hienthi();

        }


    }
}
