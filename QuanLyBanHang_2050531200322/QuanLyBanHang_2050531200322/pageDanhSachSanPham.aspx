<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="pageDanhSachSanPham.aspx.cs" Inherits="QuanLyBanHang_2050531200322.pageDanhSachSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <image alt="" src='IMAGES/<%# Eval("HINHANH")%>' width="150px" height="150px"/>
            <br />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

