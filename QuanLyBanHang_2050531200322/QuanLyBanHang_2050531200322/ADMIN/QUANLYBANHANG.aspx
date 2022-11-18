<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QUANLYBANHANG.aspx.cs" Inherits="QuanLyBanHang_2050531200322.ADMIN.QUANLYBANHANG" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 320px;
        }
        .auto-style2 {
            width: 389px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Mã danh mục</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtMaDanhMuc" runat="server"></asp:TextBox>
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Tên danh mục</td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTenDanhMuc" runat="server"></asp:TextBox>
                    </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="btnLuu" runat="server" OnClick="Button2_Click" Text="Lưu" />
                    <asp:Button ID="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" OnClick="btnXoa_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:GridView ID="grvDANHMUC" runat="server" Height="145px" Width="226px" AllowPaging="True" OnPageIndexChanging="grvDANHMUC_PageIndexChanging" PageSize="3">
                    </asp:GridView>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>