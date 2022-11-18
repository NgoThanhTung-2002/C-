<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="pageGioHang.aspx.cs" Inherits="QuanLyBanHang_2050531200322.pageGioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grvCART" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="idmon" HeaderText="Mã món " />
            <asp:BoundField DataField="TENMON" HeaderText="Tên món" />
            <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
            <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
            <asp:BoundField DataField="THANHTIEN" HeaderText="Thành tiền" />
            <asp:ImageField DataImageUrlFormatString="Images/{0}"  DataImageUrlField="HINHANH" HeaderText="Hình ảnh">
            </asp:ImageField>
            <asp:TemplateField HeaderText="Trả hàng">
                <ItemTemplate>
                    <asp:CheckBox ID="ckbREMOVEITEM" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
<asp:Button ID="btnDELETE" runat="server" OnClick="btnDELETE_Click1" style="height: 26px" Text="Trả hàng" />
</asp:Content>

