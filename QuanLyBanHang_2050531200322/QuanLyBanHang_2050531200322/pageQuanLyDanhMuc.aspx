<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="pageQuanLyDanhMuc.aspx.cs" Inherits="QuanLyBanHang_2050531200322.pageQuanLyDanhMuc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            width: 100%;
            height: 302px;
        }
        .auto-style9 {
            height: 43px;
        }
        .auto-style10 {
            height: 43px;
            width: 202px;
        }
        .auto-style18 {
            height: 40px;
            width: 202px;
        }
        .auto-style19 {
            height: 40px;
        }
        .auto-style20 {
            height: 35px;
            width: 202px;
        }
        .auto-style21 {
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="2" class="auto-style8" style="vertical-align: top">
        <tr>
            <td class="auto-style10" style="vertical-align: middle">Mã danh mục</td>
            <td class="auto-style9" style="vertical-align: middle">
                <asp:TextBox ID="txtMaDanhMuc" runat="server" Width="178px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18" style="vertical-align: middle">Tên danh mục</td>
            <td class="auto-style19" style="vertical-align: middle">
                <asp:TextBox ID="txtTenDanhMuc" runat="server" Width="180px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style20" style="vertical-align: top">Ï
                &nbsp;</td>
            <td class="auto-style21" style="vertical-align: top">
                <asp:Button ID="btn_luu" runat="server" Text="Lưu" OnClick="btn_luu_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style20" style="vertical-align: top">
                <asp:GridView ID="grvDANHMUC" runat="server">
                </asp:GridView>
            </td>
            <td class="auto-style21" style="vertical-align: top">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style20" style="vertical-align: top">
                &nbsp;</td>
            <td class="auto-style21" style="vertical-align: top">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
