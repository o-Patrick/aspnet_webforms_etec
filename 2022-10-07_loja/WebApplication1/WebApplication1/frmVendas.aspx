<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVendas.aspx.cs" Inherits="WebApplication1.frmVendas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="frmLoja.aspx">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="20pt" Text="Loja"></asp:Label>
            </a>
            <br />
            <asp:GridView ID="gridVendas" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
