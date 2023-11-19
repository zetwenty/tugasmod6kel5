<%@ Page Language="C#" AutoEventWireup="true"
CodeBehind="ListItems.aspx.cs"
Inherits="tugasmod6kel5.ListItems" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float: left;">
            <table>
                <tr>
                    <td>ID Laptop :</td>
                    <td>
                        <asp:TextBox ID="txtIdLaptop" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nama Laptop :</td>
                    <td>
                        <asp:TextBox ID="txtNamaLaptop" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAddLaptop" runat="server" Text="ADD"
OnClick="btnAddLaptop_Click" />
<asp:Button ID="btnDeleteLaptop" runat="server"
Text="DELETE" OnClick="btnDeleteLaptop_Click" />
<asp:Button ID="btnUpdateLaptop" runat="server"
Text="UPDATE" OnClick="btnUpdateLaptop_Click" />
<asp:Button ID="btnClearLaptop" runat="server"
Text="CLEAR" OnClick="btnClearLaptop_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridViewLaptop" runat="server">
            </asp:GridView>
        </div>
        <div style="float: left;">
            <table>
                <tr>
                    <td>ID Tipe:</td>
                    <td>
                        <asp:TextBox ID="txtIdTipe" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Nama Tipe:</td>
                    <td>
                        <asp:TextBox ID="txtNamaTipe" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Prosessor :</td>
                    <td>
                        <asp:TextBox ID="txtProsessor" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>ID Laptop :</td>
                    <td>
                        <asp:TextBox ID="txtIdLaptop2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnAddTipe" runat="server" Text="ADD"
                            OnClick="btnAddTipe_Click" />
                        <asp:Button ID="btnDeleteTipe" runat="server"
                            Text="DELETE" OnClick="btnDeleteTipe_Click" />
                        <asp:Button ID="btnUpdateTipe" runat="server"
                            Text="UPDATE" OnClick="btnUpdateTipe_Click" />
                        <asp:Button ID="btnClearTipe" runat="server"
                            Text="CLEAR" OnClick="btnClearTipe_Click" />
                    </td>
                </tr>
            </table>
            <asp:GridView ID="GridViewTipe" runat="server">
            </asp:GridView>
        </div>
        <div style="float: left;">
            <p>
                View Laptoptipe SBD Mod 6 Kel 5
            </p>
            <asp:GridView ID="GridViewLaptoptipe" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
