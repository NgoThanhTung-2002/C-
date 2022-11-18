<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="pageDanhSachSanPham.aspx.cs" Inherits="QuanLyBanHang_2050531200322.pageDanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList2" runat="server">
    </asp:DataList>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <a href='pageChiTietSanPham.aspx?IDMON=<%# Eval("IDMON")%>'>
                <img alt="" src='IMAGES/<%# Eval("HINHANH") %> '  width="150px"; height="150px"/>
                </a>
            </br>
            Tên sản phẩm: <%# Eval("TENMON") %>
            </br>
            Đơn giá: <%# Eval("DONGIA") %>
        </ItemTemplate>
</asp:DataList>
</asp:Content>

