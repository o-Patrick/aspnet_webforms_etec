<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLoja.aspx.cs" Inherits="WebApplication1.frmLoja" %>

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
            <br />
            <a href="frmCliente.aspx">
                <label>Cliente</label>
            </a>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="frmProduto.aspx">
                <label>Produto</label>
            </a>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <a href="frmVendas.aspx">
                <label>Vendas</label>
            </a>
        </div>
    </form>
</body>
</html>
