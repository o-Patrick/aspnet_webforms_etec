<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmVendas.aspx.cs" Inherits="venda.frmVendas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="CADASTRO DE PRODUTOS"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Produto"></asp:Label>
&nbsp;<asp:TextBox ID="txtProduto" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Valor R$"></asp:Label>
&nbsp;<asp:TextBox ID="txtValor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Quantidade"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantidade" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Tipo de pagamento"></asp:Label>
            <br />
            <asp:RadioButton ID="rdbVista" runat="server" GroupName="tipoPagamento" Text="Vista" />
&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="rdbPrazo" runat="server" GroupName="tipoPagamento" Text="Prazo" />
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Valor total R$"></asp:Label>
&nbsp;
            <asp:Label ID="lblValorTotal" runat="server" Text="..."></asp:Label>
        </div>
    </form>
</body>
</html>
