<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmProduto.aspx.cs" Inherits="WebApplication1.frmProduto" %>

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
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="15pt" Text="Área Produto"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Código do produto: "></asp:Label>
            <asp:TextBox ID="txtCodProd" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Descrição: "></asp:Label>
            <asp:TextBox ID="txtDescProd" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnConsultaProd" runat="server" OnClick="btnConsultaProd_Click" Text="Consultar" />
            <br />
            <br />
            <asp:GridView ID="gridProduto" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
