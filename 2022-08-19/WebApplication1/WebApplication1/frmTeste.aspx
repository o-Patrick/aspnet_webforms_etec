<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTeste.aspx.cs" Inherits="WebApplication1.frmTeste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Names="Arial" Font-Size="XX-Large" Text="Exemplo de DDL (dropdown list)"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Produto"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLProduto" runat="server" OnSelectedIndexChanged="DDLProduto_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Tipo"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLTipo" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Cor"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLCor" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
