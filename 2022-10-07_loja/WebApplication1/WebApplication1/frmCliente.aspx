<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="WebApplication1.frmCliente" %>

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
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="15pt" Text="Área Cliente"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Código do cliente: "></asp:Label>
            <asp:TextBox ID="txtCodCliente" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="txtNomeCliente" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnConsultaCliente" runat="server" OnClick="btnConsultaCliente_Click" Text="Consultar" />
            <br />
            <br />
            <asp:GridView ID="gridCliente" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
