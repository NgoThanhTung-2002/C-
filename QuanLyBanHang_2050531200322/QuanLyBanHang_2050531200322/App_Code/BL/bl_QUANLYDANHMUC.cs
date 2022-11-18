using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLyBanHang_2050531200322.App_Code.BL
{
    public class bl_QUANLYDANHMUC
    {
        App_Code.PD.pd_QUANLYDANHMUC pd_quanlydanhmuc;

        Page pageDanhMuc;

        public bl_QUANLYDANHMUC(Page p)
        {
            this.pageDanhMuc = p;
            pd_quanlydanhmuc = new PD.pd_QUANLYDANHMUC();

        }

        public void hienthi()
        {
            ((GridView)this.pageDanhMuc.FindControl("grvDANHMUC")).DataSource =
                pd_quanlydanhmuc.BangDanhMuc();

            ((GridView)this.pageDanhMuc.FindControl("grvDANHMUC")).DataBind();
        }

        public void ThemMoi()
        {
            String tendanhmuc = ((TextBox)this.pageDanhMuc.FindControl("txtTenDanhMuc")).Text;
            int k = pd_quanlydanhmuc.themmoiDanhMuc(tendanhmuc);
        }

        public void Xoa()
        {
            String madanhmuc = ((TextBox)this.pageDanhMuc.FindControl("txtMaDanhMuc")).Text;
            int k = pd_quanlydanhmuc.XoaDanhMuc(madanhmuc);
        }
        public void Capnhat()
        {
            String madanhmuc = ((TextBox)this.pageDanhMuc.FindControl("txtMaDanhMuc")).Text;
            String tendanhmuc = ((TextBox)this.pageDanhMuc.FindControl("txtTenDanhMuc")).Text;
            int k = pd_quanlydanhmuc.SuaDanhMuc(madanhmuc, tendanhmuc);
        }
    }
}