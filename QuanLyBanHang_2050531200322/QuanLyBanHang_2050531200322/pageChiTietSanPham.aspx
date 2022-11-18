<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="pageChiTietSanPham.aspx.cs" Inherits="QuanLyBanHang_2050531200322.pageChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater2" runat="server" >
    <ItemTemplate>
        
        <img alt="" src='IMAGES/<%# Eval("HINHANH") %>' width="150px" height="150px" />
        <h1>Tên món: <%# Eval("TENMON") %></h1>
        <h1>Giá: <%# Eval("DONGIA") %> </h1>
        <h1>Mô Tả: <%# Eval("MOTA") %></h1>
        
        <br />
    </ItemTemplate>
    </asp:Repeater>
    <asp:DropDownList ID="drlSOLUONG" runat="server"></asp:DropDownList>
    <asp:Button ID="btn_GIOHANG" runat="server" Text="Giỏ hàng" OnClick="btn_GIOHANG_Click"/>
    <p>

    </p>
</asp:Content>
